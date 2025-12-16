using Tyuiu.FendelNS.Sprint6.Task1.V4.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_FNS.Text);
                int stopStep = Convert.ToInt32(textBoxStop_FNS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_FNS.Text = "";
                textBoxRes_FNS.AppendText("+-------------+------------+" + Environment.NewLine);
                textBoxRes_FNS.AppendText("|      X      |     f(x)   |" + Environment.NewLine);
                textBoxRes_FNS.AppendText("+-------------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}     |", startStep, valueArray[i]);
                    textBoxRes_FNS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_FNS.AppendText("+-------------+------------+");

            }
            catch
            {
                MessageBox.Show("Введены неверные данные" , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHeLP_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТБ-24-1 Фендель Николай Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
