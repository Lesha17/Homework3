//
// Дисциплина: Программирование
// Студент: Мачнев Алексей
// Работа: Контрольное Домашнее задание за 3й модуль, вариант 8
// Дата написаниия: 24 февраля 2016 г.
// Файл содержит описание контроллера формы MainForm
//

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Homework3.ViewModels;
using Homework3.Model;
using System;

namespace Homework3
{
    public partial class MainForm
    {
        const string exception_caption = "Ошибка";
        private string save_settings_path = null;

        // Обновляет содержимое списка позиций
        private void updateListBox()
        {
            if (frq_viewmodel == null)
            {
                return;
            }

            try
            {
                var positions = frq_viewmodel.Positions;
                var checked_positions = settings.CheckedPositions;

                uint data_cnt = (uint)positions.Count();
                uint settings_cnt = settings.CountOfPositions;

                uint min_cnt = data_cnt < settings_cnt ? data_cnt : settings_cnt;

                uint i = 0;

                var settings_item_positions = new HashSet<uint>(settings.CheckedPositions);

                checkedListBox1.Items.Clear();
                settings.UncheckAll();
                foreach (var p in positions)
                {
                    bool contains = settings_item_positions.Contains(p);
                    int index = checkedListBox1.Items.Add(p, contains);
                    if (contains)
                    {
                        settings.Check(p);
                    }

                    if (++i >= min_cnt)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Обновляет диаграмму
        private void updateChart()
        {
            try
            {
                if (frq_viewmodel == null)
                {
                    return;
                }

                chart1.Series.Clear();

                foreach (char c in frq_viewmodel.Letters)
                {
                    string series_name = c.ToString();

                    Series series = new Series(series_name);
                    series.ChartType = SeriesChartType.StackedArea100;
                    if (settings.CheckedPositions.Count() == 1)
                    {
                        series.ChartType = SeriesChartType.StackedColumn100;
                    }

                    chart1.Series.Add(series);

                    foreach (uint p in settings.CheckedPositions)
                    {
                        chart1.Series[series_name].Points.AddXY(p, frq_viewmodel.Data.Data[p][c]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Обновляет содержимое таблицы
        private void updateGrid()
        {
            try
            {
                if (frq_viewmodel == null)
                {
                    return;
                }

                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                var positions = frq_viewmodel.Positions;

                uint data_cnt = (uint)positions.Count();
                uint settings_cnt = settings.CountOfPositions;

                uint min_cnt = data_cnt < settings_cnt ? data_cnt : settings_cnt;

                foreach (char c in frq_viewmodel.Letters)
                {
                    string column_name = c.ToString();
                    dataGridView1.Columns.Add(column_name, column_name);
                }

                uint i = 0;
                foreach (uint num in positions)
                {
                    int index = dataGridView1.Rows.Add(frq_viewmodel.RowAt(num, settings.Precision));
                    dataGridView1.Rows[index].HeaderCell.Value = num.ToString();

                    if (++i >= min_cnt)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Открывает данные из файла
        private async Task open_data_file()
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    frq_viewmodel = new FrqViewModel(await Frq.LoadAsync(openFileDialog1.FileName));

                    updateListBox();
                    updateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Сохраняет настройки в файл без открытия диалогового окна выбора файла,
        // если настройки ранее уже сохранялись или были открыты из файла
        private async Task save_settings()
        {
            try
            {
                if (save_settings_path == null)
                {
                    await save_settings_as();
                    return;
                }

                await save_settungs_to(save_settings_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Сохраняет настройки в файл, полученный из диалогового окна
        private async Task save_settings_as()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    await save_settungs_to(save_settings_path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Сохраняет настройки в файл по пути path
        private async Task save_settungs_to(string path)
        {
            try
            {
                await settings.Save(path);
                save_settings_path = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Открывает настройки из файла
        private async Task open_setting_from_file()
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    settings = await Settings.Load(openFileDialog2.FileName);
                    save_settings_path = openFileDialog2.FileName;
                    updateListBox();
                    updateChart();
                    updateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }

        // Открывает диалоговое окно с настройками
        private void set_settings()
        {
            try
            {
                SettingsForm sf = new SettingsForm(settings.Precision, settings.CountOfPositions);

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    settings.Precision = sf.Precision;
                    settings.CountOfPositions = sf.Count;

                    updateListBox();
                    updateChart();
                    updateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, exception_caption);
            }
        }
    }
}
