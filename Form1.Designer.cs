namespace PRACTICA2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 70);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 0;
            label1.Text = "Hello, Mundo!!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 206);
            label2.Name = "label2";
            label2.Size = new Size(155, 19);
            label2.TabIndex = 1;
            label2.Text = "cual es tu nombre?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 278);
            label3.Name = "label3";
            label3.Size = new Size(183, 19);
            label3.TabIndex = 2;
            label3.Text = "Hello, alguien especial!";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(93, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 26);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(348, 222);
            button1.Name = "button1";
            button1.Size = new Size(186, 39);
            button1.TabIndex = 4;
            button1.Text = "Diga \"Hello\"";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "HOLA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}