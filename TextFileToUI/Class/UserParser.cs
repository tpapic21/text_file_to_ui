using System.Windows.Forms;

namespace TextFileToUI
{
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







}
