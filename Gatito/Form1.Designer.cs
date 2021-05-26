
namespace Gatito
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Globo1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SiempreAlFrente = new System.Windows.Forms.ToolStripMenuItem();
            this.FueraDelFrente = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Cargar = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.Fuente = new System.Windows.Forms.ToolStripMenuItem();
            this.Tiempo = new System.Windows.Forms.ToolStripMenuItem();
            this.segundos15 = new System.Windows.Forms.ToolStripMenuItem();
            this.segundos30 = new System.Windows.Forms.ToolStripMenuItem();
            this.minuto = new System.Windows.Forms.ToolStripMenuItem();
            this.minutos5 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutos20 = new System.Windows.Forms.ToolStripMenuItem();
            this.apagado = new System.Windows.Forms.ToolStripMenuItem();
            this.Transparencia = new System.Windows.Forms.ToolStripMenuItem();
            this.cienOP = new System.Windows.Forms.ToolStripMenuItem();
            this.setentaycincoOP = new System.Windows.Forms.ToolStripMenuItem();
            this.cincuentaOP = new System.Windows.Forms.ToolStripMenuItem();
            this.veinticincoOP = new System.Windows.Forms.ToolStripMenuItem();
            this.Texto = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Invertir = new System.Windows.Forms.ToolStripMenuItem();
            this.Izquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.Derecha = new System.Windows.Forms.ToolStripMenuItem();
            this.text1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnfuentes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Globo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Globo1
            // 
            this.Globo1.BackColor = System.Drawing.Color.Transparent;
            this.Globo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Globo1.InitialImage = null;
            this.Globo1.Location = new System.Drawing.Point(340, 0);
            this.Globo1.Name = "Globo1";
            this.Globo1.Size = new System.Drawing.Size(389, 361);
            this.Globo1.TabIndex = 0;
            this.Globo1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 302);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SiempreAlFrente,
            this.FueraDelFrente,
            this.Guardar,
            this.Cargar,
            this.SalirFuente,
            this.Fuente,
            this.Tiempo,
            this.Transparencia,
            this.Texto,
            this.Salir,
            this.Invertir});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(193, 268);
            // 
            // SiempreAlFrente
            // 
            this.SiempreAlFrente.Name = "SiempreAlFrente";
            this.SiempreAlFrente.Size = new System.Drawing.Size(192, 24);
            this.SiempreAlFrente.Text = "Siempre al frente";
            this.SiempreAlFrente.Click += new System.EventHandler(this.SiempreAlFrente_Click);
            // 
            // FueraDelFrente
            // 
            this.FueraDelFrente.Name = "FueraDelFrente";
            this.FueraDelFrente.Size = new System.Drawing.Size(192, 24);
            this.FueraDelFrente.Text = "Salir del frente";
            this.FueraDelFrente.Click += new System.EventHandler(this.FueraDelFrente_Click);
            // 
            // Guardar
            // 
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(192, 24);
            this.Guardar.Text = "Guardar archivo";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cargar
            // 
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(192, 24);
            this.Cargar.Text = "Cargar archivo";
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // SalirFuente
            // 
            this.SalirFuente.Name = "SalirFuente";
            this.SalirFuente.Size = new System.Drawing.Size(192, 24);
            this.SalirFuente.Text = "Cerrar fuentes";
            this.SalirFuente.Visible = false;
            this.SalirFuente.Click += new System.EventHandler(this.SalirFuente_Click);
            // 
            // Fuente
            // 
            this.Fuente.Name = "Fuente";
            this.Fuente.Size = new System.Drawing.Size(192, 24);
            this.Fuente.Text = "Fuente";
            this.Fuente.Click += new System.EventHandler(this.Fuente_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segundos15,
            this.segundos30,
            this.minuto,
            this.minutos5,
            this.minutos20,
            this.apagado});
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(192, 24);
            this.Tiempo.Text = "Tiempo";
            this.Tiempo.Click += new System.EventHandler(this.Tiempo_Click);
            // 
            // segundos15
            // 
            this.segundos15.Name = "segundos15";
            this.segundos15.Size = new System.Drawing.Size(175, 26);
            this.segundos15.Text = "15 segundos";
            this.segundos15.Click += new System.EventHandler(this.segundos15_Click);
            // 
            // segundos30
            // 
            this.segundos30.Name = "segundos30";
            this.segundos30.Size = new System.Drawing.Size(175, 26);
            this.segundos30.Text = "30 segundos";
            this.segundos30.Click += new System.EventHandler(this.segundos30_Click);
            // 
            // minuto
            // 
            this.minuto.Name = "minuto";
            this.minuto.Size = new System.Drawing.Size(175, 26);
            this.minuto.Text = "1 Minuto";
            this.minuto.Click += new System.EventHandler(this.minuto_Click);
            // 
            // minutos5
            // 
            this.minutos5.Name = "minutos5";
            this.minutos5.Size = new System.Drawing.Size(175, 26);
            this.minutos5.Text = "5 Minutos";
            this.minutos5.Click += new System.EventHandler(this.minutos5_Click);
            // 
            // minutos20
            // 
            this.minutos20.Name = "minutos20";
            this.minutos20.Size = new System.Drawing.Size(175, 26);
            this.minutos20.Text = "20 Minutos";
            this.minutos20.Click += new System.EventHandler(this.minutos20_Click);
            // 
            // apagado
            // 
            this.apagado.Name = "apagado";
            this.apagado.Size = new System.Drawing.Size(175, 26);
            this.apagado.Text = "Apagado";
            this.apagado.Click += new System.EventHandler(this.apagado_Click);
            // 
            // Transparencia
            // 
            this.Transparencia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cienOP,
            this.setentaycincoOP,
            this.cincuentaOP,
            this.veinticincoOP});
            this.Transparencia.Name = "Transparencia";
            this.Transparencia.Size = new System.Drawing.Size(192, 24);
            this.Transparencia.Text = "Transparencia";
            this.Transparencia.Click += new System.EventHandler(this.Transparencia_Click);
            // 
            // cienOP
            // 
            this.cienOP.Name = "cienOP";
            this.cienOP.Size = new System.Drawing.Size(128, 26);
            this.cienOP.Text = "100%";
            this.cienOP.Click += new System.EventHandler(this.cienOP_Click);
            // 
            // setentaycincoOP
            // 
            this.setentaycincoOP.Name = "setentaycincoOP";
            this.setentaycincoOP.Size = new System.Drawing.Size(128, 26);
            this.setentaycincoOP.Text = "75%";
            this.setentaycincoOP.Click += new System.EventHandler(this.setentaycincoOP_Click);
            // 
            // cincuentaOP
            // 
            this.cincuentaOP.Name = "cincuentaOP";
            this.cincuentaOP.Size = new System.Drawing.Size(128, 26);
            this.cincuentaOP.Text = "50%";
            this.cincuentaOP.Click += new System.EventHandler(this.cincuentaOP_Click);
            // 
            // veinticincoOP
            // 
            this.veinticincoOP.Name = "veinticincoOP";
            this.veinticincoOP.Size = new System.Drawing.Size(128, 26);
            this.veinticincoOP.Text = "25%";
            this.veinticincoOP.Click += new System.EventHandler(this.veinticincoOP_Click);
            // 
            // Texto
            // 
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(192, 24);
            this.Texto.Text = "Texto";
            this.Texto.Click += new System.EventHandler(this.Texto_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(192, 24);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Invertir
            // 
            this.Invertir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Izquierda,
            this.Derecha});
            this.Invertir.Name = "Invertir";
            this.Invertir.Size = new System.Drawing.Size(192, 24);
            this.Invertir.Text = "Invertir";
            // 
            // Izquierda
            // 
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(154, 26);
            this.Izquierda.Text = "Izquierda";
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // Derecha
            // 
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(154, 26);
            this.Derecha.Text = "Derecha";
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.White;
            this.text1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text1.Font = new System.Drawing.Font("Gentium Book Basic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text1.Location = new System.Drawing.Point(394, 31);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(294, 170);
            this.text1.TabIndex = 2;
            this.text1.Visible = false;
            // 
            // btnfuentes
            // 
            this.btnfuentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfuentes.BackColor = System.Drawing.Color.Beige;
            this.btnfuentes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnfuentes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.btnfuentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfuentes.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfuentes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnfuentes.FormattingEnabled = true;
            this.btnfuentes.ItemHeight = 43;
            this.btnfuentes.Location = new System.Drawing.Point(12, 253);
            this.btnfuentes.Name = "btnfuentes";
            this.btnfuentes.Size = new System.Drawing.Size(673, 49);
            this.btnfuentes.TabIndex = 4;
            this.btnfuentes.Text = " Elegir Fuente ";
            this.btnfuentes.Visible = false;
            this.btnfuentes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.btnfuentes_DrawItem);
            this.btnfuentes.SelectedIndexChanged += new System.EventHandler(this.btnfuentes_SelectedIndexChanged);
            this.btnfuentes.Click += new System.EventHandler(this.btnfuentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(732, 324);
            this.Controls.Add(this.btnfuentes);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Globo1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.86D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gatito";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Globo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Globo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Fuente;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem Cargar;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ComboBox btnfuentes;
        public System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.ToolStripMenuItem SalirFuente;
        private System.Windows.Forms.ToolStripMenuItem Tiempo;
        private System.Windows.Forms.ToolStripMenuItem segundos15;
        private System.Windows.Forms.ToolStripMenuItem segundos30;
        private System.Windows.Forms.ToolStripMenuItem minuto;
        private System.Windows.Forms.ToolStripMenuItem minutos5;
        private System.Windows.Forms.ToolStripMenuItem minutos20;
        private System.Windows.Forms.ToolStripMenuItem apagado;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Transparencia;
        private System.Windows.Forms.ToolStripMenuItem cienOP;
        private System.Windows.Forms.ToolStripMenuItem setentaycincoOP;
        private System.Windows.Forms.ToolStripMenuItem cincuentaOP;
        private System.Windows.Forms.ToolStripMenuItem veinticincoOP;
        private System.Windows.Forms.ToolStripMenuItem Texto;
        private System.Windows.Forms.ToolStripMenuItem SiempreAlFrente;
        private System.Windows.Forms.ToolStripMenuItem FueraDelFrente;
        private System.Windows.Forms.ToolStripMenuItem Invertir;
        private System.Windows.Forms.ToolStripMenuItem Izquierda;
        private System.Windows.Forms.ToolStripMenuItem Derecha;
    }
}

