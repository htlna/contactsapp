using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactsApp
{
    class Contact
    {
        string ho;
        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }
  
        string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
  
        string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
  
        string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public Contact(string ho, string ten, string diachi, string sdt)
        {
            this.ho = ho;
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}