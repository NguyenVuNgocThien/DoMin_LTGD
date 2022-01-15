using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoXo
{
    public partial class Form1 : Form
    {
        private int s = 0, w = 0, row = 0, col = 0, slmin = 0;
        private Button[,] domin;
        private int[,] a;
        private int control = 0;
        private int SoLuongODaMo = 0;
        private bool[] Level = new bool[5];
        private void CapDo()
        {
            for(int i = 0; i < 5; i++)
            {
                Level[i] = true;
            }
            if (rdCap1.Checked == true)
            {
                slmin = 2 ;
                w = 40;
                row = panDoMin.Width / w;
                col = panDoMin.Height / w;
                domin = new Button[row, col];
                a = new int[row, col];
                Level[0] = false;
            }
            else if (rdCap2.Checked == true)
            {
                slmin = 15;
                w = 35;
                row = panDoMin.Width / w;
                col = panDoMin.Height / w;
                domin = new Button[row, col];
                a = new int[row, col];
                Level[1] = false;
            }
            else if (rdCap3.Checked == true)
            {
                slmin = 20;
                w = 30;
                row = panDoMin.Width / w;
                col = panDoMin.Height / w;
                domin = new Button[row, col];
                a = new int[row, col];
                Level[2] = false;
            }
            else if (rdCap4.Checked == true)
            {
                slmin = 25;
                w = 25;
                row = panDoMin.Width / w;
                col = panDoMin.Height / w;
                domin = new Button[row, col];
                a = new int[row, col];
                Level[3] = false;
            }
            else if (rdCap5.Checked == true)
            {
                slmin = 30;
                w = 20;
                row = panDoMin.Width / w;
                col = panDoMin.Height / w;
                domin = new Button[row, col];
                a = new int[row, col];
                Level[4] = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    domin[i, j].Width = 0;
                    domin[i, j].Height = 0;
                }
            }
            control = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (rdCap1.Checked == true || rdCap2.Checked == true || rdCap3.Checked == true || rdCap4.Checked == true || rdCap5.Checked == true)
            {
                CapDo();
                for (int k = 0; k < 5; k++)
                {
                    if (!Level[k])
                    {
                        int i = 0, j = 0;
                        for (i = 0; i < row; i++)
                        {
                            for (j = 0; j < col; j++)
                            {
                                domin[i, j] = new Button();
                                domin[i, j].Text = "";
                                domin[i, j].Width = w;
                                domin[i, j].Height = w;
                                domin[i, j].Location = new Point(i * w, j * w);
                                domin[i, j].Click += new EventHandler(Bamnut);
                                panDoMin.Controls.Add(domin[i, j]);
                                a[i, j] = 0;
                            }
                        }
                        int dem = 0;
                        while (dem < slmin)
                        {
                            Random rnd = new Random();
                            i = rnd.Next(0, row);
                            j = rnd.Next(0, col);
                            if (a[i, j] == 0)
                            {
                                a[i, j] = 1;
                                dem++;
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn cấp độ chơi");
        }

        private void Bamnut(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            if (control == 0)
            {
                
                x = ((Button)sender).Location.X;
                y = ((Button)sender).Location.Y;
                int i = 0, j = 0;
                i = x / w;
                j = y / w;
                if (a[i, j] == 0)
                {
                    if (((Button)sender).Text == "")
                    {
                        SoLuongODaMo++;
                        if (SoLuongMin_DuocSetUp(i, j) == 0)
                        {
                            domin[i , j].Text = " ";
                        }
                        else
                        {
                            domin[i , j].Text = SoLuongMin_DuocSetUp(i, j).ToString();
                        }
                        ((Button)sender).BackColor = Color.Beige;
                        if (SoLuongMin_DuocSetUp(i, j) == 0)
                        {
                            ClickButton_MoCacButtonLanCan(i, j);
                        }
                    }
                }
                else
                {
                    ((Button)sender).Text = "*";
                    ((Button)sender).BackColor = Color.Red;
                    control = -1;
                }
            }
            if (SoLuongODaMo == row * col - slmin)
            {
                control = 1;
            }
            if (control == 1)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        domin[i, j].Width = 0;
                        domin[i, j].Height = 0;
                    }
                }
                int l = 0;
                for (l = 0; l < 5; l++)
                {
                    if (Level[l] == false)
                    {
                        Level[l] = true;
                        break;
                    }
                }
                if (l == 0)
                {
                    rdCap1.Checked = false;
                    rdCap2.Checked = true;
                    SoLuongODaMo = 0;
                    control = 0;
                }
                if (l == 1)
                {
                    rdCap2.Checked = false;
                    rdCap3.Checked = true;
                    SoLuongODaMo = 0;
                    control = 0;
                }
                if (l == 2)
                {
                    rdCap3.Checked = false;
                    rdCap4.Checked = true;
                    SoLuongODaMo = 0;
                    control = 0;
                }
                if (l == 3)
                {
                    rdCap4.Checked = false;
                    rdCap5.Checked = true;
                    SoLuongODaMo = 0;
                    control = 0;
                }
                if (l == 4)
                {
                    rdCap5.Checked = false;
                    SoLuongODaMo = 0;
                }
                DialogResult KetQua;
                KetQua = MessageBox.Show("You win this level", "thong bao", MessageBoxButtons.OK);
                if (KetQua == DialogResult.OK)
                {
                    btStart.PerformClick();
                }
            }
            else if (control == -1)
            {
                DialogResult KetQua;
                KetQua = MessageBox.Show("You lose this level", "thong bao", MessageBoxButtons.OK);
            }
        }
        private void ClickButton_MoCacButtonLanCan(int i, int j)
        {
            if (i - 1 > 0) //Kiem tra phia tren
            {
                if (a[i - 1, j] == 0)
                {
                    if (domin[i - 1, j].Text == "")
                    {
                        SoLuongODaMo++;
                        if (SoLuongMin_DuocSetUp(i, j) == 0)
                        {
                            domin[i - 1, j].Text = " ";
                        }
                        else
                        {
                            domin[i - 1, j].Text = SoLuongMin_DuocSetUp(i, j).ToString();
                        }
                        domin[i - 1, j].BackColor = Color.Beige;
                        if (SoLuongMin_DuocSetUp(i - 1, j) == 0)
                            ClickButton_MoCacButtonLanCan(i - 1, j);
                    }
                }
            }
            if (j - 1 > 0) //Kiem tra ben trai
            {
                if (a[i, j - 1] == 0)
                {
                    if (domin[i, j - 1].Text == "")
                    {
                        SoLuongODaMo++;
                        if (SoLuongMin_DuocSetUp(i, j) == 0)
                        {
                            domin[i, j - 1].Text = " ";
                        }
                        else
                        {
                            domin[i, j - 1].Text = SoLuongMin_DuocSetUp(i, j).ToString();
                        }
                        domin[i, j - 1].BackColor = Color.Beige;
                        if (SoLuongMin_DuocSetUp(i, j - 1) == 0)
                            ClickButton_MoCacButtonLanCan(i, j - 1);
                    }
                }
            }
            if (j + 1 > col) //Kiem Tra ben phai
            {
                if (a[i, j + 1] == 0)
                {
                    if (domin[i, j + 1].Text == "")
                    {
                        SoLuongODaMo++;
                        if (SoLuongMin_DuocSetUp(i, j) == 0)
                        {
                            domin[i, j + 1].Text = " ";
                        }
                        else
                        {
                            domin[i, j + 1].Text = SoLuongMin_DuocSetUp(i, j).ToString();
                        }
                        domin[i, j + 1].BackColor = Color.Beige;
                        if (SoLuongMin_DuocSetUp(i, j + 1) == 0)
                            ClickButton_MoCacButtonLanCan(i, j + 1);
                    }
                }
            }
            if (i + 1 > row)
            {
                if (a[i + 1, j] == 0)
                {
                    if (domin[i + 1, j].Text == "")
                    {
                        SoLuongODaMo++;
                        if (SoLuongMin_DuocSetUp(i, j) == 0)
                        {
                            domin[i + 1, j].Text = " ";
                        }
                        else
                        {
                            domin[i + 1, j].Text = SoLuongMin_DuocSetUp(i, j).ToString();
                        }
                        domin[i + 1, j].BackColor = Color.Beige;
                        if (SoLuongMin_DuocSetUp(i + 1, j) == 0)
                            ClickButton_MoCacButtonLanCan(i + 1, j);
                    }
                }
            }
        }
        private int SoLuongMin_DuocSetUp(int i, int j)
        {
            int kq = 0;
            if (i > 0)
            {
                if (j > 0)
                {
                    kq += a[i - 1, j - 1];
                }
                kq += a[i - 1, j];
                if (j < col - 1)
                {
                    kq += a[i - 1, j + 1];
                }
            }
            if (j > 0)
            {
                kq += a[i, j - 1];
            }
            if (j < col - 1)
                kq += a[i, j + 1];
            if (i < row - 1)
            {
                if (j > 0)
                {
                    kq += a[i + 1, j - 1];
                }
                kq += a[i + 1, j];
                if (j < col-1)
                {
                    kq += a[i + 1, j + 1];
                }
            }
            return kq;
        }
    }
}
