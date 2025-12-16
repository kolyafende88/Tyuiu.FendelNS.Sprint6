using System.Data;
using Tyuiu.FendelNS.Sprint6.Task2.V15.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task2.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_FNS.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_FNS.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] res = ds.GetMassFunction(startValue, stopValue);
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResult_PDA.Rows.Add(Convert.ToString(startValue), Convert.ToString(res[i]));
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonQuestion_PDA_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТБ-24-1 Фендель Николай Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
