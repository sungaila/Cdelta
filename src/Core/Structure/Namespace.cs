using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal class Namespace : StructureBase
    {
        public string Identifier { get; set; }

        public IList<Automaton> Automata { get; } = new List<Automaton>();

        public Namespace(string identifier)
        {
            Identifier = identifier;
        }

        public override string ToCode()
        {
            var result = new StringBuilder();
            result.Append($"namespace {Identifier}{Environment.NewLine}{{{Environment.NewLine}");

            foreach (var automaton in Automata)
            {
                result.AppendLine(automaton.ToCodeIndented());
            }

            result.Append('}');
            return result.ToString();
        }
    }
}
