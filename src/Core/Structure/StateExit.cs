using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal class StateExit : StructureBase
    {
        public string ExitStateMethod { get => $"ExitState{((State)Parent!).Identifier}"; }

        public override string ToCode()
            => $"protected virtual void {ExitStateMethod}() {{ }}";
    }
}
