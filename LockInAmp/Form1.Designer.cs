namespace LockInAmp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FrequencySlider1 = new System.Windows.Forms.TrackBar();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.FrequencySlider2 = new System.Windows.Forms.TrackBar();
            this.frequency_num1 = new System.Windows.Forms.NumericUpDown();
            this.frequency_num2 = new System.Windows.Forms.NumericUpDown();
            this.phaseshift_slider = new System.Windows.Forms.TrackBar();
            this.phaseshift_num = new System.Windows.Forms.NumericUpDown();
            this.output_plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plot_left = new System.Windows.Forms.CheckBox();
            this.plot_right = new System.Windows.Forms.CheckBox();
            this.plot_input = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.frequency_label2 = new System.Windows.Forms.Label();
            this.frequency_label1 = new System.Windows.Forms.Label();
            this.phaseshift_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencySlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencySlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency_num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency_num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseshift_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseshift_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_plot)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrequencySlider1
            // 
            this.FrequencySlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrequencySlider1.Location = new System.Drawing.Point(136, 3);
            this.FrequencySlider1.Maximum = 20000;
            this.FrequencySlider1.Name = "FrequencySlider1";
            this.FrequencySlider1.Size = new System.Drawing.Size(407, 67);
            this.FrequencySlider1.SmallChange = 10;
            this.FrequencySlider1.TabIndex = 1;
            this.FrequencySlider1.TickFrequency = 1000;
            this.FrequencySlider1.ValueChanged += new System.EventHandler(this.FrequencySlider1_ValueChanged);
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.Start.Location = new System.Drawing.Point(768, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(88, 32);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start Signal";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartButton);
            // 
            // Stop
            // 
            this.Stop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stop.Location = new System.Drawing.Point(768, 76);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(88, 32);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop Signal";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StopButton);
            // 
            // FrequencySlider2
            // 
            this.FrequencySlider2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrequencySlider2.Location = new System.Drawing.Point(136, 76);
            this.FrequencySlider2.Maximum = 20000;
            this.FrequencySlider2.Name = "FrequencySlider2";
            this.FrequencySlider2.Size = new System.Drawing.Size(407, 67);
            this.FrequencySlider2.SmallChange = 10;
            this.FrequencySlider2.TabIndex = 7;
            this.FrequencySlider2.TickFrequency = 1000;
            this.FrequencySlider2.ValueChanged += new System.EventHandler(this.FrequencySlider2_ValueChanged);
            // 
            // frequency_num1
            // 
            this.frequency_num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequency_num1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.frequency_num1.Location = new System.Drawing.Point(549, 3);
            this.frequency_num1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.frequency_num1.Name = "frequency_num1";
            this.frequency_num1.Size = new System.Drawing.Size(105, 20);
            this.frequency_num1.TabIndex = 10;
            this.frequency_num1.ThousandsSeparator = true;
            this.frequency_num1.ValueChanged += new System.EventHandler(this.frequency_num1_ValueChanged);
            this.frequency_num1.Leave += new System.EventHandler(this.frequency_num1_ValueChanged);
            // 
            // frequency_num2
            // 
            this.frequency_num2.Dock = System.Windows.Forms.DockStyle.Top;
            this.frequency_num2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.frequency_num2.Location = new System.Drawing.Point(549, 76);
            this.frequency_num2.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.frequency_num2.Name = "frequency_num2";
            this.frequency_num2.Size = new System.Drawing.Size(105, 20);
            this.frequency_num2.TabIndex = 11;
            this.frequency_num2.ThousandsSeparator = true;
            this.frequency_num2.ValueChanged += new System.EventHandler(this.frequency_num2_ValueChanged);
            this.frequency_num2.Leave += new System.EventHandler(this.frequency_num2_ValueChanged);
            // 
            // phaseshift_slider
            // 
            this.phaseshift_slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phaseshift_slider.Location = new System.Drawing.Point(136, 149);
            this.phaseshift_slider.Maximum = 360;
            this.phaseshift_slider.Name = "phaseshift_slider";
            this.phaseshift_slider.Size = new System.Drawing.Size(407, 68);
            this.phaseshift_slider.TabIndex = 12;
            this.phaseshift_slider.TickFrequency = 10;
            this.phaseshift_slider.ValueChanged += new System.EventHandler(this.phaseshift_slider_ValueChanged);
            // 
            // phaseshift_num
            // 
            this.phaseshift_num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phaseshift_num.Location = new System.Drawing.Point(549, 149);
            this.phaseshift_num.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.phaseshift_num.Name = "phaseshift_num";
            this.phaseshift_num.Size = new System.Drawing.Size(105, 20);
            this.phaseshift_num.TabIndex = 13;
            this.phaseshift_num.ThousandsSeparator = true;
            this.phaseshift_num.ValueChanged += new System.EventHandler(this.phaseshift_num_ValueChanged);
            // 
            // output_plot
            // 
            this.output_plot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1000D;
            chartArea1.AxisX.Maximum = 8820D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 20D;
            chartArea1.AxisY.Interval = 0.5D;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = -1D;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.output_plot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.output_plot.Legends.Add(legend1);
            this.output_plot.Location = new System.Drawing.Point(9, 12);
            this.output_plot.Name = "output_plot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Stereo Left";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Stereo Right";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Mic Input";
            this.output_plot.Series.Add(series1);
            this.output_plot.Series.Add(series2);
            this.output_plot.Series.Add(series3);
            this.output_plot.Size = new System.Drawing.Size(859, 213);
            this.output_plot.TabIndex = 15;
            this.output_plot.TabStop = false;
            this.output_plot.Text = "Graph";
            // 
            // plot_left
            // 
            this.plot_left.AutoSize = true;
            this.plot_left.Checked = true;
            this.plot_left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plot_left.Location = new System.Drawing.Point(660, 3);
            this.plot_left.Name = "plot_left";
            this.plot_left.Size = new System.Drawing.Size(99, 17);
            this.plot_left.TabIndex = 16;
            this.plot_left.Text = "Plot Stereo Left";
            this.plot_left.UseVisualStyleBackColor = true;
            this.plot_left.CheckStateChanged += new System.EventHandler(this.plot_left_CheckStateChanged);
            // 
            // plot_right
            // 
            this.plot_right.AutoSize = true;
            this.plot_right.Checked = true;
            this.plot_right.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plot_right.Location = new System.Drawing.Point(660, 76);
            this.plot_right.Name = "plot_right";
            this.plot_right.Size = new System.Drawing.Size(102, 17);
            this.plot_right.TabIndex = 17;
            this.plot_right.Text = "Plot Stereo Right";
            this.plot_right.UseVisualStyleBackColor = true;
            this.plot_right.CheckStateChanged += new System.EventHandler(this.plot_right_CheckStateChanged);
            // 
            // plot_input
            // 
            this.plot_input.AutoSize = true;
            this.plot_input.Checked = true;
            this.plot_input.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plot_input.Location = new System.Drawing.Point(660, 149);
            this.plot_input.Name = "plot_input";
            this.plot_input.Size = new System.Drawing.Size(91, 17);
            this.plot_input.TabIndex = 18;
            this.plot_input.Text = "Plot Mic Input";
            this.plot_input.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(0, 220);
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Controls.Add(this.frequency_label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Stop, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.frequency_label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Start, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.plot_right, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.FrequencySlider1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.plot_left, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FrequencySlider2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.phaseshift_num, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.phaseshift_slider, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.phaseshift_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.frequency_num1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.frequency_num2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.plot_input, 3, 2);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 220);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // frequency_label2
            // 
            this.frequency_label2.AutoSize = true;
            this.frequency_label2.Location = new System.Drawing.Point(3, 0);
            this.frequency_label2.Name = "frequency_label2";
            this.frequency_label2.Size = new System.Drawing.Size(122, 13);
            this.frequency_label2.TabIndex = 8;
            this.frequency_label2.Text = "Stereo Right: Frequency";
            // 
            // frequency_label1
            // 
            this.frequency_label1.AutoSize = true;
            this.frequency_label1.Location = new System.Drawing.Point(3, 146);
            this.frequency_label1.Name = "frequency_label1";
            this.frequency_label1.Size = new System.Drawing.Size(115, 13);
            this.frequency_label1.TabIndex = 2;
            this.frequency_label1.Text = "Stereo Left: Frequency";
            // 
            // phaseshift_label
            // 
            this.phaseshift_label.AutoSize = true;
            this.phaseshift_label.Location = new System.Drawing.Point(3, 73);
            this.phaseshift_label.Name = "phaseshift_label";
            this.phaseshift_label.Size = new System.Drawing.Size(125, 13);
            this.phaseshift_label.TabIndex = 14;
            this.phaseshift_label.Text = "Phase Shift: Right to Left";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.output_plot);
            this.Name = "Form1";
            this.Text = "LockInAmp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FrequencySlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencySlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency_num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency_num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseshift_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseshift_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_plot)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar FrequencySlider1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TrackBar FrequencySlider2;
        private System.Windows.Forms.NumericUpDown frequency_num1;
        private System.Windows.Forms.NumericUpDown frequency_num2;
        private System.Windows.Forms.TrackBar phaseshift_slider;
        private System.Windows.Forms.NumericUpDown phaseshift_num;
        private System.Windows.Forms.DataVisualization.Charting.Chart output_plot;
        private System.Windows.Forms.CheckBox plot_left;
        private System.Windows.Forms.CheckBox plot_right;
        private System.Windows.Forms.CheckBox plot_input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label frequency_label2;
        private System.Windows.Forms.Label frequency_label1;
        private System.Windows.Forms.Label phaseshift_label;
    }
}

