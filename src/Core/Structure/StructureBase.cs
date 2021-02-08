using System;
using System.Collections.Generic;
using System.Text;

namespace Cdelta.Structure
{
    internal abstract class StructureBase : IStructure
    {
        public Guid Id { get; } = Guid.NewGuid();

        public StructureBase? Parent { get; set; }

        public abstract string ToCode();

        public override string ToString() => ToCode();

        public string ToCodeIndented()
        {
            var code = ToCode();

            if (string.IsNullOrEmpty(code))
                return code;

            return $"\t{code.Replace(Environment.NewLine, $"{Environment.NewLine}\t")}";
        }
    }
}
