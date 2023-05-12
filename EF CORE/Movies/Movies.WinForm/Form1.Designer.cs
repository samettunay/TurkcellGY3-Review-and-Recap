namespace Movies.WinForm
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
            listBoxMovies = new ListBox();
            buttonGetMovies = new Button();
            SuspendLayout();
            // 
            // listBoxMovies
            // 
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.ItemHeight = 15;
            listBoxMovies.Location = new Point(161, 220);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(392, 199);
            listBoxMovies.TabIndex = 1;
            // 
            // buttonGetMovies
            // 
            buttonGetMovies.Location = new Point(324, 99);
            buttonGetMovies.Name = "buttonGetMovies";
            buttonGetMovies.Size = new Size(75, 23);
            buttonGetMovies.TabIndex = 2;
            buttonGetMovies.Text = "Getir";
            buttonGetMovies.UseVisualStyleBackColor = true;
            buttonGetMovies.Click += buttonGetMovies_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGetMovies);
            Controls.Add(listBoxMovies);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxMovies;
        private Button buttonGetMovies;
    }
}