using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu1 : Form
    {
       public static  decimal _TotalPrice = 0;///done
        public static string Topping = null;///done
        public static string Size = null;///done
        public static string CrustType = null;///done
        public static string ToEat = null;
        public MainMenu1()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Imoge_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu1_Load(object sender, EventArgs e)
        {
            
        }


        private void Check()
        {
            if ((RD_Small.Checked || RD_Medium.Checked || RD_Larg.Checked)
               && (RDB_EatIn.Checked || RDB_Takeout.Checked) &&
           
               ( RD_ThickCurst.Checked || RD_ThinCrust.Checked))
            {

                FRM_Result Frm = new FRM_Result();
                Frm.Show();
                if (Frm.Enabled)
                {
                    MessageBox.Show("Thanks 🍕 Price Is : " + _TotalPrice.ToString());

                }
            }
            else
            {

                MessageBox.Show("Sorry  Try Choose : ", "Try", MessageBoxButtons.OK, MessageBoxIcon.Error);// add messeg Wrong 
            }
        }
        private void BUT_OrderPizza_Click(object sender, EventArgs e)
        {


            //    FRM_Result Frm = new FRM_Result();
            //    Frm.Show();
            //   if (Frm.Enabled)
            // {
            //      MessageBox.Show("Thanks 🍕 Price Is : " + _TotalPrice.ToString());

            //   }
            //}
            Check();
        }




        private void BUT_ResetForm_Click(object sender, EventArgs e)
        {

            Check();
            //FRM_Result Frm = new FRM_Result();
            //Frm.Show();
        }
       

        private void UpdatePrice ()
        {
            Topping = "";
            _TotalPrice = 0;
            ToEat = "";
            
            foreach (Control Con in GrbSize.Controls)
            {
                if (Con is RadioButton Cu && Cu.Checked)
                {
                    _TotalPrice = decimal.Parse(Cu.Tag.ToString());
                    Size = Cu.Text;
                    break;

                }
            }
            if (RD_ThickCurst.Checked)
            {
                _TotalPrice += decimal.Parse(RD_ThickCurst.Tag.ToString());
                CrustType = RD_ThickCurst.Text;

            }
            else if (RD_ThinCrust.Checked)
            {
                _TotalPrice += decimal.Parse(RD_ThinCrust.Tag.ToString());
                CrustType = RD_ThinCrust.Text;
            }

          

            foreach (Control Hold in Grb_Topping.Controls)
            {
                if (Hold is CheckBox CHB && CHB.Checked)
                {
                    _TotalPrice += decimal.Parse(CHB.Tag.ToString());
                    Topping += CHB.Text + ", ";
                }


            }
            if (Topping.EndsWith(", ")) Topping.Substring(0, Topping.Length - 2);
            /// this is space " ," space and ,
            if (RDB_EatIn.Checked) ToEat = RDB_EatIn.Text;
            else if (RDB_Takeout.Checked) ToEat = RDB_Takeout.Text;


            LB_Price.Text = _TotalPrice.ToString() + "LE";
        }
        

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void RD_Small_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void RD_Medium_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void RD_ThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void RD_ThickCurst_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void CHB_Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void CHB_Olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void CHB_Musgrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void CHB_GreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void CHB_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void RDB_EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();

        }
      
    }
}
