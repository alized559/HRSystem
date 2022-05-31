using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRSystem
{
    public partial class Jobs : Form
    {
        JobModel[] jobs;
        public Jobs()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new LogIn();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

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
                foreach(JobModel job in jobs)
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
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (jobList.SelectedIndex == -1)
            {
                errorLabel.Text = "Please Select Job Post";
                errorLabel.Visible = true;
            } else
            {
                Program.selectedJobID = jobs[jobList.SelectedIndex].id;
                Job jobForm = new Job();
                jobForm.Show();
            }
        }
    }
}
