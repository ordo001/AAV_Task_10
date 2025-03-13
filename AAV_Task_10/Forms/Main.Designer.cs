namespace AAV_Task_10
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать на аукцион";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокТоваровToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.авторизоватьсяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокТоваровToolStripMenuItem
            // 
            this.списокТоваровToolStripMenuItem.Name = "списокТоваровToolStripMenuItem";
            this.списокТоваровToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.списокТоваровToolStripMenuItem.Text = "Список товаров";
            this.списокТоваровToolStripMenuItem.Click += new System.EventHandler(this.списокТоваровToolStripMenuItem_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.продажиToolStripMenuItem.Text = "Продажи";
            // 
            // авторизоватьсяToolStripMenuItem
            // 
            this.авторизоватьсяToolStripMenuItem.Name = "авторизоватьсяToolStripMenuItem";
            this.авторизоватьсяToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.авторизоватьсяToolStripMenuItem.Text = "Авторизоваться";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem списокТоваровToolStripMenuItem;
        private ToolStripMenuItem продажиToolStripMenuItem;
        private ToolStripMenuItem авторизоватьсяToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}