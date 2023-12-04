using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class NguoiDung
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public int roles { get; set; }

        public NguoiDung()
        {

        }
    }
}
