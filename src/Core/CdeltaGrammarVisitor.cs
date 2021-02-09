using Cdelta.Language;
using Cdelta.Structure;
using System.Collections.Generic;
using System.Linq;

namespace Cdelta
{
    internal class CdeltaGrammarVisitor : CdeltaParserBaseVisitor<IEnumerable<StructureBase>>
    {
        public override IEnumerable<StructureBase> VisitNamespace(CdeltaParser.NamespaceContext context)
        {
            var result = new Namespace(string.Join(".", context.IDENTIFIER().AsEnumerable()));

            foreach (var child in base.VisitNamespace(context))
            {
                if (child is Automaton automaton)
                {
                    automaton.Parent = result;
                    result.Automata.Add(automaton);
                }
            }

            yield return result;
        }

        public override IEnumerable<StructureBase> VisitAutomatonDefinition(CdeltaParser.AutomatonDefinitionContext context)
        {
            var result = new Automaton(context.IDENTIFIER().GetText())
            {
                Modifier = context.accessModifier()?.GetText(),
                IsPartial = context.PARTIAL() != null,
                DataType = context.automatonDataType()?.GetText()
            };

            foreach (var child in base.VisitAutomatonDefinition(context))
            {
                if (child is State state)
                {
                    state.Parent = result;
                    result.States.Add(state);
                }
                else if (child is Transition transition)
                {
                    transition.Parent = result;
                    result.Transitions.Add(transition);
                }
            }

            yield return result;
        }

        public override IEnumerable<StructureBase> VisitStateDefinition(CdeltaParser.StateDefinitionContext context)
        {
            var result = new State(context.IDENTIFIER().GetText())
            {
                IsStart = context.START() != null,
                IsEnd = context.END() != null,
            };

            foreach (var child in base.VisitStateDefinition(context))
            {
                if (child is StateEnter enter)
                {
                    enter.Parent = result;
                    result.Enter = enter;
                }
                else if (child is StateExit exit)
                {
                    exit.Parent = result;
                    result.Exit = exit;
                }
            }

            yield return result;
        }

        public override IEnumerable<StructureBase> VisitStateEnter(CdeltaParser.StateEnterContext context)
        {
            yield return new StateEnter();
        }

        public override IEnumerable<StructureBase> VisitStateExit(CdeltaParser.StateExitContext context)
        {
            yield return new StateExit();
        }

        public override IEnumerable<StructureBase> VisitTransitionDefinition(CdeltaParser.TransitionDefinitionContext context)
        {
            var result = new Transition(context.IDENTIFIER(0).GetText(), context.IDENTIFIER(1).GetText());

            foreach (var child in base.VisitTransitionDefinition(context))
            {
                if (child is TransitionEnter enter)
                {
                    enter.Parent = result;
                    result.Enter = enter;
                }
            }

            yield return result;
        }

        public override IEnumerable<StructureBase> VisitTransitionEnter(CdeltaParser.TransitionEnterContext context)
        {
            yield return new TransitionEnter();
        }

        protected override IEnumerable<StructureBase> AggregateResult(IEnumerable<StructureBase> aggregate, IEnumerable<StructureBase> nextResult)
        {
            foreach (var child in aggregate)
                yield return child;

            foreach (var child in nextResult)
                yield return child;
        }

        protected override IEnumerable<StructureBase> DefaultResult => Enumerable.Empty<StructureBase>();
    }
}