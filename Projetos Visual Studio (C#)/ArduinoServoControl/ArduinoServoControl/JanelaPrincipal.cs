/**
 * 
 * Aplicativo desenvolvido para controlar
 * servo motores com Arduino a partir de 
 * uma porta serial.
 * 
 * Autor: Renato Peterman
 * 
 * Data: 26/07/2010
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArduinoServoControl
{
    public partial class JanelaPrincipal : Form 
    {
        private SerialPort porta;
        private string[] portas;
        private int posicao;
        private Boolean conectado;

        public JanelaPrincipal()
        {
            InitializeComponent();
            listaPortas();
        }

        private void defineStatus(bool status)
        {
            if (status == true)
            {
                statusLabel.Text = "Conectado";
                statusLabel.ForeColor = Color.Green;
                conectado = true;
            }
            else
            {
                statusLabel.Text = "Desconectado";
                statusLabel.ForeColor = Color.Red;
                conectado = false;
            }
        }

        private void listaPortas()
        {
            portas = SerialPort.GetPortNames();

            if (portas.Length > 0)
            {
                comboBoxPortas.Items.Clear();

                comboBoxPortas.SelectedIndex = -1;
                comboBoxBaudRate.SelectedIndex = -1;

                foreach (string s in SerialPort.GetPortNames())
                {
                    comboBoxPortas.Items.Add(s);
                }

                defineStatus(false);

                permissoes(true,true,false,true,true,false,false);

            }
            else
            {
                defineStatus(false);

                permissoes(false, false, false, false, true, false,false);

                MessageBox.Show(this,"Nenhuma porta encontrada","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void permissoes(bool portas, bool conectar, bool desconectar,
            bool baudrate, bool verifica, bool direita, bool esquerda)
        {
            comboBoxPortas.Enabled = portas;
            btConectar.Enabled = conectar;
            btDesconectar.Enabled = desconectar;
            comboBoxBaudRate.Enabled = baudrate;
            btVerificaPortas.Enabled = verifica;
            btDireita.Enabled = direita;
            btEsquerda.Enabled = esquerda;
        }

        private void fechaPorta()
        {
            if (porta != null && porta.IsOpen)
            {
                porta.Close();
                porta = null;
                defineStatus(false);
                listaPortas();
            }
            
        }

        protected override bool ProcessCmdKey(ref Message m, Keys keyData)
        {
            if (conectado == true)
            {
                bool blnProcess = false;
                
                if (keyData == Keys.Left)
                {
                    if (posicao >= 0 && posicao < 180)
                    {
                        posicao += 10;
                    }


                    if (posicao >= 0 && posicao >= 100)
                    {
                        porta.WriteLine(posicao.ToString());
                    }
                    else
                    {
                        porta.WriteLine("0" + posicao.ToString());
                    }

                    labelGraus.Text = posicao.ToString();

                    imgRight.Image = Properties.Resources.right_up;
                    imgLeft.Image = Properties.Resources.left_down;
                    
                    blnProcess = true;
                }

                if (keyData == Keys.Right)
                {
                    if (posicao > 0 && posicao <= 180)
                    {
                        posicao -= 10;
                    }


                    if (posicao >= 0 && posicao >= 100)
                    {
                        porta.WriteLine(posicao.ToString());
                    }
                    else if (posicao == 0)
                    {
                        porta.WriteLine("000");
                    }
                    else
                    {
                        porta.WriteLine("0" + posicao.ToString());
                    }

                    labelGraus.Text = posicao.ToString();

                    imgLeft.Image = Properties.Resources.left_up;
                    imgRight.Image = Properties.Resources.right_down;

                    blnProcess = true; 
                }

                if (blnProcess == true)
                {
                    return true;
                }
                else
                {
                    return base.ProcessCmdKey(ref m, keyData);
                }
            }

            else

            {
                return false;
            }

        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {
            fechaPorta();
            imgLeft.Image = Properties.Resources.left_up;
            imgRight.Image = Properties.Resources.right_up;
            labelGraus.Text = "0";
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxPortas.SelectedIndex != -1 && comboBoxBaudRate.SelectedIndex != -1)
                {
                    porta = new SerialPort();
                    porta.PortName = comboBoxPortas.SelectedItem.ToString();
                    porta.BaudRate = Int32.Parse(comboBoxBaudRate.SelectedItem.ToString());
                }
                else
                {
                    throw new Exception("Selecione a PORTA e o BAUD RATE para conectar");
                }

                if (!porta.IsOpen)
                {
                    porta.Open();
                    posicao = 0;
                    porta.WriteLine("000");

                    permissoes(false, false, true, false, false,true,true);
                    defineStatus(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,"Desculpe, não foi possível conectar ao Arduino.\nErro: " + ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //Environment.Exit(0);
            }
        }

        private void btVerificaPortas_Click(object sender, EventArgs e)
        {
            listaPortas();
        }

        private void btEsquerda_Click(object sender, EventArgs e)
        {
            if (posicao >= 0 && posicao < 180)
            {
                posicao += 10;
            }


            if (posicao >= 0 && posicao >= 100)
            {
                porta.WriteLine(posicao.ToString());
            }
            else
            {
                porta.WriteLine("0" + posicao.ToString());
            }

            labelGraus.Text = posicao.ToString();
        }

        private void btDireita_Click(object sender, EventArgs e)
        {
            if (posicao > 0 && posicao <= 180)
            {
                posicao -= 10;
            }


            if (posicao >= 0 && posicao >= 100)
            {
                porta.WriteLine(posicao.ToString());
            }
            else if (posicao == 0)
            {
                porta.WriteLine("000");
            }
            else
            {
                porta.WriteLine("0" + posicao.ToString());
            }

            labelGraus.Text = posicao.ToString();
        }

        private void JanelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            fechaPorta();
        }

    }
}
