namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTardanza = new System.Windows.Forms.TextBox();
            this.textBoxAtencion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewLista = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEmpleados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRES:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(146, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(302, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria: ";
            // 
            // comboBoxLista
            // 
            this.comboBoxLista.FormattingEnabled = true;
            this.comboBoxLista.Location = new System.Drawing.Point(146, 89);
            this.comboBoxLista.Name = "comboBoxLista";
            this.comboBoxLista.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "MINUTOS DE TARDANZA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "N° LLAMADAS DE ATENCION:";
            // 
            // textBoxTardanza
            // 
            this.textBoxTardanza.Location = new System.Drawing.Point(188, 147);
            this.textBoxTardanza.Name = "textBoxTardanza";
            this.textBoxTardanza.Size = new System.Drawing.Size(100, 20);
            this.textBoxTardanza.TabIndex = 6;
            // 
            // textBoxAtencion
            // 
            this.textBoxAtencion.Location = new System.Drawing.Point(499, 147);
            this.textBoxAtencion.Name = "textBoxAtencion";
            this.textBoxAtencion.Size = new System.Drawing.Size(100, 20);
            this.textBoxAtencion.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "REGISTRAR EMPLEADO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listViewLista
            // 
            this.listViewLista.Location = new System.Drawing.Point(38, 277);
            this.listViewLista.Name = "listViewLista";
            this.listViewLista.Size = new System.Drawing.Size(528, 181);
            this.listViewLista.TabIndex = 10;
            this.listViewLista.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL DE EMPLEADOS:";
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.Location = new System.Drawing.Point(456, 478);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(13, 13);
            this.labelEmpleados.TabIndex = 12;
            this.labelEmpleados.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 513);
            this.Controls.Add(this.labelEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewLista);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAtencion);
            this.Controls.Add(this.textBoxTardanza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTardanza;
        private System.Windows.Forms.TextBox textBoxAtencion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEmpleados;
    }
}

