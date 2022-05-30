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
            
        }
    }
}
