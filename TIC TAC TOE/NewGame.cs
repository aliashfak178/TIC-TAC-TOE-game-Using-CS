using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void StartNewGame_Click(object sender, EventArgs e)
        {
            MainGame MG1 = new MainGame(PlayerOneNameTextBox.Text, PlayerYwoNameTextBox.Text, PlayerOneRadioButton.Checked, StartPlayerOneRadioButton.Checked);
            OpenChildForm(MG1);
        }

        private Form ActiveForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.Controls.Add(ChildForm);
            this.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
