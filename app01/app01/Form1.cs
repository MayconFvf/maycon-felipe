using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            if (comboBox1.Text == "hybrida")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("gorilaglue");
                comboBox2.Items.Add("gelato");
            }
            else if (comboBox1.Text == "indica")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("northern-lights");
                comboBox2.Items.Add("purple-punch");
            }
            else if (comboBox1.Text == "sativa")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("jack-herer");
                comboBox2.Items.Add("sourdisel");
            }
            else if (comboBox1.Text == "cbd")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("HARLEY-TSU");
                comboBox2.Items.Add("WHITECBG");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fotoscannabis = Directory.GetFiles(@"C:\Users\Maycon\Desktop\Aplicativos\.vs\aplicativo cannabis\imagen\");
            foreach (string img in fotoscannabis)
            {
                string[] separador = img.Split('\\');
                string[] nomeSelecionado = separador[8].Split('.');

                if (comboBox2.Text == nomeSelecionado[0])
                {
                    string v = @"C:\Users\Maycon\Desktop\Aplicativos\.vs\aplicativo cannabis\imagen\" + comboBox2.Text + ".jpg";
                    if (File.Exists(v))
                    {
                        pictureBox2.ImageLocation = v;
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("imagen nao encontrada" + v);
                    }
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string[] textocanabis = Directory.GetFiles(@"C:\Users\Maycon\Desktop\Aplicativos\.vs\aplicativo cannabis\cbd\");
            foreach (string txt in textocanabis)
            {
                string[] separador1 = txt.Split('\\');
                string[] nomeSelecionado1 = separador1[8].Split('.');

                if (comboBox2.Text == nomeSelecionado1[0])
                {
                    string a = (@"C:\Users\Maycon\Desktop\Aplicativos\.vs\aplicativo cannabis\cbd\" + comboBox2.Text + ".txt");
                    if (File.Exists(a))
                        try
                        {
                            // Abra o arquivo de texto com o aplicativo padrão associado (por exemplo, o Bloco de Notas)
                            Process.Start(a);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message);
                        }
                }

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] textocannabis1 = Directory.GetFiles(@"C:\Users\Maycon\Desktop\Aplicativos\.vs\aplicativo cannabis\cbd\");
            foreach (string txt1 in textocannabis1)
            {
                string[] separador2 = txt1.Split('\\');
                string[] nomeSelecionado2 = separador2[8].Split('.');

                if (comboBox2.Text == nomeSelecionado2[0])
                {
                    string b = comboBox2.Text + ".txt";
                    string caminho = Path.Combine(@"C:\Users\Maycon\Desktop\Aplicativos\.vs\aplicativo cannabis\cbd\", b);

                    if (File.Exists(caminho))
                    {
                        try
                        {
                            string t = File.ReadAllText(caminho);
                            richTextBox1.Text = t;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arquivo de texto não encontrado: " + caminho);
                    }
                }

                    }

                }
                }
            }
       
    
        
    

