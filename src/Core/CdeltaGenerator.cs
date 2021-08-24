using Antlr4.Runtime;
using Cdelta.Language;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cdelta
{
    /// <summary>
    /// Generates C# source code out of *.cdelta files.
    /// </summary>
    [Generator]
    public class CdeltaGenerator : ISourceGenerator
    {
        private static IEnumerable<AdditionalText> GetCdeltaFiles(GeneratorExecutionContext context)
        {
            foreach (AdditionalText file in context.AdditionalFiles)
            {
                if (Path.GetExtension(file.Path).Equals(".cdelta", StringComparison.OrdinalIgnoreCase))
                {
                    yield return file;
                }
            }
        }

        /// <inheritdoc/>
        public void Execute(GeneratorExecutionContext context)
        {
            foreach (var file in GetCdeltaFiles(context))
            {
                var input = file.GetText()?.ToString();
                if (input == null)
                    continue;

                var inputStream = new AntlrInputStream(input);

                var lexer = new CdeltaLexer(inputStream);
                var tokenStream = new CommonTokenStream(lexer);
                var parser = new CdeltaParser(tokenStream);

                CdeltaParser.CodeFileContext parsed = parser.codeFile();
                var visitor = new CdeltaGrammarVisitor();
                var result = visitor.Visit(parsed);

                var code = result.First().ToCode();
                context.AddSource($"{Path.GetFileName(file.Path)}.cs", code);
            }

            using var stream = typeof(CdeltaGenerator).Assembly.GetManifestResourceStream("Cdelta.IAutomaton.cs");
            using var reader = new StreamReader(stream);
            context.AddSource("IAutomaton.cs", reader.ReadToEnd());
        }

        /// <inheritdoc/>
        public void Initialize(GeneratorInitializationContext context)
        {
#if FALSE && DEBUG
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Launch();
            }
#endif
        }
    }
}