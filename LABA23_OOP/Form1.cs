using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA23_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int Width = 800;
        private const int Height = 600;
        private const int Padding = 40;
        private double coefficient;
        private void DrawGraph_Click(object sender, EventArgs e)
        {
            //Створюємо нову форму, для подальшого виведення графіка у новому вікні
            Form2 graphic = new Form2();
            // Отримуємо значення коефіцієнта з текстового поля
            if (!double.TryParse(CoefficientTextBox.Text, out coefficient))
            {
                MessageBox.Show("Некоректний ввід коефіцієнта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створюємо новий Bitmap для малювання графіку
            Bitmap bitmap = new Bitmap(Width, Height);

            // Отримуємо Graphics для малювання на Bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Встановлюємо чорний колір фону
                graphics.Clear(Color.White);

                // Встановлюємо кольори для осей та графіку
                Pen axisPen = new Pen(Color.Black);
                Pen graphPen = new Pen(Color.Blue);

                // Обчислюємо масштаб для графіку
                double tMin = -10;
                double tMax = 10;
                double tRange = tMax - tMin;
                double pixelRange = Width - 2 * Padding;
                double tStep = tRange / (pixelRange*coefficient);

                // Малюємо осі координат
                graphics.DrawLine(axisPen, Padding, Height / 2, Width - Padding, Height / 2); // Ось X
                graphics.DrawLine(axisPen, Width / 2, Padding, Width / 2, Height - Padding); // Ось Y

                // Підписуємо осі координат
                graphics.DrawString("X", DefaultFont, Brushes.Black, Width - Padding, Height / 2);
                graphics.DrawString("Y", DefaultFont, Brushes.Black, Width / 2, Padding);

                // Малюємо графік функції
                for (double t = tMin; t <= tMax; t += tStep)
                {
                    double x = coefficient * (t - Math.Sin(t));
                    double y = coefficient * (t - Math.Cos(t));

                    // Перетворюємо координати в пікселі
                    int pixelX = Padding + (int)((t - tMin) * pixelRange / tRange);
                    int pixelY = Height - Padding - (int)((y - tMin) * pixelRange / tRange);
                    // Малюємо точку на графіку
                    graphics.DrawRectangle(graphPen, pixelX, pixelY, 1, 1);
                }
            }

            // Відображаємо графік на PictureBox у іншому вікін
            graphic.GraphPictureBox.Image = bitmap;
            graphic.ShowDialog();
        }
    }
}
    

