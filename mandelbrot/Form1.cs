using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mandelbrot
{

    public partial class Form1 : Form
    {
        double schaal;

        Bitmap bm;

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            bm = new Bitmap(400, 400);

            //pas dit aan.
            this.Paint += this.teken_bitmap;

            double midden_x = double.Parse(textBox_midden_x.Text);
            double midden_y = double.Parse(textBox_midden_y.Text);

            // tempvariable
            schaal = 0.01;


        }
        private void pas_aan(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // maak ok knop
        private void button_OK_Click(object sender, EventArgs e)
        {
            this.bitmap_image();
            this.Invalidate();

        }

        private void teken_bitmap(object obj, PaintEventArgs pea)
        {
            pea.Graphics.DrawImage(bm, 200, 200);
        }

        // maak een bitmap op het form en teken deze
        private void bitmap_image()
        {
            //Graphics gr = pea.Graphics;
        
           // gr.DrawImage(bm, 200, 200);

            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    // bepaal voor de bitmapwaarden van x en y wat de positie op de wiskundige assenstelsel is
                    double eenX;
                    eenX = BepaalGrafiekX((double) x, schaal);

                    double eenY;
                    eenY = BepaalGrafiekY((double)y, schaal);

                    // roep methode aan om mandelgetal te berekenen
                    int mandelgetal;
                    mandelgetal = mandelgetallen(eenX, eenY);

                    if (mandelgetal % 2 == 0)
                    {
                        bm.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        bm.SetPixel(x, y, Color.Black);
                    }
                  //  bm.SetPixel(x, y, Color.Red);

                    
                }
            }
            bm.SetPixel(0, 0, Color.Black);
        }
        // bereken de mandelgetallen: gebruik de formule en methode bereken de afstand. De functie krijgt de x en y waarde uit de form als parameters. 
        // De formules worden maximaal 100 keer uitgevoerd. Daarom is er een maximumcounter toegevoegd. 
    
        private int mandelgetallen(double x, double y)
        {
            if(x==0 & y==0)
            {
                Console.WriteLine(" bla");
            }
            double a = 0;
            double b = 0;
            bool getalgevonden = false;
            int mandelgetal = 0;
            int maximumcounter = 0;

            while (!getalgevonden & maximumcounter < 99)
            {
                a = a * a - b * b + x;
                b = 2 * a * b + y;
                mandelgetal += 1;
                maximumcounter += 1;

                // Als berekenDeAfstand een waarde geeft groter dan 2, stop deze methode.
                double afstand = berekenDeAfstand(x, y);
                if(afstand >= 2)
                {
                    getalgevonden = true;
                }
            }
            return mandelgetal;
        }
        // bereken de afstand tussen a,b en x,y
        private double berekenDeAfstand(double x, double y)
        {
            double afstand;
            afstand = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));
            return afstand;
        }
        
        // De mandelgetallen zijn berekend, dus we kunnen hiermee de pixels uitrekenen.
        // nog uit te schrijven: modulo -> mandelgetal % 2 == 0 worden wit; mandelgetal % 2 == 1 worden zwart. Mandelgetallen die oneindig zijn worden ook zwart.
        // de bijbehorende coordinaten van het mandelgetal moeten vertaald worden naar coordinaten in de bitmap. 
        // de methode moet als argument de x-coordinaat en de y-coordinaat krijgen. En moet 

        private double BepaalGrafiekX (double pixel_x,double schaal)
        {
            double wiskundige_x= ((pixel_x - 200) * schaal);

            return wiskundige_x;
                     
        }
        
        private double BepaalGrafiekY(double pixel_y, double schaal)
        {
            double wiskundige_y= ((200 - pixel_y) * schaal);

            return wiskundige_y;
        }

    }
 
}
