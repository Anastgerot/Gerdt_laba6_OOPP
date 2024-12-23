namespace Gerdt_laba6_OOPP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.countryEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveEditBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addAnimationFilmBtn = new System.Windows.Forms.Button();
            this.addFilmBtn = new System.Windows.Forms.Button();
            this.ratingEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genreEdit = new System.Windows.Forms.TextBox();
            this.yearEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilmslistBox = new System.Windows.Forms.ListBox();
            this.directorEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.voiceActorsEdit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.animationStyleEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.isAvaliableBox = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryEdit
            // 
            this.countryEdit.Enabled = false;
            this.countryEdit.Location = new System.Drawing.Point(564, 231);
            this.countryEdit.Margin = new System.Windows.Forms.Padding(4);
            this.countryEdit.Name = "countryEdit";
            this.countryEdit.Size = new System.Drawing.Size(272, 22);
            this.countryEdit.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Страна";
            // 
            // groupBox
            // 
            this.groupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox.Controls.Add(this.loadBtn);
            this.groupBox.Controls.Add(this.saveBtn);
            this.groupBox.Location = new System.Drawing.Point(567, 522);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(267, 90);
            this.groupBox.TabIndex = 31;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Файлы";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(8, 23);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(251, 25);
            this.loadBtn.TabIndex = 13;
            this.loadBtn.Text = "Загрузить из файла";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(8, 56);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(251, 25);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Сохранить в файл";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.Location = new System.Drawing.Point(567, 486);
            this.saveEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(263, 28);
            this.saveEditBtn.TabIndex = 30;
            this.saveEditBtn.Text = "Обновить данные";
            this.saveEditBtn.UseVisualStyleBackColor = true;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(458, 567);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 28);
            this.deleteBtn.TabIndex = 29;
            this.deleteBtn.Text = "Удалить\r\n";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addAnimationFilmBtn
            // 
            this.addAnimationFilmBtn.Location = new System.Drawing.Point(187, 567);
            this.addAnimationFilmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addAnimationFilmBtn.Name = "addAnimationFilmBtn";
            this.addAnimationFilmBtn.Size = new System.Drawing.Size(263, 28);
            this.addAnimationFilmBtn.TabIndex = 28;
            this.addAnimationFilmBtn.Text = "Добавить анимационный фильм\r\n";
            this.addAnimationFilmBtn.UseVisualStyleBackColor = true;
            this.addAnimationFilmBtn.Click += new System.EventHandler(this.addAnimationFilmBtn_Click);
            // 
            // addFilmBtn
            // 
            this.addFilmBtn.Location = new System.Drawing.Point(12, 567);
            this.addFilmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addFilmBtn.Name = "addFilmBtn";
            this.addFilmBtn.Size = new System.Drawing.Size(167, 28);
            this.addFilmBtn.TabIndex = 27;
            this.addFilmBtn.Text = "Добавить фильм";
            this.addFilmBtn.UseVisualStyleBackColor = true;
            this.addFilmBtn.Click += new System.EventHandler(this.addFilmBtn_Click);
            // 
            // ratingEdit
            // 
            this.ratingEdit.Enabled = false;
            this.ratingEdit.Location = new System.Drawing.Point(564, 179);
            this.ratingEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ratingEdit.Name = "ratingEdit";
            this.ratingEdit.Size = new System.Drawing.Size(272, 22);
            this.ratingEdit.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Рейтинг";
            // 
            // genreEdit
            // 
            this.genreEdit.Enabled = false;
            this.genreEdit.Location = new System.Drawing.Point(564, 127);
            this.genreEdit.Margin = new System.Windows.Forms.Padding(4);
            this.genreEdit.Name = "genreEdit";
            this.genreEdit.Size = new System.Drawing.Size(272, 22);
            this.genreEdit.TabIndex = 24;
            // 
            // yearEdit
            // 
            this.yearEdit.Enabled = false;
            this.yearEdit.Location = new System.Drawing.Point(564, 75);
            this.yearEdit.Margin = new System.Windows.Forms.Padding(4);
            this.yearEdit.Name = "yearEdit";
            this.yearEdit.Size = new System.Drawing.Size(272, 22);
            this.yearEdit.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Год";
            // 
            // titleEdit
            // 
            this.titleEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleEdit.Enabled = false;
            this.titleEdit.ForeColor = System.Drawing.Color.Black;
            this.titleEdit.Location = new System.Drawing.Point(564, 25);
            this.titleEdit.Margin = new System.Windows.Forms.Padding(4);
            this.titleEdit.Name = "titleEdit";
            this.titleEdit.Size = new System.Drawing.Size(272, 22);
            this.titleEdit.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название";
            // 
            // FilmslistBox
            // 
            this.FilmslistBox.FormattingEnabled = true;
            this.FilmslistBox.ItemHeight = 16;
            this.FilmslistBox.Location = new System.Drawing.Point(12, 12);
            this.FilmslistBox.Name = "FilmslistBox";
            this.FilmslistBox.Size = new System.Drawing.Size(545, 548);
            this.FilmslistBox.TabIndex = 36;
            this.FilmslistBox.SelectedIndexChanged += new System.EventHandler(this.FilmslistBox_SelectedIndexChanged);
            // 
            // directorEdit
            // 
            this.directorEdit.Enabled = false;
            this.directorEdit.Location = new System.Drawing.Point(564, 286);
            this.directorEdit.Margin = new System.Windows.Forms.Padding(4);
            this.directorEdit.Name = "directorEdit";
            this.directorEdit.Size = new System.Drawing.Size(272, 22);
            this.directorEdit.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Режиссер";
            // 
            // voiceActorsEdit
            // 
            this.voiceActorsEdit.Location = new System.Drawing.Point(564, 393);
            this.voiceActorsEdit.Margin = new System.Windows.Forms.Padding(4);
            this.voiceActorsEdit.Name = "voiceActorsEdit";
            this.voiceActorsEdit.Size = new System.Drawing.Size(272, 22);
            this.voiceActorsEdit.TabIndex = 42;
            this.voiceActorsEdit.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 373);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Актеры озвучки";
            this.label9.Visible = false;
            // 
            // animationStyleEdit
            // 
            this.animationStyleEdit.Location = new System.Drawing.Point(567, 446);
            this.animationStyleEdit.Margin = new System.Windows.Forms.Padding(4);
            this.animationStyleEdit.Name = "animationStyleEdit";
            this.animationStyleEdit.Size = new System.Drawing.Size(272, 22);
            this.animationStyleEdit.TabIndex = 44;
            this.animationStyleEdit.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 426);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Стиль анимации";
            this.label8.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Жанр";
            // 
            // isAvaliableBox
            // 
            this.isAvaliableBox.AutoSize = true;
            this.isAvaliableBox.Location = new System.Drawing.Point(567, 336);
            this.isAvaliableBox.Name = "isAvaliableBox";
            this.isAvaliableBox.Size = new System.Drawing.Size(102, 20);
            this.isAvaliableBox.TabIndex = 45;
            this.isAvaliableBox.Text = "В прокате?";
            this.isAvaliableBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 618);
            this.Controls.Add(this.isAvaliableBox);
            this.Controls.Add(this.animationStyleEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.voiceActorsEdit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.directorEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilmslistBox);
            this.Controls.Add(this.countryEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.saveEditBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addAnimationFilmBtn);
            this.Controls.Add(this.addFilmBtn);
            this.Controls.Add(this.ratingEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genreEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleEdit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox countryEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button saveEditBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addAnimationFilmBtn;
        private System.Windows.Forms.Button addFilmBtn;
        private System.Windows.Forms.TextBox ratingEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genreEdit;
        private System.Windows.Forms.TextBox yearEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FilmslistBox;
        private System.Windows.Forms.TextBox directorEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox voiceActorsEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox animationStyleEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isAvaliableBox;
    }
}

