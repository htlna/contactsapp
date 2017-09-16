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
            set
            {
                if(ho.Length > 10)
                    ho = "";
                else
                    ho = value;
            }
        }
  
        string ten;
        public string Ten
        {
            get { return ten; }
            set
            {
                if(ten.Length > 10)
                    ten = "";
                else
                    ten = value;
            }
        }
  
        string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set
            {
                if(diachi.Length > 10)
                    diachi = "";
                else
                    diachi = value;
            }
        }
  
        string sdt;
        public string SDT
        {
            get { return sdt; }
            set
            {
                if(sdt.Length > 10)
                    sdt = "";
                else
                    sdt = value;
            }
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