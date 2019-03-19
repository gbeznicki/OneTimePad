using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// problem z kodowaniem polskich znaków: https://www.di-mgt.com.au/cryptoInternational2.html

namespace OneTimePad
{
    public partial class Form1 : Form
    {
        private Encryptor encryptor;
        private byte[] fileToEncryptOrDecrypt;
        private string fileExtension;
        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            buttonSifre.Enabled = false;
            buttonDesifre.Enabled = false;
            encryptor = new Encryptor();
        }

        private void buttonSifre_Click(object sender, EventArgs e)
        {

            if (radioButtonText.Checked)
            {
                if (textBoxDesifred.Text.Length == 0)
                {
                    MessageBox.Show("Wprowadź tekst do szyfrowania");
                    return;
                }
                if(textBoxKey.Text.Length == 0)
                {
                    MessageBox.Show("Najpierw wylosuj klucz do szyfrowania");
                    return;
                }
                //Zamiana string na tablicę bajtów przy zapewnieniu kodowania UTF-8
                byte[] encrypted = encryptor.encrypt(Encoding.GetEncoding("UTF-8").GetBytes(textBoxDesifred.Text));

                //wyświetlenie zaszyfrowanej wiadomości przy pomocy kodowania Base64 (ze względu na problem ze znakami z alfabetu łacińskiego
                textBoxSifred.Text = System.Convert.ToBase64String(encrypted);
            }
            else //TODO: import z pliku i szyfrowanie
            {
                if (textBoxKey.Text.Length == 0)
                {
                    MessageBox.Show("Najpierw wylosuj klucz do szyfrowania");
                    return;
                }
                //zapisanie zaszyfrowanego strumienia bajtów do pliku
                File.WriteAllBytes("D:\\Pulpit\\AA_One_time\\zaszyfrowane", encryptor.encrypt(fileToEncryptOrDecrypt));
            }
        }

        private void buttonDesifre_Click(object sender, EventArgs e)
        {
            if (radioButtonText.Checked)
            {
                if (textBoxSifred.Text.Length == 0)
                {
                    MessageBox.Show("Wprowadź tekst do deszyfrowania");
                    return;
                }

                //Odkodowanie tekstu z base64 i zapisanie do tablicy bajtów
                byte[] toDecrypt = System.Convert.FromBase64String(textBoxSifred.Text);

                //odszyfrowanie tablicy bajtów przy pomocy wcześniej użytego klucza szyfrującego
                byte[] decrypted = encryptor.decrypt(toDecrypt);

                //wypisanie odszyfrowanego tekstu wykorzystując kodowanie UTF-8
                textBoxDesifred.Text = Encoding.UTF8.GetString(decrypted);
            }
            else //TODO: import z pliku i deszyfrowanie
            {
                //odczytanie zaszyfrowanego pliku i zapisanie do zmiennej
                fileToEncryptOrDecrypt = File.ReadAllBytes("D:\\Pulpit\\AA_One_time\\zaszyfrowane");

                //odszyfrowanie zapisanego w pamięci zaszyfrowanego pliku i zapisanie wyniku do pliku
                File.WriteAllBytes("D:\\Pulpit\\AA_One_time\\odszyfrowane"+fileExtension, encryptor.decrypt(fileToEncryptOrDecrypt));
            }

        }

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            textBoxDesifred.Enabled = true;
            textBoxSifred.Enabled = true;
            buttonFile.Enabled = false;
        }

        private void radioButtonFile_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            textBoxDesifred.Enabled = false;
            textBoxSifred.Enabled = false;
            buttonFile.Enabled = true;
        }

        private void radioButtonSifre_CheckedChanged(object sender, EventArgs e)
        {
            buttonSifre.Enabled = true;
            buttonDesifre.Enabled = false;
            if (radioButtonText.Checked)
            {
                //textBoxDesifred.ReadOnly = false;
                //textBoxSifred.ReadOnly = true;
            }
        }

        private void radioButtonDesifre_CheckedChanged(object sender, EventArgs e)
        {
            buttonSifre.Enabled = false;
            buttonDesifre.Enabled = true;
            if (radioButtonText.Checked)
            {
                //textBoxDesifred.ReadOnly = true;
                //textBoxSifred.ReadOnly = false;
            }
        }

        private void buttonDrawKey_Click(object sender, EventArgs e)
        {
            if (radioButtonFile.Checked)
            {
                textBoxKey.Text = encryptor.generateOneTimePadKey(fileToEncryptOrDecrypt.Length);
            }
            else
            {
                if (textBoxDesifred.Text.Length > 0)
                    this.textBoxKey.Text = encryptor.generateOneTimePadKey(Encoding.GetEncoding("UTF-8").GetBytes(textBoxDesifred.Text.ToCharArray()).Length);
                else
                    textBoxKey.Text = encryptor.generateOneTimePadKey(256);
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileToEncryptOrDecrypt = File.ReadAllBytes(openFileDialog.FileName);
                IfFIleIsChosen.Text = "Plik został załadowany do pamięci";
                fileExtension = Path.GetExtension(openFileDialog.FileName);
            }
        }
    }
}
