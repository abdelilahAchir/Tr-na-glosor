namespace Träna_glosor_winForm
{
    partial class ListsForm
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
            this.Select = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NewList = new System.Windows.Forms.Button();
            this.languageBox = new System.Windows.Forms.ListBox();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.languagesLabel = new System.Windows.Forms.Label();
            this.wordListLabel = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.numberOfWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Select.Location = new System.Drawing.Point(615, 389);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(165, 46);
            this.Select.TabIndex = 0;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(415, 389);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(165, 46);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewList
            // 
            this.NewList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewList.Location = new System.Drawing.Point(22, 389);
            this.NewList.Name = "NewList";
            this.NewList.Size = new System.Drawing.Size(165, 46);
            this.NewList.TabIndex = 2;
            this.NewList.Text = "Create New List";
            this.NewList.UseVisualStyleBackColor = true;
            this.NewList.Click += new System.EventHandler(this.NewList_Click);
            // 
            // languageBox
            // 
            this.languageBox.FormattingEnabled = true;
            this.languageBox.ItemHeight = 20;
            this.languageBox.Location = new System.Drawing.Point(471, 62);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(252, 264);
            this.languageBox.TabIndex = 3;
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 20;
            this.wordListBox.Location = new System.Drawing.Point(74, 62);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(252, 264);
            this.wordListBox.TabIndex = 4;
            this.wordListBox.SelectedIndexChanged += new System.EventHandler(this.wordListBox_SelectedIndexChanged);
            // 
            // languagesLabel
            // 
            this.languagesLabel.AutoSize = true;
            this.languagesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.languagesLabel.Location = new System.Drawing.Point(474, 36);
            this.languagesLabel.Name = "languagesLabel";
            this.languagesLabel.Size = new System.Drawing.Size(84, 20);
            this.languagesLabel.TabIndex = 5;
            this.languagesLabel.Text = "Languages";
            // 
            // wordListLabel
            // 
            this.wordListLabel.AutoSize = true;
            this.wordListLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordListLabel.Location = new System.Drawing.Point(74, 36);
            this.wordListLabel.Name = "wordListLabel";
            this.wordListLabel.Size = new System.Drawing.Size(84, 20);
            this.wordListLabel.TabIndex = 6;
            this.wordListLabel.Text = "Word Lists";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordCount.Location = new System.Drawing.Point(201, 36);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(102, 20);
            this.wordCount.TabIndex = 7;
            this.wordCount.Text = "Word Count :";
            // 
            // numberOfWords
            // 
            this.numberOfWords.AutoSize = true;
            this.numberOfWords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfWords.Location = new System.Drawing.Point(300, 37);
            this.numberOfWords.Name = "numberOfWords";
            this.numberOfWords.Size = new System.Drawing.Size(18, 20);
            this.numberOfWords.TabIndex = 8;
            this.numberOfWords.Text = "0";
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOfWords);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.wordListLabel);
            this.Controls.Add(this.languagesLabel);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.NewList);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Select);
            this.Name = "ListsForm";
            this.Text = "Select word list";
            this.Load += new System.EventHandler(this.ListsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Select;
        private Button Cancel;
        private Button NewList;
        private ListBox languageBox;
        private ListBox wordListBox;
        private Label languagesLabel;
        private Label wordListLabel;
        private Label wordCount;
        private Label numberOfWords;
    }
}