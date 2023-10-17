namespace Prueba_ENE
{
    partial class ListarTrabajadores
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
            this.dataGridViewTrabajadores = new System.Windows.Forms.DataGridView();
            this.Trabajador = new System.Windows.Forms.Label();
            this.comboTrabajador = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrabajadores
            // 
            this.dataGridViewTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrabajadores.Location = new System.Drawing.Point(12, 97);
            this.dataGridViewTrabajadores.Name = "dataGridViewTrabajadores";
            this.dataGridViewTrabajadores.RowHeadersWidth = 51;
            this.dataGridViewTrabajadores.RowTemplate.Height = 24;
            this.dataGridViewTrabajadores.Size = new System.Drawing.Size(375, 150);
            this.dataGridViewTrabajadores.TabIndex = 0;
            // 
            // Trabajador
            // 
            this.Trabajador.AutoSize = true;
            this.Trabajador.Location = new System.Drawing.Point(33, 45);
            this.Trabajador.Name = "Trabajador";
            this.Trabajador.Size = new System.Drawing.Size(99, 16);
            this.Trabajador.TabIndex = 1;
            this.Trabajador.Text = "TRABAJADOR";
            // 
            // comboTrabajador
            // 
            this.comboTrabajador.FormattingEnabled = true;
            this.comboTrabajador.Location = new System.Drawing.Point(175, 45);
            this.comboTrabajador.Name = "comboTrabajador";
            this.comboTrabajador.Size = new System.Drawing.Size(121, 24);
            this.comboTrabajador.TabIndex = 2;
            this.comboTrabajador.Text = "TODOS";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(22, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 51);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(218, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 51);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(119, 316);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 51);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // ListarTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 379);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.comboTrabajador);
            this.Controls.Add(this.Trabajador);
            this.Controls.Add(this.dataGridViewTrabajadores);
            this.Name = "ListarTrabajadores";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrabajadores;
        private System.Windows.Forms.Label Trabajador;
        private System.Windows.Forms.ComboBox comboTrabajador;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}