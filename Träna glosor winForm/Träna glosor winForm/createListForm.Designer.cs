namespace Träna_glosor_winForm
{
    partial class CreateListForm
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
            this.createList = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.languagesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createList
            // 
            this.createList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createList.Location = new System.Drawing.Point(75, 248);
            this.createList.Name = "createList";
            this.createList.Size = new System.Drawing.Size(140, 29);
            this.createList.TabIndex = 0;
            this.createList.Text = "Create List";
            this.createList.UseVisualStyleBackColor = true;
            this.createList.Click += new System.EventHandler(this.createList_Click);
            
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(222, 248);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 29);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a name for the list";
            // 
            // listNameBox
            // 
            this.listNameBox.Location = new System.Drawing.Point(139, 61);
            this.listNameBox.Name = "listNameBox";
            this.listNameBox.Size = new System.Drawing.Size(174, 27);
            this.listNameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(173, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Languages";
            // 
            // languagesBox
            // 
            this.languagesBox.Location = new System.Drawing.Point(139, 136);
            this.languagesBox.Multiline = true;
            this.languagesBox.Name = "languagesBox";
            this.languagesBox.Size = new System.Drawing.Size(174, 96);
            this.languagesBox.TabIndex = 6;
            // 
            // CreateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.languagesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.createList);
            this.Name = "CreateListForm";
            this.Text = "Create List Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createList;
        private Button Cancel;
        private Label label1;
        private TextBox listNameBox;
        private Label label2;
        private TextBox languagesBox;
    }
}