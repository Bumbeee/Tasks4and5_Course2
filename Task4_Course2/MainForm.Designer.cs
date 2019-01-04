namespace Task4_Course2
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
            this.новаяГонкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьГонкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавить4УчастникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьУчастниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьРазмерТрассыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // новаяГонкаToolStripMenuItem
            // 
            this.новаяГонкаToolStripMenuItem.Name = "новаяГонкаToolStripMenuItem";
            this.новаяГонкаToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.новаяГонкаToolStripMenuItem.Text = "Новая гонка";
            this.новаяГонкаToolStripMenuItem.Click += new System.EventHandler(this.новаяГонкаToolStripMenuItem_Click);
            // 
            // остановитьГонкуToolStripMenuItem
            // 
            this.остановитьГонкуToolStripMenuItem.Name = "остановитьГонкуToolStripMenuItem";
            this.остановитьГонкуToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.остановитьГонкуToolStripMenuItem.Text = "Остановить гонку";
            this.остановитьГонкуToolStripMenuItem.Click += new System.EventHandler(this.остановитьГонкуToolStripMenuItem_Click);
            // 
            // добавить4УчастникаToolStripMenuItem
            // 
            this.добавить4УчастникаToolStripMenuItem.Name = "добавить4УчастникаToolStripMenuItem";
            this.добавить4УчастникаToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.добавить4УчастникаToolStripMenuItem.Text = "Добавить 4 участника";
            this.добавить4УчастникаToolStripMenuItem.Click += new System.EventHandler(this.добавить4УчастникаToolStripMenuItem_Click);
            // 
            // очиститьУчастниковToolStripMenuItem
            // 
            this.очиститьУчастниковToolStripMenuItem.Name = "очиститьУчастниковToolStripMenuItem";
            this.очиститьУчастниковToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.очиститьУчастниковToolStripMenuItem.Text = "Очистить участников";
            this.очиститьУчастниковToolStripMenuItem.Click += new System.EventHandler(this.очиститьУчастниковToolStripMenuItem_Click);
            // 
            // изменитьРазмерТрассыToolStripMenuItem
            // 
            this.изменитьРазмерТрассыToolStripMenuItem.Name = "изменитьРазмерТрассыToolStripMenuItem";
            this.изменитьРазмерТрассыToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.изменитьРазмерТрассыToolStripMenuItem.Text = "Изменить размер трассы";
            this.изменитьРазмерТрассыToolStripMenuItem.Click += new System.EventHandler(this.изменитьРазмерТрассыToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяГонкаToolStripMenuItem,
            this.остановитьГонкуToolStripMenuItem,
            this.добавить4УчастникаToolStripMenuItem,
            this.очиститьУчастниковToolStripMenuItem,
            this.изменитьРазмерТрассыToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(894, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 487);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Гонки";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem новаяГонкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьГонкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавить4УчастникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьУчастниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьРазмерТрассыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Timer timer1;
    }
}

