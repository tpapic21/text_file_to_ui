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
      
        public Form1()
        {
            InitializeComponent();
            userFile = new UserFileReading();
            
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

   




}
