namespace LeastSquareMethod
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GridTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonClear = new System.Windows.Forms.ToolStripMenuItem();
            this.Function = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridTable
            // 
            this.GridTable.BackgroundColor = System.Drawing.Color.MistyRose;
            this.GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.GridTable.Location = new System.Drawing.Point(538, 127);
            this.GridTable.Name = "GridTable";
            this.GridTable.RowHeadersWidth = 51;
            this.GridTable.RowTemplate.Height = 24;
            this.GridTable.Size = new System.Drawing.Size(250, 254);
            this.GridTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(535, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программирование\r\nЛабораторная работа 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Используя метод наименьших \r\nквадратов на множестве точек, \r\nнайти коэффициенты ф" +
    "ункции f(x).";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ButtonSearch,
            this.ButtonClear});
            this.menuStrip1.Location = new System.Drawing.Point(0, 422);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 24);
            this.toolStripMenuItem1.Text = "Квадратичная";
            this.toolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.QuadraticCalculate);
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
            this.ButtonSearch.Size = new System.Drawing.Size(93, 24);
            this.ButtonSearch.Text = "Линейная";
            this.ButtonSearch.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ButtonSearch.Click += new System.EventHandler(this.CalculateButton);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(87, 24);
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Function
            // 
            this.Function.AutoSize = true;
            this.Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function.Location = new System.Drawing.Point(535, 395);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(0, 18);
            this.Function.TabIndex = 25;
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(12, 22);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(486, 391);
            this.plotView1.TabIndex = 26;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "x";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "y";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Межецкая Юлия, ПИ-211";
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DataGridView GridTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ButtonSearch;
		private System.Windows.Forms.ToolStripMenuItem ButtonClear;
		private System.Windows.Forms.Label Function;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

