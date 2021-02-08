using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cdelta.Structure
{
    internal class Transition : StructureBase
    {
        public string SourceIdentifier { get; set; }

        public State? Source => (Parent as Automaton)?.States.SingleOrDefault(s => s.Identifier == SourceIdentifier);

        public string TargetIdentifier { get; set; }

        public State? Target => (Parent as Automaton)?.States.SingleOrDefault(s => s.Identifier == TargetIdentifier);

        public TransitionEnter? Enter { get; set; }

        public Transition(string sourceIdentifier, string targetIdentifier)
        {
            SourceIdentifier = sourceIdentifier;
            TargetIdentifier = targetIdentifier;
        }

        public string CanTransitionMethod { get => $"CanTransition{SourceIdentifier}{TargetIdentifier}"; }

        public override string ToCode()
        {
            var result = new StringBuilder();

            result.Append($"protected abstract bool {CanTransitionMethod}({((Automaton)Parent!).DataType} value);");

            if (Enter != null)
            {
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
                result.Append(Enter.ToCode());
            }

            return result.ToString();
        }
    }
}
