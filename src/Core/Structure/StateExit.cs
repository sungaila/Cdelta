using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal class StateExit : StructureBase
    {
        public string ExitStateMethod { get => $"ExitState_{((State)Parent!).Identifier}"; }

        public override string ToCode()
        {
            var result = new StringBuilder();

            result.AppendLine("/// <summary>");
            result.AppendLine($"/// Called when <see cref=\"State.{((State)Parent!).Identifier}\"/> is left.");
            result.AppendLine("/// </summary>");
            result.Append($"protected virtual void {ExitStateMethod}() {{ }}");

            return result.ToString();
        }
    }
}
