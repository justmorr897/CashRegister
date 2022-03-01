using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class background : Form
    {
        double burgerNum;
        double friesNum;
        double cokeNum;

        double burgerPrice = 3.99;
        double friesPrice = 3.49;
        double cokePrice = 1.99;
        double tax = 0.13;

        double subtotal;
        double taxAmount;
        double total;
        double tendered;
        double change;
        double burgerTotal;
        double friesTotal;
        double cokeTotal;

        public background()
        {
            InitializeComponent();
        }

        private void burgerInput_TextChanged(object sender, EventArgs e)
        {
            orderProgress.Value = 16;

        }
        private void friesInput_TextChanged(object sender, EventArgs e)
        {
            orderProgress.Value = 32;

        }
        private void cokeInput_TextChanged(object sender, EventArgs e)
        {
            orderProgress.Value = 48;

        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            orderProgress.Value = 64;

            SoundPlayer cashregister = new SoundPlayer(Properties.Resources.cashregister);
            cashregister.Play();

            try
            {
                burgerNum = Convert.ToDouble(burgerInput.Text);
                friesNum = Convert.ToDouble(friesInput.Text);
                cokeNum = Convert.ToDouble(cokeInput.Text);

                burgerTotal = burgerNum * burgerPrice;
                friesTotal = friesNum * friesPrice;
                cokeTotal = cokeNum * cokePrice;

                subtotal = burgerTotal + friesTotal + cokeTotal;
                subtotalOutput.Text = subtotal.ToString("C");

                taxAmount = subtotal * tax;
                taxOutput.Text = taxAmount.ToString("C");

                total = taxAmount + subtotal;
                totalOutput.Text = total.ToString("C");

                changeButton.Enabled = true;
            }
            catch
            {
                cashregister.Stop();
                SoundPlayer error = new SoundPlayer(Properties.Resources.error);
                error.Play();

                receiptLabel.Text = "ERROR";
                subtotalOutput.Text = "ERROR";

                taxOutput.Text = "";
                totalOutput.Text = "";
                changeOutput.Text = "";
                tenderedInput.Clear();
                burgerInput.Clear();
                friesInput.Clear();
                cokeInput.Clear();

                orderProgress.Value = 0;
            }
        }

        private void tenderedInput_TextChanged(object sender, EventArgs e)
        {
            //SoundPlayer cashregister = new SoundPlayer(Properties.Resources.cashregister);
            //cashregister.Play();

            orderProgress.Value = 80;

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            SoundPlayer cashregister = new SoundPlayer(Properties.Resources.cashregister);
            cashregister.Play();

            orderProgress.Value = 100;

            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);

                change = tendered - total;
                changeOutput.Text = change.ToString("C");

                printButton.Enabled = true;
            }
            catch
            {
                cashregister.Stop();
                SoundPlayer error = new SoundPlayer(Properties.Resources.error);
                error.Play();

                receiptLabel.Text = "Error";
                changeOutput.Text = "ERROR";

                taxOutput.Text = "";
                totalOutput.Text = "";
                subtotalOutput.Text = "";
                tenderedInput.Clear();
                burgerInput.Clear();
                friesInput.Clear();
                cokeInput.Clear();
                orderProgress.Value = 0;

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            SoundPlayer cashregister = new SoundPlayer(Properties.Resources.cashregister);
            cashregister.Play();

            receiptLabel.Text = "";
            receiptLabel.Size = new Size(receiptLabel.Width, receiptLabel.Height - 364);

            if (tendered < total)
            {
                receiptLabel.Size = new Size(receiptLabel.Width, receiptLabel.Height + 364);
                receiptLabel.Visible = true;
                receiptLabel.Text += "YOU ARE NOW IN DEBT TO ME";
                receiptLabel.Font = new Font("Tahoma", 18);
                receiptLabel.TextAlign = ContentAlignment.TopCenter;
                receiptLabel.ForeColor = Color.Red;

            }

            else
            {
                SoundPlayer printsound = new SoundPlayer(Properties.Resources.printer);
                printsound.Play();

                receiptLabel.Font = new Font("Consolas", 9);
                receiptLabel.ForeColor = Color.Black;
                printMotion();
                textDisplay();
            }
        }

        private void textDisplay()
        {
            receiptLabel.Text += "\nTHANKS FOR CHOOSING MORRISON'S MORSELS!!!";
            receiptLabel.Refresh();

            printMotion();
            receiptLabel.Font = new Font("Consolas", 9);
            receiptLabel.Text += "\n\n   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nHamburgers x{burgerNum}";
            receiptLabel.Text += $"         @ {burgerTotal.ToString("C")}";
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nFries x{friesNum}              @ ";
            receiptLabel.Text += friesTotal.ToString("C");
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nCokes x{cokeNum}              @ ";
            receiptLabel.Text += cokeTotal.ToString("C");
            receiptLabel.Refresh();

            receiptLabel.Text += "\n\n   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nSubtotal              ";
            receiptLabel.Text += subtotal.ToString("C");
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nTax Amount            ";
            receiptLabel.Text += taxAmount.ToString("C");
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nTotal Price           ";
            receiptLabel.Text += total.ToString("C");
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += "\n\n   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nTendered              ";
            receiptLabel.Text += tendered.ToString("C");
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\nChange                ";
            receiptLabel.Text += change.ToString("C");
            receiptLabel.Refresh();

            printMotion();

            receiptLabel.Text += $"\n\n            HAVE A NICE DAY";
            receiptLabel.Refresh();

            printMotion();

        }

        private void printMotion()
        {
            receiptLabel.Visible = true;

            for (int i = 0; i < 29; i++)
            {
                receiptLabel.Size = new Size(receiptLabel.Width, receiptLabel.Height + 1);
                receiptLabel.Refresh();
                Thread.Sleep(9);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer newSound = new SoundPlayer(Properties.Resources.whoosh);
            newSound.Play();


            changeButton.Enabled = false;
            printButton.Enabled = false;

            receiptLabel.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";
            tenderedInput.Clear();
            burgerInput.Clear();
            friesInput.Clear();
            cokeInput.Clear();

            double subtotal = 0;
            double taxAmount = 0;
            double total = 0;
            double tendered = 0;
            double change = 0;
            double burgerTotal = 0;
            double friesTotal = 0;
            double cokeTotal = 0;

            receiptLabel.Size = new Size(receiptLabel.Width, receiptLabel.Height - 364);
            receiptLabel.Refresh();

            orderProgress.Value = 0;

        }
    }
}
