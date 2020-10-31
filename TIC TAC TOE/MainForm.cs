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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            SubMenuPanel.Visible = false;
            HelpSubMenuPanel.Visible = false;
            //... If Onother sub menu is present
        }
        private void HideSubMenu()
        {
            if (SubMenuPanel.Visible == true)
            {
                SubMenuPanel.Visible = false;
            }
            if (HelpSubMenuPanel.Visible == true)
            {
                HelpSubMenuPanel.Visible = false;
            }
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubMenuPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewGame());
            //..
            button2.Enabled = false;
            //..
            HideSubMenu();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            //..
            //My Code
            //..
            ShowSubMenu(HelpSubMenuPanel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutGame());
            //..
            //My Code
            //..
            HideSubMenu();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //..
            //My Code
            //..
            HideSubMenu();
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
            ContainerPanel.Controls.Add(ChildForm);
            ContainerPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
