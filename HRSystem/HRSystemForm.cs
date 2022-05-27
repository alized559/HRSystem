using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class HRSystemForm : Form
    {
        public HRSystemForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.adminTableAdapter.Fill(this.hRSystemDataSet.admin);
            this.employeeTableAdapter.Fill(this.hRSystemDataSet.employee);
            this.CenterToScreen();
            adminNameLabel.Text = "Welcome " + Program.currentHRName;

            // admin nav is invisible because I did it invisible in UI
            // locate it and put plus btn enabled attribute to false
            // because I don't think we need to do it, there is signup
            // but you can do it, and you have add employee UI
        }

        public void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRSystemDataSet);
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            AddEmployee form = new AddEmployee();
            form.Show();
        }

        private void onChangeTabItem(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                adminNav.Visible = false;
                employeeNav.Visible = true;
            } else
            {
                employeeNav.Visible = false;
                adminNav.Visible = true;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // logout
        }
    }
}
