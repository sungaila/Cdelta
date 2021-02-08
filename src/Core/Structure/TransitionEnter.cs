using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal class TransitionEnter : StructureBase
    {
        public string EnterTransitionMethod { get => $"EnterTransition{((Transition)Parent!).SourceIdentifier}{((Transition)Parent!).TargetIdentifier}"; }

        public override string ToCode()
            => $"protected virtual void {EnterTransitionMethod}() {{ }}";
    }
}
