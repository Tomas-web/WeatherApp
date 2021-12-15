
namespace ChuckNorrisJokes
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByNameBtn = new System.Windows.Forms.Button();
            this.jokeImage = new System.Windows.Forms.PictureBox();
            this.jokeText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jokeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Items.AddRange(new object[] {
            "any"});
            this.categoriesListBox.Location = new System.Drawing.Point(16, 46);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(174, 95);
            this.categoriesListBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(16, 147);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search joke by name";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(20, 226);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(170, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            // 
            // searchByNameBtn
            // 
            this.searchByNameBtn.Location = new System.Drawing.Point(20, 265);
            this.searchByNameBtn.Name = "searchByNameBtn";
            this.searchByNameBtn.Size = new System.Drawing.Size(75, 23);
            this.searchByNameBtn.TabIndex = 5;
            this.searchByNameBtn.Text = "Search";
            this.searchByNameBtn.UseVisualStyleBackColor = true;
            this.searchByNameBtn.Click += new System.EventHandler(this.searchByNameBtn_Click);
            // 
            // jokeImage
            // 
            this.jokeImage.Location = new System.Drawing.Point(518, 46);
            this.jokeImage.Name = "jokeImage";
            this.jokeImage.Size = new System.Drawing.Size(143, 95);
            this.jokeImage.TabIndex = 6;
            this.jokeImage.TabStop = false;
            // 
            // jokeText
            // 
            this.jokeText.Location = new System.Drawing.Point(333, 174);
            this.jokeText.Name = "jokeText";
            this.jokeText.Size = new System.Drawing.Size(455, 250);
            this.jokeText.TabIndex = 7;
            this.jokeText.Text = "";
            this.jokeText.TextChanged += new System.EventHandler(this.jokeText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name should be between 3 and 120 characters length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jokeText);
            this.Controls.Add(this.jokeImage);
            this.Controls.Add(this.searchByNameBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.categoriesListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Chuck Norris Jokes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jokeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchByNameBtn;
        private System.Windows.Forms.PictureBox jokeImage;
        private System.Windows.Forms.RichTextBox jokeText;
        private System.Windows.Forms.Label label3;
    }
}

