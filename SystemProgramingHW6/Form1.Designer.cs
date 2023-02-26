namespace SystemProgramingHW6
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
            listBoxCreateThreads = new ListBox();
            listBoxWorkingThreads = new ListBox();
            listBoxWaitingThreads = new ListBox();
            domainUpDown1 = new DomainUpDown();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxCreateThreads
            // 
            listBoxCreateThreads.FormattingEnabled = true;
            listBoxCreateThreads.ItemHeight = 20;
            listBoxCreateThreads.Location = new Point(601, 69);
            listBoxCreateThreads.Name = "listBoxCreateThreads";
            listBoxCreateThreads.Size = new Size(187, 204);
            listBoxCreateThreads.TabIndex = 0;
            listBoxCreateThreads.SelectedIndexChanged += listBoxCreateThreads_SelectedIndexChanged;
            // 
            // listBoxWorkingThreads
            // 
            listBoxWorkingThreads.FormattingEnabled = true;
            listBoxWorkingThreads.ItemHeight = 20;
            listBoxWorkingThreads.Location = new Point(12, 69);
            listBoxWorkingThreads.Name = "listBoxWorkingThreads";
            listBoxWorkingThreads.Size = new Size(187, 204);
            listBoxWorkingThreads.TabIndex = 0;
            // 
            // listBoxWaitingThreads
            // 
            listBoxWaitingThreads.FormattingEnabled = true;
            listBoxWaitingThreads.ItemHeight = 20;
            listBoxWaitingThreads.Location = new Point(295, 69);
            listBoxWaitingThreads.Name = "listBoxWaitingThreads";
            listBoxWaitingThreads.Size = new Size(187, 204);
            listBoxWaitingThreads.TabIndex = 0;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(12, 316);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(187, 27);
            domainUpDown1.TabIndex = 1;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // button1
            // 
            button1.Location = new Point(601, 316);
            button1.Name = "button1";
            button1.Size = new Size(187, 27);
            button1.TabIndex = 2;
            button1.Text = "Create New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Waiting Threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 46);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Create Threads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Working Threads";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(domainUpDown1);
            Controls.Add(listBoxWaitingThreads);
            Controls.Add(listBoxWorkingThreads);
            Controls.Add(listBoxCreateThreads);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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