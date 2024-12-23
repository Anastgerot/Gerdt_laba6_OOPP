using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerdt_laba6_OOPP
{
    public partial class Form1 : Form   
    {
        public Form1()
        {
            InitializeComponent();
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Film
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Title;

            [MarshalAs(UnmanagedType.I4)]
            public int Year; 

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Genre;

            [MarshalAs(UnmanagedType.R8)]
            public double Rating;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Country;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Director; 

            [MarshalAs(UnmanagedType.Bool)]
            public bool IsAvailable; 

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string VoiceActors; 

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string AnimationStyle;
        }

        // Подключение к DLL для операций с фильмами
        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern int GetSize();

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern bool LoadFilm(StringBuilder filename);

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern bool Save(StringBuilder filename);

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern void GetFilm(ref Film film, int id);

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern void AddFilm(int param);

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern void UpdateFilm(ref Film film, int id);

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern bool DeleteFilm(int id);

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern void Clear();


        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            if (FilmslistBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите фильм для обновления данных.");
                return;
            }
            int selected = FilmslistBox.SelectedIndex;
            var beforeEditFilm = new Film();
            GetFilm(ref beforeEditFilm, selected);

            try
            {
                if (string.IsNullOrEmpty(titleEdit.Text))
                {
                    MessageBox.Show("Поле 'Название' не может быть пустым.", "Ошибка ввода");
                    return;
                }
                else if (Convert.ToInt32(yearEdit.Text) <= 0 || Convert.ToInt32(yearEdit.Text) > 2024)
                {
                    MessageBox.Show("Год выпуска должен быть в диапазоне от 1895 до текущего года.", "Ошибка ввода");
                    return;
                }
                else if (Convert.ToDouble(ratingEdit.Text) < 0 || Convert.ToDouble(ratingEdit.Text) > 10)
                {
                    MessageBox.Show("Рейтинг должен быть в диапазоне от 0 до 10.", "Ошибка ввода");
                    return;
                }
                beforeEditFilm.Title = titleEdit.Text;
                beforeEditFilm.Year = Convert.ToInt32(yearEdit.Text);
                beforeEditFilm.Genre = genreEdit.Text;
                beforeEditFilm.Rating = Convert.ToDouble(ratingEdit.Text);
                beforeEditFilm.Country = countryEdit.Text;
                beforeEditFilm.Director = directorEdit.Text;
                beforeEditFilm.IsAvailable = isAvaliableBox.Checked;

                // Обработка анимационных фильмов
                if (voiceActorsEdit.Visible)
                {
                    beforeEditFilm.VoiceActors = voiceActorsEdit.Text;
                    beforeEditFilm.AnimationStyle = animationStyleEdit.Text;
                }
                else
                {
                    beforeEditFilm.VoiceActors = "";
                    beforeEditFilm.AnimationStyle = "";
                }
            }
            catch
            {
                MessageBox.Show("Неправильный формат. Проверьте данные.");
                return;
            }

            UpdateFilm(ref beforeEditFilm, selected);
            UpdateListBox();
            FilmslistBox.SelectedIndex = selected;
        }


        private void FilmslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var film = new Film();
            GetFilm(ref film, FilmslistBox.SelectedIndex);

            titleEdit.Text = film.Title;
            yearEdit.Text = film.Year.ToString();
            genreEdit.Text = film.Genre;
            ratingEdit.Text = film.Rating.ToString();
            countryEdit.Text = film.Country;
            directorEdit.Text = film.Director;
            isAvaliableBox.Checked = film.IsAvailable;

            if (!string.IsNullOrEmpty(film.AnimationStyle))
            {
                voiceActorsEdit.Text = film.VoiceActors;
                animationStyleEdit.Text = film.AnimationStyle;
                voiceActorsEdit.Visible = true;
                animationStyleEdit.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
            }
            else
            {
                voiceActorsEdit.Visible = false;
                animationStyleEdit.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
            }

            titleEdit.Enabled = true;
            yearEdit.Enabled = true;
            genreEdit.Enabled = true;
            ratingEdit.Enabled = true;
            countryEdit.Enabled = true;
            directorEdit.Enabled = true;
            isAvaliableBox.Enabled = true;

        }


        private void UpdateListBox()
        {
            FilmslistBox.Items.Clear();
            for (int i = 0; i < GetSize(); i++)
            {
                var film = new Film();
                GetFilm(ref film, i);
                FilmslistBox.Items.Add(film.Title);
            }
        }

        private void addFilmBtn_Click(object sender, EventArgs e)
        {
            AddFilm(0); 
            UpdateListBox();
            FilmslistBox.SelectedIndex = FilmslistBox.Items.Count - 1;
        }
        private void addAnimationFilmBtn_Click(object sender, EventArgs e)
        {
            AddFilm(1);
            UpdateListBox();
            FilmslistBox.SelectedIndex = FilmslistBox.Items.Count - 1;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (FilmslistBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите фильм для удаления.");
                return;
            }
            if (DeleteFilm(FilmslistBox.SelectedIndex))
            {
                int beforeDelete = FilmslistBox.SelectedIndex;
                UpdateListBox();
                if (beforeDelete != FilmslistBox.Items.Count)
                {
                    FilmslistBox.SelectedIndex = beforeDelete;
                }
                else
                {
                    FilmslistBox.SelectedIndex = beforeDelete - 1;
                }
            }

        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary Files (*.dat)|*.dat";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Файл не выбран.", "Ошибка");
                    return;
                }

                var filePath = new StringBuilder(fileName);

                if (!LoadFilm(filePath))
                {
                    MessageBox.Show("Не удалось загрузить данные. Проверьте файл.", "Ошибка");
                    return;
                }

                UpdateListBox();
                MessageBox.Show("Данные успешно загружены.", "Успех");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (FilmslistBox.Items.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения.", "Ошибка");
                return;
            }

            saveFileDialog1.Filter = "Binary Files (*.dat)|*.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Имя файла не может быть пустым.", "Ошибка");
                    return;
                }

                var filename = new StringBuilder(fileName);

                if (Save(filename))
                {
                    MessageBox.Show("Данные успешно сохранены.", "Успех");
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить данные. Проверьте путь и доступ к файлу.", "Ошибка");
                }
            }
        }
    }
}

