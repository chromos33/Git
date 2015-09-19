using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightNovelHTMLParser
{
    public partial class LightNovelDownloadForm : Form
    {
        public LightNovelDownloadForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LightNovelDownloadForm_Load(object sender, EventArgs e)
        {

        }
        private void LightNovelDownloadForm_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            
            // Ensure the Form remains square (Height = Width).
            SupportedPageList.Height = control.Size.Height - 80;
            SupportedPageList.Width = control.Size.Width/3;

            LightNovelAvailableField.Height = control.Size.Height - 80;
            LightNovelAvailableField.Width = control.Size.Width / 3;
            LightNovelAvailableField.Left = SupportedPageList.Right+20;
            LightNovelListLabel.Left = SupportedPageList.Right + 20;


        }

        private void searchpage_btn_Click(object sender, EventArgs e)
        {

        }

        private void download_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
