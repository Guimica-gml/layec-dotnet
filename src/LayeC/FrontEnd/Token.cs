﻿using System.Numerics;

using LayeC.Source;

namespace LayeC.FrontEnd;

public sealed class Token(TokenKind kind, SourceLanguage language, SourceText source, SourceRange range)
    : IHasSourceInfo
    , ITreeDebugNode
{
    public static readonly Token AnyEndOfFile = new(TokenKind.EndOfFile, SourceLanguage.None, SourceText.Unknown, default);

    public TokenKind Kind { get; set; } = kind;
    public SourceLanguage Language { get; set; } = language;
    public SourceText Source { get; } = source;
    public SourceRange Range { get; } = range;
    public SourceLocation Location { get; } = range.Begin;

    private StringView? _overrideSpelling;
    public StringView Spelling
    {
        get => _overrideSpelling ?? Source.Slice(Range);
        set => _overrideSpelling = value;
    }

    public bool IsAtStartOfLine { get; set; } = false;
    public bool IsAtEndOfLine => TrailingTrivia.Trivia.Any(t => t is TriviumNewLine or TriviumLineComment);

    public TriviaList LeadingTrivia { get; init; } = TriviaList.EmptyLeading;
    public TriviaList TrailingTrivia { get; init; } = TriviaList.EmptyTrailing;

    private bool? _overrideWhitespaceBeforeState;
    public bool HasWhiteSpaceBefore
    {
        get => _overrideWhitespaceBeforeState ?? LeadingTrivia.Trivia.Count != 0;
        set => _overrideWhitespaceBeforeState = value;
    }

    public StringView StringValue { get; init; }
    public BigInteger IntegerValue { get; init; }
    public double FloatValue { get; init; }

    public bool DisableExpansion { get; set; }

    public int CPPIntegerData { get; set; }
    public int MacroParameterIndex => CPPIntegerData;
    public int VAOptCloseParenIndex => CPPIntegerData;

    string ITreeDebugNode.DebugNodeName { get; } = nameof(Token);
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0301:Simplify collection initialization", Justification = "I know Array.Empty is quick and constant, there's no need to use a collection expression when the semantics in this case are unclear and may change.")]
    IEnumerable<ITreeDebugNode> ITreeDebugNode.Children { get; } = Array.Empty<ITreeDebugNode>();
}
