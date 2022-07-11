namespace Practica04
{
    partial class frmDepart
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultaDepto = new System.Windows.Forms.Button();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreDepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultaFabrica = new System.Windows.Forms.Button();
            this.lblFabricaNombre = new System.Windows.Forms.Label();
            this.txtFabrica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bntBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(559, 49);
            this.label5.TabIndex = 16;
            this.label5.Text = " Maestro de Departamento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConsultaDepto
            // 
            this.btnConsultaDepto.Location = new System.Drawing.Point(252, 82);
            this.btnConsultaDepto.Name = "btnConsultaDepto";
            this.btnConsultaDepto.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaDepto.TabIndex = 18;
            this.btnConsultaDepto.Text = "...";
            this.btnConsultaDepto.UseVisualStyleBackColor = true;
            this.btnConsultaDepto.Click += new System.EventHandler(this.btnConsultaDepto_Click);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(187, 83);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(65, 20);
            this.txtDepartamento.TabIndex = 17;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamento_KeyPress);
            this.txtDepartamento.Leave += new System.EventHandler(this.txtDepartamento_Leave);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID Departamento";
            // 
            // txtNombreDepto
            // 
            this.txtNombreDepto.Location = new System.Drawing.Point(187, 109);
            this.txtNombreDepto.Name = "txtNombreDepto";
            this.txtNombreDepto.Size = new System.Drawing.Size(359, 20);
            this.txtNombreDepto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre de la Posición";
            // 
            // btnConsultaFabrica
            // 
            this.btnConsultaFabrica.Location = new System.Drawing.Point(252, 134);
            this.btnConsultaFabrica.Name = "btnConsultaFabrica";
            this.btnConsultaFabrica.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaFabrica.TabIndex = 23;
            this.btnConsultaFabrica.Text = "...";
            this.btnConsultaFabrica.UseVisualStyleBackColor = true;
            this.btnConsultaFabrica.Click += new System.EventHandler(this.btnConsultaFabrica_Click);
            // 
            // lblFabricaNombre
            // 
            this.lblFabricaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFabricaNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFabricaNombre.Location = new System.Drawing.Point(285, 135);
            this.lblFabricaNombre.Name = "lblFabricaNombre";
            this.lblFabricaNombre.Size = new System.Drawing.Size(261, 20);
            this.lblFabricaNombre.TabIndex = 25;
            // 
            // txtFabrica
            // 
            this.txtFabrica.Location = new System.Drawing.Point(187, 135);
            this.txtFabrica.Name = "txtFabrica";
            this.txtFabrica.Size = new System.Drawing.Size(65, 20);
            this.txtFabrica.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID Fabrica";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 198);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 34);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // bntBorrar
            // 
            this.bntBorrar.Location = new System.Drawing.Point(282, 198);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(129, 34);
            this.bntBorrar.TabIndex = 28;
            this.bntBorrar.Text = "Borrar";
            this.bntBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBorrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(147, 198);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 34);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 34);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 257);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConsultaFabrica);
            this.Controls.Add(this.lblFabricaNombre);
            this.Controls.Add(this.txtFabrica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreDepto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultaDepto);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "frmDepart";
            this.Text = "frmDepart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultaDepto;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreDepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultaFabrica;
        private System.Windows.Forms.Label lblFabricaNombre;
        private System.Windows.Forms.TextBox txtFabrica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button bntBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}