using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void addRow(string color_btn, string subject_btn)
        {
            String[] row = { color_btn, subject_btn };
            dataGridView1.Rows.Add(row);
        }

        //добавление данных в dataGridView1
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(color_btn.Text, subject_btn.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Rows.Add("синий", "утюг");
        }

        //экспорт в txt
        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
                try
                {
                    List<int> col_n = new List<int>();
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                        if (col.Visible)
                        {
                            sw.Write(col.HeaderText + "\t");
                            col_n.Add(col.Index);
                        }
                    sw.WriteLine();
                    int x = dataGridView1.RowCount;
                    if (dataGridView1.AllowUserToAddRows) x--;

                    for (int i = 0; i < x; i++)
                    {
                        for (int y = 0; y < col_n.Count; y++)
                            sw.Write(dataGridView1[col_n[y], i].Value + "\t");
                        sw.Write(" \r\n");
                    }
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }

            }
        }

        // вывод в формате csv
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "CSV (*.csv)|*.csv";
                save.FileName = "Test.csv";
                bool fileError = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("не удалось записать данные на диск" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + "  ";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + "  ";
                                }
                            }
                            File.WriteAllLines(save.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("данные успешно экспортированы", "информация");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ошибка :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("нет записи для экспорта", "информация");
            }
        }
    }
}
