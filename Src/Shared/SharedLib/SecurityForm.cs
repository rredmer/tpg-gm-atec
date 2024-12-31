using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SharedLib
{
    public partial class SecurityForm : Form
    {
        DESCryptoServiceProvider desProv = new DESCryptoServiceProvider();
        private const string cryptKey = "!!@%!(^&";


        public SecurityForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            desProv.Key = ASCIIEncoding.ASCII.GetBytes(cryptKey);
            desProv.IV = ASCIIEncoding.ASCII.GetBytes(cryptKey);
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            EncryptText();
            ReadPlainText();
            DecryptText();
        }

        public void EncryptText()
        {
            FileStream stream = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Write);
            CryptoStream crStream = new CryptoStream(stream, desProv.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] data = ASCIIEncoding.ASCII.GetBytes(this.plainText.Text);
            crStream.Write(data, 0, data.Length);
            crStream.Close();
            stream.Close();
        }

        public void DecryptText()
        {
            FileStream stream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            CryptoStream crStream = new CryptoStream(stream, desProv.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(crStream);
            string data = reader.ReadToEnd();
            this.decryptedText.Text = data;
            reader.Close();
            stream.Close();
        }

        private void ReadPlainText()
        {
            FileStream stream = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            this.encryptedText.Text = data;
            reader.Close();
            stream.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}