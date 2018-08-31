// <copyright file="DiagnosticCode.Generated.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

/// <summary>
/// This file is auto-generated by a build task. It shouldn't be edited by hand.
/// </summary>
namespace SuperBasic.Compiler.Diagnostics
{
    using SuperBasic.Utilities;
    using SuperBasic.Utilities.Resources;

    public enum DiagnosticCode
    {
        UnrecognizedCharacter,
        UnterminatedStringLiteral,
        UnexpectedTokenFound,
        UnexpectedEndOfStream,
        UnexpectedStatementInsteadOfNewLine,
        UnexpectedTokenInsteadOfStatement,
    }

    internal static partial class DiagnosticCodeExtensions
    {
        public static string ToDisplayString(this DiagnosticCode kind)
        {
            switch (kind)
            {
                case DiagnosticCode.UnrecognizedCharacter: return DiagnosticsResources.UnrecognizedCharacter;
                case DiagnosticCode.UnterminatedStringLiteral: return DiagnosticsResources.UnterminatedStringLiteral;
                case DiagnosticCode.UnexpectedTokenFound: return DiagnosticsResources.UnexpectedTokenFound;
                case DiagnosticCode.UnexpectedEndOfStream: return DiagnosticsResources.UnexpectedEndOfStream;
                case DiagnosticCode.UnexpectedStatementInsteadOfNewLine: return DiagnosticsResources.UnexpectedStatementInsteadOfNewLine;
                case DiagnosticCode.UnexpectedTokenInsteadOfStatement: return DiagnosticsResources.UnexpectedTokenInsteadOfStatement;
                default: throw ExceptionUtilities.UnexpectedValue(kind);
            }
        }
    }
}