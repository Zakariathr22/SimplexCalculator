namespace WinFormsApp1
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
            this.Var_Num = new System.Windows.Forms.NumericUpDown();
            this.Cons_Num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Z_X = new System.Windows.Forms.Label();
            this.MAXorMIN = new System.Windows.Forms.ComboBox();
            this.ZeroEquationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.EquationsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Var_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cons_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Var_Num
            // 
            this.Var_Num.BackColor = System.Drawing.Color.Snow;
            this.Var_Num.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Var_Num.Location = new System.Drawing.Point(217, 12);
            this.Var_Num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Var_Num.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Var_Num.Name = "Var_Num";
            this.Var_Num.Size = new System.Drawing.Size(70, 29);
            this.Var_Num.TabIndex = 0;
            this.Var_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Var_Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Var_Num.ValueChanged += new System.EventHandler(this.Var_Num_ValueChanged);
            // 
            // Cons_Num
            // 
            this.Cons_Num.BackColor = System.Drawing.Color.Snow;
            this.Cons_Num.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cons_Num.Location = new System.Drawing.Point(526, 12);
            this.Cons_Num.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Cons_Num.Name = "Cons_Num";
            this.Cons_Num.Size = new System.Drawing.Size(70, 29);
            this.Cons_Num.TabIndex = 1;
            this.Cons_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cons_Num.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Cons_Num.ValueChanged += new System.EventHandler(this.Cons_Num_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Number of Variables:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.label2.Location = new System.Drawing.Point(307, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "The Number of Constrains:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(74)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(622, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "NEXT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Z_X
            // 
            this.Z_X.AutoSize = true;
            this.Z_X.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Z_X.Location = new System.Drawing.Point(83, 80);
            this.Z_X.Name = "Z_X";
            this.Z_X.Size = new System.Drawing.Size(57, 21);
            this.Z_X.TabIndex = 5;
            this.Z_X.Text = "Z(X) =";
            this.Z_X.Visible = false;
            this.Z_X.Click += new System.EventHandler(this.label3_Click);
            // 
            // MAXorMIN
            // 
            this.MAXorMIN.BackColor = System.Drawing.Color.Snow;
            this.MAXorMIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MAXorMIN.FormattingEnabled = true;
            this.MAXorMIN.Items.AddRange(new object[] {
            "MAX",
            "MIN"});
            this.MAXorMIN.Location = new System.Drawing.Point(12, 77);
            this.MAXorMIN.Name = "MAXorMIN";
            this.MAXorMIN.Size = new System.Drawing.Size(65, 29);
            this.MAXorMIN.TabIndex = 6;
            this.MAXorMIN.Text = "MAX";
            this.MAXorMIN.Visible = false;
            // 
            // ZeroEquationPanel
            // 
            this.ZeroEquationPanel.AutoScroll = true;
            this.ZeroEquationPanel.AutoScrollMinSize = new System.Drawing.Size(10000, 0);
            this.ZeroEquationPanel.Location = new System.Drawing.Point(146, 77);
            this.ZeroEquationPanel.Name = "ZeroEquationPanel";
            this.ZeroEquationPanel.Size = new System.Drawing.Size(596, 52);
            this.ZeroEquationPanel.TabIndex = 7;
            this.ZeroEquationPanel.Visible = false;
            this.ZeroEquationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ZeroEquationPanel_Paint);
            // 
            // EquationsPanel
            // 
            this.EquationsPanel.Location = new System.Drawing.Point(11, 161);
            this.EquationsPanel.Name = "EquationsPanel";
            this.EquationsPanel.Size = new System.Drawing.Size(731, 225);
            this.EquationsPanel.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(74)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(250, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "SOLVE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.button3.Image = global::WinFormsApp1.Properties.Resources.Broom;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(376, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 50);
            this.button3.TabIndex = 10;
            this.button3.Text = "CLEAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "The Linear Programming Problem:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subject to the Constraints:";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(749, 451);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EquationsPanel);
            this.Controls.Add(this.ZeroEquationPanel);
            this.Controls.Add(this.MAXorMIN);
            this.Controls.Add(this.Z_X);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cons_Num);
            this.Controls.Add(this.Var_Num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simplex Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Var_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cons_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown Var_Num;
        private NumericUpDown Cons_Num;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label Z_X;
        private ComboBox MAXorMIN;
        private FlowLayoutPanel ZeroEquationPanel;
        private FlowLayoutPanel EquationsPanel;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
    }
}