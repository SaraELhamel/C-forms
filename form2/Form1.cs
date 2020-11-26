using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int validname = 0;
        int validprenom = 0;
        int validtele = 0;
        int valid_email = 0;
        int validpays = 0;
        int validville = 0;
        int specialite = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
          
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            valid_name(textBox1.Text);
            valid_prenom(textBox2.Text);
            isvalid_telephone(textBox3.Text);
            isvalid_email(textBox4.Text);
            if (comboBox1.Text == "")
            {
                validpays++;
                label7.Text = "merci de sélectionner un pays";
            }
            else
            {
                label7.Text = "";
                validpays = 0;
            }
            if (comboBox2.Text == "")
            {
                label8.Text = "merci de sélectionner une ville";
                validville++;

            }
            else
            {
                label8.Text = "";
                validville = 0;
            }

            if (comboBox3.Text == "")
            {
                label10.Text = "merci de sélectionner une spécialité";
                specialite++;
            }
            else
            {
                label10.Text = "";
                specialite = 0;
            }


            //message de validation
            if (validname == 0 && validprenom == 0 && validtele == 0 && valid_email == 0 && validpays == 0 && validville == 0 && specialite == 0)
            {

                label11.Text = "vous information est validé avec succès";
            }
        }

        public bool valid_name(string nom)
        {
            Regex check = new Regex(@"^([a-z-A-Z]+)$");
            bool valid = false;
            valid = check.IsMatch(nom);
            if (valid == true)
            {
                validname = 0;
                label2.Text = "true value";
                return valid;
            }
            else
            {
                validname++;
                label2.Text = "nom est incorrect";
                return valid;

            }
        }
        public bool valid_prenom(string prenom)
        {
            Regex check = new Regex(@"^([a-z-A-Z]+)$");
            bool valid = false;
            valid = check.IsMatch(prenom);
            if (valid == true)
            {
                validprenom = 0;
                this.prenom.Text = "true value";
                return valid;
            }
            else
            {
                validprenom++;
                this.prenom.Text = "prenom est incorrect";
                return valid;

            }
        }
        public bool isvalid_telephone(string n)
        {
            Regex check = new Regex(@"^([0-9]+)$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid == true)
            {
                validtele = 0;
                tel.Text = "";
                return valid;
            }
            else
            {
                validtele++;
                tel.Text = "telephone est incorrect";
                return valid;
            }
        }
        public bool isvalid_email(string email)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valide = false;
            valide = check.IsMatch(email);
            if (valide == true)
            {
                valid_email = 0;
              label5.Text = "";
                return valide;
            }
            else
            {
                valid_email++;
               label5.Text = "email est incorrect";
                return valide;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox1.Text == "Maroc")
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Safi");
                    comboBox2.Items.Add("Agadir");
                    comboBox2.Items.Add("Esaouira");
                    comboBox2.Items.Add("Titouan");
                }
                else if (comboBox1.Text == "France")
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Paris");
                    comboBox2.Items.Add("Lyon");
                    comboBox2.Items.Add("Toulouse");
                    comboBox2.Items.Add("Tours");
                }
                else if (comboBox1.Text == "Allemand")
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Bonn");
                    comboBox2.Items.Add("Berlin");
                }
            }
      
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {

        }
    }
}

