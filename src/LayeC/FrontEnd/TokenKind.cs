﻿namespace LayeC.FrontEnd;

public enum TokenKind
{
    Invalid = 0,

    UnexpectedCharacter,
    Missing,

    EndOfFile,

    CPPIdentifier,
    CPPNumber,
    CPPVAOpt,
    CPPVAArgs,
    CPPMacroParam,
    CPPHeaderName,
    CPPDirectiveEnd,

    Hash,
    HashHash,
    HashSquare,

    Identifier,
    LiteralInteger,
    LiteralFloat,
    LiteralCharacter,
    LiteralString,

    OpenParen,
    CloseParen,
    OpenSquare,
    CloseSquare,
    OpenCurly,
    CloseCurly,

    Comma,
    SemiColon,
    Dot,
    DotDot,
    DotDotEqual,
    DotDotDot,
    Colon,
    ColonColon,

    Equal,
    EqualEqual,
    EqualGreater,
    Bang,
    BangEqual,

    Less,
    LessEqual,
    LessEqualGreater,
    LessLess,
    LessLessEqual,
    Greater,
    GreaterEqual,
    GreaterGreater,
    GreaterGreaterEqual,
    GreaterGreaterGreater,
    GreaterGreaterGreaterEqual,

    Plus,
    PlusEqual,
    PlusPlus,
    Minus,
    MinusEqual,
    MinusMinus,
    MinusGreater,
    Star,
    StarEqual,
    Slash,
    SlashEqual,
    Percent,
    PercentEqual,
    Caret,
    CaretEqual,
    Tilde,
    TildeEqual,
    Ampersand,
    AmpersandEqual,
    AmpersandAmpersand,
    Pipe,
    PipeEqual,
    PipePipe,
    Question,
    QuestionQuestion,
    QuestionQuestionEqual,

    KWAlias,
    KWAlignas,
    KWAlignof,
    KWAnd,
    KWAs,
    KWAssert,
    KW_Atomic,
    KW__Attribute__,
    KWAuto,
    KW_BitInt,
    KWBool,
    KWBoolSized,
    KWBreak,
    KWBuiltinFFIBool,
    KWBuiltinFFIChar,
    KWBuiltinFFIShort,
    KWBuiltinFFIInt,
    KWBuiltinFFILong,
    KWBuiltinFFILongLong,
    KWBuiltinFFIFloat,
    KWBuiltinFFIDouble,
    KWBuiltinFFILongDouble,
    KWCallconv,
    KWCase,
    KWCast,
    KWChar,
    KW_Complex,
    KWConst,
    KWConstexpr,
    KWContinue,
    KWCountof,
    KW_Decimal128,
    KW_Decimal32,
    KW_Decimal64,
    KWDefault,
    KWDefer,
    KWDelegate,
    KWDelete,
    KWDiscard,
    KWDiscardable,
    KWDo,
    KWDouble,
    KWElse,
    KWEnum,
    KWEval,
    KWExtern,
    KWExport,
    KWFalse,
    KWFallthrough,
    KWFloat,
    KWFloat32,
    KWFloat64,
    KWFor,
    KWForeign,
    KWFrom,
    KW_Generic,
    KWGlobal,
    KWGoto,
    KWIf,
    KW_Imaginary,
    KWImport,
    KWInline,
    KWInt,
    KWIntSized,
    KWIs,
    KWLong,
    KWModule,
    KWMut,
    KWNew,
    KWNil,
    KWNoreturn,
    KWNot,
    KWNullptr,
    KWOffsetof,
    KWOperator,
    KWOr,
    KWPragma,
    KWRankof,
    KWRef,
    KWRegister,
    KWRestrict,
    KWReturn,
    KWShort,
    KWSigned,
    KWSizeof,
    KWStatic,
    KWStatic_Assert,
    KWStrict,
    KWStruct,
    KWSwitch,
    KWTemplate,
    KWTest,
    KWThread_Local,
    KWTrue,
    KWTypedef,
    KWTypeof,
    KWTypeof_Unqual,
    KWUnion,
    KWUnreachable,
    KWUnsigned,
    KWVar,
    KWVarargs,
    KWVariant,
    KWVoid,
    KWVolatile,
    KWWhile,
    KWXor,
    KWXyzzy,
    KWYield,
}
