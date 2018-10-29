using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DataViewer
{
    public partial class HelpForm : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            picBox_Photo.Image = Image.FromFile(@"Images/flintstone_peek.png");
        }
    }
}
