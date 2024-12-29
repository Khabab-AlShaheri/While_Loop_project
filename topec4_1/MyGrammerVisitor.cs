using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace topec4_1
{
    public class MyGrammerVisitor : MyGrammerBaseVisitor<object>
    {
        RichTextBox txt;
        private Dictionary<string, object> variables { get; } = new Dictionary<string, object>();
        //private Dictionary<string, object> variables { get;}=new();

        private StringBuilder generatedCode = new StringBuilder();
        string generated = "";
        string gstr = "";
        public void SaveCodeToFile(string filePath)
        {
            File.WriteAllText(filePath, generatedCode.ToString());
        }
        public MyGrammerVisitor(RichTextBox txt1)
        {
            this.txt = txt1;
            //variables["Write"]=new Dictionary<string, object>(Write);
            variables["write"] = new Func<object[], object>(Write);
        }
        private object[] Write(object[] args)
        {
            string str = "";
            for(int i=0;i<args.Length;i++)
            {
                if(i==0)
                {
                    if (args[i] == null)
                        str = " None ";
                    else
                        str = args[i].ToString();
                }
                    
                else
                {
                    if (args[i] == null)
                        str += ", None ";
                    else
                        str += "," + args[i].ToString();

                }
                    
            }
            txt.Text += str+"\n";
            //generated = "print(" + generated + ")";// هذا يكون دالة طباعة في بايثون تحتوي على اسم المتغير 
            generated = "print(" + str + ")";//هذا يكون دالة طباعة في بايثون تحتوي على قيمة  المتغير
            generatedCode.AppendLine(generated);
           
            generated = "";

            return null;
        }
        
        public override object VisitFunctionCall([NotNull] MyGrammerParser.FunctionCallContext context)
        {
            try
            {
                var name = context.IDENTIFIER().GetText();
                var args = context.expression().Select(e => Visit(e)).ToArray();

                if (!variables.ContainsKey(name))
                {
                    throw new Exception($"Function {name} is not defined .");
                }

                if (variables[name] is Func<object[], object> func)
                    return func(args);
                else
                    throw new Exception($"Variable {name} is not  afunction .");

            }
            catch (Exception ex)
            {
                txt.Text += "this fuuuuuuu";
                return ex.ToString();
            }
            //return base.VisitFunctionCall(context);
        }
        public override object VisitAssigmentDeclaration([NotNull] MyGrammerParser.AssigmentDeclarationContext context)
        {
            generated = "";
            string str = "";
            int len = context.assigment().Length;
            for(int i = 0; i < len; i++)
            {
                string varName = context.assigment()[i].IDENTIFIER().GetText();

                if (len == 1)
                {
                    if (context.assigment()[i].expression() != null)
                    {
                        var value = Visit(context.assigment()[i].expression());
                        variables[varName] = value;
                        //generated=varName.ToString()+"="+value.ToString();
                        gstr = varName;
                        str = generated;

                    }
                    else
                    {

                        variables[varName] = null;
                        gstr = varName.ToString();
                        str = "None";
                    }

                }
                else if (len > 1)
                {
                    if(i<len-1)
                    {
                        if (context.assigment()[i].expression() != null)
                        {
                            var value = Visit(context.assigment()[i].expression());
                            variables[varName] = value;
                            //generated=varName.ToString()+"="+value.ToString();
                            gstr+= varName+",";
                            str += generated+",";

                        }
                        else
                        {

                            variables[varName] = null;
                            gstr+= varName.ToString()+",";
                            str += "None ,";
                        }
                        generated = "";
                    }
                    else
                    {
                        if (context.assigment()[i].expression() != null)
                        {
                            var value = Visit(context.assigment()[i].expression());
                            variables[varName] = value;
                            //generated=varName.ToString()+"="+value.ToString();
                            gstr += varName;
                            str+=generated;

                        }
                        else
                        {

                            variables[varName] = null;
                            gstr += varName.ToString();
                            str += "None";
                        }
                        generated = "";
                    }

                }
            }

            gstr = gstr.Trim()+"="+str;
            generatedCode.AppendLine(gstr);
            generated = "";
            gstr = "";
            return null;

            //return base.VisitAssigmentDeclaration(context);
        }

        public override object VisitMultiplicativeExpression([NotNull] MyGrammerParser.MultiplicativeExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var op = context.multOp().GetText();
            generated += op.ToString();
            var right = Visit(context.expression(1));
            
            if (op == "*")
            {
                return mult(left, right);
            }
            else if (op == "/")
            {
                return null;
            }
            throw new NotImplementedException();
        }
        private object mult(object left, object right)
        {
            if (left is int l && right is int r)
                return l * r;
            if (left is float lf && right is float rf)
                return lf * rf;
            if (left is int lInt && right is float rFloat)
                return lInt * rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat * rInt;
            throw new Exception($"Cannot compare  values of types {left.GetType()} and {right.GetType()} .");
        }
        public override object VisitAdditiveExpression([NotNull] MyGrammerParser.AdditiveExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var op = context.addOp().GetText();
            generated+=op.ToString();
            var right = Visit(context.expression(1));
            
            if (op == "+")
            { return Add(left, right); }
            else if (op == "-")
            {
                return Subtract(left, right);
            }
            throw new NotImplementedException();

        }
        private object Add(object left, object right)
        {
            if (left is int l && right is int r)
                return l + r;
            if (left is float lf && right is float rf)
                return lf + rf;
            if (left is int lInt && right is float rFloat)
                return lInt + rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat + rInt;
            if (left is string || right is string)
                return $"{left}{right}";
            //throw new NotImplementedException();
            throw new Exception($"Cannot add these Values {left?.GetType()} and {right?.GetType()}. ");

        }
        private object Subtract(object left, object right)
        {
            if (left is int l && right is int r)
                return l - r;
            if (left is float lf && right is float rf)
                return lf - rf;
            if (left is int lInt && right is float rFloat)
                return lInt - rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat - rInt;
            if (left is string || right is string)
                return $"{left}{right}";
            //throw new NotImplementedException();
            throw new Exception($"Cannot add these Values {left?.GetType()} and {right?.GetType()}. ");

        }
        public override object VisitIdentifierExpression([NotNull] MyGrammerParser.IdentifierExpressionContext context)
        {
            var varName = context.IDENTIFIER().GetText();
            generated+=varName.ToString();           
            if (!variables.ContainsKey(varName))
            {
                throw new Exception($"Variable {varName} is not defined .");
            }
            return variables[varName];
            //return base.VisitIdentifierExpression(context);
        }

        public override object VisitConstant([NotNull] MyGrammerParser.ConstantContext context)
        {
            if (context.INTEGER() != null)
            {
                int result= int.Parse(context.INTEGER().GetText());
                generated+=result.ToString();
                return result;
            }
                
            if (context.FLOAT() != null)
            {
                float result = float.Parse(context.FLOAT().GetText());
                generated += result.ToString();
                return result;
            }
            
            if (context.STRING() != null)
            {
                string result = context.STRING().GetText();
                generated += result;
                return result;
            }
            
            if (context.BOOL() != null)
            {
                bool result= bool.Parse(context.BOOL().GetText()); 
                generated+=result.ToString();   
                return context.BOOL().GetText() == "true";
            }          
            if (context.NULL() != null)
                return null;
            throw new NotImplementedException();       
        }

        public override object VisitWhileBlock([NotNull] MyGrammerParser.WhileBlockContext context)
        {
            //Func<object, bool> condition = context.WHILE().GetText() == "while" ? IsTrue: IsFalse;
            bool condition = context.WHILE().GetText() == "while";

            if (IsTrue(Visit(context.expression())))
            {
                //gstr = "while(" + generated + "):";
                
                do
                {

                    generated = "";
                    
                    Visit(context.block());


                } while (IsTrue(Visit(context.expression())));

            }
            else if(context.elseIfBlock() != null)
            {
                Visit(context.elseIfBlock());
            }
            return null;
            //return base.VisitWhileBlock(context);
        }
        private bool IsTrue(object value)
        {
            if (value is bool b)
                return b;
            throw new Exception("Value is not boolean");
        }
        public bool IsFalse(object value) => !IsTrue(value);
        public override object VisitBooleanExpression([NotNull] MyGrammerParser.BooleanExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var op = context.boolOp().GetText();
            generated+=op.ToString();
            var right = Visit(context.expression(1));
            
            if (op == "and")
            {
                return andd(left, right);
            }


            return base.VisitBooleanExpression(context);
        }
        private bool andd(object left, object right)
        {
            if (left is bool l && right is bool r)
                return (l & r);
            throw new Exception($"Cannot compare  values of types {left.GetType()} and {right.GetType()} .");
        }
        private bool orr(object left, object right)
        {
            if (left is bool l && right is bool r)
                return (l | r);
            throw new Exception($"Cannot compare  values of types {left.GetType()} and {right.GetType()} .");
        }
        public override object VisitComparisonExpression([NotNull] MyGrammerParser.ComparisonExpressionContext context)
        {
            var left = Visit(context.expression(0));
            var op = context.compareOp().GetText();
            generated += op.ToString();
            var right = Visit(context.expression(1));
            
            if (op == "==")
            {
                return left.Equals(right);
            }
            else if (op == "!=")
            {
                return !(left.Equals(right));
            }
            else if (op == ">")
            {
                return Greaterthan(left, right);
            }
            else if (op == "<")
            {
                return Lessthan(left, right);
            }
            else if (op == ">=")
            {
                return GreaterthanOrEqual(left, right);
            }
            else if (op == "<=")
            {
                return LessthanOrEqual(left, right);
            }
            throw new NotImplementedException();
            //throw new Exception()
        }
        private bool Lessthan(object left, object right)
        {
            if (left is int l && right is int r)
                return l < r;
            if (left is float lf && right is float rf)
                return lf < rf;
            if (left is int lInt && right is float rFloat)
                return lInt < rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat < rInt;
            throw new Exception($"Cannot compare  values of types {left.GetType()} and {right.GetType()} .");
        }
        private bool Greaterthan(object left, object right)
        {
            if (left is int l && right is int r)
                return l > r;
            if (left is float lf && right is float rf)
                return lf > rf;
            if (left is int lInt && right is float rFloat)
                return lInt > rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat > rInt;
            throw new Exception($"Cannot compare  values of types {left.GetType()} and {right.GetType()} .");
        }
        private bool GreaterthanOrEqual(object left, object right)
        {
            if (left is int l && right is int r)
                return l >= r;
            if (left is float lf && right is float rf)
                return lf >= rf;
            if (left is int lInt && right is float rFloat)
                return lInt >= rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat >= rInt;
            throw new Exception($"Cannot compare  values of types {left.GetType()} and {right.GetType()} .");
        }
        private bool LessthanOrEqual(object left, object right)
        {
            if (left is int l && right is int r)
                return l <= r;
            if (left is float lf && right is float rf)
                return lf <= rf;
            if (left is int lInt && right is float rFloat)
                return lInt <= rFloat;
            if (left is float lFloat && right is int rInt)
                return lFloat <= rInt;
            throw new Exception($"Cannot compare  values of types {left.GetType()} and {right.GetType()} .");
        }


        public override object VisitIfBlock([NotNull] MyGrammerParser.IfBlockContext context)
        {
            if (IsTrue(Visit(context.expression())))
            {
                //gstr = "if (" + generated + "):";                
                    generated = "";
                    Visit(context.block());                
            }
            else if (context.elseIfBlock() != null)
            {
                Visit(context.elseIfBlock());
            }
            return null;
            
        }
        public override object VisitElseIfBlock([NotNull] MyGrammerParser.ElseIfBlockContext context)
        {
            generated = "";
            Visit(context.block());
            return null;
            //return base.VisitElseIfBlock(context);
        }
    }


}
