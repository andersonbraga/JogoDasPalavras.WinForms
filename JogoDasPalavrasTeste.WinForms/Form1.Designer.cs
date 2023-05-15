namespace JogoDasPalavrasTeste.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSecretWord = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            SuspendLayout();
            // 
            // lblSecretWord
            // 
            lblSecretWord.AutoSize = true;
            lblSecretWord.Location = new Point(384, 87);
            lblSecretWord.Name = "lblSecretWord";
            lblSecretWord.Size = new Size(38, 15);
            lblSecretWord.TabIndex = 0;
            lblSecretWord.Text = "label1";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(353, 190);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(384, 248);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(75, 23);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "button1";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblSecretWord);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSecretWord;
        private TextBox txtGuess;
        private Button btnGuess;
    }
}