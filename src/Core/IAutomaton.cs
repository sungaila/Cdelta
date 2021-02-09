namespace Cdelta
{
    /// <summary>
    /// Describes an automaton that reads input, evaluates transitions and changes states.
    /// </summary>
    public interface IAutomaton
    {
        /// <summary>
        /// The <see cref="CurrentState"/> is an accepting state.
        /// </summary>
        bool IsAcceptingState { get; }

        /// <summary>
        /// The automaton is in an erroneous state and halted.
        /// E.g. there is no valid transition or an <see cref="System.Exception"/> was thrown.
        /// </summary>
        bool IsHalted { get; }

        /// <summary>
        /// The current state of the automaton.
        /// </summary>
        int CurrentState { get; }

        /// <summary>
        /// Evaluates the <paramref name="input"/> and traverses a matching transition.
        /// </summary>
        /// <param name="input">The input value to evaluate.</param>
        void Invoke(object input);
    }
}
