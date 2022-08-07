using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsRi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyImage general;
        private void button1_Click(object sender, EventArgs e)
        {
           
            QrCode qr = new QrCode(textQr.Text);
            pic.ImageLocation = "QR.bmp";
            
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void textQr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonNuance_Click(object sender, EventArgs e)
        {
            general.noirEtBlanc();
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonMiroire_Click(object sender, EventArgs e)
        {
            general.effet_miroir();
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonTaille_Click(object sender, EventArgs e)
        {
            
            try
            {
                double multiple = Convert.ToDouble(textTaille.Text);
                general.modifierTaille(multiple);
                general.From_Image_To_File("sortie");
                pic.ImageLocation = "sortie.bmp";
            }
            catch
            {
                pic.ImageLocation = "erreur.bmp";
            }
        }

        private void buttonFlou_Click(object sender, EventArgs e)
        {
            general.filtre("FLOU");
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonRepoussage_Click(object sender, EventArgs e)
        {
            general.filtre("REPOUSSAGE");
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonContour_Click(object sender, EventArgs e)
        {
            general.filtre("CONTOUR");
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            try
            {
                double angle = Convert.ToDouble(textAngle.Text);
                general.rotate(angle);
                general.From_Image_To_File("sortie");
                pic.ImageLocation = "sortie.bmp";
            }
            catch
            {
                pic.ImageLocation = "erreur.bmp";
            }
        }

        private void buttonFractale_Click(object sender, EventArgs e)
        {
            int resolution = Convert.ToInt32(textResolution.Text);
            double reel = Convert.ToDouble(textReel.Text);
            double imaginaire = Convert.ToDouble(textImaginaire.Text);
            Complexe c = new Complexe(reel, imaginaire);
            general = new MyImage("unPixel.bmp");
            general.fractale_julia(resolution, c);
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonHisto_Click(object sender, EventArgs e)
        {
            general.Histogramme();
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";

        }

        private void textResolution_TextChanged(object sender, EventArgs e)
        {

        }

        private void textReel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textImaginaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAngle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lyon_Click(object sender, EventArgs e)
        {
            general = new MyImage("lyon.bmp");
            pic.ImageLocation = "lyon.bmp";
        }

        private void avion_Click(object sender, EventArgs e)
        {
            general = new MyImage("avion.bmp");
            pic.ImageLocation = "avion.bmp";
        }

        private void Coco_Click(object sender, EventArgs e)
        {
            general = new MyImage("coco.bmp");
            pic.ImageLocation = "coco.bmp";
        }

        private void taj_Click(object sender, EventArgs e)
        {
            general = new MyImage("taj.bmp");
            
            pic.ImageLocation = "taj.bmp";
        }

        private void textTaille_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAfficherW_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("sortie.bmp") { UseShellExecute = true });
        }

        private void buttonFiltre_Click(object sender, EventArgs e)
        {
            string Filtre = textFiltre.Text;
            Filtre = Filtre.ToUpper();
            if(Filtre!="CYAN" && Filtre!="JAUNE"&& Filtre!="MAGENTA"&&Filtre!="ROUGE"&& Filtre!="BLEU" && Filtre != "VERT")
            {
                pic.ImageLocation = "erreur.bmp";
            }
            else
            {
                
                general.filtre_couleur(Filtre);
                general.From_Image_To_File("sortie");
                pic.ImageLocation = "sortie.bmp";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCrypterPixel_Click(object sender, EventArgs e)
        {
            general.crypterpixel();
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttondecrypterPixel_Click(object sender, EventArgs e)
        {
            general.decrypterPixel(textBox1.Text);
            general.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonSortie_Click(object sender, EventArgs e)
        {
            general = new MyImage("sortie.bmp");
            pic.ImageLocation = "sortie.bmp";
        }

        private void buttonsahbg_Click(object sender, EventArgs e)
        {
            general = new MyImage("sahBG.bmp");
            pic.ImageLocation = "sahBG.bmp";
        }

        private void buttonCacher_Click(object sender, EventArgs e)
        {
            MyImage im1 = new MyImage(textBox2.Text);
            MyImage im2 = new MyImage(textBox3.Text);
            MyImage im3 = new MyImage("unPixel.bmp");
            im3.BVR=MyImage.cacherImage(im1, im2);
            im3.From_Image_To_File("sortie");
            pic.ImageLocation = "sortie.bmp";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeca_Click(object sender, EventArgs e)
        {
            
            MyImage image = new MyImage("sortie.bmp");
            MyImage im1 = new MyImage("sortie.bmp");
            MyImage im2 = new MyImage("sortie.bmp");
            image.decrypte(im1, im2);

            im1.From_Image_To_File("image1");
            im2.From_Image_To_File("image2");
        }
    }
}
