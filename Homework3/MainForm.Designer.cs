namespace Homework3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.iFrqDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_data_fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_settings_asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsStripButton = new System.Windows.Forms.ToolStripButton();
            this.open_settings_fileToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.save_settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.save_settings_asStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.open_settings_fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.iFrqDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iFrqDataBindingSource, "Data", true));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 73);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(92, 529);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // iFrqDataBindingSource
            // 
            this.iFrqDataBindingSource.DataSource = typeof(Homework3.Model.IFrqData);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номера позиций";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "Area";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(114, 73);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(677, 327);
            this.chart1.TabIndex = 2;
            this.chart1.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 70;
            this.dataGridView1.Size = new System.Drawing.Size(677, 184);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_data_fileToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // open_data_fileToolStripMenuItem
            // 
            this.open_data_fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("open_data_fileToolStripMenuItem.Image")));
            this.open_data_fileToolStripMenuItem.Name = "open_data_fileToolStripMenuItem";
            this.open_data_fileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.open_data_fileToolStripMenuItem.Text = "Открыть";
            this.open_data_fileToolStripMenuItem.Click += new System.EventHandler(this.open_data_fileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_settingsToolStripMenuItem,
            this.open_settings_fileToolStripMenuItem,
            this.save_settingsToolStripMenuItem,
            this.save_settings_asToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // open_settingsToolStripMenuItem
            // 
            this.open_settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("open_settingsToolStripMenuItem.Image")));
            this.open_settingsToolStripMenuItem.Name = "open_settingsToolStripMenuItem";
            this.open_settingsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.open_settingsToolStripMenuItem.Text = "Открыть настройки";
            this.open_settingsToolStripMenuItem.Click += new System.EventHandler(this.open_settingsToolStripMenuItem_Click);
            // 
            // save_settingsToolStripMenuItem
            // 
            this.save_settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("save_settingsToolStripMenuItem.Image")));
            this.save_settingsToolStripMenuItem.Name = "save_settingsToolStripMenuItem";
            this.save_settingsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.save_settingsToolStripMenuItem.Text = "Сохранить настройки";
            this.save_settingsToolStripMenuItem.Click += new System.EventHandler(this.save_settingsToolStripMenuItem_Click);
            // 
            // save_settings_asToolStripMenuItem
            // 
            this.save_settings_asToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("save_settings_asToolStripMenuItem.Image")));
            this.save_settings_asToolStripMenuItem.Name = "save_settings_asToolStripMenuItem";
            this.save_settings_asToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.save_settings_asToolStripMenuItem.Text = "Сохранить настройки как";
            this.save_settings_asToolStripMenuItem.Click += new System.EventHandler(this.save_settings_asToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.toolStripSeparator1,
            this.settingsStripButton,
            this.open_settings_fileToolStripButton1,
            this.save_settingsToolStripButton,
            this.save_settings_asStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(803, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Открыть";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // settingsStripButton
            // 
            this.settingsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsStripButton.Image")));
            this.settingsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsStripButton.Name = "settingsStripButton";
            this.settingsStripButton.Size = new System.Drawing.Size(23, 22);
            this.settingsStripButton.Text = "Настройки";
            this.settingsStripButton.Click += new System.EventHandler(this.settingsStripButton_Click);
            // 
            // open_settings_fileToolStripButton1
            // 
            this.open_settings_fileToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open_settings_fileToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("open_settings_fileToolStripButton1.Image")));
            this.open_settings_fileToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open_settings_fileToolStripButton1.Name = "open_settings_fileToolStripButton1";
            this.open_settings_fileToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.open_settings_fileToolStripButton1.Text = "Открыть файл с настройками";
            this.open_settings_fileToolStripButton1.Click += new System.EventHandler(this.open_settings_fileStripButton1_Click);
            // 
            // save_settingsToolStripButton
            // 
            this.save_settingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_settingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("save_settingsToolStripButton.Image")));
            this.save_settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_settingsToolStripButton.Name = "save_settingsToolStripButton";
            this.save_settingsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.save_settingsToolStripButton.Text = "&Сохранить настройки";
            this.save_settingsToolStripButton.Click += new System.EventHandler(this.save_settingsToolStripButton_Click);
            // 
            // save_settings_asStripButton2
            // 
            this.save_settings_asStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_settings_asStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("save_settings_asStripButton2.Image")));
            this.save_settings_asStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_settings_asStripButton2.Name = "save_settings_asStripButton2";
            this.save_settings_asStripButton2.Size = new System.Drawing.Size(23, 22);
            this.save_settings_asStripButton2.Text = "Сохранить нстройки как";
            this.save_settings_asStripButton2.Click += new System.EventHandler(this.save_settings_asButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы результатов графематического анализа(*.frq)|*.frq";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Файлы настроек программы(*.hw3s)|*.hw3s";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Файлы настроек программы(*.hw3s)|*.hw3s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Диаграмма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Таблица";
            // 
            // open_settings_fileToolStripMenuItem
            // 
            this.open_settings_fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("open_settings_fileToolStripMenuItem.Image")));
            this.open_settings_fileToolStripMenuItem.Name = "open_settings_fileToolStripMenuItem";
            this.open_settings_fileToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.open_settings_fileToolStripMenuItem.Text = "Открыть файл с настройками";
            this.open_settings_fileToolStripMenuItem.Click += new System.EventHandler(this.open_settings_fileToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(819, 654);
            this.Name = "MainForm";
            this.Text = "Результаты графематического анализа";
            ((System.ComponentModel.ISupportInitialize)(this.iFrqDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.BindingSource iFrqDataBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton settingsStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_data_fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton save_settingsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton open_settings_fileToolStripButton1;
        private System.Windows.Forms.ToolStripButton save_settings_asStripButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem save_settings_asToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem open_settings_fileToolStripMenuItem;
    }
}

