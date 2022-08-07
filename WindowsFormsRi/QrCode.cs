using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsRi
{
    public class QrCode
    {
        private char[,] base1 = new char[,] 
        {
            { '1','1','1','1','1','1','1','0','0','b','n','b','n','0','1','1','1','1','1','1','1'},
            { '1','0','0','0','0','0','1','0','0','n','b','n','b','0','1','0','0','0','0','0','1'},
            { '1','0','1','1','1','0','1','0','1','b','n','b','n','0','1','0','1','1','1','0','1'},
            { '1','0','1','1','1','0','1','0','0','n','b','n','b','0','1','0','1','1','1','0','1'},
            { '1','0','1','1','1','0','1','0','0','b','n','b','n','0','1','0','1','1','1','0','1'},
            { '1','0','0','0','0','0','1','0','0','n','b','n','b','0','1','0','0','0','0','0','1'},
            { '1','1','1','1','1','1','1','0','1','0','1','0','1','0','1','1','1','1','1','1','1'},
            { '0','0','0','0','0','0','0','0','1','n','b','n','b','0','0','0','0','0','0','0','0'},
            {'1' ,'1','1','0','1','1','1','1','1','b','n','b','n','1','1','0','0','0','1','0','0'},
            {'b' ,'n','b','n','b','n','0','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            {'n' ,'b','n','b','n','b','1','b','n','b','n','b','n','b','n','b','n','b','n','b','n'},
            {'b' ,'n','b','n','b','n','0','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            {'n' ,'b','n','b','n','b','1','b','n','b','n','b','n','b','n','b','n','b','n','b','n'},
            { '0','0','0','0','0','0','0','0','1','n','b','n','b','n','b','n','b','n','b','n','b'},
            { '1','1','1','1','1','1','1','0','1','b','n','b','n','b','n','b','n','b','n','b','n'},
            { '1','0','0','0','0','0','1','0','1','n','b','n','b','n','b','n','b','n','b','n','b'},
            { '1','0','1','1','1','0','1','0','1','b','n','b','n','b','n','b','n','b','n','b','n'},
            { '1','0','1','1','1','0','1','0','0','n','b','n','b','n','b','n','b','n','b','n','b'},
            { '1','0','1','1','1','0','1','0','1','b','n','b','n','b','n','b','n','b','n','b','n'},
            { '1','0','0','0','0','0','1','0','1','n','b','n','b','n','b','n','b','n','b','n','b'},
            { '1','1','1','1','1','1','1','0','1','b','n','b','n','b','n','b','n','b','n','b','n'},
        };
        private char[,] base2 = new char[,]
        {
            { '1','1','1','1','1','1','1','0','0','b','n','b','n','b','n','b','n','0','1','1','1','1','1','1','1'},
            { '1','0','0','0','0','0','1','0','0','n','b','n','b','n','b','n','b','0','1','0','0','0','0','0','1'},
            { '1','0','1','1','1','0','1','0','1','b','n','b','n','b','n','b','n','0','1','0','1','1','1','0','1'},
            { '1','0','1','1','1','0','1','0','0','n','b','n','b','n','b','n','b','0','1','0','1','1','1','0','1'},
            { '1','0','1','1','1','0','1','0','0','b','n','b','n','b','n','b','n','0','1','0','1','1','1','0','1'},
            { '1','0','0','0','0','0','1','0','0','n','b','n','b','n','b','n','b','0','1','0','0','0','0','0','1'},
            { '1','1','1','1','1','1','1','0','1','0','1','0','1','0','1','0','1','0','1','1','1','1','1','1','1'},
            { '0','0','0','0','0','0','0','0','1','n','b','n','b','n','b','n','b','0','0','0','0','0','0','0','0'},
            {'1' ,'1','1','0','1','1','1','1','1','b','n','b','n','b','n','b','n','1','1','0','0','0','1','0','0'},
            {'b' ,'n','b','n','b','n','0','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            {'n' ,'b','n','b','n','b','1','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n'},
            {'b' ,'n','b','n','b','n','0','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            {'n' ,'b','n','b','n','b','1','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n'},
            {'0' ,'n','b','n','b','n','0','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            {'1' ,'0','n','b','n','b','1','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n'},
            {'0' ,'1','b','n','b','n','0','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            {'1' ,'0','n','b','n','b','1','b','n','b','n','b','n','b','n','b','1','1','1','1','1','b','n','b','n'},
            { '0','0','0','0','0','0','0','0','1','n','b','n','b','n','b','n','1','0','0','0','1','n','b','n','b'},
            { '1','1','1','1','1','1','1','0','1','b','n','b','n','b','n','b','1','0','1','0','1','b','n','b','n'},
            { '1','0','0','0','0','0','1','0','1','n','b','n','b','n','b','n','1','0','0','0','1','n','b','n','b'},
            { '1','0','1','1','1','0','1','0','1','b','n','b','n','b','n','b','1','1','1','1','1','b','n','b','n'},
            { '1','0','1','1','1','0','1','0','0','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            { '1','0','1','1','1','0','1','0','1','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n'},
            { '1','0','0','0','0','0','1','0','1','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b'},
            { '1','1','1','1','1','1','1','0','1','b','n','b','n','b','n','b','n','b','n','b','n','b','n','b','n'},
        };
        private MyImage QR= new MyImage("unPixel.bmp");
        /// <summary>
        /// <c>QrCode</c> construit le QR code à partir de la phrase passé en paramètre et l'enregisre dans le fichier QR.bmp
        /// </summary>
        public QrCode( string phrase)
        {


            phrase = phrase.ToUpper();

            if (phrase.Length <= 19)
            {

                this.QR = new MyImage("QR_V1.bmp");// on instancie le QR code
                string sentence = code_phrase(phrase,"V1");// on crée la séquence de bits à partir de la phrase sentence
               
                string[,] charQR = placerbits(sentence, base1);// on crée la matrice charQR qui a les bien placé

               
                
                this.QR.BVR = ConvertirCharToPixel(charQR);// on converti notre matrice de char en matrice de pixel et on l'associe à notre matrice de pixel de notre objet MyImage
                this.QR.taillex8(); // on multiplie la taille par  pour que ça soit lisible par windows
                //QR.rotate(0);
                QR.From_Image_To_File("QR");// on enregistre l'image
            }
            else if (phrase.Length <= 34 && phrase.Length > 19)
            {
                this.QR = new MyImage("QR_V2.bmp");
                string sentence = code_phrase(phrase, "V2");
                
                string[,] charQR = placerbits(sentence, base2);
                this.QR.BVR = ConvertirCharToPixel(charQR);
                this.QR.taillex8();
                //QR.rotate(0);
                QR.From_Image_To_File("QR");
            }
            else
            {
                Console.WriteLine("phrase trop longue impossible à écrire");
            }
        }
        /// <summary>
        /// <c>get_alphanum</c> permet de renvoyer la valeur alphanumérique du caractère en entré
        /// </summary>
        public static int get_alphanum(Char c)
        {
            
            Char[] alphanum = new Char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '$', '%', '*', '+', '-', '.', '/', ':' };
            for(int i = 0; i < alphanum.Length; i++)
            {
                if (c == alphanum[i])
                {
                    return i;
                }
            }
            Console.WriteLine("erreur , pas dans les propositions de alphanum");
            return -1;
        }
        /// <summary>
        /// <c>completeZero</c> permet de completer avec des 0  s de sorte à ce que ça fasse la bonne longueur length
        /// </summary>
        public static string completeZero(string s,int length)//permet de completer avec des 0 de sorte à ce que ça fasse la bonne longueur
        {
            int remaining = length - s.Length;
            for(int i = 0; i < remaining; i++)
            {
                s = "0" + s;
            }
            return s;
        }
        /// <summary>
        /// <c>ConvertirCharToPixel</c> converti une matrice de string en matrice de pixel par la conversion suivante: 1-> pixel noir 0-> pixel blanc
        /// </summary>
        public static Pixel[,] ConvertirCharToPixel(string[,] c)
        {
            Pixel[,] mat = new Pixel[c.GetLength(0), c.GetLength(1)];
            Pixel blanc = new Pixel(255, 255, 255);
            Pixel noir = new Pixel(0, 0, 0);
            Pixel b = new Pixel(0, 0, 255);

            
            for (int i = 0; i <c.GetLength(0) ; i++)
            {
                for (int j = 0; j <c.GetLength(1) ; j++)
                {
                    Console.Write(c[i, j] + " ");
                    if (c[i, j] == "1")
                    {
                        mat[c.GetLength(0)-i-1, j] = noir;
                    }
                    if (c[i, j] == "0")
                    {
                        mat[c.GetLength(0) - i-1, j] = blanc;
                    }
                    if (c[i, j] == "_")
                    {
                        mat[c.GetLength(0) - i-1, j] = b;
                       
                    }

                }
                
            }
            
            return mat;
        }
        /// <summary>
        /// <c>code_phrase</c> prend en argument la version et la phrase et renvoie la phrase encodé au format QRcode
        /// </summary>
        public static string code_phrase(string phrase, string version)
        {
            
            string modeIndicator = "0010";//indicateur de l'alphanumérique
            string caractereCountIndicator= Convert.ToString(phrase.Length, 2);
            
            caractereCountIndicator = completeZero(caractereCountIndicator, 9);//met le nombre de caractere avec les 0 manquant
           
            string phrase_binaire = modeIndicator+caractereCountIndicator;
            string phraseDecomp = "";
            //partie qui renvoie la chaine de bit de la phrase en elle même
            if (phrase.Length % 2 == 0)
            {
                phraseDecomp = phrase;
            }
            else
            {
                phraseDecomp = phrase.Substring(0,phrase.Length-1);
            }


            for (int i = 0; i < phraseDecomp.Length; i = i + 2)
            {
                int val = get_alphanum(phraseDecomp[i]) * 45 + get_alphanum(phraseDecomp[i + 1]);
                string binaryVal = completeZero(Convert.ToString(val, 2), 11);
                
                phrase_binaire = phrase_binaire + binaryVal;
            }

            //on sépare le cas àù la phrase est impaire
            if (phrase.Length % 2 == 1)
            {
                int val = get_alphanum(phrase[phrase.Length - 1]);
                string binaryVal= completeZero(Convert.ToString(val, 2), 6);
                
                phrase_binaire = phrase_binaire  + binaryVal;
            }
            //ajout de la terminaison
            int restant = 0;
            if (version == "V1")
            {
                restant = 152 - phrase_binaire.Length;
            }
            if (version == "V2")
            {
                restant = 272 - phrase_binaire.Length;
            }
            if (restant >= 4)
            {
                phrase_binaire = phrase_binaire + "0000";
                
            }
            else
            {
                for (int i = 0; i < restant; i++)
                {
                    phrase_binaire = phrase_binaire + "0";
                }
            }
           
            
            //ajouter des 0 pour faire un multiple de 8

            int restant0 = (8-phrase_binaire.Length % 8)%8;
            
            for(int i = 0; i < restant0; i++)
            {
                phrase_binaire = phrase_binaire + "0";
            }

            //ajouter les fameux bits 236 et 17 pour arriver à la bonne taille en fonction de la version
            int octetRestant = 0;
            if (version == "V1")
            {
                octetRestant = (152 - phrase_binaire.Length)/8;
                
            }
            if (version == "V2")
            {
                octetRestant = (272 - phrase_binaire.Length) / 8;
            }
            string b236 = "11101100";
            string b17 = "00010001";
            string ajouter = "11101100";
            
            for (int i = 0; i < octetRestant; i++)
            {
                phrase_binaire = phrase_binaire + ajouter;
                if (ajouter == b236)
                {
                    ajouter = "00010001";
                }
                else if (ajouter == b17)
                {
                    ajouter = "11101100";
                }
            }
            

            //ajouter le code de correction d'erreur 

            byte[] test = new byte[phrase_binaire.Length/8];
            for(int i = 0; i < phrase_binaire.Length / 8; i = i + 1)
            {
                string octet= phrase_binaire.Substring(8*i, 8);
                int o= Convert.ToInt32(octet, 2);
                
                test[i] = Convert.ToByte(o);
                
            }
            
            byte[] result = ReedSolomonAlgorithm.Encode(test, 7, ErrorCorrectionCodeType.QRCode);
            if (version == "V1")
            {
                result = ReedSolomonAlgorithm.Encode(test, 7, ErrorCorrectionCodeType.QRCode);
            }
            else if (version == "V2")
            {
                result = ReedSolomonAlgorithm.Encode(test, 10, ErrorCorrectionCodeType.QRCode);
            }
            foreach (byte val in result)
            {
                
                phrase_binaire = phrase_binaire + completeZero(Convert.ToString(val, 2), 8);
            }
            
            

            return phrase_binaire;
        }
        /// <summary>
        /// <c>placerbits</c> place les bits de la sentence sur la matrice de char baseVersion pour renvoyer la matrice de string avec tout de bien placé
        /// </summary>
        public static string[,] placerbits(string sentence,char[,] baseVersion)
        {
            string[,] res = new string[baseVersion.GetLength(0),baseVersion.GetLength(1)];
            for(int y = 0; y < baseVersion.GetLength(0); y++)
            {
                for(int x=0; x < baseVersion.GetLength(1); x++)
                {
                    res[y, x] = Convert.ToString(baseVersion[y, x]);
                }
            }
            int index = 0;
            int i = baseVersion.GetLength(0)-1;
            int j = baseVersion.GetLength(1)-1;
            
            string currentmove = "UP";
            while (index < sentence.Length)
            {

                if (j == 6)
                {
                    break;
                }
                if (res[i, j] != "1" && res[i, j] != "0")
                {
                    string placer = "-";
                    if (res[i, j] == "b")
                    {
                        placer = Convert.ToString(sentence[index]);
                        
                    }
                    else if (res[i, j] == "n")
                    {
                        if (sentence[index] == '1')
                        {
                            placer = "0";
                        }
                        else 
                        {
                            placer = "1";
                        }

                    }
                    

                    res[i, j] = placer;
                    

                    index++;
                }
               
                if (currentmove == "UP")
                {
                   
                    if (j % 2 == 0)
                    {
                        j = j - 1;
                    }
                    else
                    {
                        
                        if (i - 1 >= 0)
                        {
                            j = j + 1;
                            i = i - 1;
                        }
                        else
                        {
                            j = j - 1;
                            currentmove = "DOWN";
                        }
                    }
                }
                else if (currentmove == "DOWN")
                {
                    if (j % 2 == 0)
                    {
                        j = j - 1;
                    }
                    else
                    {
                        if (i + 1 < res.GetLength(0))
                        {
                            j = j + 1;
                            i = i + 1;
                        }
                        else
                        {
                            j = j - 1;
                            currentmove = "UP";
                        }
                    }
                }
            }
            currentmove = "DOWN";
            j = 5;
            i = 1;
            while (index < sentence.Length)
            {
               
                if (res[i, j] != "1" && res[i, j] != "0")
                {
                    string placer = "-";
                    if (res[i, j] == "b")
                    {
                        placer = Convert.ToString(sentence[index]);

                    }
                    else if (res[i, j] == "n")
                    {
                        if (sentence[index] == '1')
                        {
                            placer = "0";
                        }
                        else
                        {
                            placer = "1";
                        }

                    }


                    res[i, j] = placer;
                    

                    index++;
                }

                if (currentmove == "UP")
                {

                    if (j % 2 == 1)
                    {
                        j = j - 1;
                    }
                    else
                    {

                        if (i - 1 >= 0)
                        {
                            j = j + 1;
                            i = i - 1;
                        }
                        else
                        {
                            j = j - 1;
                            currentmove = "DOWN";
                        }
                    }
                }
                else if (currentmove == "DOWN")
                {
                    if (j % 2 == 1)
                    {
                        j = j - 1;
                    }
                    else
                    {
                        if (i + 1 < res.GetLength(0))
                        {
                            j = j + 1;
                            i = i + 1;
                        }
                        else
                        {
                            j = j - 1;
                            currentmove = "UP";
                        }
                    }
                }
            }

            return res;
        }
    }
}
