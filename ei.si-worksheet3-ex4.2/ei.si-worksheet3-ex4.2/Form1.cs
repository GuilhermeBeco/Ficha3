using EI.SI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ei_si_worksheet3
{
    public partial class Form1 : Form
    {
        private StreamReader fileStreamReader;
        private FileStream file;
        private StreamWriter fileStreamWriter;
        private AesCryptoServiceProvider algorithm;
        private SymmetricsSI symmetricsSI;
        private string textFile;
        private string textFileTemp;

        public Form1()
        {
            algorithm = new AesCryptoServiceProvider();
            symmetricsSI = new SymmetricsSI(algorithm);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {              
                //file = new FileStream("temp.dat", FileMode.OpenOrCreate);
                byte[] textFileBytes = Encoding.UTF8.GetBytes(textFile);
                string textFile64 = Convert.ToBase64String(textFileBytes);
                byte[] clearBytes = Encoding.UTF8.GetBytes(textFile64);
                byte[] encryptedBytes = null;
                encryptedBytes = symmetricsSI.Encrypt(clearBytes);
                if (encryptedBytes.Length >= 100)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        textBoxEncryptedData.AppendText(encryptedBytes[i].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < encryptedBytes.Length; i++)
                    {
                        textBoxEncryptedData.AppendText(encryptedBytes[i].ToString());
                    }
                }
                fileStreamWriter = new StreamWriter("temp.dat");
                fileStreamWriter.WriteLine(Convert.ToBase64String(encryptedBytes));
                MessageBox.Show(Convert.ToBase64String(encryptedBytes));

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
                if (fileStreamReader != null)
                {
                    fileStreamReader.Dispose();
                }
                if (fileStreamWriter != null)
                {
                   fileStreamWriter.Dispose();
                }
            }
        }


        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileStreamReader = new StreamReader(openFileDialog1.FileName);
                textFile = fileStreamReader.ReadToEnd();
                byte[] clearBytes = Encoding.UTF8.GetBytes(textFile);
                if (textFile.Length>=200){
                    for (int i = 0; i < 200; i++) {
                        textBoxDataToEncrypt.AppendText(clearBytes[i].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < textFile.Length; i++)
                    {
                        textBoxDataToEncrypt.AppendText(clearBytes[i].ToString());
                    }
                }
            }
        }


        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                
                fileStreamReader = new StreamReader("temp.dat");
                textFileTemp = fileStreamReader.ReadToEnd();
                MessageBox.Show(textFileTemp);
                byte[] encryptedBytes= Convert.FromBase64String(textFileTemp);
                byte[] clearBytes = null;
                clearBytes = symmetricsSI.Decrypt(encryptedBytes);
                if (clearBytes.Length >= 200)
                {
                    for (int i = 0; i < 200; i++)
                    {
                        textBoxDecryptedData.AppendText(clearBytes[i].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < clearBytes.Length; i++)
                    {
                        textBoxDecryptedData.AppendText(clearBytes[i].ToString());
                    }
                }
                fileStreamReader.Close();
                fileStreamWriter = new StreamWriter("temp.dat");
                fileStreamWriter.WriteLine(Convert.ToBase64String(clearBytes));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
              
                if (fileStreamReader != null)
                {
                    fileStreamReader.Dispose();
                }
                if (fileStreamWriter != null)
                {
                    fileStreamWriter.Dispose();
                }
            }
        }
    }
}
