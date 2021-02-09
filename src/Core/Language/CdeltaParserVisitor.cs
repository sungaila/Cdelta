﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Documents\Repos\sungaila\Cdelta\src\Grammar\Language\CdeltaParser.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Cdelta.Language
{
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;
    using IToken = Antlr4.Runtime.IToken;

    /// <summary>
    /// This interface defines a complete generic visitor for a parse tree produced
    /// by <see cref="CdeltaParser"/>.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
    [System.CLSCompliant(false)]
    internal interface ICdeltaParserVisitor<Result> : IParseTreeVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.codeFile"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitCodeFile([NotNull] CdeltaParser.CodeFileContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.@namespace"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitNamespace([NotNull] CdeltaParser.NamespaceContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.automatonDefinition"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitAutomatonDefinition([NotNull] CdeltaParser.AutomatonDefinitionContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.accessModifier"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitAccessModifier([NotNull] CdeltaParser.AccessModifierContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.automatonDataType"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitAutomatonDataType([NotNull] CdeltaParser.AutomatonDataTypeContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.automatonBody"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitAutomatonBody([NotNull] CdeltaParser.AutomatonBodyContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.stateDefinition"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStateDefinition([NotNull] CdeltaParser.StateDefinitionContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.stateInnerBlock"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStateInnerBlock([NotNull] CdeltaParser.StateInnerBlockContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.stateEnter"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStateEnter([NotNull] CdeltaParser.StateEnterContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.stateExit"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStateExit([NotNull] CdeltaParser.StateExitContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.transitionDefinition"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitTransitionDefinition([NotNull] CdeltaParser.TransitionDefinitionContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.transitionInnerBlock"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitTransitionInnerBlock([NotNull] CdeltaParser.TransitionInnerBlockContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="CdeltaParser.transitionEnter"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitTransitionEnter([NotNull] CdeltaParser.TransitionEnterContext context);
    }
} // namespace Cdelta.Language
