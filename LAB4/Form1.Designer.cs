using System.Windows.Forms.DataVisualization.Charting;

namespace OlympiadSorting
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Function = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonClear = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Bubble = new System.Windows.Forms.CheckBox();
            this.Insert = new System.Windows.Forms.CheckBox();
            this.Shaker = new System.Windows.Forms.CheckBox();
            this.Rapid = new System.Windows.Forms.CheckBox();
            this.Bogo = new System.Windows.Forms.CheckBox();
            this.TableData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChartBubble = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReversCheck = new System.Windows.Forms.CheckBox();
            this.BubbleTimer = new System.Windows.Forms.Label();
            this.InsertTimer = new System.Windows.Forms.Label();
            this.ShakerTimer = new System.Windows.Forms.Label();
            this.RapidTimer = new System.Windows.Forms.Label();
            this.BogoTimer = new System.Windows.Forms.Label();
            this.ChartInsert = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartShaker = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartRapid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartBogo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonRandom = new System.Windows.Forms.Button();
            this.CountData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartShaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartRapid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Function
            // 
            this.Function.AutoSize = true;
            this.Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function.Location = new System.Drawing.Point(440, 382);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(0, 18);
            this.Function.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ButtonClear});
            this.menuStrip1.Location = new System.Drawing.Point(0, 409);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1268, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 24);
            this.toolStripMenuItem1.Text = "Сортировать";
            this.toolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(87, 24);
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Программирование\r\nЛабораторная работа 4";
            // 
            // Bubble
            // 
            this.Bubble.AutoSize = true;
            this.Bubble.Location = new System.Drawing.Point(308, 7);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(117, 20);
            this.Bubble.TabIndex = 31;
            this.Bubble.Text = "Пузырьковая";
            this.Bubble.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.Location = new System.Drawing.Point(308, 208);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(100, 20);
            this.Insert.TabIndex = 32;
            this.Insert.Text = "Вставками";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Shaker
            // 
            this.Shaker.AutoSize = true;
            this.Shaker.Location = new System.Drawing.Point(635, 6);
            this.Shaker.Name = "Shaker";
            this.Shaker.Size = new System.Drawing.Size(102, 20);
            this.Shaker.TabIndex = 33;
            this.Shaker.Text = "Шейкерная";
            this.Shaker.UseVisualStyleBackColor = true;
            // 
            // Rapid
            // 
            this.Rapid.AutoSize = true;
            this.Rapid.Location = new System.Drawing.Point(635, 208);
            this.Rapid.Name = "Rapid";
            this.Rapid.Size = new System.Drawing.Size(84, 20);
            this.Rapid.TabIndex = 34;
            this.Rapid.Text = "Быстрая";
            this.Rapid.UseVisualStyleBackColor = true;
            // 
            // Bogo
            // 
            this.Bogo.AutoSize = true;
            this.Bogo.Location = new System.Drawing.Point(956, 97);
            this.Bogo.Name = "Bogo";
            this.Bogo.Size = new System.Drawing.Size(68, 20);
            this.Bogo.TabIndex = 35;
            this.Bogo.Text = "BOGO";
            this.Bogo.UseVisualStyleBackColor = true;
            // 
            // TableData
            // 
            this.TableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.TableData.Location = new System.Drawing.Point(15, 54);
            this.TableData.Name = "TableData";
            this.TableData.RowHeadersWidth = 51;
            this.TableData.RowTemplate.Height = 24;
            this.TableData.Size = new System.Drawing.Size(165, 246);
            this.TableData.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Данные";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // ChartBubble
            // 
            this.ChartBubble.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.Name = "ChartArea1";
            this.ChartBubble.ChartAreas.Add(chartArea6);
            this.ChartBubble.Location = new System.Drawing.Point(308, 28);
            this.ChartBubble.Name = "ChartBubble";
            this.ChartBubble.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Name = "Series1";
            series6.YValuesPerPoint = 4;
            this.ChartBubble.Series.Add(series6);
            this.ChartBubble.Size = new System.Drawing.Size(289, 170);
            this.ChartBubble.TabIndex = 0;
            this.ChartBubble.Text = "chart1";
            // 
            // ReversCheck
            // 
            this.ReversCheck.AutoSize = true;
            this.ReversCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReversCheck.Location = new System.Drawing.Point(199, 54);
            this.ReversCheck.Name = "ReversCheck";
            this.ReversCheck.Size = new System.Drawing.Size(64, 42);
            this.ReversCheck.TabIndex = 38;
            this.ReversCheck.Text = "⇅";
            this.ReversCheck.UseVisualStyleBackColor = true;
            // 
            // BubbleTimer
            // 
            this.BubbleTimer.AutoSize = true;
            this.BubbleTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BubbleTimer.Location = new System.Drawing.Point(431, 8);
            this.BubbleTimer.Name = "BubbleTimer";
            this.BubbleTimer.Size = new System.Drawing.Size(0, 16);
            this.BubbleTimer.TabIndex = 41;
            // 
            // InsertTimer
            // 
            this.InsertTimer.AutoSize = true;
            this.InsertTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertTimer.Location = new System.Drawing.Point(431, 208);
            this.InsertTimer.Name = "InsertTimer";
            this.InsertTimer.Size = new System.Drawing.Size(0, 16);
            this.InsertTimer.TabIndex = 42;
            // 
            // ShakerTimer
            // 
            this.ShakerTimer.AutoSize = true;
            this.ShakerTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShakerTimer.Location = new System.Drawing.Point(758, 6);
            this.ShakerTimer.Name = "ShakerTimer";
            this.ShakerTimer.Size = new System.Drawing.Size(0, 16);
            this.ShakerTimer.TabIndex = 43;
            // 
            // RapidTimer
            // 
            this.RapidTimer.AutoSize = true;
            this.RapidTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RapidTimer.Location = new System.Drawing.Point(758, 208);
            this.RapidTimer.Name = "RapidTimer";
            this.RapidTimer.Size = new System.Drawing.Size(0, 16);
            this.RapidTimer.TabIndex = 44;
            // 
            // BogoTimer
            // 
            this.BogoTimer.AutoSize = true;
            this.BogoTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BogoTimer.Location = new System.Drawing.Point(1079, 97);
            this.BogoTimer.Name = "BogoTimer";
            this.BogoTimer.Size = new System.Drawing.Size(0, 16);
            this.BogoTimer.TabIndex = 45;
            // 
            // ChartInsert
            // 
            chartArea7.Name = "ChartArea1";
            this.ChartInsert.ChartAreas.Add(chartArea7);
            this.ChartInsert.Location = new System.Drawing.Point(308, 234);
            this.ChartInsert.Name = "ChartInsert";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series7.Name = "Series1";
            series7.YValuesPerPoint = 4;
            this.ChartInsert.Series.Add(series7);
            this.ChartInsert.Size = new System.Drawing.Size(289, 170);
            this.ChartInsert.TabIndex = 46;
            this.ChartInsert.Text = "chart1";
            // 
            // ChartShaker
            // 
            chartArea8.Name = "ChartArea1";
            this.ChartShaker.ChartAreas.Add(chartArea8);
            this.ChartShaker.Location = new System.Drawing.Point(635, 28);
            this.ChartShaker.Name = "ChartShaker";
            this.ChartShaker.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series8.Name = "Series1";
            series8.YValuesPerPoint = 4;
            this.ChartShaker.Series.Add(series8);
            this.ChartShaker.Size = new System.Drawing.Size(289, 170);
            this.ChartShaker.TabIndex = 47;
            this.ChartShaker.Text = "chart2";
            // 
            // ChartRapid
            // 
            chartArea9.Name = "ChartArea1";
            this.ChartRapid.ChartAreas.Add(chartArea9);
            this.ChartRapid.Location = new System.Drawing.Point(635, 234);
            this.ChartRapid.Name = "ChartRapid";
            this.ChartRapid.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series9.Name = "Series1";
            series9.YValuesPerPoint = 4;
            this.ChartRapid.Series.Add(series9);
            this.ChartRapid.Size = new System.Drawing.Size(289, 170);
            this.ChartRapid.TabIndex = 48;
            this.ChartRapid.Text = "chart3";
            // 
            // ChartBogo
            // 
            chartArea10.Name = "ChartArea1";
            this.ChartBogo.ChartAreas.Add(chartArea10);
            this.ChartBogo.Location = new System.Drawing.Point(956, 123);
            this.ChartBogo.Name = "ChartBogo";
            this.ChartBogo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series10.Name = "Series1";
            series10.YValuesPerPoint = 4;
            this.ChartBogo.Series.Add(series10);
            this.ChartBogo.Size = new System.Drawing.Size(289, 170);
            this.ChartBogo.TabIndex = 49;
            this.ChartBogo.Text = "chart4";
            // 
            // ButtonRandom
            // 
            this.ButtonRandom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRandom.Location = new System.Drawing.Point(186, 346);
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Size = new System.Drawing.Size(116, 23);
            this.ButtonRandom.TabIndex = 50;
            this.ButtonRandom.Text = "Сгенерировать";
            this.ButtonRandom.UseVisualStyleBackColor = false;
            this.ButtonRandom.Click += new System.EventHandler(this.Random_Click);
            // 
            // CountData
            // 
            this.CountData.Location = new System.Drawing.Point(170, 318);
            this.CountData.Name = "CountData";
            this.CountData.Size = new System.Drawing.Size(132, 22);
            this.CountData.TabIndex = 51;
            this.CountData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountData_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Количество данных:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountData);
            this.Controls.Add(this.ButtonRandom);
            this.Controls.Add(this.ChartBogo);
            this.Controls.Add(this.ChartRapid);
            this.Controls.Add(this.ChartShaker);
            this.Controls.Add(this.ChartInsert);
            this.Controls.Add(this.BogoTimer);
            this.Controls.Add(this.RapidTimer);
            this.Controls.Add(this.ShakerTimer);
            this.Controls.Add(this.InsertTimer);
            this.Controls.Add(this.BubbleTimer);
            this.Controls.Add(this.ReversCheck);
            this.Controls.Add(this.ChartBubble);
            this.Controls.Add(this.TableData);
            this.Controls.Add(this.Bogo);
            this.Controls.Add(this.Rapid);
            this.Controls.Add(this.Shaker);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Межецкая Юлия, ПИ-211";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartShaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartRapid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Function;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ButtonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Bubble;
        private System.Windows.Forms.CheckBox Insert;
        private System.Windows.Forms.CheckBox Shaker;
        private System.Windows.Forms.CheckBox Rapid;
        private System.Windows.Forms.CheckBox Bogo;
        private System.Windows.Forms.DataGridView TableData;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBubble;
        private System.Windows.Forms.CheckBox ReversCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label BubbleTimer;
        private System.Windows.Forms.Label InsertTimer;
        private System.Windows.Forms.Label ShakerTimer;
        private System.Windows.Forms.Label RapidTimer;
        private System.Windows.Forms.Label BogoTimer;
        private Chart ChartInsert;
        private Chart ChartShaker;
        private Chart ChartRapid;
        private Chart ChartBogo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button ButtonRandom;
        private System.Windows.Forms.TextBox CountData;
        private System.Windows.Forms.Label label3;
    }
}

