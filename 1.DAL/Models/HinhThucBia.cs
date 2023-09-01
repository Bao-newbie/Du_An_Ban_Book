using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Ban_Sach._1.DAL.Models
{
    public class HinhThucBia
    {
        public Guid idBia { get; set; }
        public string LoaiBia { get; set; }

        public virtual List<SanPham> SanPhams { get; set; }
    }
}
