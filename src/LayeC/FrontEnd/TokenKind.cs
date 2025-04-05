﻿namespace LayeC.FrontEnd;

public enum TokenKind
{
    Invalid = 0,

    EndOfFile,
    UnexpectedCharacter,
    Missing,

    Bang = '!',
    Pound = '#',
    //Dollar = '$',
    Percent = '%',
    Ampersand = '&',
    OpenParen = '(',
    CloseParen = ')',
    Star = '*',
    Plus = '+',
    Comma = ',',
    Minus = '-',
    Dot = '.',
    Slash = '/',
    Colon = ':',
    SemiColon = ';',
    Less = '<',
    Equal = '=',
    Greater = '>',
    Question = '?',
    //At = '@',
    OpenSquare = '[',
    //BackSlash = '\\',
    CloseSquare = ']',
    Caret = '^',
    //Underscore = '_',
    Backtick = '`',
    OpenCurly = '{',
    Pipe = '|',
    CloseCurly = '}',
    Tilde = '~',

    BangEqual,
    PoundPound,
    PercentEqual,
    AmpersandEqual,
    AmpersandAmpersand,
    StarEqual,
    PlusPlus,
    PlusEqual,
    MinusMinus,
    MinusEqual,
    MinusGreater,
    DotDotDot,
    SlashEqual,
    ColonColon,
    LessLess,
    LessLessEqual,
    LessEqual,
    EqualEqual,
    GreaterGreater,
    GreaterGreaterEqual,
    GreaterEqual,
    CaretEqual,
    PipePipe,
    PipeEqual,

    DirectiveEnd,
    HeaderName,
    Identifier,
    PPNumber,
    CharacterConstant,
    LiteralString,

    Int,
    Operator,
    Pragma,
}

public static class TokenKindExtensions
{
    public static bool IsPunctuator(this TokenKind kind) =>
        kind is >= TokenKind.Bang and < TokenKind.DirectiveEnd;
}
