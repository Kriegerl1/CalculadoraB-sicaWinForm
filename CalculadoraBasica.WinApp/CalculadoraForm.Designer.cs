


namespace CalculadoraBasica.WinApp
{
    partial class CalculadoraForm
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
            lblPrimeiroNumero = new Label();
            txtPrimeiroNumero = new TextBox();
            lblSegundoNumero = new Label();
            txtSegundoNumero = new TextBox();
            rdbAdicao = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbDivisao = new RadioButton();
            gpRadioButtons = new GroupBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            listHistorico = new ListBox();
            lblResultado = new Label();
            lblResposta = new Label();
            gpRadioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            lblPrimeiroNumero.AutoSize = true;
            lblPrimeiroNumero.Font = new Font("Segoe UI", 12F);
            lblPrimeiroNumero.Location = new Point(12, 42);
            lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            lblPrimeiroNumero.Size = new Size(163, 28);
            lblPrimeiroNumero.TabIndex = 0;
            lblPrimeiroNumero.Text = "Primeiro Número";
            // 
            // txtPrimeiroNumero
            // 
            txtPrimeiroNumero.Font = new Font("Segoe UI", 12F);
            txtPrimeiroNumero.Location = new Point(186, 36);
            txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            txtPrimeiroNumero.Size = new Size(125, 34);
            txtPrimeiroNumero.TabIndex = 1;
            // 
            // lblSegundoNumero
            // 
            lblSegundoNumero.AutoSize = true;
            lblSegundoNumero.Font = new Font("Segoe UI", 12F);
            lblSegundoNumero.Location = new Point(12, 101);
            lblSegundoNumero.Name = "lblSegundoNumero";
            lblSegundoNumero.Size = new Size(168, 28);
            lblSegundoNumero.TabIndex = 0;
            lblSegundoNumero.Text = "Segundo Número";
            // 
            // txtSegundoNumero
            // 
            txtSegundoNumero.Font = new Font("Segoe UI", 12F);
            txtSegundoNumero.Location = new Point(186, 95);
            txtSegundoNumero.Name = "txtSegundoNumero";
            txtSegundoNumero.Size = new Size(125, 34);
            txtSegundoNumero.TabIndex = 1;
            // 
            // rdbAdicao
            // 
            rdbAdicao.AutoSize = true;
            rdbAdicao.Font = new Font("Segoe UI", 12F);
            rdbAdicao.Location = new Point(67, 10);
            rdbAdicao.Name = "rdbAdicao";
            rdbAdicao.Size = new Size(94, 32);
            rdbAdicao.TabIndex = 2;
            rdbAdicao.TabStop = true;
            rdbAdicao.Text = "Adição";
            rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Font = new Font("Segoe UI", 12F);
            rdbSubtracao.Location = new Point(67, 48);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(122, 32);
            rdbSubtracao.TabIndex = 2;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Font = new Font("Segoe UI", 12F);
            rdbMultiplicacao.Location = new Point(67, 86);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(151, 32);
            rdbMultiplicacao.TabIndex = 2;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "Multiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Font = new Font("Segoe UI", 12F);
            rdbDivisao.Location = new Point(67, 124);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(97, 32);
            rdbDivisao.TabIndex = 2;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // gpRadioButtons
            // 
            gpRadioButtons.Controls.Add(rdbDivisao);
            gpRadioButtons.Controls.Add(rdbMultiplicacao);
            gpRadioButtons.Controls.Add(rdbSubtracao);
            gpRadioButtons.Controls.Add(rdbAdicao);
            gpRadioButtons.Location = new Point(9, 135);
            gpRadioButtons.Name = "gpRadioButtons";
            gpRadioButtons.Size = new Size(319, 158);
            gpRadioButtons.TabIndex = 3;
            gpRadioButtons.TabStop = false;
            gpRadioButtons.Text = "groupBox1";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(9, 299);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(319, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(9, 335);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(319, 30);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // listHistorico
            // 
            listHistorico.FormattingEnabled = true;
            listHistorico.Location = new Point(9, 430);
            listHistorico.Name = "listHistorico";
            listHistorico.Size = new Size(319, 144);
            listHistorico.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(26, 393);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResposta.Location = new Point(115, 381);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(83, 32);
            lblResposta.TabIndex = 8;
            lblResposta.Text = "label4";
            // 
            // CalculadoraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(338, 582);
            Controls.Add(lblResposta);
            Controls.Add(lblResultado);
            Controls.Add(listHistorico);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(gpRadioButtons);
            Controls.Add(txtSegundoNumero);
            Controls.Add(lblSegundoNumero);
            Controls.Add(txtPrimeiroNumero);
            Controls.Add(lblPrimeiroNumero);
            Name = "CalculadoraForm";
            Text = "Calculadora WinForm";
            Load += this.CalculadoraForm_Load;
            gpRadioButtons.ResumeLayout(false);
            gpRadioButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listHistorico.Items.Clear();
        }







        #endregion

        private Label lblPrimeiroNumero;
        private TextBox txtPrimeiroNumero;
        private Label lblSegundoNumero;
        private TextBox txtSegundoNumero;
        private RadioButton rdbAdicao;
        private RadioButton rdbSubtracao;
        private RadioButton rdbMultiplicacao;
        private RadioButton rdbDivisao;
        private GroupBox gpRadioButtons;
        private Button btnCalcular;
        private Button btnLimpar;
        private ListBox listHistorico;
        private Label lblResultado;
        private Label lblResposta;
    }
}
