namespace ArduinoServoControl
{
    partial class JanelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbConexao = new System.Windows.Forms.GroupBox();
            this.btVerificaPortas = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.btDesconectar = new System.Windows.Forms.Button();
            this.labelPortasDisponiveis = new System.Windows.Forms.Label();
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.gbControle = new System.Windows.Forms.GroupBox();
            this.labelBotoes = new System.Windows.Forms.Label();
            this.btEsquerda = new System.Windows.Forms.Button();
            this.imgTop = new System.Windows.Forms.PictureBox();
            this.btDireita = new System.Windows.Forms.Button();
            this.imgRight = new System.Windows.Forms.PictureBox();
            this.imgLeft = new System.Windows.Forms.PictureBox();
            this.imgBottom = new System.Windows.Forms.PictureBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabelTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelGraus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbConexao.SuspendLayout();
            this.gbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBottom)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(460, 37);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Arduino Servo Control";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbConexao
            // 
            this.gbConexao.Controls.Add(this.btVerificaPortas);
            this.gbConexao.Controls.Add(this.comboBoxBaudRate);
            this.gbConexao.Controls.Add(this.labelBaudRate);
            this.gbConexao.Controls.Add(this.btDesconectar);
            this.gbConexao.Controls.Add(this.labelPortasDisponiveis);
            this.gbConexao.Controls.Add(this.btConectar);
            this.gbConexao.Controls.Add(this.comboBoxPortas);
            this.gbConexao.Location = new System.Drawing.Point(17, 49);
            this.gbConexao.Name = "gbConexao";
            this.gbConexao.Size = new System.Drawing.Size(455, 87);
            this.gbConexao.TabIndex = 7;
            this.gbConexao.TabStop = false;
            this.gbConexao.Text = "Conexão";
            // 
            // btVerificaPortas
            // 
            this.btVerificaPortas.Location = new System.Drawing.Point(251, 18);
            this.btVerificaPortas.Margin = new System.Windows.Forms.Padding(2);
            this.btVerificaPortas.Name = "btVerificaPortas";
            this.btVerificaPortas.Size = new System.Drawing.Size(194, 23);
            this.btVerificaPortas.TabIndex = 8;
            this.btVerificaPortas.Text = "Verificar Portas";
            this.btVerificaPortas.UseVisualStyleBackColor = true;
            this.btVerificaPortas.Click += new System.EventHandler(this.btVerificaPortas_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(109, 50);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(136, 21);
            this.comboBoxBaudRate.TabIndex = 5;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(6, 53);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(61, 13);
            this.labelBaudRate.TabIndex = 4;
            this.labelBaudRate.Text = "Baud Rate:";
            // 
            // btDesconectar
            // 
            this.btDesconectar.Enabled = false;
            this.btDesconectar.Location = new System.Drawing.Point(351, 46);
            this.btDesconectar.Name = "btDesconectar";
            this.btDesconectar.Size = new System.Drawing.Size(94, 25);
            this.btDesconectar.TabIndex = 3;
            this.btDesconectar.Text = "Desconectar";
            this.btDesconectar.UseVisualStyleBackColor = true;
            this.btDesconectar.Click += new System.EventHandler(this.btDesconectar_Click);
            // 
            // labelPortasDisponiveis
            // 
            this.labelPortasDisponiveis.AutoSize = true;
            this.labelPortasDisponiveis.Location = new System.Drawing.Point(6, 22);
            this.labelPortasDisponiveis.Name = "labelPortasDisponiveis";
            this.labelPortasDisponiveis.Size = new System.Drawing.Size(97, 13);
            this.labelPortasDisponiveis.TabIndex = 2;
            this.labelPortasDisponiveis.Text = "Portas disponíveis:";
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(251, 46);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(94, 25);
            this.btConectar.TabIndex = 1;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Location = new System.Drawing.Point(109, 19);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(136, 21);
            this.comboBoxPortas.TabIndex = 0;
            // 
            // gbControle
            // 
            this.gbControle.Controls.Add(this.labelBotoes);
            this.gbControle.Controls.Add(this.btEsquerda);
            this.gbControle.Controls.Add(this.imgTop);
            this.gbControle.Controls.Add(this.btDireita);
            this.gbControle.Controls.Add(this.imgRight);
            this.gbControle.Controls.Add(this.imgLeft);
            this.gbControle.Controls.Add(this.imgBottom);
            this.gbControle.Location = new System.Drawing.Point(17, 142);
            this.gbControle.Name = "gbControle";
            this.gbControle.Size = new System.Drawing.Size(455, 166);
            this.gbControle.TabIndex = 8;
            this.gbControle.TabStop = false;
            this.gbControle.Text = "Controle";
            // 
            // labelBotoes
            // 
            this.labelBotoes.AutoSize = true;
            this.labelBotoes.Location = new System.Drawing.Point(98, 17);
            this.labelBotoes.Name = "labelBotoes";
            this.labelBotoes.Size = new System.Drawing.Size(40, 13);
            this.labelBotoes.TabIndex = 6;
            this.labelBotoes.Text = "Botões";
            // 
            // btEsquerda
            // 
            this.btEsquerda.Location = new System.Drawing.Point(30, 46);
            this.btEsquerda.Margin = new System.Windows.Forms.Padding(2);
            this.btEsquerda.Name = "btEsquerda";
            this.btEsquerda.Size = new System.Drawing.Size(84, 99);
            this.btEsquerda.TabIndex = 1;
            this.btEsquerda.Text = "< Esquerda";
            this.btEsquerda.UseVisualStyleBackColor = true;
            this.btEsquerda.Click += new System.EventHandler(this.btEsquerda_Click);
            // 
            // imgTop
            // 
            this.imgTop.Image = global::ArduinoServoControl.Properties.Resources.top_up;
            this.imgTop.Location = new System.Drawing.Point(315, 25);
            this.imgTop.Name = "imgTop";
            this.imgTop.Size = new System.Drawing.Size(58, 57);
            this.imgTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTop.TabIndex = 10;
            this.imgTop.TabStop = false;
            // 
            // btDireita
            // 
            this.btDireita.Location = new System.Drawing.Point(118, 46);
            this.btDireita.Margin = new System.Windows.Forms.Padding(2);
            this.btDireita.Name = "btDireita";
            this.btDireita.Size = new System.Drawing.Size(84, 99);
            this.btDireita.TabIndex = 0;
            this.btDireita.Text = "Direita >";
            this.btDireita.UseVisualStyleBackColor = true;
            this.btDireita.Click += new System.EventHandler(this.btDireita_Click);
            // 
            // imgRight
            // 
            this.imgRight.Image = global::ArduinoServoControl.Properties.Resources.right_up;
            this.imgRight.Location = new System.Drawing.Point(377, 87);
            this.imgRight.Name = "imgRight";
            this.imgRight.Size = new System.Drawing.Size(56, 58);
            this.imgRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgRight.TabIndex = 9;
            this.imgRight.TabStop = false;
            // 
            // imgLeft
            // 
            this.imgLeft.Image = global::ArduinoServoControl.Properties.Resources.left_up;
            this.imgLeft.Location = new System.Drawing.Point(251, 88);
            this.imgLeft.Name = "imgLeft";
            this.imgLeft.Size = new System.Drawing.Size(58, 57);
            this.imgLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLeft.TabIndex = 7;
            this.imgLeft.TabStop = false;
            // 
            // imgBottom
            // 
            this.imgBottom.Image = global::ArduinoServoControl.Properties.Resources.bottom_up;
            this.imgBottom.Location = new System.Drawing.Point(315, 88);
            this.imgBottom.Name = "imgBottom";
            this.imgBottom.Size = new System.Drawing.Size(56, 57);
            this.imgBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgBottom.TabIndex = 8;
            this.imgBottom.TabStop = false;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelTitulo,
            this.statusLabel,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.labelGraus});
            this.statusBar.Location = new System.Drawing.Point(0, 328);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(484, 22);
            this.statusBar.TabIndex = 9;
            // 
            // statusLabelTitulo
            // 
            this.statusLabelTitulo.Name = "statusLabelTitulo";
            this.statusLabelTitulo.Size = new System.Drawing.Size(45, 17);
            this.statusLabelTitulo.Text = "Status: ";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(82, 17);
            this.statusLabel.Text = "Desconhecido";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel2.Text = "Graus: ";
            // 
            // labelGraus
            // 
            this.labelGraus.Name = "labelGraus";
            this.labelGraus.Size = new System.Drawing.Size(13, 17);
            this.labelGraus.Text = "0";
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 350);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.gbControle);
            this.Controls.Add(this.gbConexao);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JanelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Servo Control por Renato Peterman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JanelaPrincipal_FormClosed);
            this.gbConexao.ResumeLayout(false);
            this.gbConexao.PerformLayout();
            this.gbControle.ResumeLayout(false);
            this.gbControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBottom)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbConexao;
        private System.Windows.Forms.ComboBox comboBoxPortas;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Label labelPortasDisponiveis;
        private System.Windows.Forms.Button btDesconectar;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Button btVerificaPortas;
        private System.Windows.Forms.GroupBox gbControle;
        private System.Windows.Forms.PictureBox imgBottom;
        private System.Windows.Forms.PictureBox imgLeft;
        private System.Windows.Forms.PictureBox imgTop;
        private System.Windows.Forms.PictureBox imgRight;
        private System.Windows.Forms.Label labelBotoes;
        private System.Windows.Forms.Button btEsquerda;
        private System.Windows.Forms.Button btDireita;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelTitulo;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labelGraus;
    }
}

