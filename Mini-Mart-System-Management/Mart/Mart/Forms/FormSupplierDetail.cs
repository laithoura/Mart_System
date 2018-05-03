using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mart.InstanceClasses;
namespace Mart.Forms
{
    public partial class FormSupplierDetail : Form
    {
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private Supplier sup;
      
        public FormSupplierDetail()
        {
            InitializeComponent();
            pBannerTop.MouseDown += DoMouseDown;
            pBannerTop.MouseUp += DoMouseUp;
            pBannerTop.MouseMove += DoMouseMove;

            lblTitle.MouseDown += DoMouseDown;
            lblTitle.MouseUp += DoMouseUp;
            lblTitle.MouseMove += DoMouseMove;
        }


        void DoMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 100;
                mouseY = MousePosition.Y - 10;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        void DoMouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        void DoMouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
        private void SetDataToControls()
        {
            if (sup == null) return;
           lblSupID.Text = sup.ID.ToString();
            lblSupFirstName.Text = sup.FirstName.ToString();
            lblSupLastName.Text = sup.LastName.ToString();
            if (sup.Gender == "Male") lblGender.Text = "Male";
            else if (sup.Gender == "Female") lblGender.Text = "Female";
            lblPNumber.Text = sup.pNumber.ToString();
            dtpSupBd.Value = sup.BirthDate;
            lblEmail.Text = sup.Email;
            lblCompany.Text = sup.Company;
           


         
        }
     
        public FormSupplierDetail(Supplier sup):this()
        {
            
            this.sup = sup;
        }
      

         private void frmSupplierDetail_Load(object sender, EventArgs e)
        {
         
           
             if (sup != null)
            {
                
                SetDataToControls();
            }
             dtpSupBd.CustomFormat = "yyyy";
             dtpSupBd.Enabled = false;
             
            // lblSupAge.Text +=age.ToString();
        }

         private void dtpSupBd_SizeChanged(object sender, EventArgs e)
         {
             TimeSpan age = DateTime.Now - dtpSupBd.Value;
             int years = DateTime.Now.Year - dtpSupBd.Value.Year;
             if (dtpSupBd.Value.AddYears(years) > DateTime.Now) years--;
           

         }

         private void dtpSupBd_ValueChanged(object sender, EventArgs e)
         {
             TimeSpan age = DateTime.Now - dtpSupBd.Value;
             int years = DateTime.Now.Year - dtpSupBd.Value.Year;
             if (dtpSupBd.Value.AddYears(years) > DateTime.Now) years--;
            
         }

         private void label1_Click(object sender, EventArgs e)
         {

         }

         private void label2_Click(object sender, EventArgs e)
         {

         }

         private void label3_Click(object sender, EventArgs e)
         {

         }

         private void Gender_Click(object sender, EventArgs e)
         {

         }

         private void label4_Click(object sender, EventArgs e)
         {

         }

         private void label6_Click(object sender, EventArgs e)
         {

         }

         private void label5_Click(object sender, EventArgs e)
         {

         }

         private void label7_Click(object sender, EventArgs e)
         {

         }

         private void lblSupID_Click(object sender, EventArgs e)
         {

         }

         private void lblSupFirstName_Click(object sender, EventArgs e)
         {

         }

         private void lblSupLastName_Click(object sender, EventArgs e)
         {

         }

         private void lblGender_Click(object sender, EventArgs e)
         {

         }

         private void label8_Click(object sender, EventArgs e)
         {

         }

         private void lblPNumber_Click(object sender, EventArgs e)
         {

         }

         private void lblEmail_Click(object sender, EventArgs e)
         {

         }

         private void lblCompany_Click(object sender, EventArgs e)
         {

         }

         private void lblSupAge_Click(object sender, EventArgs e)
         {

         }

         private void dtpSupBd_ValueChanged_1(object sender, EventArgs e)
         {

         }

         private void pictureBox3_Click(object sender, EventArgs e)
         {
             this.WindowState = FormWindowState.Minimized;
         }

         private void pictureBox2_Click(object sender, EventArgs e)
         {
             this.Close();
         }
        }
    }

