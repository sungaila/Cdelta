using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Cdelta.Structure
{
    internal class Automaton : StructureBase
    {
        public string Identifier { get; set; }

        public string? Modifier { get; set; }

        public bool IsPartial { get; set; }

        private string? _dataType;

        public string? DataType
        {
            get
            {
                if (string.IsNullOrEmpty(_dataType))
                    return "object";

                return _dataType!;
            }
            set => _dataType = value;
        }

        public bool IsGenericType { get => IsGenericTypeValid(DataType); }

        public IList<State> States { get; } = new List<State>();

        public IList<Transition> Transitions { get; } = new List<Transition>();

        public Automaton(string identifier)
        {
            Identifier = identifier;
        }

        public override string ToCode()
        {
            var result = new StringBuilder();

            result.AppendLine(GenerateAutomatonHeader());
            result.AppendLine($"{{");

            result.Append(GenerateInterfaceImplementation());
            result.AppendLine();
            result.AppendLine();
            result.Append(GenerateStateEnum());
            result.AppendLine();
            result.AppendLine();
            result.Append(GenerateInvoke());

            foreach (var state in States)
            {
                var code = state.ToCodeIndented();

                if (!string.IsNullOrEmpty(code))
                {
                    result.AppendLine();
                    result.AppendLine();
                    result.Append(code);
                }
            }

            foreach (var transition in Transitions)
            {
                var code = transition.ToCodeIndented();

                if (!string.IsNullOrEmpty(code))
                {
                    result.AppendLine();
                    result.AppendLine();
                    result.Append(code);
                }
            }

            result.AppendLine();
            result.Append('}');
            return result.ToString();
        }

        private string GenerateAutomatonHeader()
        {
            var result = new StringBuilder();

            result.AppendLine("/// <summary>");
            result.AppendLine("/// The base implementation of a generated automaton.");
            result.AppendLine("/// </summary>");

            var tool = typeof(CdeltaGenerator).Assembly.GetName().Name;
            var version = typeof(CdeltaGenerator).Assembly.GetName().Version.ToString();
            var versionAttr = typeof(CdeltaGenerator).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (versionAttr != null)
                version = versionAttr.InformationalVersion;

            result.AppendLine($"[System.CodeDom.Compiler.GeneratedCode(\"{tool}\", \"{version}\")]");

            result.Append($"{Modifier} abstract");

            if (IsPartial)
                result.Append(" partial");

            result.Append($" class {Identifier}");

            if (IsGenericType)
            {
                result.Append($"<T> : Cdelta.IAutomaton where T : {DataType ?? "class"}");
            }
            else
            {
                result.Append(": Cdelta.IAutomaton");
            }

            return result.ToString();
        }

        private string GenerateInterfaceImplementation()
        {
            var result = new StringBuilder();
            result.Append('\t');

            result.AppendLine("/// <inheritdoc/>");
            result.AppendLine("public bool IsHalted { get; private set; }");
            result.AppendLine();

            result.AppendLine("/// <inheritdoc/>");
            result.AppendLine("int IAutomaton.CurrentState { get => (int)CurrentState; }");
            result.AppendLine();

            result.AppendLine("/// <inheritdoc/>");
            result.AppendLine($"void IAutomaton.Invoke(object input) => Invoke(({(IsGenericType ? "T" : DataType)})input);");
            result.AppendLine();

            result.AppendLine("/// <inheritdoc/>");
            result.AppendLine("public bool IsAcceptingState");
            result.AppendLine("{");
            result.AppendLine("\tget");
            result.AppendLine("\t{");

            result.AppendLine("\t\tswitch (CurrentState)");
            result.AppendLine("\t\t{");

            foreach (var state in States.Where(s => s.IsEnd).OrderBy(s => s.Identifier))
            {
                result.AppendLine($"\t\t\tcase State.{state.Identifier}:");
            }
            result.AppendLine("\t\t\t\treturn true;");

            result.AppendLine("\t\t\tdefault:");
            result.AppendLine("\t\t\t\treturn false;");

            result.AppendLine("\t\t}");

            result.AppendLine("\t}");
            result.Append('}');

            return result.ToString().Replace(Environment.NewLine, $"{Environment.NewLine}\t");
        }

        private string GenerateStateEnum()
        {
            var result = new StringBuilder();
            result.Append('\t');
            result.AppendLine("/// <summary>");
            result.AppendLine("/// The current state of the automaton.");
            result.AppendLine("/// </summary>");
            result.AppendLine("public State CurrentState { get; private set; }");
            result.AppendLine();

            result.AppendLine("/// <summary>");
            result.AppendLine("/// The available states for this state machine.");
            result.AppendLine("/// </summary>");
            result.AppendLine("public enum State : int");
            result.AppendLine("{");

            result.Append('\t');
            result.AppendLine($"{States.Single(s => s.IsStart).Identifier} = 0,");

            foreach (var state in States.OrderBy(s => s.Identifier))
            {
                if (state.IsStart)
                    continue;

                result.Append('\t');
                result.AppendLine($"{state.Identifier},");
            }

            result.Append('}');

            return result.ToString().Replace(Environment.NewLine, $"{Environment.NewLine}\t");
        }

        private string GenerateInvoke()
        {
            var result = new StringBuilder();
            result.Append('\t');

            result.AppendLine("/// <summary>");
            result.AppendLine("/// Evaluates the <paramref name=\"input\"/> and traverses a matching transition.");
            result.AppendLine("/// </summary>");
            result.AppendLine("/// <param name=\"input\">The input value to evaluate.</param>");
            result.AppendLine($"public void Invoke({(IsGenericType ? "T" : DataType)} input)");
            result.AppendLine("{");

            result.AppendLine("\tif (IsHalted)");
            result.AppendLine("\t\treturn;");
            result.AppendLine();

            result.AppendLine("\ttry");
            result.AppendLine("\t{");
            result.AppendLine("\t\tswitch (CurrentState)");
            result.AppendLine("\t\t{");

            foreach (var state in States.OrderBy(s => s.Identifier))
            {
                result.AppendLine($"\t\t\tcase State.{state.Identifier}:");

                var transitions = Transitions.Where(t => t.Source == state);

                for (int i = 0; i < transitions.Count(); i++)
                {
                    var transition = transitions.ElementAt(i);

                    result.Append(i == 0
                        ? "\t\t\t\tif ("
                        : "\t\t\t\telse if (");
                    result.AppendLine($"{transition.CanTransitionMethod}(input))");
                    result.AppendLine("\t\t\t\t{");

                    if (transition.Source?.Exit != null)
                        result.AppendLine($"\t\t\t\t\t{transition.Source.Exit.ExitStateMethod}();");

                    if (transition.Enter != null)
                        result.AppendLine($"\t\t\t\t\t{transition.Enter.EnterTransitionMethod}();");

                    result.AppendLine($"\t\t\t\t\tCurrentState = State.{transition.Target!.Identifier};");

                    if (transition.Target?.Enter != null)
                        result.AppendLine($"\t\t\t\t\t{transition.Target.Enter.EnterStateMethod}();");

                    result.AppendLine("\t\t\t\t\treturn;");
                    result.AppendLine("\t\t\t\t}");
                }

                result.AppendLine("\t\t\t\tIsHalted = true;");
                result.AppendLine("\t\t\t\tbreak;");
            }

            result.AppendLine("\t\t\tdefault:");
            result.AppendLine("\t\t\t\tthrow new System.InvalidOperationException($\"Unknown current state {System.Enum.GetName(typeof(State), CurrentState)}.\");");

            result.AppendLine("\t\t}");
            result.AppendLine("\t}");
            result.AppendLine("\tcatch");
            result.AppendLine("\t{");
            result.AppendLine("\t\tIsHalted = true;");
            result.AppendLine("\t\tthrow;");
            result.AppendLine("\t}");
            result.Append('}');

            return result.ToString().Replace(Environment.NewLine, $"{Environment.NewLine}\t");
        }

        private static bool IsGenericTypeValid(string? type)
        {
            switch (type)
            {
                case "bool":
                case "byte":
                case "sbyte":
                case "char":
                case "decimal":
                case "double":
                case "float":
                case "int":
                case "uint":
                case "long":
                case "ulong":
                case "short":
                case "ushort":
                case "dynamic":
                case "string":
                    return false;
                default:
                    break;
            }

            Type dataType = Type.GetType(type, false);
            if (dataType != null && dataType.IsPrimitive)
                return false;

            return true;
        }
    }
}
