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
namespace Shop
{
    public partial class Form1 : Form
    {
        double missile;
        double missileCost = 50;
        double supermissile;
        double supermissileCost = 200;
        double morphball;
        double morphballCost = 500;
        double subtotal;
        double tax;
        double taxCost = 0.13;
        double total;
        double tendered;
        double change;
        double subtotal1;
        double subtotal2;
        double subtotal3;   
        public Form1()
        {
            InitializeComponent();
            SoundPlayer ambient = new SoundPlayer(Properties.Resources.Ambient);
            ambient.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (missileInput.Text == "")
                {
                    missileInput.Text = "0";
                }

                if (supermissileInput.Text == "")
                {
                    supermissileInput.Text = "0";
                }

                if (morphballInput.Text == "")
                {
                    morphballInput.Text = "0";
                }
                missile = Convert.ToDouble(missileInput.Text);
                supermissile = Convert.ToDouble(supermissileInput.Text);
                morphball = Convert.ToDouble(morphballInput.Text);

                subtotal1 = missile * missileCost;
                subtotal2 += supermissile * supermissileCost;
                subtotal3 += morphball * morphballCost;

                subtotal = subtotal1 + subtotal2 + subtotal3;

                tax = subtotal * taxCost;
                total = subtotal + tax;

                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{tax.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";

            }
            catch
            {
                subtotalOutput.Text = "!INVALID!";
                taxOutput.Text = "!INVALID!";
                totalOutput.Text = "!INVALID!";
                tenderedInput.Text = "!INVALID!";
                changeOutput.Text = "!INVALID!";
            }

            //private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

            //private void button2_Click(object sender, EventArgs e)
            {

            }
        }

        private void missileInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                tendered = Convert.ToDouble(tenderedInput.Text);

                change = tendered - total;

                changeOutput.Text = $"{change.ToString("C")}";

            }
            catch
            {
                subtotalOutput.Text = "!INVALID!";
                taxOutput.Text = "!INVALID!";
                totalOutput.Text = "!INVALID!";
                tenderedInput.Text = "!INVALID!";
                changeOutput.Text = "!INVALID!";
            }
        }

        private void receiptLabel_Click(object sender, EventArgs e)
        {

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {

            SoundPlayer receiptnoise = new SoundPlayer(Properties.Resources.ReceiptNoise);
            receiptnoise.Play();
            
            receiptLabel.Text = "";
            receiptLabel.Text = $"\n          METROID SHOP";
            Refresh();
            Thread.Sleep(700);
            
            receiptLabel.Text += $"\n\n    Order Number 2006";
            Refresh();
            Thread.Sleep(700);
            receiptLabel.Text += $"\n    October 3, 2022";
            Refresh();
            Thread.Sleep(700);

            receiptLabel.Text += $"\n\n    Missile          x{missile} @ {missileCost}";
            Refresh();
            Thread.Sleep(700);
            receiptLabel.Text += $"\n    Super Missile    x{supermissile} @ {supermissileCost}";
            Refresh();
            Thread.Sleep(700); 
            receiptLabel.Text += $"\n    Morph Ball       x{morphball} @ {morphballCost}";
            Refresh();
            Thread.Sleep(700);

            receiptLabel.Text += $"\n\n    Subtotal         {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(700);
            receiptLabel.Text += $"\n    Tax              {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(700);
            receiptLabel.Text += $"\n    Total            {total.ToString("C")}";
            Refresh();
            Thread.Sleep(700);

            receiptLabel.Text += $"\n\n    Tendered         {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(700);
            receiptLabel.Text += $"\n    Change           {change.ToString("C")}";
            Refresh();
            Thread.Sleep(700);

            receiptLabel.Text += $"\n\n\n        Dont DIE!";
            SoundPlayer ambient = new SoundPlayer(Properties.Resources.Ambient);
            ambient.Play();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            subtotalOutput.Text ="";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "";
            changeOutput.Text = "";
            missileInput.Text = "";
            supermissileInput.Text = "";
            morphballInput.Text = "";
            receiptLabel.Text = "";
        }
    }
}

