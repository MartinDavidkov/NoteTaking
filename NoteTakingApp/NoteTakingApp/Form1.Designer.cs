namespace NoteTakingApp
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            save = new Button();
            view = new Button();
            title = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(459, 238);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 64);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter your note";
            // 
            // save
            // 
            save.Location = new Point(389, 326);
            save.Name = "save";
            save.Size = new Size(89, 34);
            save.TabIndex = 2;
            save.Text = "Save note";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // view
            // 
            view.Location = new Point(26, 329);
            view.Name = "view";
            view.Size = new Size(117, 23);
            view.TabIndex = 3;
            view.Text = "View Saved Notes";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // title
            // 
            title.Location = new Point(19, 18);
            title.Name = "title";
            title.PlaceholderText = "Title";
            title.Size = new Size(159, 23);
            title.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 408);
            Controls.Add(title);
            Controls.Add(view);
            Controls.Add(save);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button save;
        private Button view;
        private TextBox title;
    }
}