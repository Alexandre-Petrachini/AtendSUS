using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Media;
using AtendimentoSUS;
using System.Globalization;

namespace FilaEspera
{
    public partial class Form1 : Form
    {
        string tipo = " ";
        int maxSenha = 0;

      
   
   

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChamarSenha_Click(object sender, EventArgs e)
        {
            lblSenha.Visible = true;

            tipo = "P";

            pegaSenha();


            if (maxSenha > 0)
            {
                lblSenha.Text = tipo + maxSenha.ToString();
            }
            else
            {
                tipo = "N";
                

                pegaSenha();

                if (maxSenha > 0)
                {
                    lblSenha.Text = tipo + maxSenha.ToString();
                }
                else
                {
                    MessageBox.Show("Não há pacientes no momento.");
                    return;
                }
            }


            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 100;

            SystemSounds.Beep.Play();
            synth.Speak(lblSenha.Text);

            Senhas.Items.Add("  " + lblSenha.Text);

            if (Senhas.Items.Count != 0)
            {
                Senhas.SelectedIndex = Senhas.Items.Count - 1;
            }

            gravaChamada();

        }

        private void pegaSenha()
        {
            Conexao comb = new Conexao();
            String status = "";
            comb.open();

            comb.sql = "Select min(tb01_seq) from tb01_senhas ";
            comb.sql += " where tb01_tipo =  '"+ tipo +"'";
            comb.sql += " and   tb01_status= '" + status + "'";

            
          

            maxSenha = Convert.ToInt32(comb.ExecuteScalar());

            if (maxSenha == 0)
            {
                Senha.Text = "";
            }
            else
            {
                Senha.Text = "" + tipo + "" + maxSenha;
            }

            comb.close();
        }

        private void gravaChamada()
        {
            Conexao comb = new Conexao();

            comb.open();

            comb.sql = "Update tb01_senhas set ";
            comb.sql += " tb01_status = 's'";
            comb.sql += " where tb01_tipo = '" + tipo + "'";
            comb.sql += " and   tb01_seq = '" + maxSenha + "'";

            int qt = comb.Runsql();
                
            comb.close();

        }

        private void Form1_Resize_1(object sender, EventArgs e)
         {
            lblSenha.Width = (sender as Form).Width;
            lbTexto.Width = (sender as Form).Width;
            Paciente.Width = (sender as Form).Width;
            lbHora.Width = (sender as Form).Width;

       }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            Paciente.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }
    }
}
