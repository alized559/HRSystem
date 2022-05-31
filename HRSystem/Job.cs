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
    public partial class Job : Form
    {
        int selectedJobID;
        public Job()
        {
            InitializeComponent();
            this.selectedJobID = Program.selectedJobID;
        }

        private void Job_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            string conn = "Data Source=DESKTOP-KING\\SQLEXPRESS;Initial Catalog=HRSystem;Integrated Security=True";

            SqlConnection connection = new SqlConnection(conn);
            string query = "SELECT * FROM job WHERE id = " + selectedJobID;
            SqlCommand cmd = new SqlCommand(query, connection);
        
            try
            {
                connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    titleLabel.Text = reader["title"].ToString();
                    locationLabel.Text = reader["location"].ToString();
                    placeLabel.Text = "(" + reader["wrokplace_type"].ToString() + ")";
                    typeLabel.Text = reader["type"].ToString();
                    employeesNbLabel.Text = "20 employee";
                    description.Text = reader["description"].ToString();
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
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
