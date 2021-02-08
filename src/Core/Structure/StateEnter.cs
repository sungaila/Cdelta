using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal class StateEnter : StructureBase
    {
        public string EnterStateMethod { get => $"EnterState{((State)Parent!).Identifier}"; }

        public override string ToCode()
            => $"protected virtual void {EnterStateMethod}() {{ }}";
    }
}
