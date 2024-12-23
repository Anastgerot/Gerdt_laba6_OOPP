using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static Gerdt_laba6_OOPP.Form1;

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

            [MarshalAs(UnmanagedType.R4)]
            public float Rating;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Country;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Director;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string VoiceActors; 

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string AnimationStyle;

            [MarshalAs(UnmanagedType.Bool)]
            public bool IsAvailable;
        }

        // Подключение к DLL для операций с фильмами
        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern int GetSize();

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern bool LoadFilm(string filename);

        [DllImport(@"C:\Users\anast\OneDrive\Документы\GitHub\Lab6_OOPP\Gerdt_laba6_OOPP\x64\Debug\Gerdt_DLL_lab6.dll", CharSet = CharSet.Ansi)]
        public static extern bool Save(string filename);

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
                else if (Convert.ToDouble(ratingEdit.Text) < 0|| Convert.ToDouble(ratingEdit.Text) > 10)
                {
                    MessageBox.Show("Рейтинг должен быть в диапазоне от 0 до 10.", "Ошибка ввода");
                    return;
                }

                beforeEditFilm.Title = titleEdit.Text;
                beforeEditFilm.Year = Convert.ToInt32(yearEdit.Text);
                beforeEditFilm.Genre = genreEdit.Text;
                beforeEditFilm.Rating = Convert.ToSingle(ratingEdit.Text);
                beforeEditFilm.Country = countryEdit.Text;
                beforeEditFilm.Director = directorEdit.Text;
                beforeEditFilm.IsAvailable = isAvaliableBox.Checked;

                // Обработка анимационных фильмов
                if (voiceActorsEdit.Visible)
                {
                    beforeEditFilm.VoiceActors = voiceActorsEdit.Text;
                    beforeEditFilm.AnimationStyle = animationStyleEdit.Text;
                    if (string.IsNullOrEmpty(voiceActorsEdit.Text))
                    {
                        MessageBox.Show("Поле 'Актеры озвучки' не может быть пустым.", "Ошибка ввода");
                        return;
                    }
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

            if (!string.IsNullOrEmpty(film.VoiceActors))
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
            ToggleButtons(true);
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

            voiceActorsEdit.Text = "";
            animationStyleEdit.Text = "";
            voiceActorsEdit.Visible = false;
            animationStyleEdit.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            ToggleButtons(false);

        }
        private void addAnimationFilmBtn_Click(object sender, EventArgs e)
        {
            AddFilm(1);
            UpdateListBox();
            FilmslistBox.SelectedIndex = FilmslistBox.Items.Count - 1;
            voiceActorsEdit.Text = "";
            animationStyleEdit.Text = "";
            voiceActorsEdit.Visible = true;
            animationStyleEdit.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            ToggleButtons(false);
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
            ToggleButtons(true);
            if (GetSize() == 0)
            {
                titleEdit.Text = "";
                yearEdit.Text = "";
                genreEdit.Text = "";
                ratingEdit.Text = "";
                countryEdit.Text = "";
                directorEdit.Text = "";
                isAvaliableBox.Checked = false;
                voiceActorsEdit.Text = "";
                animationStyleEdit.Text = "";
                titleEdit.Enabled = false;
                yearEdit.Enabled = false;
                genreEdit.Enabled = false;
                ratingEdit.Enabled = false;
                countryEdit.Enabled = false;
                directorEdit.Enabled = false;
                isAvaliableBox.Enabled = false;
                voiceActorsEdit.Visible = false;
                animationStyleEdit.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                return;
            }
        }

        private void ToggleButtons(bool enable)
        {
            addFilmBtn.Enabled = enable;
            addAnimationFilmBtn.Enabled = enable;
            loadBtn.Enabled = enable;
            saveBtn.Enabled = enable;
            FilmslistBox.Enabled = enable;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    LoadFilm(fileName);

                    if (string.IsNullOrEmpty(fileName))
                    {
                        MessageBox.Show("Файл не выбран.", "Ошибка");
                        return;
                    }

                    if (!LoadFilm(fileName))
                    {
                        MessageBox.Show("Не удалось загрузить данные из файла.", "Ошибка");
                        return;
                    }

                    UpdateListBox();
                    MessageBox.Show("Данные успешно загружены.", "Успех");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}\n{ex.StackTrace}");
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (FilmslistBox.Items.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения.", "Ошибка");
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                if (Save(fileName))
                {
                    Save(fileName);
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

