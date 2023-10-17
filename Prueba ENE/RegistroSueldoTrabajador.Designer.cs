namespace Prueba_ENE
{
    partial class RegistroSueldoTrabajador
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
            this.HorasTrabajadas = new System.Windows.Forms.Label();
            this.HorasExtra = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.comboAFP = new System.Windows.Forms.ComboBox();
            this.comboHealth = new System.Windows.Forms.ComboBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.SueldoBruto = new System.Windows.Forms.Label();
            this.SueldoLiquido = new System.Windows.Forms.Label();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.txtSueldoLiquido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.AutoSize = true;
            this.HorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasTrabajadas.Location = new System.Drawing.Point(12, 36);
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            this.HorasTrabajadas.Size = new System.Drawing.Size(160, 18);
            this.HorasTrabajadas.TabIndex = 0;
            this.HorasTrabajadas.Text = "HORAS TRABAJADAS";
            // 
            // HorasExtra
            // 
            this.HorasExtra.AutoSize = true;
            this.HorasExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasExtra.Location = new System.Drawing.Point(12, 83);
            this.HorasExtra.Name = "HorasExtra";
            this.HorasExtra.Size = new System.Drawing.Size(124, 18);
            this.HorasExtra.TabIndex = 1;
            this.HorasExtra.Text = "HORAS EXTRAS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(15, 142);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 29);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(15, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 29);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(15, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 60);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar Campos";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(15, 315);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(80, 29);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // comboAFP
            // 
            this.comboAFP.FormattingEnabled = true;
            this.comboAFP.Location = new System.Drawing.Point(505, 30);
            this.comboAFP.Name = "comboAFP";
            this.comboAFP.Size = new System.Drawing.Size(121, 24);
            this.comboAFP.TabIndex = 6;
            // 
            // comboHealth
            // 
            this.comboHealth.FormattingEnabled = true;
            this.comboHealth.Location = new System.Drawing.Point(505, 83);
            this.comboHealth.Name = "comboHealth";
            this.comboHealth.Size = new System.Drawing.Size(121, 24);
            this.comboHealth.TabIndex = 7;
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(242, 35);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(148, 22);
            this.txtHorasTrabajadas.TabIndex = 8;
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(242, 82);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(148, 22);
            this.txtHorasExtra.TabIndex = 9;
            // 
            // SueldoBruto
            // 
            this.SueldoBruto.AutoSize = true;
            this.SueldoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SueldoBruto.Location = new System.Drawing.Point(239, 194);
            this.SueldoBruto.Name = "SueldoBruto";
            this.SueldoBruto.Size = new System.Drawing.Size(127, 18);
            this.SueldoBruto.TabIndex = 10;
            this.SueldoBruto.Text = "SUELDO BRUTO";
            // 
            // SueldoLiquido
            // 
            this.SueldoLiquido.AutoSize = true;
            this.SueldoLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SueldoLiquido.Location = new System.Drawing.Point(239, 256);
            this.SueldoLiquido.Name = "SueldoLiquido";
            this.SueldoLiquido.Size = new System.Drawing.Size(134, 18);
            this.SueldoLiquido.TabIndex = 11;
            this.SueldoLiquido.Text = "SUELDO LIQUIDO";
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(505, 193);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(148, 22);
            this.txtSueldoBruto.TabIndex = 12;
            // 
            // txtSueldoLiquido
            // 
            this.txtSueldoLiquido.Location = new System.Drawing.Point(505, 256);
            this.txtSueldoLiquido.Name = "txtSueldoLiquido";
            this.txtSueldoLiquido.Size = new System.Drawing.Size(148, 22);
            this.txtSueldoLiquido.TabIndex = 13;
            // 
            // RegistroSueldoTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 391);
            this.Controls.Add(this.txtSueldoLiquido);
            this.Controls.Add(this.txtSueldoBruto);
            this.Controls.Add(this.SueldoLiquido);
            this.Controls.Add(this.SueldoBruto);
            this.Controls.Add(this.txtHorasExtra);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.comboHealth);
            this.Controls.Add(this.comboAFP);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.HorasExtra);
            this.Controls.Add(this.HorasTrabajadas);
            this.Name = "RegistroSueldoTrabajador";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HorasTrabajadas;
        private System.Windows.Forms.Label HorasExtra;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox comboAFP;
        private System.Windows.Forms.ComboBox comboHealth;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.Label SueldoBruto;
        private System.Windows.Forms.Label SueldoLiquido;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.TextBox txtSueldoLiquido;
    }
}