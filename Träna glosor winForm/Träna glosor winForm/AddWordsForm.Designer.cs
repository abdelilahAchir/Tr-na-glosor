namespace Träna_glosor_winForm
{
    partial class AddWordsForm
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
            this.dataGridAddWords = new System.Windows.Forms.DataGridView();
            this.AddWordsButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddWords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAddWords
            // 
            this.dataGridAddWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAddWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridAddWords.MultiSelect = false;
            this.dataGridAddWords.Name = "dataGridAddWords";
            this.dataGridAddWords.RowHeadersWidth = 51;
            this.dataGridAddWords.RowTemplate.Height = 29;
            this.dataGridAddWords.Size = new System.Drawing.Size(393, 257);
            this.dataGridAddWords.TabIndex = 0;
            // 
            // AddWordsButton
            // 
            this.AddWordsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddWordsButton.Location = new System.Drawing.Point(25, 263);
            this.AddWordsButton.Name = "AddWordsButton";
            this.AddWordsButton.Size = new System.Drawing.Size(171, 43);
            this.AddWordsButton.TabIndex = 1;
            this.AddWordsButton.Text = "Add Words";
            this.AddWordsButton.UseVisualStyleBackColor = true;
            this.AddWordsButton.Click += new System.EventHandler(this.AddWordsButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoneButton.Location = new System.Drawing.Point(206, 263);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(171, 43);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 318);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AddWordsButton);
            this.Controls.Add(this.dataGridAddWords);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddWordsForm";
            this.ShowIcon = false;
            this.Text = "Add Words Form";
            this.Load += new System.EventHandler(this.AddWordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridAddWords;
        private Button AddWordsButton;
        private Button DoneButton;
    }
}