namespace topec4_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodeError = new System.Windows.Forms.RichTextBox();
            this.txtCodeEditor = new System.Windows.Forms.RichTextBox();
            this.txtExcute_py = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtoutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(694, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "تحليل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodeError
            // 
            this.txtCodeError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCodeError.Location = new System.Drawing.Point(0, 555);
            this.txtCodeError.Name = "txtCodeError";
            this.txtCodeError.Size = new System.Drawing.Size(1411, 112);
            this.txtCodeError.TabIndex = 14;
            this.txtCodeError.Text = "";
            // 
            // txtCodeEditor
            // 
            this.txtCodeEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeEditor.Location = new System.Drawing.Point(12, 2);
            this.txtCodeEditor.Name = "txtCodeEditor";
            this.txtCodeEditor.Size = new System.Drawing.Size(676, 366);
            this.txtCodeEditor.TabIndex = 15;
            this.txtCodeEditor.Text = "";
            this.txtCodeEditor.TextChanged += new System.EventHandler(this.txtCodeEditor_TextChanged);
            // 
            // txtExcute_py
            // 
            this.txtExcute_py.Location = new System.Drawing.Point(327, 388);
            this.txtExcute_py.Name = "txtExcute_py";
            this.txtExcute_py.Size = new System.Drawing.Size(786, 127);
            this.txtExcute_py.TabIndex = 16;
            this.txtExcute_py.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(-4, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Excute Code from Python File :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(671, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Error :";
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(816, 2);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(583, 366);
            this.txtoutput.TabIndex = 18;
            this.txtoutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 667);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExcute_py);
            this.Controls.Add(this.txtCodeEditor);
            this.Controls.Add(this.txtCodeError);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtCodeError;
        private System.Windows.Forms.RichTextBox txtCodeEditor;
        private System.Windows.Forms.RichTextBox txtExcute_py;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtoutput;
    }
}

