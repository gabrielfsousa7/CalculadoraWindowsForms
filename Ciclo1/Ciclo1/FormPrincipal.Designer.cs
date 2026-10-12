namespace Ciclo1
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            lblNome = new Label();
            txtNome = new TextBox();
            grpSexo = new GroupBox();
            rdoFeminino = new RadioButton();
            rdoMasculino = new RadioButton();
            grpTime = new GroupBox();
            rdoPalmeiras = new RadioButton();
            rdoSantos = new RadioButton();
            rdoSaoPaulo = new RadioButton();
            rdoCorinthians = new RadioButton();
            grpArea = new GroupBox();
            rdoHumanas = new RadioButton();
            rdoExatas = new RadioButton();
            rdoTecnologia = new RadioButton();
            txtAno = new TextBox();
            lblAno = new Label();
            txtSalario = new TextBox();
            lblSalario = new Label();
            chkFaculdade = new CheckBox();
            btnCalcular = new Button();
            lblBonus = new Label();
            lblTotal = new Label();
            erros = new ErrorProvider(components);
            dicas = new ToolTip(components);
            grpSexo.SuspendLayout();
            grpTime.SuspendLayout();
            grpArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erros).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(28, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(240, 24);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(25, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(243, 29);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += EntradaAlterada;
            txtNome.Validating += ValidarCampo;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(rdoFeminino);
            grpSexo.Controls.Add(rdoMasculino);
            grpSexo.Location = new Point(31, 122);
            grpSexo.Name = "grpSexo";
            grpSexo.Size = new Size(255, 169);
            grpSexo.TabIndex = 2;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo";
            // 
            // rdoFeminino
            // 
            rdoFeminino.AutoSize = true;
            rdoFeminino.Location = new Point(69, 94);
            rdoFeminino.Name = "rdoFeminino";
            rdoFeminino.Size = new Size(106, 26);
            rdoFeminino.TabIndex = 1;
            rdoFeminino.TabStop = true;
            rdoFeminino.Text = "Feminino";
            rdoFeminino.UseVisualStyleBackColor = true;
            rdoFeminino.CheckedChanged += EntradaAlterada;
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.Location = new Point(69, 41);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(112, 26);
            rdoMasculino.TabIndex = 0;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Masculino";
            rdoMasculino.UseVisualStyleBackColor = true;
            rdoMasculino.CheckedChanged += EntradaAlterada;
            // 
            // grpTime
            // 
            grpTime.Controls.Add(rdoPalmeiras);
            grpTime.Controls.Add(rdoSantos);
            grpTime.Controls.Add(rdoSaoPaulo);
            grpTime.Controls.Add(rdoCorinthians);
            grpTime.Location = new Point(313, 122);
            grpTime.Name = "grpTime";
            grpTime.Size = new Size(274, 169);
            grpTime.TabIndex = 3;
            grpTime.TabStop = false;
            grpTime.Text = "Time que simpatiza";
            // 
            // rdoPalmeiras
            // 
            rdoPalmeiras.Location = new Point(81, 129);
            rdoPalmeiras.Name = "rdoPalmeiras";
            rdoPalmeiras.Size = new Size(187, 27);
            rdoPalmeiras.TabIndex = 5;
            rdoPalmeiras.TabStop = true;
            rdoPalmeiras.Text = "Palmeiras";
            rdoPalmeiras.UseVisualStyleBackColor = true;
            rdoPalmeiras.CheckedChanged += EntradaAlterada;
            // 
            // rdoSantos
            // 
            rdoSantos.Location = new Point(81, 95);
            rdoSantos.Name = "rdoSantos";
            rdoSantos.Size = new Size(187, 27);
            rdoSantos.TabIndex = 4;
            rdoSantos.TabStop = true;
            rdoSantos.Text = "Santos";
            rdoSantos.UseVisualStyleBackColor = true;
            rdoSantos.CheckedChanged += EntradaAlterada;
            // 
            // rdoSaoPaulo
            // 
            rdoSaoPaulo.Location = new Point(81, 61);
            rdoSaoPaulo.Name = "rdoSaoPaulo";
            rdoSaoPaulo.Size = new Size(187, 27);
            rdoSaoPaulo.TabIndex = 3;
            rdoSaoPaulo.TabStop = true;
            rdoSaoPaulo.Text = "São Paulo";
            rdoSaoPaulo.UseVisualStyleBackColor = true;
            rdoSaoPaulo.CheckedChanged += EntradaAlterada;
            // 
            // rdoCorinthians
            // 
            rdoCorinthians.Location = new Point(81, 27);
            rdoCorinthians.Name = "rdoCorinthians";
            rdoCorinthians.Size = new Size(187, 27);
            rdoCorinthians.TabIndex = 2;
            rdoCorinthians.TabStop = true;
            rdoCorinthians.Text = "Corinthians";
            rdoCorinthians.UseVisualStyleBackColor = true;
            rdoCorinthians.CheckedChanged += EntradaAlterada;
            // 
            // grpArea
            // 
            grpArea.Controls.Add(rdoHumanas);
            grpArea.Controls.Add(rdoExatas);
            grpArea.Controls.Add(rdoTecnologia);
            grpArea.Location = new Point(312, 312);
            grpArea.Name = "grpArea";
            grpArea.Size = new Size(284, 126);
            grpArea.TabIndex = 3;
            grpArea.TabStop = false;
            grpArea.Text = "Área";
            // 
            // rdoHumanas
            // 
            rdoHumanas.Location = new Point(5, 88);
            rdoHumanas.Name = "rdoHumanas";
            rdoHumanas.Size = new Size(279, 27);
            rdoHumanas.TabIndex = 7;
            rdoHumanas.TabStop = true;
            rdoHumanas.Text = "Não Tecnológica - Humanas";
            rdoHumanas.UseVisualStyleBackColor = true;
            rdoHumanas.CheckedChanged += AreaAlterada;
            // 
            // rdoExatas
            // 
            rdoExatas.Location = new Point(5, 59);
            rdoExatas.Name = "rdoExatas";
            rdoExatas.Size = new Size(279, 27);
            rdoExatas.TabIndex = 6;
            rdoExatas.TabStop = true;
            rdoExatas.Text = "Não Tecnológica - Exatas";
            rdoExatas.UseVisualStyleBackColor = true;
            rdoExatas.CheckedChanged += AreaAlterada;
            // 
            // rdoTecnologia
            // 
            rdoTecnologia.Location = new Point(5, 27);
            rdoTecnologia.Name = "rdoTecnologia";
            rdoTecnologia.Size = new Size(270, 27);
            rdoTecnologia.TabIndex = 4;
            rdoTecnologia.TabStop = true;
            rdoTecnologia.Text = "Tecnologia";
            rdoTecnologia.UseVisualStyleBackColor = true;
            rdoTecnologia.CheckedChanged += AreaAlterada;
            // 
            // txtAno
            // 
            txtAno.Cursor = Cursors.IBeam;
            txtAno.Location = new Point(279, 59);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(140, 29);
            txtAno.TabIndex = 5;
            txtAno.TextChanged += EntradaAlterada;
            txtAno.Validating += ValidarCampo;
            // 
            // lblAno
            // 
            lblAno.Location = new Point(279, 32);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(150, 24);
            lblAno.TabIndex = 4;
            lblAno.Text = "Ano Nascimento";
            // 
            // txtSalario
            // 
            txtSalario.Cursor = Cursors.IBeam;
            txtSalario.Location = new Point(432, 59);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(164, 29);
            txtSalario.TabIndex = 7;
            dicas.SetToolTip(txtSalario, "Informe o salário sem pontos de milhar. Use 0 se não trabalha.\r\n");
            txtSalario.TextChanged += EntradaAlterada;
            txtSalario.Validating += ValidarCampo;
            // 
            // lblSalario
            // 
            lblSalario.Location = new Point(432, 32);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(164, 24);
            lblSalario.TabIndex = 6;
            lblSalario.Text = "Salário";
            // 
            // chkFaculdade
            // 
            chkFaculdade.Location = new Point(30, 310);
            chkFaculdade.Name = "chkFaculdade";
            chkFaculdade.Size = new Size(289, 36);
            chkFaculdade.TabIndex = 8;
            chkFaculdade.Text = "Cursando faculdade";
            chkFaculdade.UseVisualStyleBackColor = true;
            chkFaculdade.CheckedChanged += FaculdadeAlterada;
            // 
            // btnCalcular
            // 
            btnCalcular.Image = Properties.Resources.calculadora;
            btnCalcular.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcular.Location = new Point(32, 411);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Padding = new Padding(12, 0, 8, 0);
            btnCalcular.Size = new Size(174, 105);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular\r\nValor\r\nBônus";
            btnCalcular.TextAlign = ContentAlignment.MiddleRight;
            btnCalcular.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += Calcular;
            // 
            // lblBonus
            // 
            lblBonus.Location = new Point(327, 461);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(170, 37);
            lblBonus.TabIndex = 10;
            lblBonus.Text = "Valor Bônus";
            lblBonus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Cursor = Cursors.Hand;
            lblTotal.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTotal.Location = new Point(327, 490);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(169, 26);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "R$ ???????,??";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            dicas.SetToolTip(lblTotal, "Após calcular, clique para ver a memória do cálculo.");
            lblTotal.Click += MostrarMemoria;
            // 
            // erros
            // 
            erros.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            erros.ContainerControl = this;
            // 
            // FormPrincipal
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(630, 544);
            Controls.Add(lblTotal);
            Controls.Add(lblBonus);
            Controls.Add(btnCalcular);
            Controls.Add(chkFaculdade);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(txtAno);
            Controls.Add(lblAno);
            Controls.Add(grpArea);
            Controls.Add(grpTime);
            Controls.Add(grpSexo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Font = new Font("Arial", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 3, 5, 3);
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo de bônus social";
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            grpTime.ResumeLayout(false);
            grpArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private GroupBox grpSexo;
        private GroupBox grpTime;
        private GroupBox grpArea;
        private RadioButton rdoMasculino;
        private RadioButton rdoFeminino;
        private RadioButton rdoCorinthians;
        private TextBox txtAno;
        private Label lblAno;
        private TextBox txtSalario;
        private Label lblSalario;
        private RadioButton rdoSantos;
        private RadioButton rdoSaoPaulo;
        private RadioButton rdoPalmeiras;
        private CheckBox chkFaculdade;
        private RadioButton rdoExatas;
        private RadioButton rdoTecnologia;
        private RadioButton rdoHumanas;
        private Button btnCalcular;
        private Label lblBonus;
        private Label lblTotal;
        private ErrorProvider erros;
        private ToolTip dicas;
    }
}
