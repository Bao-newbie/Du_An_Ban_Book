using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class TacGiaView
    {
        public  Guid idtacGia { get; set; }
        public string MaTG { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public string diaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
    }
}
