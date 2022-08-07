using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsRi
{
    public class Complexe
    {
        double reel;
        double imaginaire;
        public Complexe(double reel, double imaginaire)
        {
            this.reel = reel;
            this.imaginaire = imaginaire;
        }
        public double Reel
        {
            get { return this.reel; }
            set { this.reel = value; }
        }
        public double Imaginaire
        {
            get { return this.imaginaire; }
            set { this.imaginaire = value; }
        }
        public void iteration_julia(Complexe c)
        {

            double a = this.reel;
            double b = this.imaginaire;
            this.reel = a* a - b * b + c.Reel;
            
            this.imaginaire = 2 * a * b + c.Imaginaire;
           
        }
        public int speedConv(Complexe c)
        {
            int compteur = 0;
            while (compteur < 100 && (Math.Sqrt((this.Reel * this.Reel + this.Imaginaire * this.Imaginaire)) < 100000000))
            {
                compteur++;
                this.iteration_julia(c);
            }
            return compteur;
        }
        

    }
}
