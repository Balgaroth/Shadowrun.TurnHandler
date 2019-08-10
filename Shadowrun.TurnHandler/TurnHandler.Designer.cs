using System.Windows.Forms;

namespace Shadowrun.TurnHandler
{
    partial class TurnHandler
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addParticipantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passDoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTurnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParticipantPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addParticipantToolStripMenuItem,
            this.passDoneToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.newTurnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            //this.menuStrip1.Size = new System.Drawing.Size(3110, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addParticipantToolStripMenuItem
            // 
            this.addParticipantToolStripMenuItem.Name = "addParticipantToolStripMenuItem";
            this.addParticipantToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.addParticipantToolStripMenuItem.Text = "Add Participant";
            this.addParticipantToolStripMenuItem.Click += new System.EventHandler(this.AddParticipantToolStripMenuItem_Click);
            // 
            // passDoneToolStripMenuItem
            // 
            this.passDoneToolStripMenuItem.Name = "passDoneToolStripMenuItem";
            this.passDoneToolStripMenuItem.Size = new System.Drawing.Size(144, 36);
            this.passDoneToolStripMenuItem.Text = "Pass Done";
            this.passDoneToolStripMenuItem.Click += new System.EventHandler(this.PassDoneToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // newTurnToolStripMenuItem
            // 
            this.newTurnToolStripMenuItem.Name = "newTurnToolStripMenuItem";
            this.newTurnToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.newTurnToolStripMenuItem.Text = "New Turn";
            this.newTurnToolStripMenuItem.Click += new System.EventHandler(this.NewTurnToolStripMenu_Click);
            // 
            // ParticipantPanel
            // 
            this.ParticipantPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticipantPanel.AutoScroll = true;
            this.ParticipantPanel.Location = new System.Drawing.Point(17, 46);
            this.ParticipantPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ParticipantPanel.Name = "ParticipantPanel";
            //this.ParticipantPanel.Size = new System.Drawing.Size(3077, 1119);
            this.ParticipantPanel.TabIndex = 1;
            // 
            // TurnHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(3110, 1180);
            this.Controls.Add(this.ParticipantPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TurnHandler";
            this.Text = "Shadowrun TurnHandler";
            this.Load += new System.EventHandler(this.TurnHandler_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addParticipantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passDoneToolStripMenuItem;
        private System.Windows.Forms.Panel ParticipantPanel;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTurnToolStripMenuItem;
    }
}

