using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileToUI
{


    public partial class UserInfoForm : Form
    {
        UserFileReading userFile;
        UserParser userParser;
        UserDisplayer userDisplayer;
        public UserInfoForm()
        {
            InitializeComponent();
            userFile = new UserFileReading();
            
        }

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            userFile.ChooseFile(this);
            userParser = new UserParser(userFile.ReadFile());

            if (userParser.SortData() != null)
            {
                userDisplayer = new UserDisplayer(userParser.SortData(), fullNameBox, yearOfBirth, cityBox, facultyBox, roleBox, specificAttributeBox);
                userDisplayer.PutData();
                specificRoleLabel.Text = userDisplayer.LabelText();
            }
            else
            {
                MessageBox.Show("Odaberite datoteke sa User1 ili User2 nazivom", "Odaberite tekstualnu datoteku", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

        }

    }







}
