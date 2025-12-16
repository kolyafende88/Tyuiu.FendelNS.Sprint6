using Tyuiu.FendelNS.Sprint6.Task6.V28.Lib;
namespace Tyuiu.FendelNS.Sprint6.Task6.V28;
public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    string openFilePath;
    DataService ds = new DataService();

    private void buttonOpenFile_GAE_Click(object sender, EventArgs e)
    {
        openFileDialogTask_FNS.ShowDialog();
        openFilePath = openFileDialogTask_FNS.FileName;
        textBoxIn_FNS.Text = File.ReadAllText(openFilePath);
        labelInputFileName.Text = openFilePath;
        buttonExecute_FNS.Enabled = true;
    }

    private void buttonExecute_GAE_Click(object sender, EventArgs e)
    {
        textBoxOut_FNS.Text = ds.CollectTextFromFile(openFilePath);
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new();
        formAbout.ShowDialog();
    }
}
