//
// Дисциплина: Программирование
// Студент: Мачнев Алексей
// Работа: Контрольное Домашнее задание за 3й модуль, вариант 8
// Дата написаниия: 24 февраля 2016 г.
// Файл содержит описание класса MainForm и Callback-и действий пользователя
//

using System;
using System.Windows.Forms;

namespace Homework3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Model.ISettings settings = new Model.Settings(30, 5);

        private ViewModels.FrqViewModel frq_viewmodel;

        //
        // Callback-и действий пользователя
        //

        private async void openToolStripButton_Click(object sender, EventArgs e)
        {
            await open_data_file();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            uint item = uint.Parse(checkedListBox1.Items[e.Index].ToString());

            if (e.NewValue == CheckState.Checked)
            {
                settings.Check(item);
            }
            else
            {
                settings.Uncheck(item);
            }

            updateChart();
        }

        private void settingsStripButton_Click(object sender, EventArgs e)
        {
            set_settings();
        }

        private async void open_data_fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await open_data_file();
        }

        private async void save_settingsToolStripButton_Click(object sender, EventArgs e)
        {
            await save_settings();
        }

        private async void open_settings_fileStripButton1_Click(object sender, EventArgs e)
        {
            await open_setting_from_file();
        }

        private async void save_settings_asButton_Click(object sender, EventArgs e)
        {
            await save_settings_as();
        }

        private void open_settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set_settings();
        }

        private async void save_settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await save_settings();
        }

        private async void save_settings_asToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await save_settings_as();
        }

        private async void open_settings_fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await open_setting_from_file();
        }
    }
}
