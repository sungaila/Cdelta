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

        public string CanTransitionMethod { get => $"CanTransition_{SourceIdentifier}_{TargetIdentifier}"; }

        public override string ToCode()
        {
            var result = new StringBuilder();

            result.AppendLine("/// <summary>");
            result.AppendLine($"/// Decides if a transition from <see cref=\"State.{SourceIdentifier}\"/> to <see cref=\"State.{TargetIdentifier}\"/> is possible.");
            result.AppendLine("/// </summary>");
            result.AppendLine("/// <param name=\"value\">The input this automaton is currently evaluating.</param>");
            result.Append($"protected abstract bool {CanTransitionMethod}({(((Automaton)Parent!).IsGenericType ? "T" : ((Automaton)Parent!).DataType)} value);");

            if (Enter != null)
            {
                result.AppendLine();
                result.AppendLine();
                result.Append(Enter.ToCode());
            }

            return result.ToString();
        }
    }
}
