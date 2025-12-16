using Tyuiu.FendelNS.Sprint6.Task5.V3.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"C:\Users\kolia\source\repos\Tyuiu.FendelNS.Sprint6\TXTs\InPutDataFileTask5V3";

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТБ-24-1 Фендель Николай Сергеевич", "Справка");
        }

        private void textBoxStartValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopValue_ATY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_ATY_Click(object sender, EventArgs e)
        {
            dataGridViewResult_FNS.ColumnCount = 2;
            dataGridViewResult_FNS.Columns[0].Width = 20;
            dataGridViewResult_FNS.Columns[1].Width = 50;
            this.chartFunction_FNS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_FNS.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_FNS.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_FNS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_FNS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSave_ATY_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
