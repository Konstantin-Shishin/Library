
namespace WindowsFormsLibr
{
    partial class mainform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.обАвтореToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.авторыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.книгиToolStripMenuItem.Text = "Книги";
            this.книгиToolStripMenuItem.Click += new System.EventHandler(this.книгиToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьКнигуToolStripMenuItem,
            this.выдатьКнигуToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // получитьКнигуToolStripMenuItem
            // 
            this.получитьКнигуToolStripMenuItem.Name = "получитьКнигуToolStripMenuItem";
            this.получитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.получитьКнигуToolStripMenuItem.Text = "Получить книгу";
            this.получитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.получитьКнигуToolStripMenuItem_Click);
            // 
            // выдатьКнигуToolStripMenuItem
            // 
            this.выдатьКнигуToolStripMenuItem.Name = "выдатьКнигуToolStripMenuItem";
            this.выдатьКнигуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выдатьКнигуToolStripMenuItem.Text = "Выдать книгу";
            this.выдатьКнигуToolStripMenuItem.Click += new System.EventHandler(this.выдатьКнигуToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдатьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

