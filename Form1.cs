using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Visible = false;
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            //textBox2.Visible = false;
            //textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            //button1.Enabled = false;
            //button2.Enabled = false;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        class CipherPicture
        {
            public Bitmap imageContainer;
            public Bitmap imageConMod;
            public Bitmap imageContrast; // добавим котейнер для картинки с выделенными пикселями
            //public Bitmap imageMessage;
            //public Bitmap imageMesBW;
            //public string imageMesMod = "";
            public string textMessage = "";
            public string textMesMod = "";
            public string textMesBin = "";
            public int textMesDecLen = 0;
            public int textMesBinLen = 0;
            public string textMesFull = "";

            public string filename = "";

            public int Key = 0;
            public int SizeConH = 0;
            public int SizeConW = 0;
            //public int SizeMesH = 0;
            //public int SizeMesW = 0;
            public double SizeBits = 0;
        
            public double GetRGBImageCapacity()
            {
                SizeConH = Convert.ToInt32(imageContainer.Height);
                SizeConW = Convert.ToInt32(imageContainer.Width);
                //SizeMesH = Convert.ToInt32(imageMessage.Size.Height);
                //SizeMesW = Convert.ToInt32(imageMessage.Size.Width);

                //if ((SizeConH * SizeConW * 3 < SizeMesH * SizeMesW) || (SizeConH * SizeConW * 3 < ))

                SizeBits = Math.Ceiling(Math.Log(SizeConH * SizeConW));
                if (SizeBits % 3 == 2)
                    SizeBits++;
                else if (SizeBits % 3 == 1)
                    SizeBits += 2;
                return SizeBits;
            }

            //public double RGBtoYCrCb()
            //{
            //    //double YCbCr = new double[3, imageContainer.Width, imageContainer.Height];


            //    double curRed, curGreen, curBlue;

            //    for (int y = 0; y < imageContainer.Height; y++)
            //    {
            //        for (int x = 0; x < imageContainer.Width; x++)
            //        {
            //            curRed = (double)RGB[0, x, y];
            //            curGreen = (double)RGB[1, x, y];
            //            curBlue = (double)RGB[2, x, y];

            //            YCbCr[0, x, y] = 0.299 * curRed + 0.587 * curGreen + 0.144 * curBlue;                    // Y
            //            YCbCr[1, x, y] = (-0.14713) * curRed - 0.28886 * curGreen + 0.436 * curBlue + 128;       // Cb
            //            YCbCr[2, x, y] = 0.615 * curRed - 0.51499 * curGreen - 0.10001 * curBlue + 128;          // Cr

            //        }
            //    }

            //    return YCbCr;
            //}

            //public void Converting()
            //{
            //    byte[] text = Encoding.UTF8.GetBytes(textMessage);
            //    text = Encoding.Convert(Encoding.UTF8, Encoding.ASCII, text);
            //    char[] asciiChars = new char[Encoding.ASCII.GetCharCount(text, 0, text.Length)];
            //    Encoding.ASCII.GetChars(text, 0, text.Length, asciiChars, 0);
            //    textMesMod = new string(asciiChars);

            //    foreach (string letter in textMesMod.Select(c => Convert.ToString(c, 2)))
            //    {
            //        textMesBin += letter;
            //    }

                

            //    string length = Convert.ToString(textMesMod.Length, 2);
            //    textMesFull = length + textMesMod;

            //    for (int i = 0; i < SizeBits - length.Length; i++)
            //    {
            //        textMesFull = "0" + textMesFull;
            //    }
            //}

            public void Converting()
            {
                //StringBuilder crypted = new StringBuilder();
                //foreach (byte b in System.Text.Encoding.Default.GetBytes(textMessage))
                //{
                //    crypted.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                //}
                //textMesMod = Convert.ToString(crypted);

                //foreach (string letter in textMessage.Select(c => Convert.ToString(c, 2)))
                //    textMesMod = letter;

                byte[] bytes = Encoding.GetEncoding(1251).GetBytes(textMessage);
                foreach (var b in bytes)
                {
                    textMesMod += Convert.ToString(b, 2).PadLeft(8);
                }
            }

            public void CapacityLSB()
            {
                string length = "";

                if (textMessage.Length * 8 + SizeBits > SizeConH * SizeConW)
                    MessageBox.Show("Контейнера недостаточно для сокрытия информации.", "Ошибка", MessageBoxButtons.OK);
                else
                {
                    length = Convert.ToString(textMesMod.Length, 2);
                    textMesFull = length + textMesMod;

                    //textMesBinLen = textMesMod.Length.ToString("B").Length + (Convert.ToInt32(SizeBits) - textMesMod.Length);
                    //textMesFull = textMesMod.ToString("B" + textMesBinLen.ToString());

                    for (int i = 0; i < SizeBits - length.Length; i++)
                    {
                        textMesFull = "0" + textMesFull;
                    }
                }
            }

            public void CapacityKohaZhao()
            {
                if (textMessage.Length * 8 + SizeBits > SizeConH * SizeConW / (8 * 8))
                    MessageBox.Show("Контейнера неостаточно для сокрытия информации.", "Ошибка", MessageBoxButtons.OK);
            }

            public void ClearBits()
            {
                int R = 0, G = 0, B = 0, i = 0;

                // pass through the rows
                for (int y = 0; y < imageContainer.Height; y++)
                {
                    // pass through each row
                    for (int x = 0; x < imageContainer.Width; x++)
                    {
                        // holds the pixel that is currently being processed
                        Color pixel = imageContainer.GetPixel(x, y);

                        // now, clear the least significant bit (LSB) from each pixel element
                        R = pixel.R - pixel.R % 2;
                        G = pixel.G - pixel.G % 2;
                        B = pixel.B - pixel.B % 2;
                        imageContainer.SetPixel(x, y, Color.FromArgb(R, G, B));
                        i++;
                        if (i == textMesFull.Length)
                            break;
                    }
                    if (i == textMesFull.Length)
                        break;
                }
            }

            public Bitmap Encryption(Bitmap imageContainer, int Key)
            {
                int i = 0, R = 0, G = 0, B = 0;
                imageConMod = imageContainer;
                
                for (int y = 0; y < imageContainer.Height; y++)
                {
                    for (int x = 0; x < imageContainer.Width; x++)
                    {
                        Color pixel = imageContainer.GetPixel(x, y);

                        if (textMesFull[i] == '1')
                            R = pixel.R + 1;
                        else
                            R = pixel.R;
                        imageConMod.SetPixel(x, y, Color.FromArgb(R, G, B));
                        i++;
                        if (i >= textMesFull.Length)
                            break;
                        if (textMesFull[i] == '1')
                            G = pixel.G + 1;
                        else
                            G = pixel.G;
                        imageConMod.SetPixel(x, y, Color.FromArgb(R, G, B));
                        i++;
                        if (i >= textMesFull.Length) 
                            break;
                        if (textMesFull[i] == '1') 
                            B = pixel.B + 1;
                        else 
                            B = pixel.B;
                        imageConMod.SetPixel(x, y, Color.FromArgb(R, G, B));
                        i++;
                        if (i >= textMesFull.Length)
                            break;

                        for (int k = 0; k < Key - 1; k++) 
                            x++;

                    }
                    if (i >= textMesFull.Length)
                        break;
                }

                return imageConMod;
            }

            public int GetSize(double SizeBits, int Key)
            {
                int i = 0;
                string size = "";

                for (int y = 0; y < imageContainer.Height; y++)
                {
                    for (int x = 0; x < imageContainer.Width; x++)
                    {
                        Color pixel = imageContainer.GetPixel(x, y);

                        if ((pixel.R % 2) == 1)
                            size += "1";
                        else
                            size += "0";
                        i++;
                        if (i == SizeBits)
                            break;
                        if ((pixel.G % 2) == 1)
                            size += "1";
                        else
                            size += "0";
                        i++;
                        if (i == SizeBits)
                            break;
                        if ((pixel.B % 2) == 1)
                            size += "1";
                        else
                            size += "0";
                        i++;
                        if (i == SizeBits)
                            break;

                        for (int k = 0; k < Key - 1; k++)
                            x++;
                    }
                    if (i == SizeBits)
                        break;
                }

                textMesDecLen = Convert.ToInt32(size, 2);
                return textMesDecLen;
            }

            public string Decoding(double SizeBits, int textMesDecLen, int Key)
            {
                int i = 0;
                for (int y = 0; y < imageContainer.Height; y++)
                {
                    for (int x = 0; x < imageContainer.Width; x++)
                    {
                        if (y == 0 & x == 0)
                            x = Convert.ToInt32(5 * Key);
                        Color pixel = imageContainer.GetPixel(x, y);

                        if (pixel.R % 2 == 1)
                            textMesMod += "1";
                        else
                            textMesMod += "0";
                        i++;
                        if (i == textMesDecLen)
                            break;
                        if (pixel.G % 2 == 1)
                            textMesMod += "1";
                        else
                            textMesMod += "0";
                        i++;
                        if (i == textMesDecLen)
                            break;
                        if (pixel.B % 2 == 1)
                            textMesMod += "1";
                        else
                            textMesMod += "0";
                        i++;
                        if (i == textMesDecLen)
                            break;
                        for (int k = 0; k < Key - 1; k++)
                            x++;
                    }
                    if (i == textMesDecLen)
                        break;
                }

                //var encrypted = Enumerable.Range(0, textMesMod.Length / 8).Select(i => Convert.ToByte(textMesMod.Substring(i * 8, 8), 2)).ToArray();
                //textMessage = Encoding.UTF8.GetString(encrypted);

                int p = 0;
                while (p < textMesMod.Length)
                {
                    Char ch = (char)Convert.ToByte(textMesMod.Substring(p, 8), 2);
                    textMessage += System.Text.Encoding.GetEncoding(1251).GetString(new byte[] { (byte)ch });
                    p += 8;
                }

                return textMessage;
            }

            public void Contrast()
            {
                int i = 0, R = 0, G = 0, B = 0;
                imageContrast = imageContainer;
                for (int y = 0; y < imageContrast.Height; y++)
                {
                    for (int x = 0; x < imageContrast.Width; x++)
                    {
                        Color pixel = imageContainer.GetPixel(x, y);

                        R = 0;
                        G = 0;
                        B = 255;
                        imageContrast.SetPixel(x, y, Color.FromArgb(R, G, B));
                        i++;
                        if (i == textMesFull.Length)
                            break;
                        for (int k = 0; k < Key - 1; k++)
                            x++;
                    }
                    if (i == textMesFull.Length)
                        break;
                }
            }


            /*public Bitmap BlackWhite()
            {
                // создаём Bitmap из изображения, находящегося в pictureBox1
                Bitmap input = new Bitmap(imageContainer);
                // создаём Bitmap для черно-белого изображения
                Bitmap output = new Bitmap(input.Width, input.Height);
                // перебираем в циклах все пиксели исходного изображения
                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                        // получаем (i, j) пиксель
                        UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                        // получаем компоненты цветов пикселя
                        float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                        float B = (float)(pixel & 0x000000FF); // синий
                                                               // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                        R = G = B = (R + G + B) / 3.0f;
                        // собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        // добавляем его в Bitmap нового изображения
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                // выводим черно-белый Bitmap в pictureBox2
                //pictureBox2.Image = output;
                return output;
            }*/

            /*public string MesToBin()
            {
                Color colour;
                int[,] massiv = new int[imageMesBW.Width, imageMesBW.Height];
                for (int a = 0; a < imageMesBW.Height; a++)
                {
                    for (int b = 0; b < imageMesBW.Width; b++)
                    {
                        colour = imageMesBW.GetPixel(a, b);
                        if (colour.Name == "ffffffff")  // белый
                        {
                            massiv[a, b] = 0;
                        }
                        else
                        {
                            massiv[a, b] = 1;
                        }
                        imageMesMod += massiv[a, b].ToString();
                    }
                }
                return imageMesMod;
            }*/
        }

        CipherPicture Picture1;
        CipherPicture Picture2;

        private void контейнерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture1 = new CipherPicture();
            Picture2 = new CipherPicture();
            pictureBox1.Image = null;

            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\bikhi_27b5q2u\Desktop\Предметы\4 курс\8 семестр\Технологии защиты от скрытой передачи данных\Лаба 2\",
                Filter = "Bitmap-файлы (*.bmp)|*.bmp",
                Title = "Растровое изображение"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(filePath);
                Picture1.imageContainer = Image.FromFile(filePath) as Bitmap;
            }
            else MessageBox.Show("Выберите растровое изображение.", "Ошибка", MessageBoxButtons.OK);

            //if ((textBox1.Text != "" || pictureBox3.Image != null) & textBox2.Text != "")
            //{
            //    button1.Enabled = true;
            //}
        }

        private void сообщениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //pictureBox3.Image = null;
            //Picture1 = new CipherPicture();
            textBox1.Text = null;

            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\bikhi_27b5q2u\Desktop\Предметы\4 курс\8 семестр\Технологии защиты от скрытой передачи данных\Лаба 2\",
                Filter = "Файлы-сообщения (*.txt)|*.txt",
                Title = "Файл-сообщение"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                //FileInfo fileInf = new FileInfo(filePath);

                //if (fileInf.Extension == ".bmp")
                //{
                //    textBox1.Visible = false;
                //    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //    pictureBox3.Image = Image.FromFile(filePath);
                //    Pic1.imageMessage = pictureBox3.Image as Bitmap;
                //}
                //else if (fileInf.Extension == ".txt")
                //{
                //    pictureBox3.Image = null;
                textBox1.Visible = true;
                Encoding win1251 = Encoding.GetEncoding("windows-1251");
                textBox1.Text = File.ReadAllText(filePath, win1251);
                Picture1.textMessage = File.ReadAllText(filePath, win1251);
                //}
            }
            else MessageBox.Show("Выберите текстовое сообщение.", "Ошибка", MessageBoxButtons.OK);

            //if (pictureBox1.Image != null & textBox2.Text != "")
            //{
            //    button1.Enabled = true;
            //}
        }

        private void стеганоконтейнерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Picture2 = new CipherPicture();
            pictureBox2.Image = null;

            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\bikhi_27b5q2u\Desktop\Предметы\4 курс\8 семестр\Технологии защиты от скрытой передачи данных\Лаба 2\",
                Filter = "Bitmap-файлы (*.bmp)|*.bmp",
                Title = "Растровое изображение"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(filePath);
                Picture2.imageContainer = Image.FromFile(filePath) as Bitmap;
            }
            else MessageBox.Show("Выберите растровое изображение с зашифрованным содержимым.", "Ошибка", MessageBoxButtons.OK);

            //if (textBox2.Text != "")
            //{
            //    button2.Enabled = true;
            //}
        }

        private void стеганоконтейнерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                Bitmap bmpSave = (Bitmap)pictureBox2.Image;
                SaveFileDialog sfd = new SaveFileDialog
                {
                    DefaultExt = "bmp",
                    Filter = "Image files (*.bmp)|*.bmp"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                    bmpSave.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                else
                    MessageBox.Show("Вы забыли сохранить файл!", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Вам нечего сохранять!", "Ошибка", MessageBoxButtons.OK);
        }

        private void сообщениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string str = Convert.ToString(Picture2.textMessage);
            if (str != null)
            {
                SaveFileDialog saveFile1 = new SaveFileDialog
                {
                    DefaultExt = "*.txt",
                    Filter = "Text files|*.txt"
                };

                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
                {
                    using StreamWriter sw = new StreamWriter(saveFile1.FileName, true, Encoding.GetEncoding("Windows-1251")); // убрать 3 аргумент, если не нужно ansi
                    sw.WriteLine(Convert.ToString(str));
                    sw.Close();
                }
                else
                    MessageBox.Show("Вы забыли сохранить файл.", "Ошибка", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Вам нечего сохранять.", "Ошибка", MessageBoxButtons.OK);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа реализует алгоритм сокрытия информации в " +
                "растровых изображениях с использованием стегоключей.\nСПбГУАП\nСанкт-петербург, 2022",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cipher_LSB_Click(object sender, EventArgs e) // кнопка шифрования
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Добавьте растровое изображение-контейнер.", "Ошибка", MessageBoxButtons.OK);
            else if (textBox1.Text == "")
                MessageBox.Show("Добавьте шифруемое сообщение.", "Ошибка", MessageBoxButtons.OK);
            else if (textBox2.Text == "")
                MessageBox.Show("Добавьте стегоключ.", "Ошибка", MessageBoxButtons.OK);
            else
            {
                Picture1.Key = Convert.ToInt32(textBox2.Text);

                Picture1.SizeBits = Picture1.GetRGBImageCapacity();
                Picture1.Converting();
                Picture1.CapacityLSB();
                Picture1.ClearBits();
                pictureBox1.Image = Picture1.imageContainer; // скроем лишние движения картинки в программе
                Picture1.Encryption(Picture1.imageContainer, Picture1.Key);
                //Picture1.Contrast();// здесь будет функция с выводом картинки с контрастными пикслями

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Picture1.imageConMod; // поменяем вывод результата, выводим его теперь в первый бокс
                Picture2.imageContainer = Picture1.imageConMod;
                //pictureBox2.Image = Picture1.imageContrast;
            }
        }

        private void decipher_LSB_Click(object sender, EventArgs e) // кнопка дешифрования
        {
            if (pictureBox2.Image == null)
                MessageBox.Show("Добавьте растровое изображение с зашифрованным сообщением.", "Ошибка", MessageBoxButtons.OK);
            else if (textBox2.Text == "")
                MessageBox.Show("Добавьте стегоключ", "Ошибка", MessageBoxButtons.OK);
            else
            {
                Picture2.Key = Convert.ToInt32(textBox2.Text);

                Picture2.imageContainer = pictureBox2.Image as Bitmap;
                Picture2.SizeBits = Picture2.GetRGBImageCapacity();
                Picture2.textMesDecLen = Picture2.GetSize(Picture2.SizeBits, Picture2.Key);
                Picture2.textMessage = Picture2.Decoding(Picture2.SizeBits, Picture2.textMesDecLen, Picture2.Key);
                textBox1.Visible = true;
                textBox1.Text = Picture2.textMessage;
            }
        }

        private void resultValue_Click(object sender, EventArgs e) // кнопка оценки результата шифрования
        {
            //double mul = 0;
            double numerator = 0; // числитель
            double denominator = 0; // знаменатель
            double NAD = 0; // метрика NAD
            
            if (Picture1.imageContainer == null)
                MessageBox.Show("", "", MessageBoxButtons.OK);
            else if (Picture2.imageContainer == null)
                MessageBox.Show("", "", MessageBoxButtons.OK);
            else if ((Picture1.imageContainer.Width != Picture2.imageContainer.Width) || (Picture1.imageContainer.Height != Picture2.imageContainer.Height))
                MessageBox.Show("", "", MessageBoxButtons.OK);
            else
            {
                for (int y = 0; y < Picture1.imageContainer.Height; y++)
                {
                    for (int x = 0; x < Picture1.imageContainer.Width; x++)
                    {
                        Color pixel1 = Picture1.imageContainer.GetPixel(x, y);
                        Color pixel2 = Picture2.imageContainer.GetPixel(x, y);
                        numerator += (pixel1.R - pixel2.R) + (pixel1.G - pixel2.G) + (pixel1.B - pixel2.B);
                        denominator += pixel1.R % 2 + pixel1.G % 2 + pixel1.B % 2;
                    }
                }
                NAD = numerator / denominator;
                textBox3.Text = Convert.ToString(NAD);

                //for (int y = 0; y < Picture1.imageContainer.Height; y++)
                //{
                //    for (int x = 0; x < Picture1.imageContainer.Width; x++)
                //    {
                //        Color pixel1 = Picture1.imageContainer.GetPixel(x, y);
                //        Color pixel2 = Picture2.imageContainer.GetPixel(x, y);
                //        double sum = (pixel1.R - pixel2.R) + (pixel1.G - pixel2.G) + (pixel1.B - pixel2.B);
                //        mul += Math.Pow(sum, 2);
                //    }
                //}
                //double MSE = mul / (Picture1.imageContainer.Height * Picture1.imageContainer.Width * 3);
                //textBox3.Text = Convert.ToString(MSE);
            }
        }
    }
}
