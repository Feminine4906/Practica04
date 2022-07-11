namespace Practica04
{
    partial class frmPosicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosicion));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.bntBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtNombrePosicion = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtFabrica = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblFabricaNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultaDepto = new System.Windows.Forms.Button();
            this.btnConsultaFabrica = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 232);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 34);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(147, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 34);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // bntBorrar
            // 
            this.bntBorrar.Location = new System.Drawing.Point(282, 232);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(129, 34);
            this.bntBorrar.TabIndex = 8;
            this.bntBorrar.Text = "Borrar";
            this.bntBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBorrar.UseVisualStyleBackColor = true;
            this.bntBorrar.Click += new System.EventHandler(this.bntBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 34);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Posición";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de la Posición";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Departamento";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID Fabrica";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(187, 77);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(65, 20);
            this.txtPosicion.TabIndex = 0;
            this.txtPosicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPosicion_KeyPress);
            this.txtPosicion.Leave += new System.EventHandler(this.txtPosicion_Leave);
            // 
            // txtNombrePosicion
            // 
            this.txtNombrePosicion.Location = new System.Drawing.Point(187, 103);
            this.txtNombrePosicion.Name = "txtNombrePosicion";
            this.txtNombrePosicion.Size = new System.Drawing.Size(359, 20);
            this.txtNombrePosicion.TabIndex = 1;
            this.txtNombrePosicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePosicion_KeyPress);
            this.txtNombrePosicion.Leave += new System.EventHandler(this.txtNombrePosicion_Leave);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(187, 129);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(65, 20);
            this.txtDepartamento.TabIndex = 2;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamento_KeyPress);
            this.txtDepartamento.Leave += new System.EventHandler(this.txtDepartamento_Leave);
            // 
            // txtFabrica
            // 
            this.txtFabrica.Location = new System.Drawing.Point(187, 155);
            this.txtFabrica.Name = "txtFabrica";
            this.txtFabrica.Size = new System.Drawing.Size(65, 20);
            this.txtFabrica.TabIndex = 4;
            this.txtFabrica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFabrica_KeyPress);
            this.txtFabrica.Leave += new System.EventHandler(this.txtFabrica_Leave);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDepartamento.Location = new System.Drawing.Point(285, 129);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(261, 20);
            this.lblDepartamento.TabIndex = 13;
            // 
            // lblFabricaNombre
            // 
            this.lblFabricaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFabricaNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFabricaNombre.Location = new System.Drawing.Point(285, 155);
            this.lblFabricaNombre.Name = "lblFabricaNombre";
            this.lblFabricaNombre.Size = new System.Drawing.Size(261, 20);
            this.lblFabricaNombre.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(559, 49);
            this.label5.TabIndex = 15;
            this.label5.Text = " Maestro de Cargos y/o Posiciones";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConsultaDepto
            // 
            this.btnConsultaDepto.Location = new System.Drawing.Point(252, 128);
            this.btnConsultaDepto.Name = "btnConsultaDepto";
            this.btnConsultaDepto.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaDepto.TabIndex = 3;
            this.btnConsultaDepto.Text = "...";
            this.btnConsultaDepto.UseVisualStyleBackColor = true;
            this.btnConsultaDepto.Click += new System.EventHandler(this.btnConsultaDepto_Click);
            // 
            // btnConsultaFabrica
            // 
            this.btnConsultaFabrica.Location = new System.Drawing.Point(252, 154);
            this.btnConsultaFabrica.Name = "btnConsultaFabrica";
            this.btnConsultaFabrica.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaFabrica.TabIndex = 5;
            this.btnConsultaFabrica.Text = "...";
            this.btnConsultaFabrica.UseVisualStyleBackColor = true;
            this.btnConsultaFabrica.Click += new System.EventHandler(this.btnConsultaFabrica_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(252, 76);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(27, 22);
            this.btnConsulta.TabIndex = 16;
            this.btnConsulta.Text = "...";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // frmPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 287);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnConsultaFabrica);
            this.Controls.Add(this.btnConsultaDepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFabricaNombre);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtFabrica);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtNombrePosicion);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPosicion";
            this.Text = "Practica04";
            this.Load += new System.EventHandler(this.frmPosicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button bntBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtNombrePosicion;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtFabrica;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblFabricaNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultaDepto;
        private System.Windows.Forms.Button btnConsultaFabrica;
        private System.Windows.Forms.Button btnConsulta;
    }
}