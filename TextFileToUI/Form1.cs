using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileToUI
{
    

    public partial class Form1 : Form
    {
        UserFileReading userFile;
        UserParser userParser;
        UserDisplayer userDisplayer;
        public Form1()
        {
            InitializeComponent();
            userFile = new UserFileReading();
            
        }

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            userFile.ChooseFile(this);
        }
    }

    public class UserFileReading
    {
        OpenFileDialog ofd;

        public UserFileReading()
        {
            ofd = new OpenFileDialog();
        }
        public void ChooseFile(TextFileToUI.Form1 k)
        {
            
            ofd.ShowDialog(k);
            
        }
        public string ReadFile()
        {
          
            var filestream = ofd.OpenFile();
            using (StreamReader reader = new StreamReader(filestream))
            {
                return reader.ReadToEnd();
            }
        }
        
    }

    public class UserParser
    {
        User user;
        string file = null;
        public UserParser(string file)
        {
            user = new User();
            this.file = file;

        }

        public User SortData()
        {

            try
            {
                user.Ime = file.Substring(file.IndexOf("Ime") + 4, (file.IndexOf("Prezime")) - (file.IndexOf("Ime") + 4));
                user.Prezime = file.Substring(file.IndexOf("Prezime") + 8, file.IndexOf("Godina rođenja") - (file.IndexOf("Prezime") + 8));
                user.GodinaRodjenja = int.Parse(file.Substring(file.IndexOf("Godina rođenja") + 15, file.IndexOf("Grad rođenja") - (file.IndexOf("Godina rođenja") + 15)));
                user.GradRodjenja = file.Substring(file.IndexOf("Grad rođenja") + 13, file.IndexOf("Fakultet") - ((file.IndexOf("Grad rođenja") + 13)));
                user.Fakultet = file.Substring(file.IndexOf("Fakultet") + "Fakultet".Length + 1, file.IndexOf("Uloga") - (file.IndexOf("Fakultet") + "Fakultet".Length + 1));


                if (file.Contains("Najdraži kolegij"))
                {
                    user.Uloga = file.Substring(file.IndexOf("Uloga") + "Uloga".Length + 1, file.IndexOf("Najdraži kolegij") - (file.IndexOf("Uloga") + "Uloga".Length + 1));
                    user.NajdraziKolegij = file.Substring(file.IndexOf("Najdraži kolegij") + "Najdraži kolegij".Length + 1, file.IndexOf("Datoteci pristupljeno puta") - (file.IndexOf("Najdraži kolegij") + "Najdraži kolegij".Length + 1));

                }
                else
                {
                    user.Uloga = file.Substring(file.IndexOf("Uloga") + "Uloga".Length + 1, file.IndexOf("Katedra") - (file.IndexOf("Uloga") + "Uloga".Length + 1));
                    user.Katedra = file.Substring(file.IndexOf("Katedra") + "Katedra".Length + 1, file.IndexOf("Datoteci pristupljeno puta") - (file.IndexOf("Katedra") + "Katedra".Length + 1));

                }

                return user;
            }

            catch
            {
                MessageBox.Show("Doslo je do greske", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

        }

    }

    public class UserDisplayer
    {
        User User;
        string textForLabel = null;
        TextBox nameT,yearT,cityT,facultyT,roleT,specificT;
        public UserDisplayer(User user, TextBox name,TextBox year, TextBox city, TextBox faculty, TextBox role, TextBox specific) { 

            User= user;
            nameT = name;
            yearT= year;
            cityT= city;
            facultyT= faculty;
            roleT= role;
            specificT= specific;
        }

        public void PutData()
        {
            nameT.Text=User.Ime+" "+User.Prezime;
            yearT.Text = User.GodinaRodjenja.ToString();
            cityT.Text = User.GradRodjenja;
            facultyT.Text = User.Fakultet;
            roleT.Text = User.Uloga;
            if (User.NajdraziKolegij != null)
            {
                specificT.Text = User.NajdraziKolegij;
                textForLabel = "Najdraži kolegij: ";
            }
            else
            { specificT.Text = User.Katedra; textForLabel = "Katedra: "; }

            
        } 

        public string LabelText()
        {
            return textForLabel;
        }

    }

    public class User
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string GradRodjenja { get; set; }
        public int GodinaRodjenja { get; set; }
        public string Fakultet { get; set; }
        public string Uloga { get; set; }
        public string NajdraziKolegij { get; set; }
        public string Katedra { get; set; }
    }







}
