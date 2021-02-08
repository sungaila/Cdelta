using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Cdelta.Structure
{
    internal class Automaton : StructureBase
    {
        public string Identifier { get; set; }

        public string? Modifier { get; set; }

        public bool IsAbstract { get; set; }

        public bool IsPartial { get; set; }

        public string? DataType { get; set; }

        public IList<State> States { get; } = new List<State>();

        public IList<Transition> Transitions { get; } = new List<Transition>();

        public Automaton(string identifier)
        {
            Identifier = identifier;
        }

        public override string ToCode()
        {
            var result = new StringBuilder();

            var tool = typeof(CdeltaGenerator).Assembly.GetName().Name;
            var version = typeof(CdeltaGenerator).Assembly.GetName().Version.ToString();
            var versionAttr = typeof(CdeltaGenerator).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            if (versionAttr != null)
                version = versionAttr.InformationalVersion;

            result.AppendLine($"[System.CodeDom.Compiler.GeneratedCode(\"{tool}\", \"{version}\")]");

            result.Append($"{Modifier}");

            if (IsAbstract)
                result.Append(" abstract");

            if (IsPartial)
                result.Append(" partial");

            result.Append($" class {Identifier}");

            if (IsGenericTypeValid(DataType))
            {
                result.Append($"<T> where T : {DataType ?? "object"}");
            }

            result.Append($"{Environment.NewLine}{{{Environment.NewLine}");

            foreach (var state in States)
            {
                var stateCode = state.ToCodeIndented();
                if (!string.IsNullOrEmpty(stateCode))
                {
                    result.AppendLine(stateCode);
                }
            }

            foreach (var transition in Transitions)
            {
                var transitionCode = transition.ToCodeIndented();
                if (!string.IsNullOrEmpty(transitionCode))
                {
                    result.AppendLine(transitionCode);
                }
            }

            result.Append('}');
            return result.ToString();
        }

        private static bool IsGenericTypeValid(string? type)
        {
            if (string.IsNullOrEmpty(type))
                return true;

            switch (type)
            {
                case "bool":
                case "byte":
                case "sbyte":
                case "char":
                case "decimal":
                case "double":
                case "float":
                case "int":
                case "uint":
                case "long":
                case "ulong":
                case "short":
                case "ushort":
                case "dynamic":
                case "string":
                    return false;
                default:
                    break;
            }

            Type dataType = Type.GetType(type, false);
            if (dataType != null && dataType.IsPrimitive)
                return false;

            return true;
        }
    }
}
