﻿namespace LayeC.FrontEnd.SyntaxTree.Decls;

public sealed class SyntaxImportDeclaration(Token importKeywordToken, SyntaxModuleName moduleName, Token semiColonToken)
    : SyntaxNode(importKeywordToken.Source, importKeywordToken.Range)
{
    public Token ImportKeywordToken { get; } = importKeywordToken;
    public SyntaxModuleName ModuleName { get; } = moduleName;
    public Token SemiColonToken { get; } = semiColonToken;

    protected override string DebugNodeName { get; } = nameof(SyntaxImportDeclaration);
    protected override IEnumerable<ITreeDebugNode> Children { get; } = [importKeywordToken, moduleName, semiColonToken];
}
