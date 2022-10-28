namespace Träna_glosor_winForm
{
    partial class WordListS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setActiveWordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceWords = new System.Windows.Forms.Button();
            this.removeWords = new System.Windows.Forms.Button();
            this.AddWord = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doneButton = new System.Windows.Forms.Button();
            this.translatedWordBox = new System.Windows.Forms.TextBox();
            this.wordToTranslateLabel = new System.Windows.Forms.Label();
            this.scorePracticeLabel = new System.Windows.Forms.Label();
            this.restartPracticeButton = new System.Windows.Forms.Button();
            this.endPracticeButton = new System.Windows.Forms.Button();
            this.checkTranslationbutton = new System.Windows.Forms.Button();
            this.practiceModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(720, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setActiveWordListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setActiveWordListToolStripMenuItem
            // 
            this.setActiveWordListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setActiveWordListToolStripMenuItem.Name = "setActiveWordListToolStripMenuItem";
            this.setActiveWordListToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.setActiveWordListToolStripMenuItem.Text = "Set Active Word List";
            this.setActiveWordListToolStripMenuItem.Click += new System.EventHandler(this.setActiveWordListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practiceModeMenu});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // practiceWords
            // 
            this.practiceWords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.practiceWords.Location = new System.Drawing.Point(367, 370);
            this.practiceWords.Name = "practiceWords";
            this.practiceWords.Size = new System.Drawing.Size(166, 45);
            this.practiceWords.TabIndex = 3;
            this.practiceWords.Text = "Practice";
            this.practiceWords.UseVisualStyleBackColor = true;
            this.practiceWords.Click += new System.EventHandler(this.practiceWords_Click);
            // 
            // removeWords
            // 
            this.removeWords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeWords.Location = new System.Drawing.Point(172, 371);
            this.removeWords.Name = "removeWords";
            this.removeWords.Size = new System.Drawing.Size(155, 45);
            this.removeWords.TabIndex = 4;
            this.removeWords.Text = "Remove";
            this.removeWords.UseVisualStyleBackColor = true;
            this.removeWords.Click += new System.EventHandler(this.removeWords_Click);
            // 
            // AddWord
            // 
            this.AddWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddWord.Location = new System.Drawing.Point(6, 370);
            this.AddWord.Name = "AddWord";
            this.AddWord.Size = new System.Drawing.Size(131, 45);
            this.AddWord.TabIndex = 5;
            this.AddWord.Text = "Add word";
            this.AddWord.UseVisualStyleBackColor = true;
            this.AddWord.Click += new System.EventHandler(this.AddWord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(716, 331);
            this.dataGridView1.TabIndex = 1;
            // 
            // doneButton
            // 
            this.doneButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doneButton.Location = new System.Drawing.Point(554, 370);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(154, 45);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // translatedWordBox
            // 
            this.translatedWordBox.Location = new System.Drawing.Point(224, 132);
            this.translatedWordBox.Name = "translatedWordBox";
            this.translatedWordBox.Size = new System.Drawing.Size(239, 27);
            this.translatedWordBox.TabIndex = 7;
            // 
            // wordToTranslateLabel
            // 
            this.wordToTranslateLabel.AutoSize = true;
            this.wordToTranslateLabel.Location = new System.Drawing.Point(225, 82);
            this.wordToTranslateLabel.Name = "wordToTranslateLabel";
            this.wordToTranslateLabel.Size = new System.Drawing.Size(187, 20);
            this.wordToTranslateLabel.TabIndex = 8;
            this.wordToTranslateLabel.Text = "holaaaalaaaaaaaaaaaaaaa";
            // 
            // scorePracticeLabel
            // 
            this.scorePracticeLabel.AutoSize = true;
            this.scorePracticeLabel.Location = new System.Drawing.Point(229, 192);
            this.scorePracticeLabel.Name = "scorePracticeLabel";
            this.scorePracticeLabel.Size = new System.Drawing.Size(191, 20);
            this.scorePracticeLabel.TabIndex = 9;
            this.scorePracticeLabel.Text = "holaaaaaaaaaaaaaaaaaaaa";
            // 
            // restartPracticeButton
            // 
            this.restartPracticeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartPracticeButton.Location = new System.Drawing.Point(98, 253);
            this.restartPracticeButton.Name = "restartPracticeButton";
            this.restartPracticeButton.Size = new System.Drawing.Size(155, 45);
            this.restartPracticeButton.TabIndex = 10;
            this.restartPracticeButton.Text = "Restart";
            this.restartPracticeButton.UseVisualStyleBackColor = true;
            this.restartPracticeButton.Click += new System.EventHandler(this.restartPracticeButton_Click);
            // 
            // endPracticeButton
            // 
            this.endPracticeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endPracticeButton.Location = new System.Drawing.Point(289, 253);
            this.endPracticeButton.Name = "endPracticeButton";
            this.endPracticeButton.Size = new System.Drawing.Size(155, 45);
            this.endPracticeButton.TabIndex = 11;
            this.endPracticeButton.Text = "End Practice";
            this.endPracticeButton.UseVisualStyleBackColor = true;
            this.endPracticeButton.Click += new System.EventHandler(this.endPracticeButton_Click);
            // 
            // checkTranslationbutton
            // 
            this.checkTranslationbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkTranslationbutton.Location = new System.Drawing.Point(478, 253);
            this.checkTranslationbutton.Name = "checkTranslationbutton";
            this.checkTranslationbutton.Size = new System.Drawing.Size(155, 45);
            this.checkTranslationbutton.TabIndex = 12;
            this.checkTranslationbutton.Text = "Check";
            this.checkTranslationbutton.UseVisualStyleBackColor = true;
            this.checkTranslationbutton.Click += new System.EventHandler(this.checkTranslationbutton_Click);
            // 
            // practiceModeMenu
            // 
            this.practiceModeMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.practiceModeMenu.Name = "practiceModeMenu";
            this.practiceModeMenu.Size = new System.Drawing.Size(224, 26);
            this.practiceModeMenu.Text = "Practice Mode";
            this.practiceModeMenu.Click += new System.EventHandler(this.practiceModeMenu_Click);
            // 
            // WordListS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 425);
            this.Controls.Add(this.checkTranslationbutton);
            this.Controls.Add(this.endPracticeButton);
            this.Controls.Add(this.restartPracticeButton);
            this.Controls.Add(this.scorePracticeLabel);
            this.Controls.Add(this.wordToTranslateLabel);
            this.Controls.Add(this.translatedWordBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.AddWord);
            this.Controls.Add(this.removeWords);
            this.Controls.Add(this.practiceWords);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WordListS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Word list v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Button practiceWords;
        private Button removeWords;
        private Button AddWord;
        private ToolStripMenuItem setActiveWordListToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button doneButton;
        private TextBox translatedWordBox;
        private Label wordToTranslateLabel;
        private Label scorePracticeLabel;
        private Button restartPracticeButton;
        private Button endPracticeButton;
        private Button checkTranslationbutton;
        private ToolStripMenuItem practiceModeMenu;
    }
}