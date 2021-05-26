using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Gatito
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //********************************************************//
        //Seccion de animaciones//
        //********************************************************//
        #region

        void Alegre()
        {
            string Raiz = Directory.GetCurrentDirectory();
            pictureBox1.Image = Image.FromFile(Raiz + @"\Gifs\Auxiliar Alegre.gif");
        }
        void Durmiendo()
        {
            string Raiz = Directory.GetCurrentDirectory();
            pictureBox1.Image = Image.FromFile(Raiz + @"\Gifs\Auxiliar Durmiendo.gif");
        }
        void Activo()
        {
            string Raiz = Directory.GetCurrentDirectory();
            pictureBox1.Image = Image.FromFile(Raiz + @"\Gifs\Auxiliar Activo.gif");
        }

        void AuxGuardar()
        {
            string Raiz = Directory.GetCurrentDirectory();
            pictureBox1.Image = Image.FromFile(Raiz + @"\Gifs\Aux Contento.gif");
        }
        void Celular()
        {
            string Raiz = Directory.GetCurrentDirectory();
            pictureBox1.Image = Image.FromFile(Raiz + @"\Gifs\Auxiliar Celular.gif");

        }

        void GloboConv()
        {
            string Raiz = Directory.GetCurrentDirectory();
            Globo1.Image = Image.FromFile (Raiz + @"\Imagenes\Globo.png");
        }
        void GloboOculto()
        {
            Globo1.Visible = false;
        }
        void GloboAparece()
        {
            Globo1.Visible = true;
        }

        #endregion
        //********************************************************//
        //Seccion de animaciones//
        //********************************************************//


        public Form1()
        {
            InitializeComponent();
        }
      


      

        private void Form1_Load(object sender, EventArgs e)
        {
            Durmiendo();
            GloboConv();
            GloboOculto();




        }

       


        private void btnfuentes_Click(object sender, EventArgs e)
        {
            foreach (FontFamily fuente in FontFamily.Families)
            {
                string nombre = fuente.Name;
                btnfuentes.Items.Add(nombre);

            }

        }

        private void btnfuentes_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            string texto = btnfuentes.Items[e.Index].ToString();
            Font fuente = new Font(texto, e.Font.Size);

            e.Graphics.DrawString(texto, fuente, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);
            e.DrawFocusRectangle();
        }

        private void btnfuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnfuentes.Font = new Font(btnfuentes.Text, btnfuentes.Font.Size);
            text1.Font = new Font(btnfuentes.Text, btnfuentes.Font.Size);
        }

        private void Fuente_Click(object sender, EventArgs e)
        {
            btnfuentes.Visible = true;
            SalirFuente.Visible = true;
            Fuente.Visible = false;
            Celular();
        }

        private void SalirFuente_Click(object sender, EventArgs e)
        {
            SalirFuente.Visible = false;
            Fuente.Visible = true;
            btnfuentes.Visible = false;
            Celular();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Alegre();
            SaveFileDialog sfd = new();
            sfd.Filter = "Documento|*.txt";
            sfd.Title = "Guardar gatito";
            sfd.InitialDirectory = @"C:\";
            sfd.FileName = "Gatito ";
            var resultado = sfd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamWriter escribir = new(sfd.FileName);
                foreach (object line in text1.Lines)
                {
                    escribir.WriteLine(line);
                }


                escribir.Close();
            }
        }


        private void Cargar_Click(object sender, EventArgs e)
        {
            Alegre();
            OpenFileDialog Abrir = new();
            Abrir.Filter = "Documento|*.txt";
            Abrir.Title = "Cargar";
            Abrir.InitialDirectory = @"C:\";

            Abrir.FileName = "H1 ";
            var resultado = Abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new(Abrir.FileName);
                text1.Text = leer.ReadToEnd();
            }
        }
    
        private void Tiempo_Click(object sender, EventArgs e)
        {
            int Segundos = 1000;

            timer1.Interval = 1* Segundos;
        }

        private void segundos15_Click(object sender, EventArgs e)
        {
            int Segundos = 1000;
            timer1.Interval = 15 * Segundos;
        }

        private void segundos30_Click(object sender, EventArgs e)
        {
            int Segundos = 1000;
            timer1.Interval = 30 * Segundos;
        }

        private void minuto_Click(object sender, EventArgs e)
        {
            int Segundos = 1000;
            timer1.Interval = 60 * Segundos;
        }

        private void minutos5_Click(object sender, EventArgs e)
        {

            int Segundos = 1000;
            timer1.Interval = 300 * Segundos;
        }

        private void minutos20_Click(object sender, EventArgs e)
        {
            int Segundos = 1000;
            timer1.Interval = 1200 * Segundos;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    
        private void Transparencia_Click(object sender, EventArgs e)
        {
            
        }

        private void cienOP_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form();
            this.Opacity = 1.00;
        }

        private void cincuentaOP_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form();
            this.Opacity = .5;
        }

        private void setentaycincoOP_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form();
            this.Opacity = .75;
        }

        private void veinticincoOP_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form();
            this.Opacity = .25;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Texto_Click(object sender, EventArgs e)
        {
          
            
            this.text1.Visible = true;

            timer1.Enabled = true;
            Activo();
            GloboAparece();
            
        }

      

        private void SiempreAlFrente_Click(object sender, EventArgs e)
        {
            Form1 topMostForm = new Form1();
            this.Hide();
            topMostForm.Show();
            FueraDelFrente.Visible = true;
            SiempreAlFrente.Visible = false;
           
          
            
            topMostForm.TopMost = true;
                     

        }

    

        private void FueraDelFrente_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 topMostForm = new Form1();

            topMostForm.TopMost = false;
            topMostForm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Start();
            Durmiendo();
            GloboOculto();
            this.text1.Visible = false;
            timer1.Stop();
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(379, 0);
            Globo1.Location = new Point(0, 12);
            text1.Location = new Point(35, 59);
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(2, 0);
            Globo1.Location = new Point(340, 0);
            text1.Location = new Point(394, 31);
        }

        private void apagado_Click(object sender, EventArgs e)
        {
            int Segundos = 1000000;

            timer1.Interval = 100000 * Segundos;
        }
    }

}


