using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    internal class JobModel
    {
        public int id = -1;
        public string title;
        public string workplace;

        public JobModel(int id, string t, string w)
        {
            this.id = id;
            this.title = t;
            this.workplace = w;
        }

        public override string ToString()
        {
            return this.title + "    (" + this.workplace + ")";
        }
    }
}
