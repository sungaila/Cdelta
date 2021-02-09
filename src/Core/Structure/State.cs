using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal class State : StructureBase
    {
        public string Identifier { get; set; }

        public bool IsStart { get; set; }

        public bool IsEnd { get; set; }

        public StateEnter? Enter { get; set; }

        public StateExit? Exit { get; set; }

        public State(string identifier)
        {
            Identifier = identifier;
        }

        public override string ToCode()
        {
            var result = new StringBuilder();

            if (Enter != null)
            {
                result.Append(Enter.ToCode());
            }

            if (Exit != null)
            {
                if (result.Length > 0)
                {
                    result.AppendLine();
                    result.AppendLine();
                }

                result.Append(Exit.ToCode());
            }

            return result.ToString();
        }
    }
}
