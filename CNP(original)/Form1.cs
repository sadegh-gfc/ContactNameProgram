using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNP_original_
{
    public partial class Form1 : Form
    {
        //New CaontactClass As Two Parameters!
          public Contact c1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact.ContactList.Clear();

            Contact c1 = new Contact();
            Contact.ContactList.Add(c1);

            c1.FirstName = textBox1.Text;
            c1.LastName = textBox2.Text;

            Contact c2 = new Contact();
            Contact.ContactList.Add(c2);

            c2.FirstName = textBox3.Text;
            c2.LastName = textBox4.Text;
           

            
            Contact.Save();
            MessageBox.Show("Your Informations Saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            Contact.Load();
            try
            {
                Contact c1 = Contact.ContactList[0];
                textBox1.Text = c1.FirstName;
                textBox2.Text = c1.LastName;
            }
            catch
            {

            }

            try
            {
                Contact c2 = Contact.ContactList[1];

                textBox3.Text = c2.FirstName;
                textBox4.Text = c2.LastName;
            }
            catch
            {

            }
           

            

            if (Contact.IsThereFile == false)
            {
                MessageBox.Show("Your Informations Diden`t Loaded!" + Environment.NewLine + Environment.NewLine + "Because You Dident Save Any Data", "LoadErorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Contact.IsThereFile = true;
            }
            else
            {
                MessageBox.Show("Your Informations Loaded!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();


            if (textBox1.Text != "" & textBox2.Text != "")
            {
            Contact c1 = Contact.ContactList[0];
                c1.FirstName = textBox1.Text;
                c1.LastName = textBox2.Text;   
                
               // edit.isC1Use = true;
                edit.c1 = c1;
                edit.Show();
            }
            else
            {
                DialogResult d = new DialogResult();
               d = MessageBox.Show("Your Informations have some defect Do You Want To Keep Going?!",
                   "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if  (d == DialogResult.Yes)
                {
                    Contact c1 = Contact.ContactList[0];

                    c1.FirstName = textBox1.Text;

                    c1.LastName = textBox2.Text;
                   
                    
                    edit.c1 = c1;
                    edit.Show();
                    
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          

            if (textBox3.Text != "" & textBox4.Text != "")
            {
                Contact c1 = Contact.ContactList[1];

                c1.FirstName = textBox3.Text;
                c1.LastName = textBox4.Text;           
                
                Edit edit = new Edit();
                edit.c1 = c1;
                edit.Show();
            }
            else
            {
                DialogResult d = new DialogResult();
                d = MessageBox.Show("Your Informations have some defect Do You Want To Keep Going?!"
                    , "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    Contact c1 = Contact.ContactList[1];

                    c1.FirstName = textBox3.Text;
                    c1.LastName = textBox4.Text;
                    
                    Edit edit = new Edit();
                    edit.c1 = c1;
                    edit.Show();
                }
            }   
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Your Informations is Going To Be Deleted!  Do You Want To Keep Going?!"
                , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                    

                System.IO.File.Delete(Contact.path);
              

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            
            Contact.Load();
            if (Contact.IsThereFile == false)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                Contact c1 = Contact.ContactList[0];

                textBox1.Text = c1.FirstName;
                textBox2.Text = c1.LastName;

                Contact c2 = Contact.ContactList[1];
                textBox3.Text = c2.FirstName;
                textBox4.Text = c2.LastName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact.Load();
            Contact c1 = Contact.ContactList[0];
            textBox1.Text = c1.FirstName;
            textBox2.Text = c1.LastName;

            Contact c2 = Contact.ContactList[1];

            textBox3.Text = c2.FirstName;
            textBox4.Text = c2.LastName;

            if (Contact.IsThereFile == false)
            {
                MessageBox.Show("Your Informations Diden`t Loaded!" + Environment.NewLine + Environment.NewLine + "Because You Dident Save Any Data", "LoadErorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Contact.IsThereFile = true;
            }
            else
            {
                MessageBox.Show("Your Informations Loaded!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact c1 = new Contact();
            Contact.ContactList.Add(c1);

            c1.FirstName = textBox1.Text;
            c1.LastName = textBox2.Text;

            Contact c2 = new Contact();
            Contact.ContactList.Add(c2);

            c2.FirstName = textBox3.Text;
            c2.LastName = textBox4.Text;



            Contact.Save();
            MessageBox.Show("Your Informations Saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Your Informations is Going To Be Deleted!  Do You Want To Keep Going?!"
                , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {


                File.Delete(Contact.path);


            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact.Load();
            if (Contact.IsThereFile == false)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                Contact c1 = Contact.ContactList[0];

                textBox1.Text = c1.FirstName;
                textBox2.Text = c1.LastName;

                Contact c2 = Contact.ContactList[1];
                textBox3.Text = c2.FirstName;
                textBox4.Text = c2.LastName;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy Righted By Sadegh Ehsan"
                , "AboutMe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
