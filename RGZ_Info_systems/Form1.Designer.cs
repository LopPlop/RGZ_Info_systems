namespace RGZ_Info_systems
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСотрудникахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прошлиВЭтомМесяцеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должныПройтиВЭтомГодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоПоПройденымКурсамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Изменить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1221, 300);
            this.dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инфоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оСотрудникахToolStripMenuItem});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.инфоToolStripMenuItem.Text = "Справка";
            // 
            // оСотрудникахToolStripMenuItem
            // 
            this.оСотрудникахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прошлиВЭтомМесяцеToolStripMenuItem,
            this.должныПройтиВЭтомГодуToolStripMenuItem,
            this.инфоПоПройденымКурсамToolStripMenuItem});
            this.оСотрудникахToolStripMenuItem.Name = "оСотрудникахToolStripMenuItem";
            this.оСотрудникахToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оСотрудникахToolStripMenuItem.Text = "О сотрудниках";
            // 
            // прошлиВЭтомМесяцеToolStripMenuItem
            // 
            this.прошлиВЭтомМесяцеToolStripMenuItem.Name = "прошлиВЭтомМесяцеToolStripMenuItem";
            this.прошлиВЭтомМесяцеToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.прошлиВЭтомМесяцеToolStripMenuItem.Text = "Прошли в этом месяце";
            this.прошлиВЭтомМесяцеToolStripMenuItem.Click += new System.EventHandler(this.прошлиВЭтомМесяцеToolStripMenuItem_Click);
            // 
            // должныПройтиВЭтомГодуToolStripMenuItem
            // 
            this.должныПройтиВЭтомГодуToolStripMenuItem.Name = "должныПройтиВЭтомГодуToolStripMenuItem";
            this.должныПройтиВЭтомГодуToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.должныПройтиВЭтомГодуToolStripMenuItem.Text = "Должны пройти в этом году";
            this.должныПройтиВЭтомГодуToolStripMenuItem.Click += new System.EventHandler(this.должныПройтиВЭтомГодуToolStripMenuItem_Click);
            // 
            // инфоПоПройденымКурсамToolStripMenuItem
            // 
            this.инфоПоПройденымКурсамToolStripMenuItem.Name = "инфоПоПройденымКурсамToolStripMenuItem";
            this.инфоПоПройденымКурсамToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.инфоПоПройденымКурсамToolStripMenuItem.Text = "Инфо по пройденым курсам";
            this.инфоПоПройденымКурсамToolStripMenuItem.Click += new System.EventHandler(this.инфоПоПройденымКурсамToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Курсы",
            "Сотрудники",
            "Сведения о прохождении курсов"});
            this.comboBox1.Location = new System.Drawing.Point(1008, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Курсы";
            this.comboBox1.ValueMember = "0";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 471);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСотрудникахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прошлиВЭтомМесяцеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должныПройтиВЭтомГодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфоПоПройденымКурсамToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

