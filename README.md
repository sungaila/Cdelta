﻿<img src="https://raw.githubusercontent.com/sungaila/Cdelta/master/etc/Icon.png" align="left" width="64" height="64" alt="Cdelta Logo">

# Cdelta
[![Azure DevOps builds (branch)](https://img.shields.io/azure-devops/build/sungaila/2feb76e5-ff0c-4623-8319-722a43829660/3/master?style=flat-square)](https://dev.azure.com/sungaila/Cdelta/_build/latest?definitionId=3&branchName=master)
[![Azure DevOps tests (branch)](https://img.shields.io/azure-devops/tests/sungaila/Cdelta/3/master?style=flat-square)](https://dev.azure.com/sungaila/Cdelta/_build/latest?definitionId=3&branchName=master)
[![NuGet version](https://img.shields.io/nuget/v/Cdelta.svg?style=flat-square)](https://www.nuget.org/packages/Cdelta/)
[![NuGet downloads](https://img.shields.io/nuget/dt/Cdelta.svg?style=flat-square)](https://www.nuget.org/packages/Cdelta/)
[![GitHub license](https://img.shields.io/github/license/sungaila/Cdelta?style=flat-square)](https://github.com/sungaila/Cdelta/blob/master/LICENSE)

A C# source generator for finite-state machines.

Looking for the master's thesis *C𝛿: Design and Implementation of a Transcompiler for Language Integrated Finite-State Machines in C♯*? Look here: https://github.com/sungaila/CdeltaLegacy

## Quick start
### Step 1: Create *.cdelta text files
Create an _analyzer additional file_ with the `cdelta` extension. Your csproj file should contain something like this:
```xml
<ItemGroup>
    <AdditionalFiles Include="MyAutomaton.cdelta" />
</ItemGroup>
```
### Step 2: Define the automaton
* `namespace` for the class
* `[modifier] [partial] automaton {Identifier}[<{Type}>]`
  * `modifier` the access modifier (optional, defaults to `internal`)
  * `partial` generates a partial class (optional)
  * `{Identifier}` the name of your class
  * `<{Type}>` the input type for the automaton (optional, defaults to `object`)
* `[start] [end] state {Identifier};` or
* `[start] [end] state {Identifier} { [enter;] [exit;] }`
  * `start` is initial state (used exactly once)
  * `end` is accepting state (used once at least)
  * `{Identifier}` the name of this state
  * `enter` generate a virtual state enter method (optional)
  * `exit` generate a virtual state exit method (optional)
* `transition {source} {target};` or
* `transition {source} {target} { [enter;] }`
  * `{source}` the source state
  * `{target}` the target state
  * `enter` generate a virtual transition enter method (optional)
#### Example
```csharp
namespace Cdelta.Tests
{
    internal automaton LowerCamelCaseMachine<char>
    {
        // available states
        start state Init;
        state UpperChar { enter; }
        end state LowerChar { enter; exit; }

        // available transitions
        transition Init LowerChar;
        transition LowerChar LowerChar;
        transition LowerChar UpperChar;
        transition UpperChar LowerChar { enter; }
    }
}
```
### Step 3: Inherit and implement the automaton
```csharp
class LowerCamelCase : LowerCamelCaseMachine
{
    protected override bool CanTransition_Init_LowerChar(char value) => char.IsLower(value);

    protected override bool CanTransition_LowerChar_LowerChar(char value) => char.IsLower(value);

    protected override bool CanTransition_LowerChar_UpperChar(char value) => char.IsUpper(value);

    protected override bool CanTransition_UpperChar_LowerChar(char value) => char.IsLower(value);
}
```
### Step 4: Enjoy!
```csharp
var machine = new LowerCamelCase();

foreach (var c in "imputToTest")
    machine.Invoke(c);

Assert.IsTrue(machine.IsAcceptingState);
```