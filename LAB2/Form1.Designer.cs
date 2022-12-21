namespace GoldenSectionMethod
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AccuracyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndBBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StartABox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FunctionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonClear = new System.Windows.Forms.ToolStripMenuItem();
            this.Backward = new System.Windows.Forms.ToolStripMenuItem();
            this.Forward = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ResultLabel.Location = new System.Drawing.Point(19, 341);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultLabel.TabIndex = 24;
            // 
            // AccuracyBox
            // 
            this.AccuracyBox.Location = new System.Drawing.Point(75, 292);
            this.AccuracyBox.Name = "AccuracyBox";
            this.AccuracyBox.Size = new System.Drawing.Size(100, 22);
            this.AccuracyBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "e:";
            // 
            // EndBBox
            // 
            this.EndBBox.Location = new System.Drawing.Point(75, 249);
            this.EndBBox.Name = "EndBBox";
            this.EndBBox.Size = new System.Drawing.Size(100, 22);
            this.EndBBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "b:";
            // 
            // StartABox
            // 
            this.StartABox.Location = new System.Drawing.Point(75, 204);
            this.StartABox.Name = "StartABox";
            this.StartABox.Size = new System.Drawing.Size(100, 22);
            this.StartABox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "a:";
            // 
            // FunctionBox
            // 
            this.FunctionBox.Location = new System.Drawing.Point(75, 163);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(197, 22);
            this.FunctionBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "f(x):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 60);
            this.label2.TabIndex = 14;
            this.label2.Text = "Используя метод золотого сечения (Ньютона) \r\nнайти локальный минимум заданной\r\nто" +
    "чности e функции f(x) на интервале [a, b].\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Программирование\r\nЛабораторная работа 2";
            // 
            // Grafik
            // 
            chartArea2.Name = "ChartArea1";
            this.Grafik.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend1";
            this.Grafik.Legends.Add(legend2);
            this.Grafik.Location = new System.Drawing.Point(362, 14);
            this.Grafik.Name = "Grafik";
            this.Grafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.Grafik.Series.Add(series3);
            this.Grafik.Series.Add(series4);
            this.Grafik.Size = new System.Drawing.Size(426, 394);
            this.Grafik.TabIndex = 25;
            this.Grafik.Text = "chart1";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.Maroon;
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.ShowShortcutKeys = false;
            this.ButtonSearch.Size = new System.Drawing.Size(100, 35);
            this.ButtonSearch.Text = "Рассчитать";
            this.ButtonSearch.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(87, 35);
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Backward
            // 
            this.Backward.BackColor = System.Drawing.Color.MistyRose;
            this.Backward.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Backward.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(48, 35);
            this.Backward.Text = "↶";
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.MistyRose;
            this.Forward.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(48, 35);
            this.Forward.Text = "↷";
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSearch,
            this.ButtonClear,
            this.Backward,
            this.Forward});
            this.menuStrip1.Location = new System.Drawing.Point(0, 411);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grafik);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.AccuracyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EndBBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartABox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FunctionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Межецкая Юлия, ПИ-211";
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox AccuracyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndBBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartABox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FunctionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafik;
        private System.Windows.Forms.ToolStripMenuItem ButtonSearch;
        private System.Windows.Forms.ToolStripMenuItem ButtonClear;
        private System.Windows.Forms.ToolStripMenuItem Backward;
        private System.Windows.Forms.ToolStripMenuItem Forward;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

