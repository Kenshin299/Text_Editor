using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Text_Editor
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Acceder al enlace");
                Console.WriteLine(ex.Message);
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            var ps = new ProcessStartInfo("https://github.com/Kenshin299/Text_Editor")
            {
                UseShellExecute = true
            };
            Process.Start(ps);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
