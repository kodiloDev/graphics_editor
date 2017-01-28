using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SolidBrush color = new SolidBrush(Color.Black); //цвет по умолчанию
        bool paint = false; //состояние зажатия левой кнопки мыши для рисования
        Graphics graphics; //содержит нарисованное для сохранения в image
        Graphics graphicsVisual; //содержит нарисованное для отображения пользователю
        public int thickness = 5; //толщина по умолчанию
        int mouseXStart, mouseYStart, mouseYFinish, mouseXFinish = 0; // начальниые и конечные координаты мыши
        Image image; // объекс картинки для сохранения конечного файла

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            mouseXStart = e.X;
            mouseYStart = e.Y;
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
                paint = false;
                mouseXFinish = e.X;
                mouseYFinish = e.Y;
                
                if (cBox_FiguraType.SelectedIndex == 1)
                {
                    //прямая линия
                    Line line = new Line(thickness, "Линия", color, mouseXStart, mouseYStart);
                    line.Drawing(ref graphics, ref graphicsVisual, ref e);
                }
                else if (cBox_FiguraType.SelectedIndex == 2)
                {
                    //прямоугольник
                    RectangleClass rc = new RectangleClass(thickness, "Прямоугольник", color, mouseXStart, mouseYStart);
                    rc.Drawing(ref graphics,ref graphicsVisual,  ref e);

                }
                else if (cBox_FiguraType.SelectedIndex == 3)
                {
                    //круг
                    Circle circle = new Circle(thickness, "Круг", color, mouseXStart, mouseYStart);
                    circle.Drawing(ref graphics, ref graphicsVisual, ref e);
                }
            }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint && cBox_FiguraType.SelectedIndex == 0)
            {
                //произвольное рисование
                Draw draw = new Draw(thickness, "Произвольное рисование", color);
                draw.Drawing(ref graphics,ref graphicsVisual, ref e);
            }
        }

        private void mainPanel_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            try
            {
                image = Image.FromFile(files[0]);
                mainPanel.MaximumSize = new Size(image.Width, image.Height);
                mainPanel.BackgroundImage = image;
                

                graphics = Graphics.FromImage(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void mainPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (folderDialog.SelectedPath != String.Empty)
                {
                    image.Save(String.Format("{0}\\TestImage.bmp", folderDialog.SelectedPath), ImageFormat.Bmp);
                    MessageBox.Show("Файл успешно сохранен");
                }
            }
        }

        private void btn_backColor_Click(object sender, EventArgs e)
        {
            if (colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                pb_backColor.BackColor = colorDialogBackground.Color;
                mainPanel.BackColor = colorDialogBackground.Color;

                graphics = Graphics.FromImage(image);
                graphics.Clear(colorDialogBackground.Color);
            }
        }

        private void btn_figurColor_Click(object sender, EventArgs e)
        {
            if (colorDialogForFigura.ShowDialog() == DialogResult.OK)
            {
                pb_figurColor.BackColor = colorDialogForFigura.Color;
                color.Color = colorDialogForFigura.Color;
            }
        }

        private  void btn_invert_Click(object sender, EventArgs e)
        {
            Thread some_thread = new Thread
                 (delegate ()
                 {
                         for (int i = 0; i<= 100; i++)
                         {
                             Invoke((MethodInvoker)delegate
                             {
                                 Thread.Sleep(50);
                                 pb_form.Value = i;
                             });
                          }
                     Invoke((MethodInvoker)delegate
                     {
                         image = Invert(image);
                         mainPanel.BackgroundImage = image;

                         graphics = Graphics.FromImage(image);
                         graphicsVisual = mainPanel.CreateGraphics();
                     });
                 });
            some_thread.IsBackground = true;
              some_thread.Start();
        }

        public static Image Invert(Image image)
        {
            Image img = image;

            Bitmap bitmap = new Bitmap(image);
            int x;
            int y;

            for (x = 0; x <= bitmap.Width - 1; x++)
            {
                for (y = 0; y <= bitmap.Height - 1; y += 1)
                {
                    Color oldColor = bitmap.GetPixel(x, y);
                    Color newColor;
                    newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    bitmap.SetPixel(x, y, newColor);
                }
            }

            return (Image)bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image = new Bitmap(mainPanel.Width, mainPanel.Height, PixelFormat.Format24bppRgb);
            Graphics graph = Graphics.FromImage(image);
            graph.Clear(Color.White);
            graph.Dispose();

            graphics = Graphics.FromImage(image);
            graphicsVisual = mainPanel.CreateGraphics();

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void cBox_FiguraType_DropDownClosed(object sender, EventArgs e)
        {

        }
    }
}
