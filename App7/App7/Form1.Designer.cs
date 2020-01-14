namespace App7
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
            this.tbInput3 = new System.Windows.Forms.TextBox();
            this.tbInput4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbOutput1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput3
            // 
            this.tbInput3.Location = new System.Drawing.Point(120, 61);
            this.tbInput3.Name = "tbInput3";
            this.tbInput3.Size = new System.Drawing.Size(100, 26);
            this.tbInput3.TabIndex = 0;
            this.tbInput3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbInput4
            // 
            this.tbInput4.Location = new System.Drawing.Point(120, 112);
            this.tbInput4.Name = "tbInput4";
            this.tbInput4.Size = new System.Drawing.Size(100, 26);
            this.tbInput4.TabIndex = 1;
            this.tbInput4.TextChanged += new System.EventHandler(this.tbInput4_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "spausti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbOutput1
            // 
            this.tbOutput1.Location = new System.Drawing.Point(301, 61);
            this.tbOutput1.Multiline = true;
            this.tbOutput1.Name = "tbOutput1";
            this.tbOutput1.Size = new System.Drawing.Size(244, 77);
            this.tbOutput1.TabIndex = 3;
            this.tbOutput1.TextChanged += new System.EventHandler(this.tbOutput1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ugis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "svoris";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(827, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOutput1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbInput4);
            this.Controls.Add(this.tbInput3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput3;
        private System.Windows.Forms.TextBox tbInput4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbOutput1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

