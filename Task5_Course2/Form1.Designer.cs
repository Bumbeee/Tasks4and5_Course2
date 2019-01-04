namespace Task5_Course2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.начатьГонкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьГонкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавить4УчастниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьУчастниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьРазмерТрассыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьГонкуToolStripMenuItem,
            this.остановитьГонкуToolStripMenuItem,
            this.добавить4УчастниковToolStripMenuItem,
            this.очиститьУчастниковToolStripMenuItem,
            this.изменитьРазмерТрассыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // начатьГонкуToolStripMenuItem
            // 
            this.начатьГонкуToolStripMenuItem.Name = "начатьГонкуToolStripMenuItem";
            this.начатьГонкуToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.начатьГонкуToolStripMenuItem.Text = "Начать гонку";
            this.начатьГонкуToolStripMenuItem.Click += new System.EventHandler(this.начатьГонкуToolStripMenuItem_Click);
            // 
            // остановитьГонкуToolStripMenuItem
            // 
            this.остановитьГонкуToolStripMenuItem.Name = "остановитьГонкуToolStripMenuItem";
            this.остановитьГонкуToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.остановитьГонкуToolStripMenuItem.Text = "Остановить гонку";
            this.остановитьГонкуToolStripMenuItem.Click += new System.EventHandler(this.остановитьГонкуToolStripMenuItem_Click);
            // 
            // добавить4УчастниковToolStripMenuItem
            // 
            this.добавить4УчастниковToolStripMenuItem.Name = "добавить4УчастниковToolStripMenuItem";
            this.добавить4УчастниковToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.добавить4УчастниковToolStripMenuItem.Text = "Добавить 4 участников";
            this.добавить4УчастниковToolStripMenuItem.Click += new System.EventHandler(this.добавить4УчастниковToolStripMenuItem_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 398);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem начатьГонкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьГонкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавить4УчастниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьУчастниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьРазмерТрассыToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

