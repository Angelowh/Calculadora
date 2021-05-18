using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "0";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "0";
                resultado.Text += userInput;
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "1";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "1";
                resultado.Text += userInput;
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "2";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "2";
                resultado.Text += userInput;
            }
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "3";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "3";
                resultado.Text += userInput;
            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "4";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "4";
                resultado.Text += userInput;
            }
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "5";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "5";
                resultado.Text += userInput;
            }
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "6";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "6";
                resultado.Text += userInput;
            }
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "7";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "7";
                resultado.Text += userInput;
            }
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "8";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "8";
                resultado.Text += userInput;
            }
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                resultado.Text = "";
                userInput = "9";
                resultado.Text = userInput;
            }
            else
            {
                resultado.Text = "";
                userInput += "9";
                resultado.Text += userInput;
            }
        }

        private void bt_dividir_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void bt_multiplicar_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void bt_subtracao_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void bt_mais_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNum + secondNum;
                resultado.Text = result.ToString();
            }
            else if (function == '-')
            {
                result = firstNum - secondNum;
                resultado.Text = result.ToString();
            }
            else if (function == '*')
            {
                result = firstNum * secondNum;
                resultado.Text = result.ToString();
            }
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    resultado.Text = "Error";
                }
                else
                {
                    result = firstNum / secondNum;
                    resultado.Text = result.ToString();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            resultado.Text = "0";
        }

        private void bt_decimal_Click(object sender, EventArgs e)
        {
            resultado.Text += ".";
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btminimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void porcent_Click(object sender, EventArgs e)
        {
            first = userInput;
            double firstNum;
            firstNum = Convert.ToDouble(first);
            result = firstNum / 100;
            resultado.Text = result.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            userInput = "0";
            resultado.Text = userInput;
        }
    }
}
