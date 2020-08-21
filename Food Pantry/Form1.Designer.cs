namespace Food_Pantry
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
            this.title = new System.Windows.Forms.Label();
            this.R2 = new System.Windows.Forms.TextBox();
            this.R2LABEL = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.listResultsLabel = new System.Windows.Forms.Label();
            this.nameResults = new System.Windows.Forms.ListView();
            this.Pantry_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.confirm = new System.Windows.Forms.Label();
            this.allCheckins = new System.Windows.Forms.ListView();
            this.allCheckinsLabel = new System.Windows.Forms.Label();
            this.PantryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.title.Location = new System.Drawing.Point(1, 6);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(360, 54);
            this.title.TabIndex = 0;
            this.title.Text = "Pantry Check-In";
            this.title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // R2
            // 
            this.R2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.R2.Location = new System.Drawing.Point(110, 80);
            this.R2.Margin = new System.Windows.Forms.Padding(2);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(236, 45);
            this.R2.TabIndex = 1;
            this.R2.Text = " ";
            this.R2.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // R2LABEL
            // 
            this.R2LABEL.AutoSize = true;
            this.R2LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.R2LABEL.Location = new System.Drawing.Point(4, 80);
            this.R2LABEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.R2LABEL.Name = "R2LABEL";
            this.R2LABEL.Size = new System.Drawing.Size(105, 39);
            this.R2LABEL.TabIndex = 2;
            this.R2LABEL.Text = "R2D2";
            this.R2LABEL.Click += new System.EventHandler(this.Label2_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.submit.Location = new System.Drawing.Point(363, 80);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(132, 42);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // listResultsLabel
            // 
            this.listResultsLabel.AutoSize = true;
            this.listResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listResultsLabel.Location = new System.Drawing.Point(138, 140);
            this.listResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listResultsLabel.Name = "listResultsLabel";
            this.listResultsLabel.Size = new System.Drawing.Size(179, 26);
            this.listResultsLabel.TabIndex = 4;
            this.listResultsLabel.Text = "Click on your info";
            this.listResultsLabel.Click += new System.EventHandler(this.ListResultsLabel_Click);
            // 
            // nameResults
            // 
            this.nameResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pantry_ID});
            this.nameResults.HideSelection = false;
            this.nameResults.Location = new System.Drawing.Point(53, 168);
            this.nameResults.Margin = new System.Windows.Forms.Padding(2);
            this.nameResults.Name = "nameResults";
            this.nameResults.Size = new System.Drawing.Size(357, 224);
            this.nameResults.TabIndex = 5;
            this.nameResults.UseCompatibleStateImageBehavior = false;
            this.nameResults.View = System.Windows.Forms.View.List;
            this.nameResults.SelectedIndexChanged += new System.EventHandler(this.NameResults_SelectedIndexChanged);
            // 
            // Pantry_ID
            // 
            this.Pantry_ID.Width = 357;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(50, 436);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(10, 13);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "-";
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // allCheckins
            // 
            this.allCheckins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PantryID});
            this.allCheckins.Location = new System.Drawing.Point(524, 168);
            this.allCheckins.Name = "allCheckins";
            this.allCheckins.Size = new System.Drawing.Size(357, 224);
            this.allCheckins.TabIndex = 7;
            this.allCheckins.UseCompatibleStateImageBehavior = false;
            // 
            // allCheckinsLabel
            // 
            this.allCheckinsLabel.AutoSize = true;
            this.allCheckinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.allCheckinsLabel.Location = new System.Drawing.Point(613, 140);
            this.allCheckinsLabel.Name = "allCheckinsLabel";
            this.allCheckinsLabel.Size = new System.Drawing.Size(197, 26);
            this.allCheckinsLabel.TabIndex = 8;
            this.allCheckinsLabel.Text = "All submitted items";
            // 
            // PantryID
            // 
            this.PantryID.Width = 357;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.close.Location = new System.Drawing.Point(749, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(132, 42);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 484);
            this.Controls.Add(this.close);
            this.Controls.Add(this.allCheckinsLabel);
            this.Controls.Add(this.allCheckins);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.nameResults);
            this.Controls.Add(this.listResultsLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.R2LABEL);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Food Pantry Check-In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.Label R2LABEL;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label listResultsLabel;
        private System.Windows.Forms.ListView nameResults;
        private System.Windows.Forms.ColumnHeader Pantry_ID;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.ListView allCheckins;
        private System.Windows.Forms.Label allCheckinsLabel;
        private System.Windows.Forms.ColumnHeader PantryID;
        private System.Windows.Forms.Button close;
    }
}

