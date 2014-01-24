/**
 * 
 * Aplicativo desenvolvido para controlar
 * servo motores com Arduino a partir de 
 * uma porta serial.
 * 
 * Autor: Renato Peterman
 * E-mail: ***REMOVED***
 * 
 * Data: 26/07/2010
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoSimpleServoControl
{
    public partial class JanelaPrincipal : Form
    {
        // Atributo do tipo SerialPort necessário para abrir a conexão
        private SerialPort porta;
        
        // Atributo do tipo int que armazenara a posição do motor
        private int posicao;

        public JanelaPrincipal()
        {
            InitializeComponent();

            // Atribui o valor zero a posição
            posicao = 0;

            /* Cria um novo objeto SerialPort
             * Que conecta a porta "COM3"
             * E utiliza um Baud Rate (Taxa de Transmissão de dados) de 9600
             */
            porta = new SerialPort("COM3", 9600);

            //Verifica se a porta não está aberta
            if (!porta.IsOpen)
            {
                // Abre a porta
                porta.Open();

                /* Envia o valor "000", para que o 
                 * motor volte para a possição 0
                 */
                porta.WriteLine("000");
            }
        }

        /* Sobrescreve o metódo ProcessCmdKey
         * responsável por processar as entradas
         * do teclado
         */
        protected override bool ProcessCmdKey(ref Message m, Keys keyData)
        {
            bool blnProcess = false;

            /* Verifica se a tecla que está sendo pressiona
             * é a seta Esquerda (Left)
             */
            if (keyData == Keys.Left)
            {
                if (posicao >= 0 && posicao < 180)
                {
                    // Incrementa 10
                    posicao += 10;
                }

                // Aqui serão enviados os dados para a porta.
                if (posicao >= 0 && posicao >= 100)
                {
                    porta.WriteLine(posicao.ToString());
                }
                else
                {
                    porta.WriteLine("0" + posicao.ToString());
                }

                labelGraus.Text = posicao.ToString();

                blnProcess = true;
            }

            /* Verifica se a tecla que está sendo pressiona
             * é a seta Direita (Right)
             */
            if (keyData == Keys.Right)
            {
                if (posicao > 0 && posicao <= 180)
                {
                    // Diminui 10
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

                blnProcess = true;
            }

            /* Aqui verifica se "blnProcess" for verdadeiro
             * retorna este método, se não chama o metódo pai (super)
             */
            if (blnProcess == true)
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref m,keyData);
            }

        }
    }
}
