﻿namespace WindowsFormsApp1
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
            this.SRun = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.TextBox();
            this.MultipleLines = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.Singleline = new System.Windows.Forms.TextBox();
            this.MRun = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insturctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloEveryoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SRun
            // 
            this.SRun.Location = new System.Drawing.Point(9, 519);
            this.SRun.Margin = new System.Windows.Forms.Padding(2);
            this.SRun.Name = "SRun";
            this.SRun.Size = new System.Drawing.Size(100, 24);
            this.SRun.TabIndex = 0;
            this.SRun.Text = "Execute";
            this.SRun.UseVisualStyleBackColor = true;
            this.SRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(486, 563);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(145, 41);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(645, 563);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(136, 41);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.WindowText;
            this.Console.ForeColor = System.Drawing.SystemColors.Info;
            this.Console.Location = new System.Drawing.Point(327, 346);
            this.Console.Margin = new System.Windows.Forms.Padding(2);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(454, 197);
            this.Console.TabIndex = 3;
            this.Console.Text = "Console";
            // 
            // MultipleLines
            // 
            this.MultipleLines.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MultipleLines.Location = new System.Drawing.Point(9, 43);
            this.MultipleLines.Margin = new System.Windows.Forms.Padding(2);
            this.MultipleLines.Multiline = true;
            this.MultipleLines.Name = "MultipleLines";
            this.MultipleLines.Size = new System.Drawing.Size(314, 285);
            this.MultipleLines.TabIndex = 4;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Panel.Location = new System.Drawing.Point(327, 43);
            this.Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(454, 285);
            this.Panel.TabIndex = 5;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Singleline
            // 
            this.Singleline.Location = new System.Drawing.Point(9, 483);
            this.Singleline.Margin = new System.Windows.Forms.Padding(2);
            this.Singleline.Name = "Singleline";
            this.Singleline.Size = new System.Drawing.Size(237, 20);
            this.Singleline.TabIndex = 0;
            // 
            // MRun
            // 
            this.MRun.Location = new System.Drawing.Point(9, 346);
            this.MRun.Margin = new System.Windows.Forms.Padding(2);
            this.MRun.Name = "MRun";
            this.MRun.Size = new System.Drawing.Size(136, 41);
            this.MRun.TabIndex = 6;
            this.MRun.Text = "RUN";
            this.MRun.UseVisualStyleBackColor = true;
            this.MRun.Click += new System.EventHandler(this.MRun_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insturctionToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // insturctionToolStripMenuItem
            // 
            this.insturctionToolStripMenuItem.Name = "insturctionToolStripMenuItem";
            this.insturctionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insturctionToolStripMenuItem.Text = "Hints";
            this.insturctionToolStripMenuItem.Click += new System.EventHandler(this.insturctionToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloEveryoneToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helloEveryoneToolStripMenuItem
            // 
            this.helloEveryoneToolStripMenuItem.Name = "helloEveryoneToolStripMenuItem";
            this.helloEveryoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helloEveryoneToolStripMenuItem.Text = "Hello Everyone...!!!";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 638);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.MRun);
            this.Controls.Add(this.Singleline);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.MultipleLines);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SRun);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Advance Software Engineering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SRun;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.TextBox MultipleLines;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox Singleline;
        private System.Windows.Forms.Button MRun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insturctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloEveryoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

