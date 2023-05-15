namespace Calculator
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.operand2 = new System.Windows.Forms.NumericUpDown();
            this.operand1 = new System.Windows.Forms.NumericUpDown();
            this.minusBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.multiplationBtn = new System.Windows.Forms.Button();
            this.additionBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operand1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.equalsBtn);
            this.panel1.Controls.Add(this.operand2);
            this.panel1.Controls.Add(this.operand1);
            this.panel1.Controls.Add(this.minusBtn);
            this.panel1.Controls.Add(this.divisionBtn);
            this.panel1.Controls.Add(this.multiplationBtn);
            this.panel1.Controls.Add(this.additionBtn);
            this.panel1.Controls.Add(this.resultTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // equalsBtn
            // 
            this.equalsBtn.Location = new System.Drawing.Point(556, 183);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(194, 74);
            this.equalsBtn.TabIndex = 8;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            this.equalsBtn.Enabled = false; 
            // 
            // operand2
            // 
            this.operand2.Location = new System.Drawing.Point(556, 51);
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(194, 27);
            this.operand2.TabIndex = 7;
            this.operand2.Enabled = false;

            // 
            // operand1
            // 
            this.operand1.Location = new System.Drawing.Point(22, 51);
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(194, 27);
            this.operand1.TabIndex = 6;
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(241, 147);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(194, 74);
            this.minusBtn.TabIndex = 4;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.operationToRealize_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.Location = new System.Drawing.Point(241, 227);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(194, 74);
            this.divisionBtn.TabIndex = 3;
            this.divisionBtn.Text = "/";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.operationToRealize_Click);
            // 
            // multiplationBtn
            // 
            this.multiplationBtn.Location = new System.Drawing.Point(22, 223);
            this.multiplationBtn.Name = "multiplationBtn";
            this.multiplationBtn.Size = new System.Drawing.Size(194, 74);
            this.multiplationBtn.TabIndex = 2;
            this.multiplationBtn.Text = "*";
            this.multiplationBtn.UseVisualStyleBackColor = true;
            this.multiplationBtn.Click += new System.EventHandler(this.operationToRealize_Click);
            // 
            // additionBtn
            // 
            this.additionBtn.Location = new System.Drawing.Point(22, 147);
            this.additionBtn.Name = "additionBtn";
            this.additionBtn.Size = new System.Drawing.Size(194, 74);
            this.additionBtn.TabIndex = 1;
            this.additionBtn.Text = "+";
            this.additionBtn.UseVisualStyleBackColor = true;
            this.additionBtn.Click += new System.EventHandler(this.operationToRealize_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(3, 368);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(767, 40);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.ReadOnly = true; 
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operand1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox resultTextBox;
        private Button multiplationBtn;
        private Button additionBtn;
        private Button minusBtn;
        private Button divisionBtn;
        private NumericUpDown operand2;
        private NumericUpDown operand1;
        private Button equalsBtn;
    }
}