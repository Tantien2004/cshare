using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyview
{
    public class Employee
    {
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public bool GioiTinh { get; set; }

        public string NoiSinh {  get; set; }
        public string MaLopHoc { get; set; }

        public string KhoaHoc { get; set; } 
        public string Anh { get; set; }
        public DateTime NgaySinh { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
