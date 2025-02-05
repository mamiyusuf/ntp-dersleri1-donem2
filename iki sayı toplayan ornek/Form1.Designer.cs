namespace iki_sayı_toplayan_ornek
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txtsonuc = new TextBox();
            btn1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(73, 48);
            label3.TabIndex = 0;
            label3.Text = "Sonuc=";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 0;
            label1.Text = "sayı 2";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 0;
            label2.Text = "sayı 1";
            label2.Click += label2_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(96, 33);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 1;
            // 
            // txt2
            // 
            txt2.Location = new Point(96, 101);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 1;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // txtsonuc
            // 
            txtsonuc.Location = new Point(96, 234);
            txtsonuc.Name = "txtsonuc";
            txtsonuc.Size = new Size(100, 23);
            txtsonuc.TabIndex = 1;
            txtsonuc.TextChanged += txt2_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(63, 163);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 2;
            btn1.Text = "HESAPLA";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 283);
            Controls.Add(btn1);
            Controls.Add(txtsonuc);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txtsonuc;
        private Button btn1;
    }
}