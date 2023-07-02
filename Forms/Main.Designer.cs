namespace practice
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DegreesRadioButton = new System.Windows.Forms.RadioButton();
			this.RadiansRadioButton = new System.Windows.Forms.RadioButton();
			this.AngleTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.SinCheckBox = new System.Windows.Forms.CheckBox();
			this.CosCheckBox = new System.Windows.Forms.CheckBox();
			this.TgCheckBox = new System.Windows.Forms.CheckBox();
			this.CtgCheckBox = new System.Windows.Forms.CheckBox();
			this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.ForeColor = System.Drawing.Color.Black;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(129, 63);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBox1.Size = new System.Drawing.Size(245, 31);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "           Выбор функции";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(212, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Меню\r\n";
			this.label1.UseMnemonic = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(783, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(373, 35);
			this.label2.TabIndex = 4;
			this.label2.Text = "Построение графика функции";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(128, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = " Cправочная информация";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(1012, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "введите значение :";
			// 
			// DegreesRadioButton
			// 
			this.DegreesRadioButton.AutoSize = true;
			this.DegreesRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DegreesRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DegreesRadioButton.Location = new System.Drawing.Point(1013, 98);
			this.DegreesRadioButton.Name = "DegreesRadioButton";
			this.DegreesRadioButton.Size = new System.Drawing.Size(104, 24);
			this.DegreesRadioButton.TabIndex = 7;
			this.DegreesRadioButton.TabStop = true;
			this.DegreesRadioButton.Text = "в градусах";
			this.DegreesRadioButton.UseVisualStyleBackColor = true;
			this.DegreesRadioButton.CheckedChanged += new System.EventHandler(this.DegreesRadioButton_CheckedChanged);
			// 
			// RadiansRadioButton
			// 
			this.RadiansRadioButton.AutoSize = true;
			this.RadiansRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RadiansRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RadiansRadioButton.Location = new System.Drawing.Point(1013, 124);
			this.RadiansRadioButton.Name = "RadiansRadioButton";
			this.RadiansRadioButton.Size = new System.Drawing.Size(107, 24);
			this.RadiansRadioButton.TabIndex = 8;
			this.RadiansRadioButton.TabStop = true;
			this.RadiansRadioButton.Text = "в радианах";
			this.RadiansRadioButton.UseVisualStyleBackColor = true;
			this.RadiansRadioButton.CheckedChanged += new System.EventHandler(this.RadiansRadioButton_CheckedChanged);
			// 
			// AngleTextBox
			// 
			this.AngleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AngleTextBox.Location = new System.Drawing.Point(1162, 160);
			this.AngleTextBox.Name = "AngleTextBox";
			this.AngleTextBox.Size = new System.Drawing.Size(46, 20);
			this.AngleTextBox.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(1009, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(219, 40);
			this.label5.TabIndex = 10;
			this.label5.Text = "Выберите в каких величинах\r\n зададите интервал углов :";
			// 
			// CalculateButton
			// 
			this.CalculateButton.AutoSize = true;
			this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CalculateButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CalculateButton.Location = new System.Drawing.Point(1085, 689);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(257, 38);
			this.CalculateButton.TabIndex = 11;
			this.CalculateButton.Text = "Построить график";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click_1);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(760, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(159, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Выберите функцию :";
			// 
			// SinCheckBox
			// 
			this.SinCheckBox.AutoSize = true;
			this.SinCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SinCheckBox.Location = new System.Drawing.Point(764, 78);
			this.SinCheckBox.Name = "SinCheckBox";
			this.SinCheckBox.Size = new System.Drawing.Size(47, 24);
			this.SinCheckBox.TabIndex = 18;
			this.SinCheckBox.Text = "sin";
			this.SinCheckBox.UseVisualStyleBackColor = true;
			// 
			// CosCheckBox
			// 
			this.CosCheckBox.AutoSize = true;
			this.CosCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CosCheckBox.Location = new System.Drawing.Point(764, 108);
			this.CosCheckBox.Name = "CosCheckBox";
			this.CosCheckBox.Size = new System.Drawing.Size(51, 24);
			this.CosCheckBox.TabIndex = 19;
			this.CosCheckBox.Text = "cos";
			this.CosCheckBox.UseVisualStyleBackColor = true;
			// 
			// TgCheckBox
			// 
			this.TgCheckBox.AutoSize = true;
			this.TgCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TgCheckBox.Location = new System.Drawing.Point(764, 138);
			this.TgCheckBox.Name = "TgCheckBox";
			this.TgCheckBox.Size = new System.Drawing.Size(43, 24);
			this.TgCheckBox.TabIndex = 20;
			this.TgCheckBox.Text = "tg";
			this.TgCheckBox.UseVisualStyleBackColor = true;
			// 
			// CtgCheckBox
			// 
			this.CtgCheckBox.AutoSize = true;
			this.CtgCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CtgCheckBox.Location = new System.Drawing.Point(764, 168);
			this.CtgCheckBox.Name = "CtgCheckBox";
			this.CtgCheckBox.Size = new System.Drawing.Size(51, 24);
			this.CtgCheckBox.TabIndex = 21;
			this.CtgCheckBox.Text = "ctg";
			this.CtgCheckBox.UseVisualStyleBackColor = true;
			// 
			// Chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.Chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.Chart1.Legends.Add(legend1);
			this.Chart1.Location = new System.Drawing.Point(665, 192);
			this.Chart1.Name = "Chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.Chart1.Series.Add(series1);
			this.Chart1.Size = new System.Drawing.Size(1073, 480);
			this.Chart1.TabIndex = 17;
			this.Chart1.Text = "chart1";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(12, 192);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(575, 552);
			this.textBox1.TabIndex = 2;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.CtgCheckBox);
			this.Controls.Add(this.TgCheckBox);
			this.Controls.Add(this.CosCheckBox);
			this.Controls.Add(this.SinCheckBox);
			this.Controls.Add(this.Chart1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.AngleTextBox);
			this.Controls.Add(this.RadiansRadioButton);
			this.Controls.Add(this.DegreesRadioButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton DegreesRadioButton;
        private System.Windows.Forms.RadioButton RadiansRadioButton;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox SinCheckBox;
		private System.Windows.Forms.CheckBox CosCheckBox;
		private System.Windows.Forms.CheckBox TgCheckBox;
		private System.Windows.Forms.CheckBox CtgCheckBox;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

