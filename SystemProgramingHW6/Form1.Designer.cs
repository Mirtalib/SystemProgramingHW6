﻿namespace SystemProgramingHW6
{
    partial class Form1
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
            this.listBoxCreateThreads = new System.Windows.Forms.ListBox();
            this.listBoxWorkingThreads = new System.Windows.Forms.ListBox();
            this.listBoxWaitingThreads = new System.Windows.Forms.ListBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCreateThreads
            // 
            this.listBoxCreateThreads.FormattingEnabled = true;
            this.listBoxCreateThreads.ItemHeight = 20;
            this.listBoxCreateThreads.Location = new System.Drawing.Point(601, 69);
            this.listBoxCreateThreads.Name = "listBoxCreateThreads";
            this.listBoxCreateThreads.Size = new System.Drawing.Size(187, 204);
            this.listBoxCreateThreads.TabIndex = 0;
            this.listBoxCreateThreads.SelectedIndexChanged += new System.EventHandler(this.listBoxCreateThreads_SelectedIndexChanged);
            // 
            // listBoxWorkingThreads
            // 
            this.listBoxWorkingThreads.FormattingEnabled = true;
            this.listBoxWorkingThreads.ItemHeight = 20;
            this.listBoxWorkingThreads.Location = new System.Drawing.Point(12, 69);
            this.listBoxWorkingThreads.Name = "listBoxWorkingThreads";
            this.listBoxWorkingThreads.Size = new System.Drawing.Size(187, 204);
            this.listBoxWorkingThreads.TabIndex = 0;
            // 
            // listBoxWaitingThreads
            // 
            this.listBoxWaitingThreads.FormattingEnabled = true;
            this.listBoxWaitingThreads.ItemHeight = 20;
            this.listBoxWaitingThreads.Location = new System.Drawing.Point(295, 69);
            this.listBoxWaitingThreads.Name = "listBoxWaitingThreads";
            this.listBoxWaitingThreads.Size = new System.Drawing.Size(187, 204);
            this.listBoxWaitingThreads.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(12, 316);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(187, 27);
            this.domainUpDown1.TabIndex = 1;
            this.domainUpDown1.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Waiting Threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Threads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Working Threads";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.listBoxWaitingThreads);
            this.Controls.Add(this.listBoxWorkingThreads);
            this.Controls.Add(this.listBoxCreateThreads);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxCreateThreads;
        private ListBox listBoxWorkingThreads;
        private ListBox listBoxWaitingThreads;
        private DomainUpDown domainUpDown1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}