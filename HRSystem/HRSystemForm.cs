using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class HRSystemForm : Form
    {
        JobModel[] jobs;
        string conn = "Data Source=DESKTOP-KING\\SQLEXPRESS;Initial Catalog=HRSystem;Integrated Security=True";
        public HRSystemForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRSystemDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hRSystemDataSet.users);
            this.employeeTableAdapter.Fill(this.hRSystemDataSet.employee);
            this.CenterToScreen();
            adminNameLabel.Text = "Welcome " + Program.currentHRName;

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
                    if (job != null)
                    {
                        jobList.Items.Add(job);
                    }
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
                viewBtn.Visible = false;
                deleteBtn.Visible = false;
                employeeNav.Visible = true;
            } else if (tabControl.SelectedIndex == 1)
            {
                errorLabel.Visible = false;
                employeeNav.Visible = false;
                viewBtn.Visible = false;
                deleteBtn.Visible = false;
            } else
            {
                employeeNav.Visible = false;

                if (jobs.Length == 0)
                {
                    viewBtn.Visible = false;
                    deleteBtn.Visible = false;
                    errorLabel.Text = "No Jobs Available";
                    errorLabel.Visible = true;
                } else
                {
                    viewBtn.Visible = true;
                    deleteBtn.Visible = true;
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new LogIn();
            login.Closed += (s, args) => this.Close();
            login.Show();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (jobList.SelectedIndex == -1)
            {
                errorLabel.Text = "Please Select Job Post To Delete";
                errorLabel.Visible = true;
            } else
            {
                SqlConnection connection = new SqlConnection(conn);
                string query = "DELETE FROM job WHERE id = " + jobs[jobList.SelectedIndex].id;
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    jobs[jobList.SelectedIndex] = null;
                    jobList.Items.Clear();

                    foreach (JobModel job in jobs)
                    {
                        if (job != null)
                        {
                            jobList.Items.Add(job);
                        }
                    }
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
            }
        }
    }
}
