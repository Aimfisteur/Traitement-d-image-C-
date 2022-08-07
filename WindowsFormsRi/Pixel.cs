using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsRi
{
    public class Pixel
    {
        private byte b;
        private byte v;
        private byte r;

        public Pixel(byte b, byte v, byte r)
        {
            this.r = r;
            this.v = v;
            this.b = b;
        }
        public byte R
        {
            get { return this.r; }
            set { this.r = value; }
        }
        public byte V
        {
            get { return this.v; }
            set { this.v = value; }
        }
        public byte B
        {
            get { return this.b; }
            set { this.b = value; }
        }
        public string toString()
        {
            string s = "";
            return s + this.b + " " + this.v + " " + this.r+" ";
        }
    }
}
