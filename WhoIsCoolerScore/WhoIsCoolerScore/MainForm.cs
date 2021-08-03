using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WhoIsCoolerScore
{
    public partial class MainForm : MetroForm
    {
        private ImageForm newIF = new ImageForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowWindow_Click(object sender, EventArgs e)
        {
            try
            {
                newIF.scoreTeam1 = ScoreTeam1.Text;
                newIF.scoreTeam2 = ScoreTeam2.Text;
                newIF.nameTeam1 = NameTeam1.Text;
                newIF.nameTeam2 = NameTeam2.Text;
                newIF.InitDate();

                MaximizeToSecondaryMonitor(newIF);

                newIF.Show();
            }
            catch
            {
                newIF = new ImageForm();
            }
        }

        public void MaximizeToSecondaryMonitor(ImageForm window)
        {
            var secondaryScreen = Screen.AllScreens.Where(s => !s.Primary).FirstOrDefault();

            if (secondaryScreen != null)
            {
                window.StartPosition = FormStartPosition.Manual;
                var workingArea = secondaryScreen.WorkingArea;
                window.Left = workingArea.Left;
                window.Top = workingArea.Top;
                window.Width = workingArea.Width;
                window.Height = workingArea.Height;
                window.WindowState = FormWindowState.Maximized;
            }
        }

        private void HideWindow_Click(object sender, EventArgs e)
        {
            try
            {
                newIF.Hide();
            }
            catch
            {
                newIF = new ImageForm();
            }
        }
    }
}
