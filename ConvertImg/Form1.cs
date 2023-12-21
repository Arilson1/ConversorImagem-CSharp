using System.Security.Cryptography;

namespace ConvertImg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textCaminho.Text = ofd.FileName;
                    //System.Diagnostics.Process.Start(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textCaminho.Text = string.Empty;
            textByte.Text = string.Empty;
        }

        private void converter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCaminho.Text != string.Empty)
                {
                    using (Bitmap bmp = new Bitmap(textCaminho.Text))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmp.Save(ms, bmp.RawFormat);
                            byte[] imageBytes = ms.ToArray();
                            textByte.Text = String.Join("", Array.ConvertAll(imageBytes, byteValue => byteValue.ToString()));
                            textByte.ScrollBars = ScrollBars.Both;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao converter imagem.");
            }
        }

        private void base64_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCaminho.Text != string.Empty)
                {
                    using (Bitmap bmp = new Bitmap(textCaminho.Text))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmp.Save(ms, bmp.RawFormat);
                            byte[] imageBytes = ms.ToArray();
                            textByte.Text = Convert.ToBase64String(imageBytes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao converter imagem.");
            }
        }
    }
}
