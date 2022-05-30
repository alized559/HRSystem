using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class HRSystemForm : Form
    {
        JobModel[] jobs;
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

            string conn = "Data Source=DESKTOP-KING\\SQLEXPRESS;Initial Catalog=HRSystem;Integrated Security=True";

            SqlConnection connection = new SqlConnection(conn);
            string query = "SELECT COUNT(id) as count FROM job";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string count = reader["count"].ToString();
                    jobs = new JobModel[Convert.ToInt32(count)];
                }
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                cmd.Dispose();
                connection.Close();
            }

            SqlConnection connection1 = new SqlConnection(conn);
            string query1 = "SELECT * FROM job";
            SqlCommand cmd1 = new SqlCommand(query1, connection1);

            try
            {
                connection1.Open();
                var reader = cmd1.ExecuteReader();
                int index = 0;
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    jobs[index] = new JobModel(Convert.ToInt32(id), reader["title"].ToString(),
                        reader["wrokplace_type"].ToString());
                    index++;
                }
                foreach (JobModel job in jobs)
                {
                    jobList.Items.Add(job);
                }
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                cmd.Dispose();
                connection1.Close();
            }

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

        private void onChangeTabItem(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                errorLabel.Visible = false;
                adminNav.Visible = false;
                viewBtn.Visible = false;
                deleteBtn.Visible = false;
                employeeNav.Visible = true;
            } else if (tabControl.SelectedIndex == 1)
            {
                errorLabel.Visible = false;
                employeeNav.Visible = false;
                viewBtn.Visible = false;
                deleteBtn.Visible = false;
                adminNav.Visible = true;
            } else
            {
                employeeNav.Visible = false;
                adminNav.Visible = false;
                viewBtn.Visible = true;
                deleteBtn.Visible = true;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // logout
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            AddJob form = new AddJob();
            form.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddEmployee form = new AddEmployee();
            form.Show();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (jobList.SelectedIndex == -1)
            {
                errorLabel.Text = "Please Select Job Post";
                errorLabel.Visible = true;
            }
            else
            {
                Program.selectedJobID = jobs[jobList.SelectedIndex].id;
                Job jobForm = new Job();
                jobForm.Show();
            }
        }
    }
}
