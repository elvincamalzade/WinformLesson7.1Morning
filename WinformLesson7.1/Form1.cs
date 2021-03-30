using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson7._1
{
    public partial class Form1 : Form
    {
        Graphics graphic_context;
        Pen outline;
        SolidBrush fill_color;
        public Form1()
        {
            InitializeComponent();
            graphic_context = this.CreateGraphics();
            outline = new Pen(Color.Red, 3);
            fill_color = new SolidBrush(Color.Green);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender is Button bt)
            {
                switch (bt.Text)
                {
                    case "Line":
                        {
                            graphic_context.DrawLine(outline, 150, 10, 250, 100);
                            break;
                        }

                    case "Circle":
                        {
                            // graphic_context.DrawEllipse(outline, 300, 10, 100, 60);
                            graphic_context.FillEllipse(fill_color, 300, 10, 100, 60);
                            break;
                        }
                    case "Rectangle":
                        {
                            //graphic_context.DrawRectangle(outline, 300, 150, 50, 50);
                            graphic_context.FillRectangle(fill_color, 300, 150, 50, 50);
                            break;
                        }

                    case "Polygon":
                        {
                            Point[] points = new Point[5]
                            {
                                new Point(160,120),
                                new Point(120,180),
                                new Point(190,180),
                                new Point(200,241),
                                new Point(214,180)
                            };

                           // graphic_context.DrawPolygon(outline, points);
                            graphic_context.FillPolygon(fill_color, points);

                            break;
                        }

                    case "Arc":
                        {
                            Rectangle rect = new Rectangle(450, 50, 100, 100);
                           // graphic_context.DrawArc(outline, rect, 135, 180);
                            break;
                        }

                    case "Curve":
                        {
                            Point[] points = new Point[6]
                            {
                                new Point(160,120),
                                new Point(120,180),
                                new Point(190,180),
                                new Point(200,241),
                                new Point(214,180),
                                new Point(160,120)
                            };

                           // graphic_context.DrawCurve(outline, points);
                            graphic_context.FillClosedCurve(fill_color, points);

                            break;
                        }
                    case "Text":
                        {
                            Font font = new Font("Verdana", 20);
                            Point location = new Point(400, 200);

                            StringFormat draw_format = new StringFormat();

                            draw_format.FormatFlags = StringFormatFlags.DirectionVertical;

                            graphic_context.DrawString("Hello World", font, fill_color, location, draw_format);
                            break;

                        }

                    default:
                        break;
                }
            }
        }

     

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"X : {e.X}   Y : {e.Y}";
        }
    }
}
