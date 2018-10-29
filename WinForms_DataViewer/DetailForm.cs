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
    public partial class DetailForm : Form
    {
        Character _person = new Character();

        public DetailForm(Character person)
        {
            InitializeComponent();
            _person = person;
        }
        #region EVENTS

        private void DetailForm_Load(object sender, EventArgs e)
        {
            lbl_FullName.Text = _person.FullName();
            lbl_FirstName.Text = "First Name: " + _person.FirstName;
            lbl_LastName.Text = "Last Name: " + _person.LastName;
            lbl_Id.Text = "ID: " + _person.Id.ToString();
            lbl_Age.Text = "Age: " + _person.Age.ToString();
            lbl_Gender.Text = "Gender:" + _person.Gender.ToString();
            lbl_Description.Text = _person.Description;
            picBox_Photo.Image = Image.FromFile(@"Images/" + _person.ImageFileName);
            this.Text = _person.FullName() + " Details";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion EVENTS

        private void lbl_Description_Click(object sender, EventArgs e)
        {

        }
    }
}
