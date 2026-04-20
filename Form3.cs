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
    public partial class FRM_Result : Form 
    {
        public FRM_Result()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Result_Load(object sender, EventArgs e)
        {
            L_TotalPrice.Text = (MainMenu1._TotalPrice.ToString());
            L_Size.Text = MainMenu1.Size;
            L_Topings.Text = MainMenu1.Topping;
            L_CrustType.Text = MainMenu1.CrustType;
            L_WhereToEat.Text = MainMenu1.ToEat;
       
        }

        private void BUT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void LB_TotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void L_TotalPrice_Click(object sender, EventArgs e)
        {
            //L_TotalPrice.Text =( MainMenu1._TotalPrice.ToString());


        }

        private void L_Size_Click(object sender, EventArgs e)
        {
            //L_Size.Text = MainMenu1.Size;
        }

        private void L_Topings_Click(object sender, EventArgs e)
        {
            //L_Topings.Text = MainMenu1.Topping;
        }

        private void L_CrustType_Click(object sender, EventArgs e)
        {
            //L_CrustType.Text = MainMenu1.CrustType;
        }

        private void L_WhereToEat_Click(object sender, EventArgs e)
        {
            //L_WhereToEat.Text = MainMenu1.ToEat;
        }

        private void LB_Eat_Click(object sender, EventArgs e)
        {

        }

        private void LB_CrustType_Click(object sender, EventArgs e)
        {

        }
    }
}
