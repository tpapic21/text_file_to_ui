using System.IO;
using System.Windows.Forms;

namespace TextFileToUI
{
    public class UserFileReading
    {
        OpenFileDialog ofd;

        public UserFileReading()
        {
            ofd = new OpenFileDialog();
        }
        public void ChooseFile(TextFileToUI.UserInfoForm k)
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
