namespace waz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAUZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oDNOWAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sZYBKOŚĆToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wOLNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sZYBKOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pole_gry = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.pAUZAToolStripMenuItem,
            this.oDNOWAToolStripMenuItem,
            this.sZYBKOŚĆToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // pAUZAToolStripMenuItem
            // 
            this.pAUZAToolStripMenuItem.Name = "pAUZAToolStripMenuItem";
            this.pAUZAToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.pAUZAToolStripMenuItem.Text = "PAUZA";
            this.pAUZAToolStripMenuItem.Click += new System.EventHandler(this.pAUZAToolStripMenuItem_Click);
            // 
            // oDNOWAToolStripMenuItem
            // 
            this.oDNOWAToolStripMenuItem.Name = "oDNOWAToolStripMenuItem";
            this.oDNOWAToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.oDNOWAToolStripMenuItem.Text = "OD NOWA";
            this.oDNOWAToolStripMenuItem.Click += new System.EventHandler(this.oDNOWAToolStripMenuItem_Click);
            // 
            // sZYBKOŚĆToolStripMenuItem
            // 
            this.sZYBKOŚĆToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wOLNOToolStripMenuItem,
            this.sZYBKOToolStripMenuItem});
            this.sZYBKOŚĆToolStripMenuItem.Name = "sZYBKOŚĆToolStripMenuItem";
            this.sZYBKOŚĆToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.sZYBKOŚĆToolStripMenuItem.Text = "SZYBKOŚĆ";
            // 
            // wOLNOToolStripMenuItem
            // 
            this.wOLNOToolStripMenuItem.Name = "wOLNOToolStripMenuItem";
            this.wOLNOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wOLNOToolStripMenuItem.Text = "WOLNO";
            this.wOLNOToolStripMenuItem.Click += new System.EventHandler(this.wOLNOToolStripMenuItem_Click);
            // 
            // sZYBKOToolStripMenuItem
            // 
            this.sZYBKOToolStripMenuItem.Name = "sZYBKOToolStripMenuItem";
            this.sZYBKOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sZYBKOToolStripMenuItem.Text = "SZYBKO";
            this.sZYBKOToolStripMenuItem.Click += new System.EventHandler(this.sZYBKOToolStripMenuItem_Click);
            // 
            // pole_gry
            // 
            this.pole_gry.BackColor = System.Drawing.Color.Black;
            this.pole_gry.Location = new System.Drawing.Point(0, 31);
            this.pole_gry.Name = "pole_gry";
            this.pole_gry.Size = new System.Drawing.Size(414, 409);
            this.pole_gry.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 440);
            this.Controls.Add(this.pole_gry);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAUZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oDNOWAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sZYBKOŚĆToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wOLNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sZYBKOToolStripMenuItem;
        private System.Windows.Forms.Panel pole_gry;
        private System.Windows.Forms.Timer timer1;
    }
}

