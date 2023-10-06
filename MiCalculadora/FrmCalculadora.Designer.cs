namespace View
{
    partial class FrmCalculadora
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
            lblResultado = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblPrimerOperando = new Label();
            lblOperacion = new Label();
            lblSegundoOperando = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(369, 96);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(430, 178);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(300, 102);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBinario.Location = new Point(165, 54);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(98, 32);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(20, 54);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(107, 32);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(60, 350);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(321, 54);
            lblPrimerOperando.TabIndex = 2;
            lblPrimerOperando.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(474, 350);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(215, 54);
            lblOperacion.TabIndex = 3;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(769, 350);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(365, 54);
            lblSegundoOperando.TabIndex = 4;
            lblSegundoOperando.Text = "Segundo operador:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperando.Location = new Point(70, 407);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(291, 34);
            txtPrimerOperando.TabIndex = 2;
            txtPrimerOperando.TextChanged += txtprimerOperador_TextChanged;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperando.Location = new Point(803, 407);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(291, 34);
            txtSegundoOperando.TabIndex = 4;
            txtSegundoOperando.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "", "+", "-", "/", "*" });
            cmbOperacion.Location = new Point(489, 407);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(182, 36);
            cmbOperacion.TabIndex = 3;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(138, 459);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(149, 53);
            btnOperar.TabIndex = 5;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(507, 459);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 53);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(874, 459);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(149, 53);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 25;
            lstHistorial.Location = new Point(828, 93);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(316, 254);
            lstHistorial.TabIndex = 8;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(828, 32);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(160, 48);
            lblHistorial.TabIndex = 9;
            lblHistorial.Text = "Historial:";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 544);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblSegundoOperando);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperando);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Santiago Collazo";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblPrimerOperando;
        private Label lblOperacion;
        private Label lblSegundoOperando;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}