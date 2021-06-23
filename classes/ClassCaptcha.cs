using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Olympiad.classes
{
    class ClassCaptcha
    {
        private static string code = string.Empty;
        private static Random rnd = new Random();

        //create a bitmap img
        public static Image createImg()
        {
            code = randomTxt();
            Bitmap bitmap = new Bitmap(120, 120, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 3);
            Rectangle rect = new Rectangle(0, 0, 120, 120);
            SolidBrush back = new SolidBrush(Color.LightGray);
            SolidBrush front = new SolidBrush(Color.FromArgb(
                rnd.Next(0, 150),
                rnd.Next(0, 150),
                rnd.Next(0, 150)));
            int counter = 0;
            g.DrawRectangle(pen, rect);
            g.FillRectangle(back, rect);
            string[] fontList = { "Chumbly BRK", "Choktoff", "Coaster", "Cloister Black" };
            for (int i = 0; i < code.Length; i++)
            {
                g.DrawString(code[i].ToString(),
                    new Font(fontList[rnd.Next(0, 4)], 10 + rnd.Next(5, 15)),
                    front, new PointF(20 + counter, rnd.Next(15, 100)));
                counter += 20;
            }
            int num = rnd.Next(1, 4);
            randomShapes(g, num);
            g.Dispose();
            return bitmap;
        }

        //make rnd txt
        private static string randomTxt()
        {
            StringBuilder txt = new StringBuilder();
            string smallAlpha = "abcdefghijklmnopqrstuvwxyz";
            string bigAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string all = smallAlpha + bigAlpha + numbers;
            txt.Append(smallAlpha[rnd.Next(smallAlpha.Length)]);
            txt.Append(bigAlpha[rnd.Next(bigAlpha.Length)]);
            txt.Append(numbers[rnd.Next(numbers.Length)]);
            txt.Append(all[rnd.Next(all.Length)]);
            code = txt.ToString();
            return code;
        }

        //make rnd points
        private static Point[] randomPoints()
        {
            Point[] points = { new Point(rnd.Next(10, 100), rnd.Next(10, 100)),
                              new Point(rnd.Next(10, 100), rnd.Next(10, 100))};
            return points;
        }

        //make rbd shapes
        private static void randomShapes(Graphics g, int x)
        {
            switch (x)
            {
                case 1:
                    {
                        SolidBrush brush = new SolidBrush(Color.FromArgb
                        (rnd.Next(50, 200),
                        rnd.Next(50, 200),
                        rnd.Next(50, 200)));
                        //draw line
                        g.DrawLines(new Pen(brush, 2), randomPoints());
                        break;
                    }
                case 2:
                    {
                        SolidBrush brush = new SolidBrush(Color.FromArgb
                            (rnd.Next(50, 200),
                            rnd.Next(50, 200),
                            rnd.Next(50, 200)));
                        //draw Rectangle
                        g.DrawRectangle(new Pen(brush, 2),
                                       new Rectangle(rnd.Next(10, 100), rnd.Next(10, 100),
                                                    rnd.Next(10, 100), rnd.Next(10, 100)));
                        break;
                    }
                case 3:
                    {
                        SolidBrush brush = new SolidBrush(Color.FromArgb
                            (rnd.Next(50, 200),
                            rnd.Next(50, 200),
                            rnd.Next(50, 200)));
                        //draw circle
                        int redius = rnd.Next(5, 15);
                        g.DrawEllipse(new Pen(brush , 2), rnd.Next(10, 100) - redius,
                            rnd.Next(10, 100) - redius, rnd.Next(10, 100) + redius,
                            rnd.Next(10, 100) + redius);
                        break;
                    }
                default:
                    break;
            }
        }
        public static bool validate(string input)
        {
            if (code.Equals(input))
            {
                return true;
            }
            return false;
        }
    }
}
