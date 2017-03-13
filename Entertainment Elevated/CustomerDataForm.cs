using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class CustomerDataForm : Form
    {
        public CustomerDataForm()
        {
            InitializeComponent();
        }
        
        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            CustomerForm customerForm = new CustomerForm();
            general.Controls.Clear();
            general.Controls.Add(customerForm.CustomerFormPanel);
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            GeneralForm general = (GeneralForm)obj.FindForm();
            MainForm mainForm = new MainForm();
            general.Controls.Clear();
            general.Controls.Add(mainForm.MainFormPanel);
        }

        private void DataPictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawHistogram(e.Graphics, DataPictureBox.BackColor, new float[] { 1.0f, 2.0f, 3.0f },
                    DataPictureBox.ClientSize.Width, DataPictureBox.ClientSize.Height);
        }

        // Draw a histogram
        private void DrawHistogram(Graphics graphics, Color backColor, float[] values, int width, int height)
        {
            Color[] Colors = new Color[]
            {
                Color.Red, Color.LightGreen, Color.Blue,
                Color.Pink, Color.Green, Color.LightBlue,
                Color.Orange, Color.Yellow, Color.Purple
            };

            graphics.Clear(backColor);

            // Make a transformation to the PictureBox
            RectangleF data_bounds = new RectangleF(0, 0, values.Length, 10);

            PointF[] points =
            {
                new PointF(0, height),
                new PointF(width, height),
                new PointF(0, 0)
            };
            Matrix transformation = new Matrix(data_bounds, points);
            graphics.Transform = transformation;

            // Draw the histogram
            using (Pen pen = new Pen(Color.Black, 0))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    RectangleF rectangle = new RectangleF(i, 0, 1, values[i]);
                    using (Brush brush = new SolidBrush(Colors[i % Colors.Length]))
                    {
                        graphics.FillRectangle(brush, rectangle);
                        graphics.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
                    }
                }
            }

            graphics.ResetTransform();
            graphics.DrawRectangle(Pens.Black, 0, 0, width - 1, height - 1);
        }
    }
}
