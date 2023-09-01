using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class NhaCungCap
    {
        public Guid IDNhaCungCap { get; set; }
        public string MaNCC { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SdtNCC { get; set; }
        public string DiaCHi { get; set; }

        public virtual List<SanPham> SanPhams { get; set; }
    }
}
