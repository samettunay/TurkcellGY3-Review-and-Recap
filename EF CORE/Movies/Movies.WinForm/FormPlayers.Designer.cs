namespace Movies.WinForm
{
    partial class FormPlayers
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
            splitContainer1 = new SplitContainer();
            dataGridViewPlayers = new DataGridView();
            textBoxPlayerName = new TextBox();
            textBoxPlayerLastName = new TextBox();
            textBoxPlayerInfo = new TextBox();
            buttonAddPlayer = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonAddPlayer);
            splitContainer1.Panel1.Controls.Add(textBoxPlayerInfo);
            splitContainer1.Panel1.Controls.Add(textBoxPlayerLastName);
            splitContainer1.Panel1.Controls.Add(textBoxPlayerName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewPlayers);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Dock = DockStyle.Fill;
            dataGridViewPlayers.Location = new Point(0, 0);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.RowTemplate.Height = 25;
            dataGridViewPlayers.Size = new Size(530, 450);
            dataGridViewPlayers.TabIndex = 0;
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Location = new Point(74, 132);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(100, 23);
            textBoxPlayerName.TabIndex = 1;
            // 
            // textBoxPlayerLastName
            // 
            textBoxPlayerLastName.Location = new Point(74, 186);
            textBoxPlayerLastName.Name = "textBoxPlayerLastName";
            textBoxPlayerLastName.Size = new Size(100, 23);
            textBoxPlayerLastName.TabIndex = 2;
            // 
            // textBoxPlayerInfo
            // 
            textBoxPlayerInfo.Location = new Point(74, 234);
            textBoxPlayerInfo.Name = "textBoxPlayerInfo";
            textBoxPlayerInfo.Size = new Size(100, 23);
            textBoxPlayerInfo.TabIndex = 3;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.Location = new Point(89, 289);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(75, 23);
            buttonAddPlayer.TabIndex = 1;
            buttonAddPlayer.Text = "Add Player";
            buttonAddPlayer.UseVisualStyleBackColor = true;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // FormPlayers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FormPlayers";
            Text = "FormPlayers";
            Load += FormPlayers_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewPlayers;
        private TextBox textBoxPlayerInfo;
        private TextBox textBoxPlayerLastName;
        private TextBox textBoxPlayerName;
        private Button buttonAddPlayer;
    }
}