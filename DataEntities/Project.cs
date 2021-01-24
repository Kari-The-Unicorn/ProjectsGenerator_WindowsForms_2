using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsGenerator_WindowsForms_2.DataEntities
{
    public class Project
    {
        public Project()
        {
            //this.Issues = new HashSet<Issue>();
        }
        public int id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectCompany { get; set; }
        public string ProjectState { get; set; }
        public DateTime? ProjectDateIn { get; set; }
        public DateTime? ProjectDateOut { get; set; }
        public int? ImageId { get; set; }
    }
}
