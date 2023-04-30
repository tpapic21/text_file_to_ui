using System.Windows.Forms;

namespace TextFileToUI
{
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







}
