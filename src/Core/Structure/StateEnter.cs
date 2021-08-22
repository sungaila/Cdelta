using System.Text;

namespace Cdelta.Structure
{
    internal class StateEnter : StructureBase
    {
        public string EnterStateMethod { get => $"EnterState_{((State)Parent!).Identifier}"; }

        public override string ToCode()
        {
            var result = new StringBuilder();

            result.AppendLine("/// <summary>");
            result.AppendLine($"/// Called when <see cref=\"State.{((State)Parent!).Identifier}\"/> is entered.");
            result.AppendLine("/// </summary>");
            result.Append($"protected virtual void {EnterStateMethod}() {{ }}");

            return result.ToString();
        }
    }
}
