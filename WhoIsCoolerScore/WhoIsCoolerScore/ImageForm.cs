using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoIsCoolerScore
{
    public partial class ImageForm : Form
    {
        public string scoreTeam1, scoreTeam2, nameTeam1, nameTeam2;
        
        public ImageForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public void InitDate()
        {
            ResetImage();
        }

        private void ResetImage()
        {
            Image a = Image.FromFile("SChYoT.jpeg");

            a = GraphicsDraw(a, nameTeam1, 450, 360, Color.Red);
            a = GraphicsDraw(a, nameTeam2, 1495, 360, Color.Blue);
            a = GraphicsDraw(a, scoreTeam1, 400, 703, Color.Red);
            a = GraphicsDraw(a, scoreTeam2, 1515, 703, Color.Blue);

            this.BackgroundImage = a;
        }

        private Image GraphicsDraw(Image a, string inputText, int x, int y, Color col)
        {
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            Graphics _part = Graphics.FromImage(a);
            _part.DrawString(inputText,
            new Font("Segoe Script", 55, FontStyle.Bold),
            new SolidBrush(col), new RectangleF(x, y, 0, 340),
            format);
            return a;
        }
    }
}
