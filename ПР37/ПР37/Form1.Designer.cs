namespace ПР37
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Size = new System.Windows.Forms.ToolStripMenuItem();
            this.SideA = new System.Windows.Forms.ToolStripTextBox();
            this.SideB = new System.Windows.Forms.ToolStripTextBox();
            this.OK = new System.Windows.Forms.ToolStripMenuItem();
            this.Color = new System.Windows.Forms.ToolStripMenuItem();
            this.Paint = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Input = new System.Windows.Forms.ToolStripMenuItem();
            this.Work = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.Menu2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Size,
            this.Color,
            this.Paint,
            this.Quit});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(73, 29);
            this.Menu.Text = "Menu";
            // 
            // Size
            // 
            this.Size.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SideA,
            this.SideB,
            this.OK});
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(157, 34);
            this.Size.Text = "Size";
            this.Size.Click += new System.EventHandler(this.Size_Click);
            // 
            // SideA
            // 
            this.SideA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SideA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(100, 31);
            // 
            // SideB
            // 
            this.SideB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SideB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SideB.Name = "SideB";
            this.SideB.Size = new System.Drawing.Size(100, 31);
            // 
            // OK
            // 
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(190, 34);
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Color
            // 
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(157, 34);
            this.Color.Text = "Color";
            // 
            // Paint
            // 
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(157, 34);
            this.Paint.Text = "Paint";
            this.Paint.Click += new System.EventHandler(this.Paint_Click);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(157, 34);
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Menu2
            // 
            this.Menu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Input,
            this.Work,
            this.QuitMenu});
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(83, 29);
            this.Menu2.Text = "Menu2";
            // 
            // Input
            // 
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(270, 34);
            this.Input.Text = "Input";
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Work
            // 
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(270, 34);
            this.Work.Text = "Work";
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // QuitMenu
            // 
            this.QuitMenu.Name = "QuitMenu";
            this.QuitMenu.Size = new System.Drawing.Size(270, 34);
            this.QuitMenu.Text = "Quit";
            this.QuitMenu.Click += new System.EventHandler(this.QuitMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 44);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 44);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(12, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 44);
            this.textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 407);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Size;
        private System.Windows.Forms.ToolStripMenuItem Color;
        private System.Windows.Forms.ToolStripMenuItem Paint;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripTextBox SideA;
        private System.Windows.Forms.ToolStripTextBox SideB;
        private System.Windows.Forms.ToolStripMenuItem OK;
        private System.Windows.Forms.ToolStripMenuItem Menu2;
        private System.Windows.Forms.ToolStripMenuItem Input;
        private System.Windows.Forms.ToolStripMenuItem Work;
        private System.Windows.Forms.ToolStripMenuItem QuitMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

