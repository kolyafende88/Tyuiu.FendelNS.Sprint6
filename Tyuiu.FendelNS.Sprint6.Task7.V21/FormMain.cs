using Tyuiu.FendelNS.Sprint6.Task7.V21.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_FNS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_FNS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService dataService = new DataService();
        static int rows;
        static int columns;
        static string? openFilePath;

        private void buttonOpenFile_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_FNS.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_FNS.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_FNS.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonAbout_SBI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_SBI_Click(object sender, EventArgs e)
        {
            int[,] values = dataService.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_FNS.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSaveFile_FNS.Enabled = true;
        }

        private void buttonOpenFile_SBI_Click(object sender, EventArgs e)
        {
            openFileDialog_FNS.ShowDialog();
            openFilePath = openFileDialog_FNS.FileName;

            if (openFilePath != null)
            {
                int[,] arrayValues = dataService.GetStartMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewInPut_FNS.ColumnCount = columns;
                dataGridViewInPut_FNS.RowCount = rows;
                dataGridViewOutPut_FNS.ColumnCount = columns;
                dataGridViewOutPut_FNS.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInPut_FNS.Columns[i].Width = 25;
                    dataGridViewOutPut_FNS.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInPut_FNS.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
                buttonDone_FNS.Enabled = true;
            }
        }

        private void buttonSaveFile_SBI_Click(object sender, EventArgs e)
        {
            saveFileDialog_FNS.FileName = "OutPutFileTask7.csv";
            saveFileDialog_FNS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_FNS.ShowDialog();

            string path = saveFileDialog_FNS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut_FNS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut_FNS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}