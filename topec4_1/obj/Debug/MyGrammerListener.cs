//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\ComputerWorld\Desktop\مشروع مترجمات نهائي\مجلد جديد\5\While_Loop_Project\topec4_1\MyGrammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace topec4_1 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MyGrammerParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMyGrammerListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] MyGrammerParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] MyGrammerParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] MyGrammerParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] MyGrammerParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] MyGrammerParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] MyGrammerParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] MyGrammerParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] MyGrammerParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] MyGrammerParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] MyGrammerParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] MyGrammerParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] MyGrammerParser.ComparisonExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] MyGrammerParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] MyGrammerParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] MyGrammerParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] MyGrammerParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parentthesizedExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParentthesizedExpression([NotNull] MyGrammerParser.ParentthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parentthesizedExpression</c>
	/// labeled alternative in <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParentthesizedExpression([NotNull] MyGrammerParser.ParentthesizedExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] MyGrammerParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] MyGrammerParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] MyGrammerParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] MyGrammerParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] MyGrammerParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] MyGrammerParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.assigmentDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssigmentDeclaration([NotNull] MyGrammerParser.AssigmentDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.assigmentDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssigmentDeclaration([NotNull] MyGrammerParser.AssigmentDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] MyGrammerParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] MyGrammerParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] MyGrammerParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] MyGrammerParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] MyGrammerParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] MyGrammerParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.assigment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssigment([NotNull] MyGrammerParser.AssigmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.assigment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssigment([NotNull] MyGrammerParser.AssigmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] MyGrammerParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] MyGrammerParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] MyGrammerParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] MyGrammerParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOp([NotNull] MyGrammerParser.MultOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOp([NotNull] MyGrammerParser.MultOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOp([NotNull] MyGrammerParser.AddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOp([NotNull] MyGrammerParser.AddOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareOp([NotNull] MyGrammerParser.CompareOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareOp([NotNull] MyGrammerParser.CompareOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOp([NotNull] MyGrammerParser.BoolOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOp([NotNull] MyGrammerParser.BoolOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] MyGrammerParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] MyGrammerParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] MyGrammerParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] MyGrammerParser.BlockContext context);
}
} // namespace topec4_1
