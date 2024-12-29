using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Misc;

namespace topec4_1
{
    public partial class Form1 : Form
    {
        Thread mythread;
        
        public Form1()
        {
            InitializeComponent();
            mythread = new Thread(HighlightKeyword);
            mythread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           txtoutput.Clear();
            txtCodeEditor.SelectAll();
            txtCodeEditor.SelectionColor = Color.Black;
            txtCodeEditor.SelectionBackColor = Color.Transparent;
            txtExcute_py.Text = "";
            if (txtCodeEditor.Text.Length > 0)
            {
                string input = txtCodeEditor.Text.ToString();

                AntlrInputStream inputStreem = new AntlrInputStream(input);

                MyGrammerLexer lexer = new MyGrammerLexer(inputStreem);


                CommonTokenStream lTS = new CommonTokenStream(lexer);

                MyGrammerParser parser = new MyGrammerParser(lTS);
                txtCodeError.Clear();
                string pyFilePath = AppDomain.CurrentDomain.BaseDirectory + "codeOut.py";
                string exeFilePath = AppDomain.CurrentDomain.BaseDirectory + "generated_code.exe";
              
                parser.RemoveErrorListeners();       
                parser.AddErrorListener(new MyErrorListener(txtCodeError,txtCodeEditor));

                parser.BuildParseTree = true;
                IParseTree tree = parser.program();
                MyGrammerVisitor visitor = new MyGrammerVisitor(txtoutput);
                visitor.Visit(tree);

                visitor.SaveCodeToFile(pyFilePath);
                ExecutePythonFile(pyFilePath);
                //CompileCppToExe(cppFilePath, exeFilePath);

            }
        }

        private void ExecutePythonFile(string pythonFilePath)
        {
            Process pythonProcess = new Process();

           
            pythonProcess.StartInfo.FileName = "python";  
            pythonProcess.StartInfo.Arguments = "\"" + pythonFilePath + "\""; 
            pythonProcess.StartInfo.RedirectStandardOutput = true;
            pythonProcess.StartInfo.RedirectStandardError = true;
            pythonProcess.StartInfo.UseShellExecute = false;
            pythonProcess.StartInfo.CreateNoWindow = true;

            try
            {
                pythonProcess.Start();
                string output = pythonProcess.StandardOutput.ReadToEnd();  
                string errors = pythonProcess.StandardError.ReadToEnd();   
                pythonProcess.WaitForExit();

                if (pythonProcess.ExitCode == 0)
                {
                    txtExcute_py.AppendText("Python script executed successfully!\nOutput:\n" + output);
                }
                else
                {
                    txtExcute_py.AppendText("Python script execution failed:\n" + errors);
                }
            }
            catch (Exception ex)
            {
                txtExcute_py.AppendText("Error while executing Python script:\n" + ex.Message);
            }
            finally
            {
                pythonProcess.Close();
            }
        }
        private void CompileCppToExe(string cppFilePath, string exeFilePath)
        {

            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = "g++";
            compileProcess.StartInfo.Arguments = "-o \"" + exeFilePath + "\" \"" + cppFilePath + "\"";
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.StartInfo.RedirectStandardError = true;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.CreateNoWindow = true;

            try
            {

                compileProcess.Start();
                string output = compileProcess.StandardOutput.ReadToEnd();
                string errors = compileProcess.StandardError.ReadToEnd();
                compileProcess.WaitForExit();


                if (compileProcess.ExitCode == 0)
                {
                    txtCodeError.AppendText("Compilation succeeded! Executable created: " + exeFilePath);
                    Process.Start(exeFilePath);

                }
                else
                {
                    txtCodeError.AppendText("Compilation failed:\n" + errors);
                }
            }
            catch (Exception ex)
            {
                txtCodeError.AppendText("Error while compiling:\n" + ex.Message);
            }
            finally
            {
                compileProcess.Close();
            }
        }
        
        private void HighlightKeyword()
        {

            int startIndex = 0;
            string keyword = "write";
            if (txtCodeEditor.Text.Contains(keyword))
            {
                // ابحث عن الكلمة في النص الكامل.
                while (startIndex < txtCodeEditor.Text.Length)
                {
                    // ابحث عن الكلمة بدءًا من الفهرس المحدد.
                    int wordIndex = txtCodeEditor.Text.IndexOf(keyword, startIndex);

                    // إذا تم العثور على الكلمة، قم بتحديدها وتغيير اللون.
                    if (wordIndex != -1)
                    {
                        // حدد الكلمة.
                        txtCodeEditor.Select(wordIndex, keyword.Length);

                        // غيّر اللون.
                        txtCodeEditor.SelectionColor = Color.Blue;
                        txtCodeEditor.DeselectAll();
                        //txtCodeEditor.AutoWordSelection = true;
                        // استمر في البحث بعد الكلمة المحددة.
                        startIndex = wordIndex + keyword.Length;
                    }
                    else
                    {
                        // إذا لم يتم العثور على الكلمة، قم بالخروج من الحلقة.
                        break;

                    }
                }
            }

        
    }

        private void txtCodeEditor_TextChanged(object sender, EventArgs e)
        {
  
            //HighlightKeyword();

        }
    }


    public class MyErrorListener : BaseErrorListener
    {

        RichTextBox errorTextBox;
        RichTextBox textBox1;
        public MyErrorListener(RichTextBox _textBox,RichTextBox txtcontext)
        {
            errorTextBox = _textBox;
            textBox1 = txtcontext;

        }

        
        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {          
            errorTextBox.AppendText(msg+ " line : " + line + " possotisn : " + charPositionInLine + " \n");
            int len = offendingSymbol.StopIndex - offendingSymbol.StartIndex;
            textBox1.Select(offendingSymbol.StartIndex, len);
            textBox1.SelectionColor = Color.Red;
            //textBox1.SelectionBackColor = Color.Red;

            //textBox1.SelectAll();
            //textBox1.Text.Select(offendingSymbol.Text);
            //textBox1.SelectedText=offendingSymbol.Text;
            //= offendingSymbol.StartIndex-offendingSymbol.StopIndex;
        }
        



    }

}