
namespace WindowsFormsApp1a
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataDatos);
            this.panel1.Location = new System.Drawing.Point(72, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 253);
            this.panel1.TabIndex = 0;
            // 
            // dataDatos
            // 
            this.dataDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatos.Location = new System.Drawing.Point(3, 3);
            this.dataDatos.Name = "dataDatos";
            this.dataDatos.Size = new System.Drawing.Size(638, 247);
            this.dataDatos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(247, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Empleados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Empresa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "Empleados Mayores a 30 y viven en Bogota ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(401, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 63);
            this.button4.TabIndex = 5;
            this.button4.Text = "Empleados entre 25 y 35  ordenados por edad ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lista Empleados";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

