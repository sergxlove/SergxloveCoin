namespace SergxloveCoin
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(67, 67, 67);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(574, 12);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(67, 67, 67);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(508, 12);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(246, 48);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 2;
            label1.Text = "Ваш счёт :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(348, 105);
            label2.Name = "label2";
            label2.Size = new Size(148, 62);
            label2.TabIndex = 3;
            label2.Text = "0.000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 69, 69);
            ClientSize = new Size(646, 798);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(800, 1000);
            Name = "Form1";
            Text = "SergxloveCoin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}