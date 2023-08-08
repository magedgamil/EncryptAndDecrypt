using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncAndDec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

        private static MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();


        public static byte[] MD5Hash(string value)
        {
            return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CBKey.Text != "" && TxtEncrypted.Text != "")
            {
                Decrypt(CBKey.Text, TxtEncrypted.Text);
                TxtDecrypted.Text = Decrypt(CBKey.Text, TxtEncrypted.Text);
            }
            else
            {
                MessageBox.Show("please Fill The Fileds", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Decrypt(string key,string encryptedString)
        {
            try
            {
           
                    
                    DES.Key = MD5Hash(key);
                    DES.Mode = CipherMode.ECB;
                    byte[] Buffer = Convert.FromBase64String(encryptedString);
                    return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length));
                }
                      
            catch (Exception)
            {

            }
            return string.Empty;
        }
    }
    }

