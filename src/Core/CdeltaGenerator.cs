using Antlr4.Runtime;
using Cdelta.Language;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Cdelta
{
    /// <summary>
    /// Test
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

                CdeltaLexer lexer = new CdeltaLexer(inputStream);
                CommonTokenStream tokenStream = new CommonTokenStream(lexer);
                CdeltaParser parser = new CdeltaParser(tokenStream);

                CdeltaParser.CodeFileContext parsed = parser.codeFile();
                var visitor = new CdeltaGrammarVisitor();
                var result = visitor.Visit(parsed);

                var code = result.First().ToCode();

                context.AddSource($"{Path.GetFileName(file.Path)}.cs", code);
            }
        }

        /// <inheritdoc/>
        public void Initialize(GeneratorInitializationContext context)
        {
#if FALSE && DEBUG
            if (!Debugger.IsAttached)
            {
                Debugger.Launch();
            }
#endif
        }
    }
}
