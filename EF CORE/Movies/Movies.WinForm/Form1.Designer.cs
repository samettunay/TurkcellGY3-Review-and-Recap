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
            splitContainer1 = new SplitContainer();
            dataGridViewMovies = new DataGridView();
            buttonPlayers = new Button();
            buttonDirector = new Button();
            buttonNewMovie = new Button();
            buttonGetAllMovies = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewMovies);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonGetAllMovies);
            splitContainer1.Panel2.Controls.Add(buttonNewMovie);
            splitContainer1.Panel2.Controls.Add(buttonPlayers);
            splitContainer1.Panel2.Controls.Add(buttonDirector);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Dock = DockStyle.Fill;
            dataGridViewMovies.Location = new Point(0, 0);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowTemplate.Height = 25;
            dataGridViewMovies.Size = new Size(796, 262);
            dataGridViewMovies.TabIndex = 0;
            // 
            // buttonPlayers
            // 
            buttonPlayers.Location = new Point(113, 74);
            buttonPlayers.Name = "buttonPlayers";
            buttonPlayers.Size = new Size(129, 44);
            buttonPlayers.TabIndex = 1;
            buttonPlayers.Text = "Oyuncu İşlemleri";
            buttonPlayers.UseVisualStyleBackColor = true;
            buttonPlayers.Click += buttonPlayers_Click;
            // 
            // buttonDirector
            // 
            buttonDirector.Location = new Point(113, 25);
            buttonDirector.Name = "buttonDirector";
            buttonDirector.Size = new Size(129, 43);
            buttonDirector.TabIndex = 0;
            buttonDirector.Text = "Yönetmen İşlemleri";
            buttonDirector.UseVisualStyleBackColor = true;
            buttonDirector.Click += buttonDirector_Click;
            // 
            // buttonNewMovie
            // 
            buttonNewMovie.Location = new Point(332, 25);
            buttonNewMovie.Name = "buttonNewMovie";
            buttonNewMovie.Size = new Size(129, 44);
            buttonNewMovie.TabIndex = 2;
            buttonNewMovie.Text = "Film işlemleri";
            buttonNewMovie.UseVisualStyleBackColor = true;
            buttonNewMovie.Click += buttonNewMovie_Click;
            // 
            // buttonGetAllMovies
            // 
            buttonGetAllMovies.Location = new Point(332, 75);
            buttonGetAllMovies.Name = "buttonGetAllMovies";
            buttonGetAllMovies.Size = new Size(129, 44);
            buttonGetAllMovies.TabIndex = 3;
            buttonGetAllMovies.Text = "Film işlemleri";
            buttonGetAllMovies.UseVisualStyleBackColor = true;
            buttonGetAllMovies.Click += buttonGetAllMovies_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewMovies;
        private Button buttonPlayers;
        private Button buttonDirector;
        private Button buttonNewMovie;
        private Button buttonGetAllMovies;
    }
}