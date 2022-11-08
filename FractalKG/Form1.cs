using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
namespace FractalKG
{
    public partial class Form1 : Form
    {
        #region Для рисования фрактала
        const float alpha = 2;//угол закручивания
        const float beta = 86;//угол наклона веток
        float lmin = 1;//Минимальная длина
        float k = 0.14F;//Частота веток
        float k1 = 0.3F;//Длина веток
        float cosAlpha = (float)Math.Cos(alpha * Math.PI / 180);
        float sinAlpha = (float)Math.Sin(alpha * Math.PI / 180);
        float cosBeta = (float)Math.Cos(beta * Math.PI / 180);
        float sinBeta = (float)Math.Sin(beta * Math.PI / 180);

        private Pen pen;//Перо для рисования
        private Color[] rainbow = new Color[]
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.DarkBlue,
            Color.Violet
        };//Цвета радуги
        private Color[] bw = new Color[]
        {
            Color.Black,
            Color.White
        };//Чёрно-белый
        private Random rand = new Random();
        #endregion

        #region Вспомогательные
        bool stop;//остановка рисования
        bool notNumber;//ввод цифр в текстовые поля
        #endregion

        public Form1()
        {
            InitializeComponent();
            //Двойная буферизация пикчербокса
            SetDoubleBuffered(picFractal);
            //Переменные в элементы управления
            txtAlpha.Text = alpha.ToString();
            txtBeta.Text = beta.ToString();
            txtLmin.Text = lmin.ToString();
            txtK.Text = k.ToString();
            txtK1.Text = k1.ToString();
            cmbColors.SelectedIndex = 1;

            ToggleHandle(button1, true);
        }

        public void BuildFractal(Graphics g, PointF p1, PointF p2, int num)
        {

            Application.DoEvents();

            if (stop | (((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y)) < lmin))
                return;

            //Точка p3(x3;y3)
            PointF p3 = new PointF(
                (p2.X - p1.X) * cosAlpha - (p2.Y - p1.Y) * sinAlpha + p1.X,
                (p2.X - p1.X) * sinAlpha + (p2.Y - p1.Y) * cosAlpha + p1.Y);
            //Точка p4(x4;y4)
            PointF p4 = new PointF(
                 p1.X * (1 - k) + p3.X * k,
                 p1.Y * (1 - k) + p3.Y * k);
            //Точка p5(x5;y5)
            PointF p5 = new PointF(
                p4.X * (1 - k1) + p3.X * k1,
                p4.Y * (1 - k1) + p3.Y * k1);
            //Точка p6(x6;y6)
            PointF p6 = new PointF(
                (p5.X - p4.X) * cosBeta - (p5.Y - p4.Y) * sinBeta + p4.X,
                (p5.X - p4.X) * sinBeta - (p5.Y - p4.Y) * cosBeta + p4.Y);
            //Точка p7(x7;y7)
            PointF p7 = new PointF(
                (p5.X - p4.X) * cosBeta + (p5.Y - p4.Y) * sinBeta + p4.X,
                -1 * (p5.X - p4.X) * sinBeta - (p5.Y - p4.Y) * cosBeta + p4.Y);

            //Выбор цвета пера
            Color penColor = new Color();

            switch (cmbColors.SelectedIndex)
            {
                case 0:
                    penColor = bw[num % 2];
                    break;
                case 1:
                    penColor = rainbow[num];
                    break;
                case 2:
                    penColor = rainbow[rand.Next(0, 6)];
                    break;
                case 3:
                    penColor = colorDialog1.Color;
                    break;
                default:
                    break;
            }
            pen = new Pen(penColor, 1F);

            g.DrawLine(pen, p4, p1);//Отрезок, который и формирует фрактал
            BuildFractal(g, p4, p3, num);//Продолжение ствола
            BuildFractal(g, p4, p6, num + 1);//ветка влево
            BuildFractal(g, p4, p7, num + 1);//ветка вправо
        }

        #region Кнопка старт/стоп
        private void Start_Click(object sender, EventArgs e)
        {
            stop = false;
            ((Button)sender).Text = "Стоп";
            ToggleHandle((Button)sender, false);

            //Перенос значений из элементов управления в переменные
            lmin = float.Parse(txtLmin.Text);
            k = float.Parse(txtK.Text);
            k1 = float.Parse(txtK1.Text);
            cosAlpha = (float)Math.Cos(float.Parse(txtAlpha.Text) * Math.PI / 180);
            sinAlpha = (float)Math.Sin(float.Parse(txtAlpha.Text) * Math.PI / 180);
            cosBeta = (float)Math.Cos(float.Parse(txtBeta.Text) * Math.PI / 180);
            sinBeta = (float)Math.Sin(float.Parse(txtBeta.Text) * Math.PI / 180);

            Rectangle rect = picFractal.ClientRectangle;//зона рисования
            //Очистка пикчербокса
            if (chbClear.Checked)
                picFractal.CreateGraphics().Clear(SystemColors.Control);

            BuildFractal(picFractal.CreateGraphics(),
                new PointF((rect.Right - rect.Left) / 2, rect.Bottom),
                new PointF((rect.Right - rect.Left) / 2, rect.Top), 0);
            //Возврат обработчика события на клик
            ((Button)sender).Text = "Пуск";
            ToggleHandle((Button)sender, true);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            stop = true;
            ((Button)sender).Text = "Пуск";
            ToggleHandle((Button)sender, true);
        }

        private void ToggleHandle(Button btn, bool start)
        {
            if (start)
            {
                btn.Click -= new EventHandler(this.Stop_Click);
                btn.Click += new EventHandler(this.Start_Click);
            }
            else
            {
                btn.Click -= new EventHandler(this.Start_Click);
                btn.Click += new EventHandler(this.Stop_Click);
            }
        }
        #endregion

        #region Ввод чисел в текстбоксы
        private void txtAlpha_KeyDown(object sender, KeyEventArgs e)
        {
            notNumber = false;
            TextBox tb = (TextBox)sender;
            //Цифры верхнего ряда клавиатуры
            bool upperDigits = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && e.Modifiers != Keys.Shift;
            //Цифры цифрового блока
            bool numPadDigits = e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9;
            //Знак минус
            bool minus = (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) &&
                (tb.SelectionStart == 0 && tb.Text.IndexOf('-') == -1);
            //Клавиши перемещения
            bool moveKey = false;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                case Keys.Back:
                case Keys.Left:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                    moveKey = true;
                    return;
                default:
                    break;
            }
            notNumber = !(upperDigits | numPadDigits | minus | moveKey);
        }

        private void txtAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Запятая или точка
            bool comma = (e.KeyChar == ',' | e.KeyChar == '.') &&
                ((TextBox)sender).Text.IndexOfAny(new char[] { ',', '.' }) == -1;
            e.Handled = notNumber ? !comma : notNumber;
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColors.SelectedIndex != 3) return;
            colorDialog1.ShowDialog();
        }
        public static void SetDoubleBuffered(Control control)
        {
            // set instance non-public property with name "DoubleBuffered" to true
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }
    }
}
