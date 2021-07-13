using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNP_original_
{
    public partial class Edit : Form
    {
        // We Call The Class And Make two parameter in it
        public Contact c1;
        
        
      

        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
           // we Just Show The Datas in tex boxes
                textBox1.Text = c1.FirstName;
                textBox2.Text = c1.LastName;
                textBox3.Text = c1.Ncode;
                textBox4.Text = c1.EMail;
      
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //We Assighment Text boxes in Parameteres And Play Save Methode
                c1.FirstName = textBox1.Text;
                c1.LastName = textBox2.Text;
                c1.Ncode = textBox3.Text;
                c1.EMail = textBox4.Text;
                
                Contact.Save();

                
           
            MessageBox.Show("Your Informations Saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            DialogResult d = new DialogResult();
            d = MessageBox.Show("Are You Sure About Cancel This Process?!"
                , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
