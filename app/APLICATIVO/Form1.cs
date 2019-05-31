using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SQLite;
using System.Threading;

namespace APLICATIVO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArredondaCantosdoForm();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=MotorradDB.db;Version=3;New=False;Compress=true;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from MotorradTB";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            
            sql_con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Até a linha 89 - Codigo para poder mexer a tela do form.
        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);


            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pic_Box_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        //Até a linha 144 são os lugares que da pra usar o mouse pra mover a tela.
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
        
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void Pic_Box_Minimize_MouseHover(object sender, EventArgs e)
        {
            Pic_Box_Minimize.BackColor = Color.DeepSkyBlue;
        }

        private void Pic_Box_Minimize_MouseLeave(object sender, EventArgs e)
        {
            Pic_Box_Minimize.BackColor = Color.White;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bnt_Login_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(sql_con);
            try
            {
                sql_con.Open();
                string Query = "SELECT * from MotorradTB where User='" + this.Txt_User.Text + "' and Password='" + this.Txt_Password.Text + "' ";
                
                SQLiteCommand CreateCommand = new SQLiteCommand(Query, sql_con);
                CreateCommand.ExecuteNonQuery();
                SQLiteDataReader DR = CreateCommand.ExecuteReader();

                Thread TH;

                //Login provisório até eu conseguir comparar o que é escrito na textbox com o banco de dados.

                if ((Txt_User.Text == "Gabriel") && (Txt_Password.Text == "1234") && (Txt_ID.Text == "100"))
                {
                    this.Close();
                    TH = new Thread(OpenNewForm);
                    TH.SetApartmentState(ApartmentState.STA);
                    TH.Start();
                }
                else if ((Txt_User.Text == "Mateus") && (Txt_Password.Text == "4321") && (Txt_ID.Text == "101"))
                {
                    this.Close();
                    TH = new Thread(OpenNewForm);
                    TH.SetApartmentState(ApartmentState.STA);
                    TH.Start();
                }
                else if ((Txt_User.Text == "Ruan") && (Txt_Password.Text == "abcd") && (Txt_ID.Text == "102"))
                {
                    this.Close();
                    TH = new Thread(OpenNewForm);
                    TH.SetApartmentState(ApartmentState.STA);
                    TH.Start();
                }
                else if ((Txt_User.Text == "") && (Txt_Password.Text == "") && (Txt_ID.Text == "") || (Txt_User.Text == "") || (Txt_Password.Text == "") || (Txt_ID.Text == ""))
                {
                    MessageBox.Show("Usuario, senha e/ou ID estão vazios!", "Erro");
                }
                else
                {
                    MessageBox.Show("Usuario, senha e/ou ID estão incorretos!", "Erro");
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        
        private void OpenNewForm()
        {
            Application.Run(new ADM_Screen());
        }
    }
}
