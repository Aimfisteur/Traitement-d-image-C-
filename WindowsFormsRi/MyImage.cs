
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsRi
{
    public class MyImage//ici public internal
    {
        private string type = "";
        private int taille;
        private int offset;
        private int largeur;
        private int hauteur;
        private int nbPixel;
        Pixel[,] rvb;


        /// <summary>
        /// <c>MyImage</c> construit l'objet MyImage à partir de la lecture du fichier qui a le chemin : path
        /// </summary>
        public MyImage(string path)
        {
            byte[] myfile = File.ReadAllBytes(path);
            
            if (myfile[0] == 66 && myfile[1] == 77)
            {
                type = "BM";
            }
            byte[] taillefichier = { myfile[2], myfile[3], myfile[4], myfile[5] };
            byte[] depart = { myfile[10], myfile[11], myfile[12], myfile[13] };
            byte[] largeurfichier = { myfile[18], myfile[19], myfile[20], myfile[21] };
            byte[] hauteurfichier = { myfile[22], myfile[23], myfile[24], myfile[25] };
            byte[] Nboctetcouleur = { myfile[28], myfile[29] };



            taille = Convertir_Endian_To_Int1(taillefichier);
            offset = Convertir_Endian_To_Int1(depart);
            largeur = Convertir_Endian_To_Int1(largeurfichier); ;
            hauteur = Convertir_Endian_To_Int1(hauteurfichier); ;
            nbPixel = myfile[28] / 8;


            rvb = new Pixel[hauteur, largeur];
            
            int ligne = 0;
           
            for (int i = 54; i < myfile.Length; i = i + largeur * 3)
            {
                int colonne = 0;
                for (int j = i; j < i + 3 * largeur; j = j + 3)
                {

                    byte r;
                    byte v;
                    byte b;
                    b = myfile[j];
                    v = myfile[j + 1];
                    r = myfile[j + 2];
                    Pixel current = new Pixel(b, v, r);
                   
                    rvb[ligne, colonne] = current;
                    
                    colonne++;
                }
                
                ligne++;
                
                if (ligne >= hauteur)
                {
                    break;
                }
                
            }
            
            


        }



        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Taille
        {
            get { return taille; }
            set { taille = value; }
        }
        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }
        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }
        public int Hauteur
        {
            get { return hauteur; }
            set { hauteur = value; }
        }
        public int NbPixel
        {
            get { return nbPixel; }
            set { nbPixel = value; }
        }
        public Pixel[,] BVR
        {
            get { return rvb; }
            set { rvb = value; }
        }

        /// <summary>
        /// <c>Convertir_Endian_To_Int1</c> converti un tableau de byteau format little endian pour renvoyer un entier
        /// </summary>
        public static int Convertir_Endian_To_Int1(byte[] tab)
        {
            int valeur = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                int valeurinter = tab[i];
                for (int j = 0; j < i; j++)
                {
                    valeurinter = valeurinter * 256;
                }
                valeur = valeur + valeurinter;
            }
            return valeur;
        }
        /// <summary>
        /// <c>Convertir_Int_To_Endian1</c> transforme un entier pour le mettre au format little endian sous la forme d'un tableau de byte
        /// </summary>
        public static byte[] Convertir_Int_To_Endian1(int valeur, int taille)
        {
            byte[] tab = new byte[taille];
            for (int i = taille - 1; i >= 0; i--)
            {
                int puissance = 1;
                for (int j = 0; j < i; j++)
                {
                    puissance = puissance * 256;
                }
                tab[i] = Convert.ToByte(valeur / (puissance));
                valeur = valeur % (puissance);
            }
            return tab;
        }

        /// <summary>
        /// <c>noirEtBlanc</c> transforme la matrice de pixel afin d'obtenir une image en noir et blanc
        /// </summary>
        public void noirEtBlanc()
        {
            for (int i = 0; i < rvb.GetLength(0); i++)
            {
                for (int j = 0; j < rvb.GetLength(1); j++)
                {
                    byte r = rvb[i, j].R;
                    byte v = rvb[i, j].V;
                    byte b = rvb[i, j].B;
                    byte m = Convert.ToByte((r + v + b) / 3);//on fait la moyenne
                    Pixel moyenne = new Pixel(m, m, m);
                    rvb[i, j] = moyenne;
                }
            }
        }
        /// <summary>
        /// <c>effet_miroir</c> fait l'effet miroire de notre image
        /// </summary>
        public void effet_miroir()
        {
            byte[,] mat = pixelToByte(rvb);
            this.rvb = byteToPixel(mat);
            int n = rvb.GetLength(1);
            for (int i = 0; i < rvb.GetLength(0); i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Pixel current = rvb[i, j];
                    rvb[i, j] = rvb[i, n - j - 1];//on echange par rapport au mileu les pixels
                    rvb[i, n - j - 1] = current;

                }
            }
        }
        /// <summary>
        /// <c>effet_miroir</c> renvoie la matrice de byte issue d'une matrice de pixel
        /// </summary>
        public static byte[,] pixelToByte(Pixel[,] rvb)
        {
            byte[,] res = new byte[rvb.GetLength(0) , rvb.GetLength(1) * 3];
            for(int i = 0; i < rvb.GetLength(0); i++)
            {
                for(int j = 0; j < rvb.GetLength(1); j++)
                {
                    res[i, 3*j] = rvb[i, j].B;
                    res[i, 3*j+1] = rvb[i, j].V;
                    res[i, 3*j+2] = rvb[i, j].R;
                }
            }
            return res;
        }
        /// <summary>
        /// <c>byteToPixel</c> renvoie la matrice de pixel issue d'une matrice de byte
        /// </summary>
        public static Pixel[,] byteToPixel(byte[,] mat)
        {
            Pixel[,] res = new Pixel[mat.GetLength(0) , mat.GetLength(1) / 3];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1)/3; j = j +1)
                {
                    Pixel current = new Pixel(mat[i, 3*j], mat[i, 3*j + 1], mat[i, 3*j + 2]);
                    res[i, j] = current;
                }
            }
            return res;
        }

        /// <summary>
        /// <c>taillex8</c> multiplie la taille de l'image par 8
        /// </summary>
        public void taillex8()
        {
            int a = rvb.GetLength(0);
            int b=rvb.GetLength(1);
            
            Pixel[,] res = new Pixel[8*rvb.GetLength(0),8*rvb.GetLength(1)];
            int c = res.GetLength(0);
            int k= res.GetLength(1);
            for(int i = 0; i < res.GetLength(0); i++)
            {
                for(int j=0;j< res.GetLength(1); j++)
                {
                    res[i, j] = rvb[i / 8,j/8];
                }
            }
            rvb = res;
        }
        /// <summary>
        /// <c>modifierTaille</c> multiplie la taille de l'image par un multiple passé en entrée
        /// </summary>
        public void modifierTaille(double multiple)
        {
            this.largeur =(int) Math.Round(this.largeur * multiple);
            this.hauteur = (int)Math.Round(this.hauteur * multiple);
            this.taille = this.hauteur * this.largeur * 3 + 54;
            double pas = 1 / multiple;
            Pixel[,] res = new Pixel[hauteur, largeur];
            Pixel blanc = new Pixel(0, 0, 0);
            
            for (int k = 0; k < res.GetLength(0); k++)
            {
                for (int m = 0; m < res.GetLength(1); m++)
                {
                    res[k, m] = blanc;
                }
            }
            double i = 0;
            int x = 0;
            
            
            while (x < res.GetLength(0) && (int)Math.Round(i)<rvb.GetLength(0))
            {
                double j = 0;
                int y = 0;
                while (y < res.GetLength(1) && (int)Math.Round(j) < rvb.GetLength(1))
                {
                    int pos1 = (int)Math.Round(i);
                    int pos2 = (int)Math.Round(j);
                    res[x, y] = rvb[pos1, pos2];
                    j = j + pas;
                    y = y + 1;
                }
                i = i + pas;
                x = x + 1;
            }
            rvb = res;
            
        }
        /// <summary>
        /// <c>Convolution</c> applique le produit de convolution à la matrice de pixel par le noyau passé en entré
        /// </summary>
        /*public void Convolution( double[,] noyau)
        {
            byte[,] imageByte = pixelToByte(rvb);
            
            int n = imageByte.GetLength(0);
            int m = imageByte.GetLength(1);
            byte[,] conv = new byte[n, m];
            for (int i = 1; i <n-1; i++)
            {
                for (int j = 1; j < m-1; j++)
                {
                   ;

                    double s = 0;
                    s = s + imageByte[i - 1, j - 1] * noyau[0, 0] + imageByte[i - 1, j] * noyau[0, 1] + imageByte[i - 1, j + 1] * noyau[0, 2];
                    s=s+ imageByte[i , j - 1] * noyau[1, 0] + imageByte[i , j] * noyau[1, 1] + imageByte[i, j + 1] * noyau[1, 2];
                    s=s+ imageByte[i + 1, j - 1] * noyau[2, 0] + imageByte[i + 1, j] * noyau[2, 1] + imageByte[i + 1, j + 1] * noyau[2, 2];


                    if (s > 255)
                    {
                        s = 255;
                    }
                    if (s < 0)
                    {
                        s = 0;
                    }
                    conv[i, j] = Convert.ToByte(Convert.ToInt16(s));
                   
                }
                
            }

            rvb = byteToPixel(conv);
        }*/

        public void Convolution(double[,] Noyau)
         {
            Pixel[,] imageres = new Pixel[rvb.GetLength(0),rvb.GetLength(1)];

             int n = imageres.GetLength(0);
             int m = imageres.GetLength(1);
             ;
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {

                    double b = 0;
                    double v = 0;
                    double r = 0;
                    for (int x = 0; x < Noyau.GetLength(0); x++)
                     {
                         for (int y = 0; y < Noyau.GetLength(1); y++)
                         {
                             int corl = (i + x - Noyau.GetLength(1) / 2) % n;
                             int corc = (j + y - Noyau.GetLength(0) / 2) % m;
                             if (corl < 0)
                             {
                                 corl = corl + n;
                             }
                             if (corc < 0)
                             {
                                 corc = corc + m;
                             }
                             
                            b=b+rvb[corl, corc].B* Noyau[x, y];
                            v = v + rvb[corl, corc].V * Noyau[x, y];
                            r = r + rvb[corl, corc].R * Noyau[x, y];

                        }
                     }
                     if (b > 255)
                     {
                         b = 255;
                     }
                     if (b < 0)
                     {
                         b = 0;
                     }
                    if (v > 255)
                    {
                        v = 255;
                    }
                    if (v < 0)
                    {
                        v = 0;
                    }
                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (r < 0)
                    {
                        r = 0;
                    }

                    imageres[i, j] = new Pixel(Convert.ToByte(b), Convert.ToByte(v), Convert.ToByte(r));
                 }
             }

            rvb = imageres; 

         }

        /// <summary>
        /// <c>filtre</c> applique le produit de convolution par rapport au type de filtre passé en entré
        /// </summary>
        public void filtre(string filtre)
        {
            double[,] ker = new double[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
            if (filtre.ToUpper() == "CONTOUR")
            {
                ker = new double[,] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
                

            }
            if (filtre.ToUpper() == "REPOUSSAGE")
            {
                ker = new double[,] { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
            }
            if (filtre.ToUpper() == "FLOU")
            {
                ker = new double[,] { { 1/9.0, 1/9.0, 1 / 9.0 }, { 1 / 9.0, 1 / 9.0, 1 / 9.0 }, { 1 / 9.0, 1 / 9.0, 1 / 9.0 } };
                

            }
            if (filtre.ToUpper() == "VIDE")
            {
                ker = new double[,] { { 0,0,0}, {0,1,0 }, {0,0,0 } };


            }
            Convolution(ker);
            

        }
        /// <summary>
        /// <c>rotate</c> effectue une rotation de l'image par rapport à un angle alpha passé en entré
        /// </summary>
        public void rotate(double angle)
        {
            angle = angle * 3.14159265359 / 180;//met l'angle en radian
            Pixel[,] res = new Pixel[2*rvb.GetLength(0),2*rvb.GetLength(1)];
            Pixel b= new Pixel(255,255,255);
            //rempli l'image de renvoie de pixel blanc
            for(int i= 0; i < res.GetLength(0); i++)
            {
                for(int j=0;j< res.GetLength(1); j++)
                {
                    
                    res[i, j] = b;
                }
            }
            for(int i= 0;i<rvb.GetLength(0); i++)
            {
                for(int j=0;j<rvb.GetLength(1); j++)
                {
                    int x = i - largeur / 2;
                    int y= j - hauteur / 2;
                    int newx= Convert.ToInt32(x * Math.Cos(angle) + y * Math.Sin(angle));
                    int newy= Convert.ToInt32(x * (-Math.Sin(angle)) + y * Math.Cos(angle));
                    int finalx = newx + res.GetLength(0) / 2;
                    int finaly = newy + res.GetLength(1) / 2;
                    //partie qui sert juste à cap prcq des fois ca sort de 1 pixel de l'image
                    if (finalx >= res.GetLength(0))
                    {
                        finalx= res.GetLength(0)-1;
                    }
                    if (finaly >= res.GetLength(1))
                    {
                        finaly= res.GetLength(1)-1;
                    }
                    if (finalx <0)
                    {
                        finalx = 0;
                    }
                    if (finaly <0)
                    {
                        finaly = 0;
                    }

                    res[finalx, finaly] = rvb[i, j];
                }
            }
            int n = rvb.GetLength(0);
            
            rvb = res;
        }
        /// <summary>
        /// <c>fractale_julia</c> renvoie la fractale de julia sur une résolution passé en entré en complexe c
        /// </summary>
        public void fractale_julia(int resolution,Complexe c)
        {
            this.largeur = resolution;
            this.hauteur = resolution;
            this.taille = largeur * hauteur * 3 + 54;
            Pixel[,] P = new Pixel[resolution, resolution];
            this.rvb = P;
            for(int i = 0; i < resolution; i++)
            {
                for(int j = 0; j < resolution; j++)
                {
                    Complexe z = new Complexe((j - resolution / 2)*4.0 / ( resolution), (i - resolution / 2)*4.0 / (  resolution));
                    
                    int k = z.speedConv(c);
                    if ( k== 100)
                    {
                        Pixel p = new Pixel(0, 0, 0);
                        rvb[i, j] = p;
                    }
                    else
                    {
                        Pixel p = new Pixel(0, 0, (byte)Math.Round(255.0 / k*10));
                        rvb[i, j] = p;
                    }

                }
            }
            

        }
        /// <summary>
        /// <c>Histogramme</c> crée l'image qui associe un histogramme de l'image qu'on passe en noir est blanc au cas ou elle ne l'est pas déjà
        /// </summary>
        public void Histogramme()
        {
            this.noirEtBlanc();
            int[] compteur = new int[256];
            for(int i = 0; i < this.rvb.GetLength(0); i++)
            {
                for(int j=0;j<this.rvb.GetLength(1); j++)
                {
                    compteur[this.rvb[i, j].V]++;
                }
            }
            
            for(int i = 0; i < compteur.Length; i++)
            {
                Console.WriteLine(i + " : " +compteur[i]);
            }
            Pixel[,] hist = new Pixel[1000,256];
            for(int i = 0;i < hist.GetLength(0); i++)
            {
                for(int j=0; j<hist.GetLength(1); j++)
                {
                    hist[i, j] = new Pixel(0, 0, 0);
                }
            }
            
            int m=0;
            for(int i = 0;i<compteur.Length; i++)
            {
                if (m < compteur[i])
                {
                    m=compteur[i];
                }
            }
            int coef=1 ;
            if (m / 1000.0 < 1)
            {
                coef = 1;
            }
            else
            {
                coef = Convert.ToInt32(Math.Ceiling(m / 1000.0)) ;
            }
            
            for(int j=0;j<hist.GetLength(1); j++)
            {
                for(int i= 0; i < compteur[j] / coef; i++)
                {
                    hist[i, j] = new Pixel(0, 0, 255);
                }
            }

            this.BVR = hist;
        }
        /// <summary>
        /// <c>cacherImage</c> cache l'image im2 dans l'image im1 par la technique des bits forts
        /// </summary>
        public static Pixel[,] cacherImage(MyImage im1,MyImage im2)
        {
            
            if (im1.Largeur!= im2.Largeur || im1.Hauteur!= im2.Hauteur)
            {
                Console.WriteLine("Les Images n'ont pas les mêmes dimensions!!");
                return null;
            }
            byte[,] im1byte = pixelToByte(im1.rvb);
            byte[,] im2byte = pixelToByte(im2.rvb);
            for (int i = 0; i < im1byte.GetLength(0); i++)
            {
                for(int j=0;j< im1byte.GetLength(1); j++)
                {
                    

                    im1byte[i,j] = Convert.ToByte((im1byte[i,j]/16)*16+(im2byte[i,j]/16));

                }
            }

            return byteToPixel(im1byte);
        }
        /// <summary>
        /// <c>decrypte</c> met les images cachées dans rvb  dans les images ima et imb
        /// </summary>
        public void decrypte(MyImage ima, MyImage imb)
        {
            byte[,] image_de_base = pixelToByte(this.rvb);
            byte[,] im1byte = new byte[image_de_base.GetLength(0), image_de_base.GetLength(1)];
            byte[,] im2byte = new byte[image_de_base.GetLength(0), image_de_base.GetLength(1)];
            for (int i=0;i < image_de_base.GetLength(0);i++)
            {
                for(int j=0;j < image_de_base.GetLength(1); j++)
                {
                    
                    
                    
                    im1byte[i, j] = Convert.ToByte((image_de_base[i,j]/16)*16);
                    im2byte[i, j] = Convert.ToByte((image_de_base[i,j]-(image_de_base[i,j]/16)*16)*16);
                }
            }
            ima.BVR = byteToPixel(im1byte);
            imb.BVR = byteToPixel(im2byte);
            
            
        }
        //inovation.
        /// <summary>
        /// <c>crypterpixel</c> crée une bijection aléatoire de [|0:255|] vers [|0:255|] et l'enregistre dans le fichier key.txt afin de crypter l'image 
        /// </summary>
        public void crypterpixel()
        {
            byte[] cle = new byte[256];
            List<byte> b = new List<byte>();
            for(int i = 0; i < 256; i++)
            {
                b.Add(Convert.ToByte(i));
            }
            for(int i = 0; i < 256; i++)
            {
                var rand = new Random();
                
                int index= rand.Next(b.Count);
                cle[i] = b[index];
                b.RemoveAt(index);
            }
            
            using (StreamWriter sr = new StreamWriter("key.txt"))
            {
                foreach (byte val in cle)
                {
                    sr.WriteLine(val);
                }
                
            }
            byte[,] imagebyte = pixelToByte(rvb);
            for(int i = 0; i < imagebyte.GetLength(0); i++)
            {
                for(int j = 0; j < imagebyte.GetLength(1); j++)
                {
                    int index = Convert.ToInt32(imagebyte[i, j]);
                    imagebyte[i, j] = cle[index];
                }
            }
            rvb = byteToPixel(imagebyte);
            

        }
        /// <summary>
        /// <c>decrypterPixel</c> décrypte l'image à partir du fichier key passé en paramètre.
        /// </summary>
        public void decrypterPixel(string key)
        {
            List<byte> correspondance = new List<byte>();
            using (StreamReader sr = new StreamReader(key))
            {
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    
                    correspondance.Add(Convert.ToByte(line));
                }
            }
            byte[,] image_byte = pixelToByte(rvb);
            for(int i = 0; i < image_byte.GetLength(0); i++)
            {
                for(int j = 0; j < image_byte.GetLength(1); j++)
                {
                    byte index = 0;
                    for(int k = 0; k < correspondance.Count(); k++)
                    {
                        if (image_byte[i, j] == correspondance[k])
                        {
                            index = Convert.ToByte(k);
                            break;
                        }
                    }
                    image_byte[i, j] = index;

                }
            }
            rvb = byteToPixel(image_byte);
        }
        /// <summary>
        /// <c>filtre_couleur</c> filtre l'image par un filtre de couleur passé en paramètre, comme rouge, vert, jaune....
        /// </summary>
        public void filtre_couleur(string couleur)
        {
            for (int i = 0; i < rvb.GetLength(0); i++)
            {
                for (int j = 0; j < rvb.GetLength(1); j++)
                {
                    if (couleur.ToUpper() == "ROUGE")
                    {
                        rvb[i, j].B = 0;
                        rvb[i, j].V = 0;
                    }
                    if (couleur.ToUpper() == "VERT")
                    {
                        rvb[i, j].B = 0;
                        rvb[i, j].R = 0;
                    }
                    if (couleur.ToUpper() == "BLEU")
                    {
                        rvb[i, j].R = 0;
                        rvb[i, j].V = 0;
                    }
                    if (couleur.ToUpper() == "MAGENTA")
                    {
                        
                        rvb[i, j].V = 0;
                    }
                    if (couleur.ToUpper() == "CYAN")
                    {
                        rvb[i, j].R = 0;
                        
                    }
                    if (couleur.ToUpper() == "JAUNE")
                    {
                        rvb[i, j].B = 0;

                    }

                }
            }
        }


        /// <summary>
        /// <c>From_Image_To_File</c> écrit dans le fichier filename l'image
        /// </summary>
        public void From_Image_To_File(string filename)
          {
            int h = rvb.GetLength(0);
            int l=rvb.GetLength(1);
            byte[] res = new byte[54 + 3*h*l];
            
              
              if (this.Type == "BM")
              {
                  res[0] = 66;
                  res[1] = 77;

              }
           
            byte[] taille = Convertir_Int_To_Endian1(3 * h * l + 54, 4);//peut etre enlever le 54  
            


            for (int i = 0; i < taille.Length; i++)
              {
                
                  res[i+2]=taille[i];
              }

              res[10] = 54;//ici 54
              res[14]= 40;//ici 40
              res[15]= 0;
              res[16] = 0;
              res[17] = 0;
            byte[] largeur= Convertir_Int_To_Endian1(l,4);//ici avant l
            
            for (int i = 0;i < largeur.Length; i++)
              {
                  res[i+18]=largeur[i];

              }
            byte[] hauteur= Convertir_Int_To_Endian1(h,4);//ici avant h
            
            for (int i = 0; i<hauteur.Length; i++)
              {
                  res[i+22]=hauteur[i];
              }
              res[26] = 1;
              res[27] = 0;
            
            
              res[28] = 24;
              res[34] = 176;
              res[35] = 4;
            

            for (int i = 0; i < this.rvb.GetLength(0); i++)
            {
                for (int j = 0; j < this.rvb.GetLength(1); j++)
                {
                    res[54+i * this.nbPixel * l + j * this.nbPixel]= rvb[i, j].B;
                    res[54+i * this.nbPixel * l + j * this.nbPixel+1]= rvb[i, j].V;
                    res[54+i * this.nbPixel * l + j * this.nbPixel + 2] = rvb[i, j].R;


                }
            }

           

            
              File.WriteAllBytes(filename + ".bmp", res);
              Console.WriteLine("saved");
            


        }
        public void afficherbyte()
        {
            for (int i = 0; i < this.rvb.GetLength(0); i++)
            {
                for(int j = 0; j < this.rvb.GetLength(1); j++)
                {
                    Console.Write(this.rvb[i, j].toString());
                }
                Console.WriteLine();
            }
        }
    }
}
