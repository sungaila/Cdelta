﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Documents\Repos\sungaila\Cdelta\src\Grammar\Language\CdeltaLexer.g4 by ANTLR 4.6.6

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
    using Antlr4.Runtime;
    using Antlr4.Runtime.Atn;
    using Antlr4.Runtime.Misc;
    using DFA = Antlr4.Runtime.Dfa.DFA;

    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
    [System.CLSCompliant(false)]
    internal partial class CdeltaLexer : Lexer
    {
        public const int
            AUTOMATON = 1, STATE = 2, TRANSITION = 3, START = 4, END = 5, ENTER = 6, EXIT = 7, CONDITION = 8,
            SEMICOLON = 9, CURLY_OPEN = 10, CURLY_CLOSE = 11, LESS_THAN = 12, GREATER_THAN = 13,
            NAMESPACE = 14, DOT = 15, PUBLIC = 16, INTERNAL = 17, PROTECTED = 18, PRIVATE = 19,
            PARTIAL = 20, SINGLE_LINE_COMMENT = 21, DELIMITED_COMMENT = 22, WHITESPACES = 23,
            IDENTIFIER = 24;
        public const int
            COMMENTS_CHANNEL = 2;
        public static string[] modeNames = {
        "DEFAULT_MODE"
    };

        public static readonly string[] ruleNames = {
        "AUTOMATON", "STATE", "TRANSITION", "START", "END", "ENTER", "EXIT", "CONDITION",
        "SEMICOLON", "CURLY_OPEN", "CURLY_CLOSE", "LESS_THAN", "GREATER_THAN",
        "NAMESPACE", "DOT", "PUBLIC", "INTERNAL", "PROTECTED", "PRIVATE", "PARTIAL",
        "SINGLE_LINE_COMMENT", "DELIMITED_COMMENT", "WHITESPACES", "IDENTIFIER",
        "InputCharacter", "NewLineCharacter", "IntegerTypeSuffix", "ExponentPart",
        "CommonCharacter", "SimpleEscapeSequence", "HexEscapeSequence", "NewLine",
        "Whitespace", "UnicodeClassZS", "IdentifierOrKeyword", "IdentifierStartCharacter",
        "IdentifierPartCharacter", "LetterCharacter", "DecimalDigitCharacter",
        "ConnectingCharacter", "CombiningCharacter", "FormattingCharacter", "UnicodeEscapeSequence",
        "HexDigit", "UnicodeClassLU", "UnicodeClassLL", "UnicodeClassLT", "UnicodeClassLM",
        "UnicodeClassLO", "UnicodeClassNL", "UnicodeClassMN", "UnicodeClassMC",
        "UnicodeClassCF", "UnicodeClassPC", "UnicodeClassND"
    };


        public CdeltaLexer(ICharStream input)
            : base(input)
        {
            _interp = new LexerATNSimulator(this, _ATN);
        }

        private static readonly string[] _LiteralNames = {
        null, "'automaton'", "'state'", "'transition'", "'start'", "'end'", "'enter'",
        "'exit'", "'condition'", "';'", "'{'", "'}'", "'<'", "'>'", "'namespace'",
        "'.'", "'public'", "'internal'", "'protected'", "'private'", "'partial'"
    };
        private static readonly string[] _SymbolicNames = {
        null, "AUTOMATON", "STATE", "TRANSITION", "START", "END", "ENTER", "EXIT",
        "CONDITION", "SEMICOLON", "CURLY_OPEN", "CURLY_CLOSE", "LESS_THAN", "GREATER_THAN",
        "NAMESPACE", "DOT", "PUBLIC", "INTERNAL", "PROTECTED", "PRIVATE", "PARTIAL",
        "SINGLE_LINE_COMMENT", "DELIMITED_COMMENT", "WHITESPACES", "IDENTIFIER"
    };
        public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

        [System.Obsolete("Use Vocabulary instead.")]
        public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

        private static string[] GenerateTokenNames(IVocabulary vocabulary, int length)
        {
            string[] tokenNames = new string[length];
            for (int i = 0; i < tokenNames.Length; i++)
            {
                tokenNames[i] = vocabulary.GetLiteralName(i);
                if (tokenNames[i] == null)
                {
                    tokenNames[i] = vocabulary.GetSymbolicName(i);
                }

                if (tokenNames[i] == null)
                {
                    tokenNames[i] = "<INVALID>";
                }
            }

            return tokenNames;
        }

        [System.Obsolete("Use IRecognizer.Vocabulary instead.")]
        public override string[] TokenNames
        {
            get
            {
                return tokenNames;
            }
        }

        [NotNull]
        public override IVocabulary Vocabulary
        {
            get
            {
                return DefaultVocabulary;
            }
        }

        public override string GrammarFileName { get { return "CdeltaLexer.g4"; } }

        public override string[] RuleNames { get { return ruleNames; } }

        public override string[] ModeNames { get { return modeNames; } }

        public override string SerializedAtn { get { return _serializedATN; } }

        public static readonly string _serializedATN =
            "\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x1A\x1CE\b\x1\x4" +
            "\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b" +
            "\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4" +
            "\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15" +
            "\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A" +
            "\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 " +
            "\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t" +
            ")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31" +
            "\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37" +
            "\t\x37\x4\x38\t\x38\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3" +
            "\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4" +
            "\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3" +
            "\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3" +
            "\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3" +
            "\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3" +
            "\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3" +
            "\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3" +
            "\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3" +
            "\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3" +
            "\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3" +
            "\x16\x3\x16\x3\x16\x3\x16\a\x16\xF0\n\x16\f\x16\xE\x16\xF3\v\x16\x3\x16" +
            "\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\a\x17\xFB\n\x17\f\x17\xE\x17\xFE\v" +
            "\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x6\x18\x107\n\x18" +
            "\r\x18\xE\x18\x108\x3\x18\x3\x18\x3\x19\x5\x19\x10E\n\x19\x3\x19\x3\x19" +
            "\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1C\x5\x1C\x117\n\x1C\x3\x1C\x3\x1C\x5" +
            "\x1C\x11B\n\x1C\x3\x1C\x5\x1C\x11E\n\x1C\x3\x1D\x3\x1D\x5\x1D\x122\n\x1D" +
            "\x3\x1D\x3\x1D\a\x1D\x126\n\x1D\f\x1D\xE\x1D\x129\v\x1D\x3\x1D\a\x1D\x12C" +
            "\n\x1D\f\x1D\xE\x1D\x12F\v\x1D\x3\x1E\x3\x1E\x3\x1E\x5\x1E\x134\n\x1E" +
            "\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F" +
            "\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F" +
            "\x3\x1F\x3\x1F\x5\x1F\x14C\n\x1F\x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3" +
            " \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x5 \x167" +
            "\n \x3!\x3!\x3!\x5!\x16C\n!\x3\"\x3\"\x5\"\x170\n\"\x3#\x3#\x3$\x3$\a" +
            "$\x176\n$\f$\xE$\x179\v$\x3%\x3%\x5%\x17D\n%\x3&\x3&\x3&\x3&\x3&\x5&\x184" +
            "\n&\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x5\'\x18D\n\'\x3(\x3(\x5(\x191" +
            "\n(\x3)\x3)\x5)\x195\n)\x3*\x3*\x3*\x5*\x19A\n*\x3+\x3+\x5+\x19E\n+\x3" +
            ",\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3,\x3," +
            "\x3,\x3,\x5,\x1B4\n,\x3-\x5-\x1B7\n-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\x3" +
            "\x31\x3\x31\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35\x3\x35\x3" +
            "\x36\x3\x36\x3\x37\x3\x37\x3\x38\x3\x38\x3\xFC\x2\x2\x39\x3\x2\x3\x5\x2" +
            "\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17" +
            "\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14" +
            "\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x2\x35\x2" +
            "\x2\x37\x2\x2\x39\x2\x2;\x2\x2=\x2\x2?\x2\x2\x41\x2\x2\x43\x2\x2\x45\x2" +
            "\x2G\x2\x2I\x2\x2K\x2\x2M\x2\x2O\x2\x2Q\x2\x2S\x2\x2U\x2\x2W\x2\x2Y\x2" +
            "\x2[\x2\x2]\x2\x2_\x2\x2\x61\x2\x2\x63\x2\x2\x65\x2\x2g\x2\x2i\x2\x2k" +
            "\x2\x2m\x2\x2o\x2\x2\x3\x2\x15\x6\x2\f\f\xF\xF\x87\x87\x202A\x202B\x4" +
            "\x2NNnn\x4\x2WWww\x4\x2GGgg\x4\x2--//\x3\x2\x32;\x4\x2\v\v\r\xE\v\x2\"" +
            "\"\xA2\xA2\x1682\x1682\x1810\x1810\x2002\x2008\x200A\x200C\x2031\x2031" +
            "\x2061\x2061\x3002\x3002\x5\x2\x32;\x43H\x63hT\x2\x43\\\xC2\xD8\xDA\xE0" +
            "\x102\x138\x13B\x149\x14C\x17F\x183\x184\x186\x18D\x190\x193\x195\x196" +
            "\x198\x19A\x19E\x19F\x1A1\x1A2\x1A4\x1AB\x1AE\x1B5\x1B7\x1BE\x1C6\x1CF" +
            "\x1D1\x1DD\x1E0\x1F0\x1F3\x1F6\x1F8\x1FA\x1FC\x234\x23C\x23D\x23F\x240" +
            "\x243\x248\x24A\x250\x372\x374\x378\x381\x388\x38C\x38E\x3A3\x3A5\x3AD" +
            "\x3D1\x3D6\x3DA\x3F0\x3F6\x3F9\x3FB\x3FC\x3FF\x431\x462\x482\x48C\x4CF" +
            "\x4D2\x530\x533\x558\x10A2\x10C7\x10C9\x10CF\x1E02\x1E96\x1EA0\x1F00\x1F0A" +
            "\x1F11\x1F1A\x1F1F\x1F2A\x1F31\x1F3A\x1F41\x1F4A\x1F4F\x1F5B\x1F61\x1F6A" +
            "\x1F71\x1FBA\x1FBD\x1FCA\x1FCD\x1FDA\x1FDD\x1FEA\x1FEE\x1FFA\x1FFD\x2104" +
            "\x2109\x210D\x210F\x2112\x2114\x2117\x211F\x2126\x212F\x2132\x2135\x2140" +
            "\x2141\x2147\x2185\x2C02\x2C30\x2C62\x2C66\x2C69\x2C72\x2C74\x2C77\x2C80" +
            "\x2C82\x2C84\x2CE4\x2CED\x2CEF\x2CF4\xA642\xA644\xA66E\xA682\xA69C\xA724" +
            "\xA730\xA734\xA770\xA77B\xA788\xA78D\xA78F\xA792\xA794\xA798\xA7AF\xA7B2" +
            "\xA7B3\xFF23\xFF3CS\x2\x63|\xB7\xF8\xFA\x101\x103\x179\x17C\x182\x185" +
            "\x187\x18A\x194\x197\x19D\x1A0\x1A3\x1A5\x1A7\x1AA\x1AF\x1B2\x1B6\x1B8" +
            "\x1C1\x1C8\x1CE\x1D0\x1F5\x1F7\x1FB\x1FD\x23B\x23E\x244\x249\x295\x297" +
            "\x2B1\x373\x375\x379\x37F\x392\x3D0\x3D2\x3D3\x3D7\x3D9\x3DB\x3F5\x3F7" +
            "\x461\x463\x483\x48D\x4C1\x4C4\x531\x563\x589\x1D02\x1D2D\x1D6D\x1D79" +
            "\x1D7B\x1D9C\x1E03\x1E9F\x1EA1\x1F09\x1F12\x1F17\x1F22\x1F29\x1F32\x1F39" +
            "\x1F42\x1F47\x1F52\x1F59\x1F62\x1F69\x1F72\x1F7F\x1F82\x1F89\x1F92\x1F99" +
            "\x1FA2\x1FA9\x1FB2\x1FB6\x1FB8\x1FB9\x1FC0\x1FC6\x1FC8\x1FC9\x1FD2\x1FD5" +
            "\x1FD8\x1FD9\x1FE2\x1FE9\x1FF4\x1FF6\x1FF8\x1FF9\x210C\x2115\x2131\x213B" +
            "\x213E\x213F\x2148\x214B\x2150\x2186\x2C32\x2C60\x2C63\x2C6E\x2C73\x2C7D" +
            "\x2C83\x2CEE\x2CF0\x2CF5\x2D02\x2D27\x2D29\x2D2F\xA643\xA66F\xA683\xA69D" +
            "\xA725\xA733\xA735\xA77A\xA77C\xA77E\xA781\xA789\xA78E\xA790\xA793\xA797" +
            "\xA799\xA7AB\xA7FC\xAB5C\xAB66\xAB67\xFB02\xFB08\xFB15\xFB19\xFF43\xFF5C" +
            "\b\x2\x1C7\x1CD\x1F4\x1F91\x1F9A\x1FA1\x1FAA\x1FB1\x1FBE\x1FCE\x1FFE\x1FFE" +
            "#\x2\x2B2\x2C3\x2C8\x2D3\x2E2\x2E6\x2EE\x2F0\x376\x37C\x55B\x642\x6E7" +
            "\x6E8\x7F6\x7F7\x7FC\x81C\x826\x82A\x973\xE48\xEC8\x10FE\x17D9\x1845\x1AA9" +
            "\x1C7F\x1D2E\x1D6C\x1D7A\x1DC1\x2073\x2081\x2092\x209E\x2C7E\x2C7F\x2D71" +
            "\x2E31\x3007\x3037\x303D\x3100\xA017\xA4FF\xA60E\xA681\xA69E\xA69F\xA719" +
            "\xA721\xA772\xA78A\xA7FA\xA7FB\xA9D1\xA9E8\xAA72\xAADF\xAAF5\xAAF6\xAB5E" +
            "\xAB61\xFF72\xFFA1\xEC\x2\xAC\xBC\x1BD\x1C5\x296\x5EC\x5F2\x5F4\x622\x641" +
            "\x643\x64C\x670\x671\x673\x6D5\x6D7\x6FE\x701\x712\x714\x731\x74F\x7A7" +
            "\x7B3\x7EC\x802\x817\x842\x85A\x8A2\x8B4\x906\x93B\x93F\x952\x95A\x963" +
            "\x974\x982\x987\x98E\x991\x992\x995\x9AA\x9AC\x9B2\x9B4\x9BB\x9BF\x9D0" +
            "\x9DE\x9DF\x9E1\x9E3\x9F2\x9F3\xA07\xA0C\xA11\xA12\xA15\xA2A\xA2C\xA32" +
            "\xA34\xA35\xA37\xA38\xA3A\xA3B\xA5B\xA5E\xA60\xA76\xA87\xA8F\xA91\xA93" +
            "\xA95\xAAA\xAAC\xAB2\xAB4\xAB5\xAB7\xABB\xABF\xAD2\xAE2\xAE3\xB07\xB0E" +
            "\xB11\xB12\xB15\xB2A\xB2C\xB32\xB34\xB35\xB37\xB3B\xB3F\xB63\xB73\xB85" +
            "\xB87\xB8C\xB90\xB92\xB94\xB97\xB9B\xB9C\xB9E\xBAC\xBB0\xBBB\xBD2\xC0E" +
            "\xC10\xC12\xC14\xC2A\xC2C\xC3B\xC3F\xC8E\xC90\xC92\xC94\xCAA\xCAC\xCB5" +
            "\xCB7\xCBB\xCBF\xCE0\xCE2\xCE3\xCF3\xCF4\xD07\xD0E\xD10\xD12\xD14\xD3C" +
            "\xD3F\xD50\xD62\xD63\xD7C\xD81\xD87\xD98\xD9C\xDB3\xDB5\xDBD\xDBF\xDC8" +
            "\xE03\xE32\xE34\xE35\xE42\xE47\xE83\xE84\xE86\xE8C\xE8F\xE99\xE9B\xEA1" +
            "\xEA3\xEA5\xEA7\xEA9\xEAC\xEAD\xEAF\xEB2\xEB4\xEB5\xEBF\xEC6\xEDE\xEE1" +
            "\xF02\xF49\xF4B\xF6E\xF8A\xF8E\x1002\x102C\x1041\x1057\x105C\x105F\x1063" +
            "\x1072\x1077\x1083\x1090\x10FC\x10FF\x124A\x124C\x124F\x1252\x1258\x125A" +
            "\x125F\x1262\x128A\x128C\x128F\x1292\x12B2\x12B4\x12B7\x12BA\x12C0\x12C2" +
            "\x12C7\x12CA\x12D8\x12DA\x1312\x1314\x1317\x131A\x135C\x1382\x1391\x13A2" +
            "\x13F6\x1403\x166E\x1671\x1681\x1683\x169C\x16A2\x16EC\x16F3\x16FA\x1702" +
            "\x170E\x1710\x1713\x1722\x1733\x1742\x1753\x1762\x176E\x1770\x1772\x1782" +
            "\x17B5\x17DE\x1844\x1846\x1879\x1882\x18AA\x18AC\x18F7\x1902\x1920\x1952" +
            "\x196F\x1972\x1976\x1982\x19AD\x19C3\x19C9\x1A02\x1A18\x1A22\x1A56\x1B07" +
            "\x1B35\x1B47\x1B4D\x1B85\x1BA2\x1BB0\x1BB1\x1BBC\x1BE7\x1C02\x1C25\x1C4F" +
            "\x1C51\x1C5C\x1C79\x1CEB\x1CEE\x1CF0\x1CF3\x1CF7\x1CF8\x2137\x213A\x2D32" +
            "\x2D69\x2D82\x2D98\x2DA2\x2DA8\x2DAA\x2DB0\x2DB2\x2DB8\x2DBA\x2DC0\x2DC2" +
            "\x2DC8\x2DCA\x2DD0\x2DD2\x2DD8\x2DDA\x2DE0\x3008\x303E\x3043\x3098\x30A1" +
            "\x30FC\x3101\x312F\x3133\x3190\x31A2\x31BC\x31F2\x3201\x3402\x4DB7\x4E02" +
            "\x9FCE\xA002\xA016\xA018\xA48E\xA4D2\xA4F9\xA502\xA60D\xA612\xA621\xA62C" +
            "\xA62D\xA670\xA6E7\xA7F9\xA803\xA805\xA807\xA809\xA80C\xA80E\xA824\xA842" +
            "\xA875\xA884\xA8B5\xA8F4\xA8F9\xA8FD\xA927\xA932\xA948\xA962\xA97E\xA986" +
            "\xA9B4\xA9E2\xA9E6\xA9E9\xA9F1\xA9FC\xAA00\xAA02\xAA2A\xAA42\xAA44\xAA46" +
            "\xAA4D\xAA62\xAA71\xAA73\xAA78\xAA7C\xAAB1\xAAB3\xAABF\xAAC2\xAAC4\xAADD" +
            "\xAADE\xAAE2\xAAEC\xAAF4\xAB08\xAB0B\xAB10\xAB13\xAB18\xAB22\xAB28\xAB2A" +
            "\xAB30\xABC2\xABE4\xAC02\xD7A5\xD7B2\xD7C8\xD7CD\xD7FD\xF902\xFA6F\xFA72" +
            "\xFADB\xFB1F\xFB2A\xFB2C\xFB38\xFB3A\xFB3E\xFB40\xFBB3\xFBD5\xFD3F\xFD52" +
            "\xFD91\xFD94\xFDC9\xFDF2\xFDFD\xFE72\xFE76\xFE78\xFEFE\xFF68\xFF71\xFF73" +
            "\xFF9F\xFFA2\xFFC0\xFFC4\xFFC9\xFFCC\xFFD1\xFFD4\xFFD9\xFFDC\xFFDE\x4" +
            "\x2\x16F0\x16F2\x2162\x2171\x5\x2\x905\x905\x940\x942\x94B\x94E\x5\x2" +
            "\xAF\xAF\x602\x605\x6DF\x6DF\b\x2\x61\x61\x2041\x2042\x2056\x2056\xFE35" +
            "\xFE36\xFE4F\xFE51\xFF41\xFF41\'\x2\x32;\x662\x66B\x6F2\x6FB\x7C2\x7CB" +
            "\x968\x971\x9E8\x9F1\xA68\xA71\xAE8\xAF1\xB68\xB71\xBE8\xBF1\xC68\xC71" +
            "\xCE8\xCF1\xD68\xD71\xDE8\xDF1\xE52\xE5B\xED2\xEDB\xF22\xF2B\x1042\x104B" +
            "\x1092\x109B\x17E2\x17EB\x1812\x181B\x1948\x1951\x19D2\x19DB\x1A82\x1A8B" +
            "\x1A92\x1A9B\x1B52\x1B5B\x1BB2\x1BBB\x1C42\x1C4B\x1C52\x1C5B\xA622\xA62B" +
            "\xA8D2\xA8DB\xA902\xA90B\xA9D2\xA9DB\xA9F2\xA9FB\xAA52\xAA5B\xABF2\xABFB" +
            "\xFF12\xFF1B\x1DC\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2" +
            "\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2" +
            "\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2" +
            "\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F" +
            "\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2" +
            "\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2" +
            "\x2\x31\x3\x2\x2\x2\x3q\x3\x2\x2\x2\x5{\x3\x2\x2\x2\a\x81\x3\x2\x2\x2" +
            "\t\x8C\x3\x2\x2\x2\v\x92\x3\x2\x2\x2\r\x96\x3\x2\x2\x2\xF\x9C\x3\x2\x2" +
            "\x2\x11\xA1\x3\x2\x2\x2\x13\xAB\x3\x2\x2\x2\x15\xAD\x3\x2\x2\x2\x17\xAF" +
            "\x3\x2\x2\x2\x19\xB1\x3\x2\x2\x2\x1B\xB3\x3\x2\x2\x2\x1D\xB5\x3\x2\x2" +
            "\x2\x1F\xBF\x3\x2\x2\x2!\xC1\x3\x2\x2\x2#\xC8\x3\x2\x2\x2%\xD1\x3\x2\x2" +
            "\x2\'\xDB\x3\x2\x2\x2)\xE3\x3\x2\x2\x2+\xEB\x3\x2\x2\x2-\xF6\x3\x2\x2" +
            "\x2/\x106\x3\x2\x2\x2\x31\x10D\x3\x2\x2\x2\x33\x111\x3\x2\x2\x2\x35\x113" +
            "\x3\x2\x2\x2\x37\x11D\x3\x2\x2\x2\x39\x11F\x3\x2\x2\x2;\x133\x3\x2\x2" +
            "\x2=\x14B\x3\x2\x2\x2?\x166\x3\x2\x2\x2\x41\x16B\x3\x2\x2\x2\x43\x16F" +
            "\x3\x2\x2\x2\x45\x171\x3\x2\x2\x2G\x173\x3\x2\x2\x2I\x17C\x3\x2\x2\x2" +
            "K\x183\x3\x2\x2\x2M\x18C\x3\x2\x2\x2O\x190\x3\x2\x2\x2Q\x194\x3\x2\x2" +
            "\x2S\x199\x3\x2\x2\x2U\x19D\x3\x2\x2\x2W\x1B3\x3\x2\x2\x2Y\x1B6\x3\x2" +
            "\x2\x2[\x1B8\x3\x2\x2\x2]\x1BA\x3\x2\x2\x2_\x1BC\x3\x2\x2\x2\x61\x1BE" +
            "\x3\x2\x2\x2\x63\x1C0\x3\x2\x2\x2\x65\x1C2\x3\x2\x2\x2g\x1C4\x3\x2\x2" +
            "\x2i\x1C6\x3\x2\x2\x2k\x1C8\x3\x2\x2\x2m\x1CA\x3\x2\x2\x2o\x1CC\x3\x2" +
            "\x2\x2qr\a\x63\x2\x2rs\aw\x2\x2st\av\x2\x2tu\aq\x2\x2uv\ao\x2\x2vw\a\x63" +
            "\x2\x2wx\av\x2\x2xy\aq\x2\x2yz\ap\x2\x2z\x4\x3\x2\x2\x2{|\au\x2\x2|}\a" +
            "v\x2\x2}~\a\x63\x2\x2~\x7F\av\x2\x2\x7F\x80\ag\x2\x2\x80\x6\x3\x2\x2\x2" +
            "\x81\x82\av\x2\x2\x82\x83\at\x2\x2\x83\x84\a\x63\x2\x2\x84\x85\ap\x2\x2" +
            "\x85\x86\au\x2\x2\x86\x87\ak\x2\x2\x87\x88\av\x2\x2\x88\x89\ak\x2\x2\x89" +
            "\x8A\aq\x2\x2\x8A\x8B\ap\x2\x2\x8B\b\x3\x2\x2\x2\x8C\x8D\au\x2\x2\x8D" +
            "\x8E\av\x2\x2\x8E\x8F\a\x63\x2\x2\x8F\x90\at\x2\x2\x90\x91\av\x2\x2\x91" +
            "\n\x3\x2\x2\x2\x92\x93\ag\x2\x2\x93\x94\ap\x2\x2\x94\x95\a\x66\x2\x2\x95" +
            "\f\x3\x2\x2\x2\x96\x97\ag\x2\x2\x97\x98\ap\x2\x2\x98\x99\av\x2\x2\x99" +
            "\x9A\ag\x2\x2\x9A\x9B\at\x2\x2\x9B\xE\x3\x2\x2\x2\x9C\x9D\ag\x2\x2\x9D" +
            "\x9E\az\x2\x2\x9E\x9F\ak\x2\x2\x9F\xA0\av\x2\x2\xA0\x10\x3\x2\x2\x2\xA1" +
            "\xA2\a\x65\x2\x2\xA2\xA3\aq\x2\x2\xA3\xA4\ap\x2\x2\xA4\xA5\a\x66\x2\x2" +
            "\xA5\xA6\ak\x2\x2\xA6\xA7\av\x2\x2\xA7\xA8\ak\x2\x2\xA8\xA9\aq\x2\x2\xA9" +
            "\xAA\ap\x2\x2\xAA\x12\x3\x2\x2\x2\xAB\xAC\a=\x2\x2\xAC\x14\x3\x2\x2\x2" +
            "\xAD\xAE\a}\x2\x2\xAE\x16\x3\x2\x2\x2\xAF\xB0\a\x7F\x2\x2\xB0\x18\x3\x2" +
            "\x2\x2\xB1\xB2\a>\x2\x2\xB2\x1A\x3\x2\x2\x2\xB3\xB4\a@\x2\x2\xB4\x1C\x3" +
            "\x2\x2\x2\xB5\xB6\ap\x2\x2\xB6\xB7\a\x63\x2\x2\xB7\xB8\ao\x2\x2\xB8\xB9" +
            "\ag\x2\x2\xB9\xBA\au\x2\x2\xBA\xBB\ar\x2\x2\xBB\xBC\a\x63\x2\x2\xBC\xBD" +
            "\a\x65\x2\x2\xBD\xBE\ag\x2\x2\xBE\x1E\x3\x2\x2\x2\xBF\xC0\a\x30\x2\x2" +
            "\xC0 \x3\x2\x2\x2\xC1\xC2\ar\x2\x2\xC2\xC3\aw\x2\x2\xC3\xC4\a\x64\x2\x2" +
            "\xC4\xC5\an\x2\x2\xC5\xC6\ak\x2\x2\xC6\xC7\a\x65\x2\x2\xC7\"\x3\x2\x2" +
            "\x2\xC8\xC9\ak\x2\x2\xC9\xCA\ap\x2\x2\xCA\xCB\av\x2\x2\xCB\xCC\ag\x2\x2" +
            "\xCC\xCD\at\x2\x2\xCD\xCE\ap\x2\x2\xCE\xCF\a\x63\x2\x2\xCF\xD0\an\x2\x2" +
            "\xD0$\x3\x2\x2\x2\xD1\xD2\ar\x2\x2\xD2\xD3\at\x2\x2\xD3\xD4\aq\x2\x2\xD4" +
            "\xD5\av\x2\x2\xD5\xD6\ag\x2\x2\xD6\xD7\a\x65\x2\x2\xD7\xD8\av\x2\x2\xD8" +
            "\xD9\ag\x2\x2\xD9\xDA\a\x66\x2\x2\xDA&\x3\x2\x2\x2\xDB\xDC\ar\x2\x2\xDC" +
            "\xDD\at\x2\x2\xDD\xDE\ak\x2\x2\xDE\xDF\ax\x2\x2\xDF\xE0\a\x63\x2\x2\xE0" +
            "\xE1\av\x2\x2\xE1\xE2\ag\x2\x2\xE2(\x3\x2\x2\x2\xE3\xE4\ar\x2\x2\xE4\xE5" +
            "\a\x63\x2\x2\xE5\xE6\at\x2\x2\xE6\xE7\av\x2\x2\xE7\xE8\ak\x2\x2\xE8\xE9" +
            "\a\x63\x2\x2\xE9\xEA\an\x2\x2\xEA*\x3\x2\x2\x2\xEB\xEC\a\x31\x2\x2\xEC" +
            "\xED\a\x31\x2\x2\xED\xF1\x3\x2\x2\x2\xEE\xF0\x5\x33\x1A\x2\xEF\xEE\x3" +
            "\x2\x2\x2\xF0\xF3\x3\x2\x2\x2\xF1\xEF\x3\x2\x2\x2\xF1\xF2\x3\x2\x2\x2" +
            "\xF2\xF4\x3\x2\x2\x2\xF3\xF1\x3\x2\x2\x2\xF4\xF5\b\x16\x2\x2\xF5,\x3\x2" +
            "\x2\x2\xF6\xF7\a\x31\x2\x2\xF7\xF8\a,\x2\x2\xF8\xFC\x3\x2\x2\x2\xF9\xFB" +
            "\v\x2\x2\x2\xFA\xF9\x3\x2\x2\x2\xFB\xFE\x3\x2\x2\x2\xFC\xFD\x3\x2\x2\x2" +
            "\xFC\xFA\x3\x2\x2\x2\xFD\xFF\x3\x2\x2\x2\xFE\xFC\x3\x2\x2\x2\xFF\x100" +
            "\a,\x2\x2\x100\x101\a\x31\x2\x2\x101\x102\x3\x2\x2\x2\x102\x103\b\x17" +
            "\x2\x2\x103.\x3\x2\x2\x2\x104\x107\x5\x43\"\x2\x105\x107\x5\x41!\x2\x106" +
            "\x104\x3\x2\x2\x2\x106\x105\x3\x2\x2\x2\x107\x108\x3\x2\x2\x2\x108\x106" +
            "\x3\x2\x2\x2\x108\x109\x3\x2\x2\x2\x109\x10A\x3\x2\x2\x2\x10A\x10B\b\x18" +
            "\x3\x2\x10B\x30\x3\x2\x2\x2\x10C\x10E\a\x42\x2\x2\x10D\x10C\x3\x2\x2\x2" +
            "\x10D\x10E\x3\x2\x2\x2\x10E\x10F\x3\x2\x2\x2\x10F\x110\x5G$\x2\x110\x32" +
            "\x3\x2\x2\x2\x111\x112\n\x2\x2\x2\x112\x34\x3\x2\x2\x2\x113\x114\t\x2" +
            "\x2\x2\x114\x36\x3\x2\x2\x2\x115\x117\t\x3\x2\x2\x116\x115\x3\x2\x2\x2" +
            "\x116\x117\x3\x2\x2\x2\x117\x118\x3\x2\x2\x2\x118\x11E\t\x4\x2\x2\x119" +
            "\x11B\t\x4\x2\x2\x11A\x119\x3\x2\x2\x2\x11A\x11B\x3\x2\x2\x2\x11B\x11C" +
            "\x3\x2\x2\x2\x11C\x11E\t\x3\x2\x2\x11D\x116\x3\x2\x2\x2\x11D\x11A\x3\x2" +
            "\x2\x2\x11E\x38\x3\x2\x2\x2\x11F\x121\t\x5\x2\x2\x120\x122\t\x6\x2\x2" +
            "\x121\x120\x3\x2\x2\x2\x121\x122\x3\x2\x2\x2\x122\x123\x3\x2\x2\x2\x123" +
            "\x12D\t\a\x2\x2\x124\x126\a\x61\x2\x2\x125\x124\x3\x2\x2\x2\x126\x129" +
            "\x3\x2\x2\x2\x127\x125\x3\x2\x2\x2\x127\x128\x3\x2\x2\x2\x128\x12A\x3" +
            "\x2\x2\x2\x129\x127\x3\x2\x2\x2\x12A\x12C\t\a\x2\x2\x12B\x127\x3\x2\x2" +
            "\x2\x12C\x12F\x3\x2\x2\x2\x12D\x12B\x3\x2\x2\x2\x12D\x12E\x3\x2\x2\x2" +
            "\x12E:\x3\x2\x2\x2\x12F\x12D\x3\x2\x2\x2\x130\x134\x5=\x1F\x2\x131\x134" +
            "\x5? \x2\x132\x134\x5W,\x2\x133\x130\x3\x2\x2\x2\x133\x131\x3\x2\x2\x2" +
            "\x133\x132\x3\x2\x2\x2\x134<\x3\x2\x2\x2\x135\x136\a^\x2\x2\x136\x14C" +
            "\a)\x2\x2\x137\x138\a^\x2\x2\x138\x14C\a$\x2\x2\x139\x13A\a^\x2\x2\x13A" +
            "\x14C\a^\x2\x2\x13B\x13C\a^\x2\x2\x13C\x14C\a\x32\x2\x2\x13D\x13E\a^\x2" +
            "\x2\x13E\x14C\a\x63\x2\x2\x13F\x140\a^\x2\x2\x140\x14C\a\x64\x2\x2\x141" +
            "\x142\a^\x2\x2\x142\x14C\ah\x2\x2\x143\x144\a^\x2\x2\x144\x14C\ap\x2\x2" +
            "\x145\x146\a^\x2\x2\x146\x14C\at\x2\x2\x147\x148\a^\x2\x2\x148\x14C\a" +
            "v\x2\x2\x149\x14A\a^\x2\x2\x14A\x14C\ax\x2\x2\x14B\x135\x3\x2\x2\x2\x14B" +
            "\x137\x3\x2\x2\x2\x14B\x139\x3\x2\x2\x2\x14B\x13B\x3\x2\x2\x2\x14B\x13D" +
            "\x3\x2\x2\x2\x14B\x13F\x3\x2\x2\x2\x14B\x141\x3\x2\x2\x2\x14B\x143\x3" +
            "\x2\x2\x2\x14B\x145\x3\x2\x2\x2\x14B\x147\x3\x2\x2\x2\x14B\x149\x3\x2" +
            "\x2\x2\x14C>\x3\x2\x2\x2\x14D\x14E\a^\x2\x2\x14E\x14F\az\x2\x2\x14F\x150" +
            "\x3\x2\x2\x2\x150\x167\x5Y-\x2\x151\x152\a^\x2\x2\x152\x153\az\x2\x2\x153" +
            "\x154\x3\x2\x2\x2\x154\x155\x5Y-\x2\x155\x156\x5Y-\x2\x156\x167\x3\x2" +
            "\x2\x2\x157\x158\a^\x2\x2\x158\x159\az\x2\x2\x159\x15A\x3\x2\x2\x2\x15A" +
            "\x15B\x5Y-\x2\x15B\x15C\x5Y-\x2\x15C\x15D\x5Y-\x2\x15D\x167\x3\x2\x2\x2" +
            "\x15E\x15F\a^\x2\x2\x15F\x160\az\x2\x2\x160\x161\x3\x2\x2\x2\x161\x162" +
            "\x5Y-\x2\x162\x163\x5Y-\x2\x163\x164\x5Y-\x2\x164\x165\x5Y-\x2\x165\x167" +
            "\x3\x2\x2\x2\x166\x14D\x3\x2\x2\x2\x166\x151\x3\x2\x2\x2\x166\x157\x3" +
            "\x2\x2\x2\x166\x15E\x3\x2\x2\x2\x167@\x3\x2\x2\x2\x168\x169\a\xF\x2\x2" +
            "\x169\x16C\a\f\x2\x2\x16A\x16C\t\x2\x2\x2\x16B\x168\x3\x2\x2\x2\x16B\x16A" +
            "\x3\x2\x2\x2\x16C\x42\x3\x2\x2\x2\x16D\x170\x5\x45#\x2\x16E\x170\t\b\x2" +
            "\x2\x16F\x16D\x3\x2\x2\x2\x16F\x16E\x3\x2\x2\x2\x170\x44\x3\x2\x2\x2\x171" +
            "\x172\t\t\x2\x2\x172\x46\x3\x2\x2\x2\x173\x177\x5I%\x2\x174\x176\x5K&" +
            "\x2\x175\x174\x3\x2\x2\x2\x176\x179\x3\x2\x2\x2\x177\x175\x3\x2\x2\x2" +
            "\x177\x178\x3\x2\x2\x2\x178H\x3\x2\x2\x2\x179\x177\x3\x2\x2\x2\x17A\x17D" +
            "\x5M\'\x2\x17B\x17D\a\x61\x2\x2\x17C\x17A\x3\x2\x2\x2\x17C\x17B\x3\x2" +
            "\x2\x2\x17DJ\x3\x2\x2\x2\x17E\x184\x5M\'\x2\x17F\x184\x5O(\x2\x180\x184" +
            "\x5Q)\x2\x181\x184\x5S*\x2\x182\x184\x5U+\x2\x183\x17E\x3\x2\x2\x2\x183" +
            "\x17F\x3\x2\x2\x2\x183\x180\x3\x2\x2\x2\x183\x181\x3\x2\x2\x2\x183\x182" +
            "\x3\x2\x2\x2\x184L\x3\x2\x2\x2\x185\x18D\x5[.\x2\x186\x18D\x5]/\x2\x187" +
            "\x18D\x5_\x30\x2\x188\x18D\x5\x61\x31\x2\x189\x18D\x5\x63\x32\x2\x18A" +
            "\x18D\x5\x65\x33\x2\x18B\x18D\x5W,\x2\x18C\x185\x3\x2\x2\x2\x18C\x186" +
            "\x3\x2\x2\x2\x18C\x187\x3\x2\x2\x2\x18C\x188\x3\x2\x2\x2\x18C\x189\x3" +
            "\x2\x2\x2\x18C\x18A\x3\x2\x2\x2\x18C\x18B\x3\x2\x2\x2\x18DN\x3\x2\x2\x2" +
            "\x18E\x191\x5o\x38\x2\x18F\x191\x5W,\x2\x190\x18E\x3\x2\x2\x2\x190\x18F" +
            "\x3\x2\x2\x2\x191P\x3\x2\x2\x2\x192\x195\x5m\x37\x2\x193\x195\x5W,\x2" +
            "\x194\x192\x3\x2\x2\x2\x194\x193\x3\x2\x2\x2\x195R\x3\x2\x2\x2\x196\x19A" +
            "\x5g\x34\x2\x197\x19A\x5i\x35\x2\x198\x19A\x5W,\x2\x199\x196\x3\x2\x2" +
            "\x2\x199\x197\x3\x2\x2\x2\x199\x198\x3\x2\x2\x2\x19AT\x3\x2\x2\x2\x19B" +
            "\x19E\x5k\x36\x2\x19C\x19E\x5W,\x2\x19D\x19B\x3\x2\x2\x2\x19D\x19C\x3" +
            "\x2\x2\x2\x19EV\x3\x2\x2\x2\x19F\x1A0\a^\x2\x2\x1A0\x1A1\aw\x2\x2\x1A1" +
            "\x1A2\x3\x2\x2\x2\x1A2\x1A3\x5Y-\x2\x1A3\x1A4\x5Y-\x2\x1A4\x1A5\x5Y-\x2" +
            "\x1A5\x1A6\x5Y-\x2\x1A6\x1B4\x3\x2\x2\x2\x1A7\x1A8\a^\x2\x2\x1A8\x1A9" +
            "\aW\x2\x2\x1A9\x1AA\x3\x2\x2\x2\x1AA\x1AB\x5Y-\x2\x1AB\x1AC\x5Y-\x2\x1AC" +
            "\x1AD\x5Y-\x2\x1AD\x1AE\x5Y-\x2\x1AE\x1AF\x5Y-\x2\x1AF\x1B0\x5Y-\x2\x1B0" +
            "\x1B1\x5Y-\x2\x1B1\x1B2\x5Y-\x2\x1B2\x1B4\x3\x2\x2\x2\x1B3\x19F\x3\x2" +
            "\x2\x2\x1B3\x1A7\x3\x2\x2\x2\x1B4X\x3\x2\x2\x2\x1B5\x1B7\t\n\x2\x2\x1B6" +
            "\x1B5\x3\x2\x2\x2\x1B7Z\x3\x2\x2\x2\x1B8\x1B9\t\v\x2\x2\x1B9\\\x3\x2\x2" +
            "\x2\x1BA\x1BB\t\f\x2\x2\x1BB^\x3\x2\x2\x2\x1BC\x1BD\t\r\x2\x2\x1BD`\x3" +
            "\x2\x2\x2\x1BE\x1BF\t\xE\x2\x2\x1BF\x62\x3\x2\x2\x2\x1C0\x1C1\t\xF\x2" +
            "\x2\x1C1\x64\x3\x2\x2\x2\x1C2\x1C3\t\x10\x2\x2\x1C3\x66\x3\x2\x2\x2\x1C4" +
            "\x1C5\x4\x302\x312\x2\x1C5h\x3\x2\x2\x2\x1C6\x1C7\t\x11\x2\x2\x1C7j\x3" +
            "\x2\x2\x2\x1C8\x1C9\t\x12\x2\x2\x1C9l\x3\x2\x2\x2\x1CA\x1CB\t\x13\x2\x2" +
            "\x1CBn\x3\x2\x2\x2\x1CC\x1CD\t\x14\x2\x2\x1CDp\x3\x2\x2\x2\x1D\x2\xF1" +
            "\xFC\x106\x108\x10D\x116\x11A\x11D\x121\x127\x12D\x133\x14B\x166\x16B" +
            "\x16F\x177\x17C\x183\x18C\x190\x194\x199\x19D\x1B3\x1B6\x4\x2\x4\x2\x2" +
            "\x3\x2";
        public static readonly ATN _ATN =
            new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
    }
} // namespace Cdelta.Language
