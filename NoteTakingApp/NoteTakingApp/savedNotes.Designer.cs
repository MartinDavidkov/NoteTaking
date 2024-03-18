namespace NoteTakingApp
{
    partial class savedNotes
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
            dataGridView1 = new DataGridView();
            searchName = new TextBox();
            delete = new Button();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(439, 229);
            dataGridView1.TabIndex = 0;
            // 
            // searchName
            // 
            searchName.Location = new Point(61, 33);
            searchName.Name = "searchName";
            searchName.PlaceholderText = "Search by title";
            searchName.Size = new Size(119, 23);
            searchName.TabIndex = 1;
            // 
            // delete
            // 
            delete.Location = new Point(65, 298);
            delete.Name = "delete";
            delete.Size = new Size(115, 27);
            delete.TabIndex = 2;
            delete.Text = "Delete Note";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.Location = new Point(385, 297);
            search.Name = "search";
            search.Size = new Size(115, 27);
            search.TabIndex = 3;
            search.Text = "Search Note";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // savedNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 359);
            Controls.Add(search);
            Controls.Add(delete);
            Controls.Add(searchName);
            Controls.Add(dataGridView1);
            Name = "savedNotes";
            Text = "savedNotes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchName;
        private Button delete;
        private Button search;
    }
}