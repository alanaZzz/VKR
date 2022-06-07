using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using System.Security.Cryptography;


using System.Numerics;

namespace Shnorr
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }


        //проверка: простое ли число?
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
            
        }
         //проверка введенного числа q
        private bool IsTheDivider(long p, long q)
        {
            if ((p > q) && ((p - 1) % q == 0))
                return true;
            return false;

            
        }
        //проверка введенного числа a
        private bool IsOKa(long a, long q,long p)
        {
            BigInteger aq = BigInteger.Pow(a, (int)q);
            if ((a!=1) && (aq % p == 1))
                return true;
            return false;


        }
        //проверка введенного закрытого ключа w
        private bool IsOKw(long w,long q)
        {

            if ((w<q) && (w>0))
                return true;
            return false;


        }
        //Вычисление числа X
        private long Calculate_x(long a, long r, long p)
        {

            BigInteger x = BigInteger.Pow(a, (int)r);     //a^r mod p = x
            BigInteger x1 = x % p;
            return (long)x1;
        }
        
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signbutton_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0) &&
                (textBox_v.Text.Length > 0) && (textBox_a.Text.Length > 0) &&
                (textBox_w.Text.Length > 0) && (textBox_r.Text.Length > 0) &&
                (sourceFilePathTextBox.Text.Length > 0) && (signFilePathTextBox.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                long q = Convert.ToInt64(textBox_q.Text);
                long w = Convert.ToInt64(textBox_w.Text);
                long v = Convert.ToInt64(textBox_v.Text);
                long a = Convert.ToInt64(textBox_a.Text);
                long r = Convert.ToInt64(textBox_r.Text);
                if (IsTheNumberSimple(p))
                {
                    if (IsTheDivider(p, q))
                    {
                        if (IsOKa(a,q,p))
                        {
                            if (IsOKw(w, q))
                            {
                                var pkey=BigInteger.Pow(a, (int)(q - w))% p;
                                if (v==pkey)
                                {
                                    if (r<q)
                                    {
                                        long x = Calculate_x(a, r, p);
                                        string str= File.ReadAllText(sourceFilePathTextBox.Text).ToString();
                                        var xstr= x.ToString();
                                        var resstr = string.Concat(str, xstr);
                                        string hash = resstr.GetHashCode().ToString();
                                        var key = resstr.GetHashCode();
                                        if (key < 0)
                                        {
                                            key *= -1;
                                        }
                                        var help = r + w * key;
                                        long y = help % q;
                                        string path = sourceFilePathTextBox.Text;
                                        StreamWriter sw = new StreamWriter(signFilePathTextBox.Text);
                                        sw.Write("Сообщение M:"); sw.WriteLine(str);
                                        sw.Write("Число p:"); sw.WriteLine(p.ToString());
                                        sw.Write("Число q:"); sw.WriteLine(q.ToString());
                                        sw.Write("Значение a:"); sw.WriteLine(a.ToString());
                                        sw.Write("Открытый ключ v:"); sw.WriteLine(v.ToString());
                                        sw.Write("Подпись e:"); sw.WriteLine(key.ToString());
                                        sw.Write("Подпись y:"); sw.WriteLine(y.ToString());
                                        //sw.Write("Число x:"); sw.WriteLine(x.ToString());
                                        sw.Close();
                                        MessageBox.Show("Подпись успешно создана!");

                                        Process.Start(signFilePathTextBox.Text);
                                    }
                                    else
                                        MessageBox.Show("Введите r<q!");
                                }
                                else
                                    MessageBox.Show("Неверно выбран открытый ключ, v=a^(q-s){mod p}!");
                            }
                            else
                                MessageBox.Show("введите w<q!");
                        }
                        else
                            MessageBox.Show(" Неверно вычислено a, а должно быть a^q=1{mod p}!");
                    }
                    else
                        MessageBox.Show(" q - не является делителем p-1!");
                }
                else
                    MessageBox.Show("p  - не простое число!");
            }
            else
                MessageBox.Show("Введите p,q,a,w,v,r и пути к файлам!");

        }
        
        //проверка подписи
        private void checkbutton_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0) &&
               (textBox_v.Text.Length > 0) && (textBox_a.Text.Length > 0) &&
               (textBox_e.Text.Length > 0) && (textBox_y.Text.Length > 0) &&
               (sourceFilePathTextBox.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                long q = Convert.ToInt64(textBox_q.Text);
                long pkey = Convert.ToInt64(textBox_e.Text);
                long v = Convert.ToInt64(textBox_v.Text);
                long a = Convert.ToInt64(textBox_a.Text);
                long y = Convert.ToInt64(textBox_y.Text);
               

                            BigInteger x1 = (BigInteger.ModPow(a, (int)y,(int)p));
                            BigInteger x2 = BigInteger.ModPow(v, (int)pkey,(int)p);
                            BigInteger x = (x1 * x2)%p;
                            //textBox_r.Text= x.ToString(); 
                            string str = File.ReadAllText(sourceFilePathTextBox.Text).ToString();
                            var xstr = x.ToString();
                            var resstr = string.Concat(str, xstr);
                            string hash = resstr.GetHashCode().ToString();
                            var key = resstr.GetHashCode();
                            if (key == pkey)
                            {
                                MessageBox.Show("Файл подлинный. Подпись верна!");
                                
                            }
                            else
                            {
                                MessageBox.Show("ВНИМАНИЕ! Файл не подлинный. Подпись неверна!");
                            }
                                      
                         
            }
            else
                MessageBox.Show("Введите открытые параметры p,q,a,v, подписи e и y, и пути к проверяемому файлу!");

          
        }

        private void srcFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sourceFilePathTextBox.Text = ofd.FileName;
            }
        }

        private void signFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                signFilePathTextBox.Text = ofd.FileName;
            }
        }

        private void Rand_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                
                if (IsTheNumberSimple(p))
                {
                    

                        int[] mass = new int[1000]; //массив для генерируемых чисел
                    int j = 0, size_mass = 0;
                    for (int i = 2; i < 10000; i++)  //подбор числа q
                    {
                        if (((p - 1) % i) == 0)
                        {
                            mass[j] = i;
                            j++;
                            size_mass++;    //считаем кол-во эл-тов массива
                        }
                    }
                    Random rnd = new Random();
                    int qj = rnd.Next(0, size_mass);
                    int q = mass[qj];        //если верно, присваиваем значение
                    textBox_q.Text = Convert.ToString(q);

                    Array.Clear(mass, 0, size_mass);
                    size_mass = 0;
                    
                }
                else
                    MessageBox.Show("p - не простое число!");
            }
            else
                MessageBox.Show("Введите p!");
        
        }

        private void RandAV_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                
                long q = Convert.ToInt64(textBox_q.Text);
                if (IsTheNumberSimple(p)  && IsTheDivider(p,q))
                {


                    int[] mass1 = new int[1000]; //массив для генерируемых чисел
                    int j = 0, size_mass1 = 0;
                   
                    BigInteger g;   //вводим открытый ключ g
                    
                    for (int i = 2; i < 25000; i++)     //поиск g в диапазоне (15000;25000)
                    {
                        
                        g = BigInteger.ModPow(i, (int)q, (int)p);     //i^q mod p = 1
                       if ((g == 1) && (j<1000))     //если выполняется условие
                        {
                            
                            mass1[j] = i;    //заносим в массив
                            
                            j++;
                            size_mass1++;
                        }
                    }
                   
                   // Console.WriteLine();
                   
                   Random rnd1 = new Random();
                    int aj = rnd1.Next(0, size_mass1);
                    int a = mass1[aj];        //если верно, присваиваем значение
                    textBox_a.Text = Convert.ToString(a);

                    Array.Clear(mass1, 0, size_mass1);     //очищаем массив
                    size_mass1 = 0;      //обнуляем кол-во элементов в массиве

                }
                else
                    MessageBox.Show("Проверьте правильность введенных чисел! p-простое число, p-1 делится на q");
            }
            else
                MessageBox.Show("Введите p, q!");

        }

        private void CalcV_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_w.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                long w = Convert.ToInt64(textBox_w.Text);
                long q = Convert.ToInt64(textBox_q.Text);
                long a = Convert.ToInt64(textBox_a.Text);
                if (IsTheNumberSimple(p) && IsOKw(w, q) && IsTheDivider(p, q) && IsOKa(a,q,p))
                {
                    var pkey = BigInteger.Pow(a, (int)(q - w)) % p;
                    
                    textBox_v.Text = Convert.ToString(pkey);

                }
                else
                    MessageBox.Show("Проверьте правильность введенных чисел! p-простое число, p-1 делится на q, w меньше q, a^q=1 {mod p}");
            }
            else
                MessageBox.Show("Введите p, q , число a и  закрытый ключ w!");
        }

        private void textBox_p_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_q_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            RandAV.Enabled = (textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0);
            Rand.Enabled = textBox_p.Text.Length > 0;
            CalcV.Enabled = (textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0) &&
               (textBox_a.Text.Length > 0) && (textBox_w.Text.Length > 0);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AB1 = new AboutBox1();
            AB1.labelProductName.Text = "ВКР бакалавра";
            AB1.labelVersion.Text = "Версия 1.0";
            AB1.labelCopyright.Text = "Авторские права: Дорбаева А.Б.";
            AB1.labelCompanyName.Text = "Название организации: МГТУ им.Н.Э.Баумана";
            AB1.textBoxDescription.Text = "Программная реализация алгоритма генерации ключей в электронной цифровой подписи по доверенности.";
            AB1.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
