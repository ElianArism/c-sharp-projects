namespace UnitConverter
{
    partial class UnitConverter
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
            this.baseMeterUnit = new System.Windows.Forms.ComboBox();
            this.convertMeterBtn = new System.Windows.Forms.Button();
            this.convertToMeterUnit = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.meterInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.temperatureInput = new System.Windows.Forms.NumericUpDown();
            this.convertToTemperatureUnit = new System.Windows.Forms.ComboBox();
            this.convertTemperatureBtn = new System.Windows.Forms.Button();
            this.baseTemperatureUnit = new System.Windows.Forms.ComboBox();
            this.literInput = new System.Windows.Forms.NumericUpDown();
            this.convertToLiterUnit = new System.Windows.Forms.ComboBox();
            this.convertLiterBtn = new System.Windows.Forms.Button();
            this.baseLiterUnit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.meterInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.literInput)).BeginInit();
            this.SuspendLayout();
            // 
            // baseMeterUnit
            // 
            this.baseMeterUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseMeterUnit.FormattingEnabled = true;
            this.baseMeterUnit.Location = new System.Drawing.Point(193, 76);
            this.baseMeterUnit.Name = "baseMeterUnit";
            this.baseMeterUnit.Size = new System.Drawing.Size(203, 28);
            this.baseMeterUnit.TabIndex = 0;
            // 
            // convertMeterBtn
            // 
            this.convertMeterBtn.Location = new System.Drawing.Point(621, 67);
            this.convertMeterBtn.Name = "convertMeterBtn";
            this.convertMeterBtn.Size = new System.Drawing.Size(159, 44);
            this.convertMeterBtn.TabIndex = 1;
            this.convertMeterBtn.Text = "Convert";
            this.convertMeterBtn.UseVisualStyleBackColor = true;
            this.convertMeterBtn.Click += new System.EventHandler(this.convertMeterBtn_Click);
            // 
            // convertToMeterUnit
            // 
            this.convertToMeterUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertToMeterUnit.FormattingEnabled = true;
            this.convertToMeterUnit.Location = new System.Drawing.Point(402, 75);
            this.convertToMeterUnit.Name = "convertToMeterUnit";
            this.convertToMeterUnit.Size = new System.Drawing.Size(203, 28);
            this.convertToMeterUnit.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 380);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(288, 44);
            this.textBox1.TabIndex = 4;
            // 
            // meterInput
            // 
            this.meterInput.Location = new System.Drawing.Point(20, 76);
            this.meterInput.Name = "meterInput";
            this.meterInput.Size = new System.Drawing.Size(167, 27);
            this.meterInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Meter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Celsius / Farenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Liter";
            // 
            // temperatureInput
            // 
            this.temperatureInput.Location = new System.Drawing.Point(20, 179);
            this.temperatureInput.Name = "temperatureInput";
            this.temperatureInput.Size = new System.Drawing.Size(167, 27);
            this.temperatureInput.TabIndex = 12;
            // 
            // convertToTemperatureUnit
            // 
            this.convertToTemperatureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertToTemperatureUnit.FormattingEnabled = true;
            this.convertToTemperatureUnit.Location = new System.Drawing.Point(402, 178);
            this.convertToTemperatureUnit.Name = "convertToTemperatureUnit";
            this.convertToTemperatureUnit.Size = new System.Drawing.Size(203, 28);
            this.convertToTemperatureUnit.TabIndex = 11;
            // 
            // convertTemperatureBtn
            // 
            this.convertTemperatureBtn.Location = new System.Drawing.Point(621, 170);
            this.convertTemperatureBtn.Name = "convertTemperatureBtn";
            this.convertTemperatureBtn.Size = new System.Drawing.Size(159, 44);
            this.convertTemperatureBtn.TabIndex = 10;
            this.convertTemperatureBtn.Text = "Convert";
            this.convertTemperatureBtn.UseVisualStyleBackColor = true;
            this.convertTemperatureBtn.Click += new System.EventHandler(this.convertTemperatureBtn_Click);
            // 
            // baseTemperatureUnit
            // 
            this.baseTemperatureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseTemperatureUnit.FormattingEnabled = true;
            this.baseTemperatureUnit.Location = new System.Drawing.Point(193, 179);
            this.baseTemperatureUnit.Name = "baseTemperatureUnit";
            this.baseTemperatureUnit.Size = new System.Drawing.Size(203, 28);
            this.baseTemperatureUnit.TabIndex = 9;
            // 
            // literInput
            // 
            this.literInput.Location = new System.Drawing.Point(20, 305);
            this.literInput.Name = "literInput";
            this.literInput.Size = new System.Drawing.Size(167, 27);
            this.literInput.TabIndex = 16;
            // 
            // convertToLiterUnit
            // 
            this.convertToLiterUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.convertToLiterUnit.FormattingEnabled = true;
            this.convertToLiterUnit.Location = new System.Drawing.Point(402, 304);
            this.convertToLiterUnit.Name = "convertToLiterUnit";
            this.convertToLiterUnit.Size = new System.Drawing.Size(203, 28);
            this.convertToLiterUnit.TabIndex = 15;
            // 
            // convertLiterBtn
            // 
            this.convertLiterBtn.Location = new System.Drawing.Point(621, 296);
            this.convertLiterBtn.Name = "convertLiterBtn";
            this.convertLiterBtn.Size = new System.Drawing.Size(159, 44);
            this.convertLiterBtn.TabIndex = 14;
            this.convertLiterBtn.Text = "Convert";
            this.convertLiterBtn.UseVisualStyleBackColor = true;
            this.convertLiterBtn.Click += new System.EventHandler(this.convertLiterBtn_Click);
            // 
            // baseLiterUnit
            // 
            this.baseLiterUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseLiterUnit.FormattingEnabled = true;
            this.baseLiterUnit.Location = new System.Drawing.Point(193, 305);
            this.baseLiterUnit.Name = "baseLiterUnit";
            this.baseLiterUnit.Size = new System.Drawing.Size(203, 28);
            this.baseLiterUnit.TabIndex = 13;
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.literInput);
            this.Controls.Add(this.convertToLiterUnit);
            this.Controls.Add(this.convertLiterBtn);
            this.Controls.Add(this.baseLiterUnit);
            this.Controls.Add(this.temperatureInput);
            this.Controls.Add(this.convertToTemperatureUnit);
            this.Controls.Add(this.convertTemperatureBtn);
            this.Controls.Add(this.baseTemperatureUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meterInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertToMeterUnit);
            this.Controls.Add(this.convertMeterBtn);
            this.Controls.Add(this.baseMeterUnit);
            this.Name = "UnitConverter";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.UnitConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meterInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.literInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox baseMeterUnit;
        private Button convertMeterBtn;
        private ComboBox convertToMeterUnit;
        private TextBox textBox1;
        private NumericUpDown meterInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown temperatureInput;
        private ComboBox convertToTemperatureUnit;
        private Button convertTemperatureBtn;
        private ComboBox baseTemperatureUnit;
        private NumericUpDown literInput;
        private ComboBox convertToLiterUnit;
        private Button convertLiterBtn;
        private ComboBox baseLiterUnit;
    }
}