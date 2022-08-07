
namespace WindowsFormsRi
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQr = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.textQr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNuance = new System.Windows.Forms.Button();
            this.buttonMiroire = new System.Windows.Forms.Button();
            this.buttonTaille = new System.Windows.Forms.Button();
            this.buttonFlou = new System.Windows.Forms.Button();
            this.buttonRepoussage = new System.Windows.Forms.Button();
            this.buttonContour = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.textAngle = new System.Windows.Forms.TextBox();
            this.buttonFractale = new System.Windows.Forms.Button();
            this.textResolution = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textReel = new System.Windows.Forms.TextBox();
            this.textImaginaire = new System.Windows.Forms.TextBox();
            this.buttonHisto = new System.Windows.Forms.Button();
            this.buttonCrypterPixel = new System.Windows.Forms.Button();
            this.buttondecrypterPixel = new System.Windows.Forms.Button();
            this.buttonFiltre = new System.Windows.Forms.Button();
            this.textFiltre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lyon = new System.Windows.Forms.Button();
            this.avion = new System.Windows.Forms.Button();
            this.Coco = new System.Windows.Forms.Button();
            this.taj = new System.Windows.Forms.Button();
            this.textTaille = new System.Windows.Forms.TextBox();
            this.buttonAfficherW = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSortie = new System.Windows.Forms.Button();
            this.buttonsahbg = new System.Windows.Forms.Button();
            this.buttonCacher = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDeca = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQr
            // 
            this.buttonQr.Location = new System.Drawing.Point(11, 522);
            this.buttonQr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQr.Name = "buttonQr";
            this.buttonQr.Size = new System.Drawing.Size(83, 58);
            this.buttonQr.TabIndex = 0;
            this.buttonQr.Text = "buttonQr";
            this.buttonQr.UseVisualStyleBackColor = true;
            this.buttonQr.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(0, 30);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(503, 488);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // textQr
            // 
            this.textQr.Location = new System.Drawing.Point(98, 522);
            this.textQr.Margin = new System.Windows.Forms.Padding(2);
            this.textQr.Multiline = true;
            this.textQr.Name = "textQr";
            this.textQr.Size = new System.Drawing.Size(405, 58);
            this.textQr.TabIndex = 2;
            this.textQr.TextChanged += new System.EventHandler(this.textQr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "affichage :";
            // 
            // buttonNuance
            // 
            this.buttonNuance.Location = new System.Drawing.Point(544, 76);
            this.buttonNuance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuance.Name = "buttonNuance";
            this.buttonNuance.Size = new System.Drawing.Size(155, 38);
            this.buttonNuance.TabIndex = 5;
            this.buttonNuance.Text = "Nuance de noir et blanc";
            this.buttonNuance.UseVisualStyleBackColor = true;
            this.buttonNuance.Click += new System.EventHandler(this.buttonNuance_Click);
            // 
            // buttonMiroire
            // 
            this.buttonMiroire.Location = new System.Drawing.Point(740, 76);
            this.buttonMiroire.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMiroire.Name = "buttonMiroire";
            this.buttonMiroire.Size = new System.Drawing.Size(155, 38);
            this.buttonMiroire.TabIndex = 6;
            this.buttonMiroire.Text = "Effet Miroire";
            this.buttonMiroire.UseVisualStyleBackColor = true;
            this.buttonMiroire.Click += new System.EventHandler(this.buttonMiroire_Click);
            // 
            // buttonTaille
            // 
            this.buttonTaille.Location = new System.Drawing.Point(928, 76);
            this.buttonTaille.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTaille.Name = "buttonTaille";
            this.buttonTaille.Size = new System.Drawing.Size(155, 38);
            this.buttonTaille.TabIndex = 7;
            this.buttonTaille.Text = "Modifier Taille:multiple:";
            this.buttonTaille.UseVisualStyleBackColor = true;
            this.buttonTaille.Click += new System.EventHandler(this.buttonTaille_Click);
            // 
            // buttonFlou
            // 
            this.buttonFlou.Location = new System.Drawing.Point(544, 157);
            this.buttonFlou.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFlou.Name = "buttonFlou";
            this.buttonFlou.Size = new System.Drawing.Size(155, 35);
            this.buttonFlou.TabIndex = 8;
            this.buttonFlou.Text = "Convolution Flou";
            this.buttonFlou.UseVisualStyleBackColor = true;
            this.buttonFlou.Click += new System.EventHandler(this.buttonFlou_Click);
            // 
            // buttonRepoussage
            // 
            this.buttonRepoussage.Location = new System.Drawing.Point(740, 157);
            this.buttonRepoussage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRepoussage.Name = "buttonRepoussage";
            this.buttonRepoussage.Size = new System.Drawing.Size(155, 35);
            this.buttonRepoussage.TabIndex = 9;
            this.buttonRepoussage.Text = "Convolution Repoussage";
            this.buttonRepoussage.UseVisualStyleBackColor = true;
            this.buttonRepoussage.Click += new System.EventHandler(this.buttonRepoussage_Click);
            // 
            // buttonContour
            // 
            this.buttonContour.Location = new System.Drawing.Point(928, 157);
            this.buttonContour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContour.Name = "buttonContour";
            this.buttonContour.Size = new System.Drawing.Size(155, 35);
            this.buttonContour.TabIndex = 10;
            this.buttonContour.Text = "Convolution Contour";
            this.buttonContour.UseVisualStyleBackColor = true;
            this.buttonContour.Click += new System.EventHandler(this.buttonContour_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(544, 235);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(155, 34);
            this.buttonRotate.TabIndex = 11;
            this.buttonRotate.Text = "Rotation : angle(en deg):";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // textAngle
            // 
            this.textAngle.Location = new System.Drawing.Point(725, 235);
            this.textAngle.Margin = new System.Windows.Forms.Padding(2);
            this.textAngle.Multiline = true;
            this.textAngle.Name = "textAngle";
            this.textAngle.Size = new System.Drawing.Size(150, 34);
            this.textAngle.TabIndex = 12;
            this.textAngle.TextChanged += new System.EventHandler(this.textAngle_TextChanged);
            // 
            // buttonFractale
            // 
            this.buttonFractale.Location = new System.Drawing.Point(544, 307);
            this.buttonFractale.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFractale.Name = "buttonFractale";
            this.buttonFractale.Size = new System.Drawing.Size(155, 41);
            this.buttonFractale.TabIndex = 13;
            this.buttonFractale.Text = "Fractale";
            this.buttonFractale.UseVisualStyleBackColor = true;
            this.buttonFractale.Click += new System.EventHandler(this.buttonFractale_Click);
            // 
            // textResolution
            // 
            this.textResolution.Location = new System.Drawing.Point(725, 307);
            this.textResolution.Margin = new System.Windows.Forms.Padding(2);
            this.textResolution.Multiline = true;
            this.textResolution.Name = "textResolution";
            this.textResolution.Size = new System.Drawing.Size(150, 41);
            this.textResolution.TabIndex = 14;
            this.textResolution.TextChanged += new System.EventHandler(this.textResolution_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Résolution:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(945, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "réel du complexe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1083, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "imaginaire du complexe:";
            // 
            // textReel
            // 
            this.textReel.Location = new System.Drawing.Point(933, 307);
            this.textReel.Margin = new System.Windows.Forms.Padding(2);
            this.textReel.Multiline = true;
            this.textReel.Name = "textReel";
            this.textReel.Size = new System.Drawing.Size(115, 41);
            this.textReel.TabIndex = 18;
            this.textReel.TextChanged += new System.EventHandler(this.textReel_TextChanged);
            // 
            // textImaginaire
            // 
            this.textImaginaire.Location = new System.Drawing.Point(1076, 307);
            this.textImaginaire.Margin = new System.Windows.Forms.Padding(2);
            this.textImaginaire.Multiline = true;
            this.textImaginaire.Name = "textImaginaire";
            this.textImaginaire.Size = new System.Drawing.Size(115, 41);
            this.textImaginaire.TabIndex = 19;
            this.textImaginaire.TextChanged += new System.EventHandler(this.textImaginaire_TextChanged);
            // 
            // buttonHisto
            // 
            this.buttonHisto.Location = new System.Drawing.Point(544, 384);
            this.buttonHisto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHisto.Name = "buttonHisto";
            this.buttonHisto.Size = new System.Drawing.Size(155, 41);
            this.buttonHisto.TabIndex = 20;
            this.buttonHisto.Text = "Histogramme";
            this.buttonHisto.UseVisualStyleBackColor = true;
            this.buttonHisto.Click += new System.EventHandler(this.buttonHisto_Click);
            // 
            // buttonCrypterPixel
            // 
            this.buttonCrypterPixel.Location = new System.Drawing.Point(812, 384);
            this.buttonCrypterPixel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCrypterPixel.Name = "buttonCrypterPixel";
            this.buttonCrypterPixel.Size = new System.Drawing.Size(155, 41);
            this.buttonCrypterPixel.TabIndex = 21;
            this.buttonCrypterPixel.Text = "Crypter Pixel";
            this.buttonCrypterPixel.UseVisualStyleBackColor = true;
            this.buttonCrypterPixel.Click += new System.EventHandler(this.buttonCrypterPixel_Click);
            // 
            // buttondecrypterPixel
            // 
            this.buttondecrypterPixel.Location = new System.Drawing.Point(979, 384);
            this.buttondecrypterPixel.Margin = new System.Windows.Forms.Padding(2);
            this.buttondecrypterPixel.Name = "buttondecrypterPixel";
            this.buttondecrypterPixel.Size = new System.Drawing.Size(155, 41);
            this.buttondecrypterPixel.TabIndex = 22;
            this.buttondecrypterPixel.Text = "Décrypter Pixel";
            this.buttondecrypterPixel.UseVisualStyleBackColor = true;
            this.buttondecrypterPixel.Click += new System.EventHandler(this.buttondecrypterPixel_Click);
            // 
            // buttonFiltre
            // 
            this.buttonFiltre.Location = new System.Drawing.Point(544, 476);
            this.buttonFiltre.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFiltre.Name = "buttonFiltre";
            this.buttonFiltre.Size = new System.Drawing.Size(155, 42);
            this.buttonFiltre.TabIndex = 23;
            this.buttonFiltre.Text = "Filtre";
            this.buttonFiltre.UseVisualStyleBackColor = true;
            this.buttonFiltre.Click += new System.EventHandler(this.buttonFiltre_Click);
            // 
            // textFiltre
            // 
            this.textFiltre.Location = new System.Drawing.Point(725, 476);
            this.textFiltre.Margin = new System.Windows.Forms.Padding(2);
            this.textFiltre.Multiline = true;
            this.textFiltre.Name = "textFiltre";
            this.textFiltre.Size = new System.Drawing.Size(150, 42);
            this.textFiltre.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Filtre au choix: rouge bleu vert cyan jaune magenta";
            // 
            // lyon
            // 
            this.lyon.Location = new System.Drawing.Point(544, 30);
            this.lyon.Margin = new System.Windows.Forms.Padding(2);
            this.lyon.Name = "lyon";
            this.lyon.Size = new System.Drawing.Size(69, 27);
            this.lyon.TabIndex = 26;
            this.lyon.Text = "Lyon";
            this.lyon.UseVisualStyleBackColor = true;
            this.lyon.Click += new System.EventHandler(this.lyon_Click);
            // 
            // avion
            // 
            this.avion.Location = new System.Drawing.Point(662, 30);
            this.avion.Margin = new System.Windows.Forms.Padding(2);
            this.avion.Name = "avion";
            this.avion.Size = new System.Drawing.Size(69, 27);
            this.avion.TabIndex = 27;
            this.avion.Text = "Avion";
            this.avion.UseVisualStyleBackColor = true;
            this.avion.Click += new System.EventHandler(this.avion_Click);
            // 
            // Coco
            // 
            this.Coco.Location = new System.Drawing.Point(783, 30);
            this.Coco.Margin = new System.Windows.Forms.Padding(2);
            this.Coco.Name = "Coco";
            this.Coco.Size = new System.Drawing.Size(69, 27);
            this.Coco.TabIndex = 28;
            this.Coco.Text = "Coco";
            this.Coco.UseVisualStyleBackColor = true;
            this.Coco.Click += new System.EventHandler(this.Coco_Click);
            // 
            // taj
            // 
            this.taj.Location = new System.Drawing.Point(898, 30);
            this.taj.Margin = new System.Windows.Forms.Padding(2);
            this.taj.Name = "taj";
            this.taj.Size = new System.Drawing.Size(69, 27);
            this.taj.TabIndex = 29;
            this.taj.Text = "Taj";
            this.taj.UseVisualStyleBackColor = true;
            this.taj.Click += new System.EventHandler(this.taj_Click);
            // 
            // textTaille
            // 
            this.textTaille.Location = new System.Drawing.Point(1095, 76);
            this.textTaille.Margin = new System.Windows.Forms.Padding(2);
            this.textTaille.Multiline = true;
            this.textTaille.Name = "textTaille";
            this.textTaille.Size = new System.Drawing.Size(150, 38);
            this.textTaille.TabIndex = 30;
            this.textTaille.TextChanged += new System.EventHandler(this.textTaille_TextChanged);
            // 
            // buttonAfficherW
            // 
            this.buttonAfficherW.Location = new System.Drawing.Point(11, 594);
            this.buttonAfficherW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAfficherW.Name = "buttonAfficherW";
            this.buttonAfficherW.Size = new System.Drawing.Size(492, 102);
            this.buttonAfficherW.TabIndex = 31;
            this.buttonAfficherW.Text = "AFFICHER DANS WINDOWS";
            this.buttonAfficherW.UseVisualStyleBackColor = true;
            this.buttonAfficherW.Click += new System.EventHandler(this.buttonAfficherW_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1142, 384);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 41);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1136, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fichier de décryptage";
            // 
            // buttonSortie
            // 
            this.buttonSortie.Location = new System.Drawing.Point(1002, 30);
            this.buttonSortie.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSortie.Name = "buttonSortie";
            this.buttonSortie.Size = new System.Drawing.Size(69, 27);
            this.buttonSortie.TabIndex = 34;
            this.buttonSortie.Text = "Sortie";
            this.buttonSortie.UseVisualStyleBackColor = true;
            this.buttonSortie.Click += new System.EventHandler(this.buttonSortie_Click);
            // 
            // buttonsahbg
            // 
            this.buttonsahbg.Location = new System.Drawing.Point(1112, 30);
            this.buttonsahbg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsahbg.Name = "buttonsahbg";
            this.buttonsahbg.Size = new System.Drawing.Size(70, 27);
            this.buttonsahbg.TabIndex = 35;
            this.buttonsahbg.Text = "Sah BG";
            this.buttonsahbg.UseVisualStyleBackColor = true;
            this.buttonsahbg.Click += new System.EventHandler(this.buttonsahbg_Click);
            // 
            // buttonCacher
            // 
            this.buttonCacher.Location = new System.Drawing.Point(544, 539);
            this.buttonCacher.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCacher.Name = "buttonCacher";
            this.buttonCacher.Size = new System.Drawing.Size(155, 41);
            this.buttonCacher.TabIndex = 36;
            this.buttonCacher.Text = "Cacher image 1 dans image 2";
            this.buttonCacher.UseVisualStyleBackColor = true;
            this.buttonCacher.Click += new System.EventHandler(this.buttonCacher_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(725, 542);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 36);
            this.textBox2.TabIndex = 37;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(933, 542);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 38);
            this.textBox3.TabIndex = 38;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "path image 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(976, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "path image 2";
            // 
            // buttonDeca
            // 
            this.buttonDeca.Location = new System.Drawing.Point(760, 656);
            this.buttonDeca.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeca.Name = "buttonDeca";
            this.buttonDeca.Size = new System.Drawing.Size(155, 40);
            this.buttonDeca.TabIndex = 41;
            this.buttonDeca.Text = "décacher";
            this.buttonDeca.UseVisualStyleBackColor = true;
            this.buttonDeca.Click += new System.EventHandler(this.buttonDeca_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Images disponibles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(743, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Innovation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 818);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDeca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCacher);
            this.Controls.Add(this.buttonsahbg);
            this.Controls.Add(this.buttonSortie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAfficherW);
            this.Controls.Add(this.textTaille);
            this.Controls.Add(this.taj);
            this.Controls.Add(this.Coco);
            this.Controls.Add(this.avion);
            this.Controls.Add(this.lyon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textFiltre);
            this.Controls.Add(this.buttonFiltre);
            this.Controls.Add(this.buttondecrypterPixel);
            this.Controls.Add(this.buttonCrypterPixel);
            this.Controls.Add(this.buttonHisto);
            this.Controls.Add(this.textImaginaire);
            this.Controls.Add(this.textReel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textResolution);
            this.Controls.Add(this.buttonFractale);
            this.Controls.Add(this.textAngle);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonContour);
            this.Controls.Add(this.buttonRepoussage);
            this.Controls.Add(this.buttonFlou);
            this.Controls.Add(this.buttonTaille);
            this.Controls.Add(this.buttonMiroire);
            this.Controls.Add(this.buttonNuance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQr);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.buttonQr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQr;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox textQr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNuance;
        private System.Windows.Forms.Button buttonMiroire;
        private System.Windows.Forms.Button buttonTaille;
        private System.Windows.Forms.Button buttonFlou;
        private System.Windows.Forms.Button buttonRepoussage;
        private System.Windows.Forms.Button buttonContour;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.TextBox textAngle;
        private System.Windows.Forms.Button buttonFractale;
        private System.Windows.Forms.TextBox textResolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textReel;
        private System.Windows.Forms.TextBox textImaginaire;
        private System.Windows.Forms.Button buttonHisto;
        private System.Windows.Forms.Button buttonCrypterPixel;
        private System.Windows.Forms.Button buttondecrypterPixel;
        private System.Windows.Forms.Button buttonFiltre;
        private System.Windows.Forms.TextBox textFiltre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button lyon;
        private System.Windows.Forms.Button avion;
        private System.Windows.Forms.Button Coco;
        private System.Windows.Forms.Button taj;
        private System.Windows.Forms.TextBox textTaille;
        private System.Windows.Forms.Button buttonAfficherW;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSortie;
        private System.Windows.Forms.Button buttonsahbg;
        private System.Windows.Forms.Button buttonCacher;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDeca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

