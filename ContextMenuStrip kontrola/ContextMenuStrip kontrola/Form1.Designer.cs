
namespace ContextMenuStrip_kontrola
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxLijevo = new System.Windows.Forms.TextBox();
            this.TextBoxDesno = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxLijevo
            // 
            this.TextBoxLijevo.ContextMenuStrip = this.contextMenuStrip1;
            this.TextBoxLijevo.Location = new System.Drawing.Point(60, 47);
            this.TextBoxLijevo.Name = "TextBoxLijevo";
            this.TextBoxLijevo.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLijevo.TabIndex = 0;
            // 
            // TextBoxDesno
            // 
            this.TextBoxDesno.ContextMenuStrip = this.contextMenuStrip1;
            this.TextBoxDesno.Location = new System.Drawing.Point(245, 47);
            this.TextBoxDesno.Name = "TextBoxDesno";
            this.TextBoxDesno.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDesno.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoDesnoToolStripMenuItem,
            this.desnoLijevoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // lijevoDesnoToolStripMenuItem
            // 
            this.lijevoDesnoToolStripMenuItem.Name = "lijevoDesnoToolStripMenuItem";
            this.lijevoDesnoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.lijevoDesnoToolStripMenuItem.Text = "LijevoDesno";
            this.lijevoDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoDesnoToolStripMenuItem_Click);
            // 
            // desnoLijevoToolStripMenuItem
            // 
            this.desnoLijevoToolStripMenuItem.Name = "desnoLijevoToolStripMenuItem";
            this.desnoLijevoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.desnoLijevoToolStripMenuItem.Text = "DesnoLijevo";
            this.desnoLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoLijevoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxDesno);
            this.Controls.Add(this.TextBoxLijevo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLijevo;
        private System.Windows.Forms.TextBox TextBoxDesno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoLijevoToolStripMenuItem;
    }
}

