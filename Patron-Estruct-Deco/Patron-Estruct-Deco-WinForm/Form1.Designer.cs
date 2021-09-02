
namespace Patron_Estruct_Deco_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtTe = new System.Windows.Forms.RadioButton();
            this.rbtDescafeinado = new System.Windows.Forms.RadioButton();
            this.rbtExpresso = new System.Windows.Forms.RadioButton();
            this.rbtSolo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtAzucar = new System.Windows.Forms.RadioButton();
            this.rbtCanela = new System.Windows.Forms.RadioButton();
            this.rbtCrema = new System.Windows.Forms.RadioButton();
            this.rbtEdulcorante = new System.Windows.Forms.RadioButton();
            this.rbtLeche = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtTe);
            this.groupBox1.Controls.Add(this.rbtDescafeinado);
            this.groupBox1.Controls.Add(this.rbtExpresso);
            this.groupBox1.Controls.Add(this.rbtSolo);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bebidas";
            // 
            // rbtTe
            // 
            this.rbtTe.AutoSize = true;
            this.rbtTe.Location = new System.Drawing.Point(15, 95);
            this.rbtTe.Name = "rbtTe";
            this.rbtTe.Size = new System.Drawing.Size(93, 17);
            this.rbtTe.TabIndex = 3;
            this.rbtTe.TabStop = true;
            this.rbtTe.Text = "Te Tradicional";
            this.rbtTe.UseVisualStyleBackColor = true;
            // 
            // rbtDescafeinado
            // 
            this.rbtDescafeinado.AutoSize = true;
            this.rbtDescafeinado.Location = new System.Drawing.Point(15, 72);
            this.rbtDescafeinado.Name = "rbtDescafeinado";
            this.rbtDescafeinado.Size = new System.Drawing.Size(116, 17);
            this.rbtDescafeinado.TabIndex = 2;
            this.rbtDescafeinado.TabStop = true;
            this.rbtDescafeinado.Text = "Cafe Descafeinado";
            this.rbtDescafeinado.UseVisualStyleBackColor = true;
            // 
            // rbtExpresso
            // 
            this.rbtExpresso.AutoSize = true;
            this.rbtExpresso.Location = new System.Drawing.Point(15, 49);
            this.rbtExpresso.Name = "rbtExpresso";
            this.rbtExpresso.Size = new System.Drawing.Size(93, 17);
            this.rbtExpresso.TabIndex = 1;
            this.rbtExpresso.TabStop = true;
            this.rbtExpresso.Text = "Cafe Expresso";
            this.rbtExpresso.UseVisualStyleBackColor = true;
            // 
            // rbtSolo
            // 
            this.rbtSolo.AutoSize = true;
            this.rbtSolo.Location = new System.Drawing.Point(15, 26);
            this.rbtSolo.Name = "rbtSolo";
            this.rbtSolo.Size = new System.Drawing.Size(71, 17);
            this.rbtSolo.TabIndex = 0;
            this.rbtSolo.TabStop = true;
            this.rbtSolo.Text = "Cafe Solo";
            this.rbtSolo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtLeche);
            this.groupBox2.Controls.Add(this.rbtEdulcorante);
            this.groupBox2.Controls.Add(this.rbtCrema);
            this.groupBox2.Controls.Add(this.rbtCanela);
            this.groupBox2.Controls.Add(this.rbtAzucar);
            this.groupBox2.Location = new System.Drawing.Point(174, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(116, 249);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(116, 201);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(35, 249);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Costo ";
            // 
            // rbtAzucar
            // 
            this.rbtAzucar.AutoSize = true;
            this.rbtAzucar.Location = new System.Drawing.Point(16, 24);
            this.rbtAzucar.Name = "rbtAzucar";
            this.rbtAzucar.Size = new System.Drawing.Size(58, 17);
            this.rbtAzucar.TabIndex = 4;
            this.rbtAzucar.TabStop = true;
            this.rbtAzucar.Text = "Azucar";
            this.rbtAzucar.UseVisualStyleBackColor = true;
            // 
            // rbtCanela
            // 
            this.rbtCanela.AutoSize = true;
            this.rbtCanela.Location = new System.Drawing.Point(16, 47);
            this.rbtCanela.Name = "rbtCanela";
            this.rbtCanela.Size = new System.Drawing.Size(58, 17);
            this.rbtCanela.TabIndex = 7;
            this.rbtCanela.TabStop = true;
            this.rbtCanela.Text = "Canela";
            this.rbtCanela.UseVisualStyleBackColor = true;
            // 
            // rbtCrema
            // 
            this.rbtCrema.AutoSize = true;
            this.rbtCrema.Location = new System.Drawing.Point(16, 70);
            this.rbtCrema.Name = "rbtCrema";
            this.rbtCrema.Size = new System.Drawing.Size(55, 17);
            this.rbtCrema.TabIndex = 8;
            this.rbtCrema.TabStop = true;
            this.rbtCrema.Text = "Crema";
            this.rbtCrema.UseVisualStyleBackColor = true;
            // 
            // rbtEdulcorante
            // 
            this.rbtEdulcorante.AutoSize = true;
            this.rbtEdulcorante.Location = new System.Drawing.Point(16, 93);
            this.rbtEdulcorante.Name = "rbtEdulcorante";
            this.rbtEdulcorante.Size = new System.Drawing.Size(82, 17);
            this.rbtEdulcorante.TabIndex = 9;
            this.rbtEdulcorante.TabStop = true;
            this.rbtEdulcorante.Text = "Edulcorante";
            this.rbtEdulcorante.UseVisualStyleBackColor = true;
            // 
            // rbtLeche
            // 
            this.rbtLeche.AutoSize = true;
            this.rbtLeche.Location = new System.Drawing.Point(16, 116);
            this.rbtLeche.Name = "rbtLeche";
            this.rbtLeche.Size = new System.Drawing.Size(55, 17);
            this.rbtLeche.TabIndex = 10;
            this.rbtLeche.TabStop = true;
            this.rbtLeche.Text = "Leche";
            this.rbtLeche.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(305, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtTe;
        private System.Windows.Forms.RadioButton rbtDescafeinado;
        private System.Windows.Forms.RadioButton rbtExpresso;
        private System.Windows.Forms.RadioButton rbtSolo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtLeche;
        private System.Windows.Forms.RadioButton rbtEdulcorante;
        private System.Windows.Forms.RadioButton rbtCrema;
        private System.Windows.Forms.RadioButton rbtCanela;
        private System.Windows.Forms.RadioButton rbtAzucar;
    }
}

