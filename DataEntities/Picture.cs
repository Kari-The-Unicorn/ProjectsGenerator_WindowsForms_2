using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsGenerator_WindowsForms_2.DataEntities
{
    public class Picture
    {
        public Picture()
        {
            //this.Issues = new HashSet<Issue>();
        }
        public int PictureId { get; set; }
        public string PictureName { get; set; }
        public byte[] PictureContent { get; set; }
    }
}
