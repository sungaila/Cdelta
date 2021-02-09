using System.Text;

namespace Cdelta.Structure
{
    internal class TransitionEnter : StructureBase
    {
        public string EnterTransitionMethod { get => $"EnterTransition_{((Transition)Parent!).SourceIdentifier}_{((Transition)Parent!).TargetIdentifier}"; }

        public override string ToCode()
        {
            var result = new StringBuilder();

            result.AppendLine("/// <summary>");
            result.AppendLine($"/// Called when the transition from <see cref=\"State.{((Transition)Parent!).SourceIdentifier}\"/> to <see cref=\"State.{((Transition)Parent!).TargetIdentifier}\"/> was taken.");
            result.AppendLine("/// </summary>");

            if (((Transition)Parent!).Source?.Exit != null || ((Transition)Parent!).Target?.Enter != null)
            {
                result.AppendLine("/// <remarks>");
                if (((Transition)Parent!).Source?.Exit != null)
                {
                    result.AppendLine($"/// Is called <b>after</b> <see cref=\"{((Transition)Parent!).Source!.Exit!.ExitStateMethod}\"/>.");
                }
                if (((Transition)Parent!).Target?.Enter != null)
                {
                    result.AppendLine($"/// Is called <b>before</b> <see cref=\"{((Transition)Parent!).Target!.Enter!.EnterStateMethod}\"/>.");
                }
                result.AppendLine("/// </remarks>");
            }

            result.Append($"protected virtual void {EnterTransitionMethod}() {{ }}");

            return result.ToString();
        }
    }
}
