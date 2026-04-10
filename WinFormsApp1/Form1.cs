using System.Drawing;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int dzienUrodzenia;
        public int miesiacurodzenia;
        public int rokUrodzenia;
        public String imie;
        public String nazwisko;
        public String email;
        public String haslo;
        public String pathName;

        private void SprawdzDane_Click(object sender, EventArgs e)
        {

            Regex validateRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            if (textBox1.Text == "")
            {
                MessageBox.Show("prosze uzupelnic imie");
            }
            else
            {
                imie = textBox1.Text;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("prosze uzupelnic nazwisko");

            }
            else
            {
                nazwisko = textBox2.Text;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("prosze uzupelnic rok urodzenia");
            }
            else
            {
                rokUrodzenia = int.Parse(textBox3.Text);
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("prosze uzupelnic Miesiac urodzenia");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("prosze uzupelnic dzien urodzenia");
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("prosze uzupelnic email");
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("prosze uzupelnic powtorz email");
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("prosze uzupelnic haslo");
            }
            else
            {
                haslo = textBox8.Text;
            }

            if (textBox6.Text != textBox7.Text)
            {
                MessageBox.Show("emaile sie nie zgadzaja");
            }


            if (!Single.IsNaN(float.Parse(textBox5.Text)))
            {
                if (int.Parse(textBox5.Text) <= 31 && int.Parse(textBox5.Text) >= 1)
                {
                    dzienUrodzenia = int.Parse(textBox5.Text);
                }
                if (!Single.IsNaN(float.Parse(textBox4.Text)))
                {
                    if (float.Parse(textBox4.Text) <= 12 && float.Parse(textBox4.Text) >= 1)
                    {
                        miesiacurodzenia = int.Parse(textBox4.Text);
                    }
                    if (validateRegex.IsMatch(textBox6.Text))
                    {
                        email = textBox6.Text;
                    }
                    else
                    {
                        MessageBox.Show("niepoprawny email");
                    }
                }
                else
                {
                    MessageBox.Show("miesiac urodzenia musi byc liczba z zakresu 1-12");
                }
            }
            else
            {
                MessageBox.Show("dzien urodzenia musi byc liczba z zakresu 1-31");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pathName = openFileDialog1.FileName;
            }
        }

        private void Zatwierdü_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.AppendAllText(saveFileDialog1.FileName, imie + "\n" + nazwisko + "\n" + rokUrodzenia + "\n" + miesiacurodzenia + "\n" + dzienUrodzenia + "\n" + email + "\n" + haslo + "\n" + pathName + "\n");
            }
        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] array = File.ReadAllLines(openFileDialog1.FileName);
                if (array.Length <= 7)
                {
                    textBox1.Text = array[0];
                    textBox2.Text = array[1];
                    textBox3.Text = array[2];
                    textBox4.Text = array[3];
                    textBox5.Text = array[4];
                    textBox6.Text = array[5];
                    textBox7.Text = array[5];
                    textBox8.Text = array[6];
                    pictureBox1.Image = Image.FromFile(array[7]);
                }else
                {
                    for (int i = 0; i < array.Length; i+=7)
                    {
                        textBox1.Text = array[i];
                        textBox2.Text = array[i + 1];
                        textBox3.Text = array[i + 2];
                        textBox4.Text = array[i + 3];
                        textBox5.Text = array[i + 4];
                        textBox6.Text = array[i + 5];
                        textBox7.Text = array[i + 5];
                        textBox8.Text = array[i + 6];
                        pictureBox1.Image = Image.FromFile(array[i + 7]);

                    }
                }
                
            }
        }

        private void Nastepna_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            pictureBox1.Image = null;
        }
    }
}
