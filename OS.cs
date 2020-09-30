using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DogShop
{
    class OS
    {
        public int X, Y,Inaltime,Latime;
        public Image Img;
        public OS(int X, int Y, Image img,int latime,int inaltime)
        {
            this.X = X;
            this.Y = Y;
            this.Img = img;
            this.Latime = latime;
            this.Inaltime = inaltime;
            
        }
        public void Deseneaza(Graphics g)
        {
            g.DrawImage(Img, X, Y, Latime, Inaltime);
        }
    }
}
