namespace Movies.WinForm
{
    partial class FormMovies
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
            listBoxPlayers = new ListBox();
            comboBoxDirectors = new ComboBox();
            textBoxTitle = new TextBox();
            textBoxDuration = new TextBox();
            dateTimePickerPublishDate = new DateTimePicker();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(21, 18);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(120, 94);
            listBoxPlayers.TabIndex = 0;
            // 
            // comboBoxDirectors
            // 
            comboBoxDirectors.FormattingEnabled = true;
            comboBoxDirectors.Location = new Point(147, 18);
            comboBoxDirectors.Name = "comboBoxDirectors";
            comboBoxDirectors.Size = new Size(121, 23);
            comboBoxDirectors.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(147, 90);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(147, 50);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(100, 23);
            textBoxDuration.TabIndex = 3;
            // 
            // dateTimePickerPublishDate
            // 
            dateTimePickerPublishDate.Location = new Point(147, 128);
            dateTimePickerPublishDate.Name = "dateTimePickerPublishDate";
            dateTimePickerPublishDate.Size = new Size(200, 23);
            dateTimePickerPublishDate.TabIndex = 4;
            dateTimePickerPublishDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(147, 169);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add button";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormMovies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 232);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePickerPublishDate);
            Controls.Add(textBoxDuration);
            Controls.Add(textBoxTitle);
            Controls.Add(comboBoxDirectors);
            Controls.Add(listBoxPlayers);
            Name = "FormMovies";
            Text = "FormMovies";
            Load += FormMovies_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPlayers;
        private ComboBox comboBoxDirectors;
        private TextBox textBoxTitle;
        private TextBox textBoxDuration;
        private DateTimePicker dateTimePickerPublishDate;
        private Button buttonAdd;
    }
}