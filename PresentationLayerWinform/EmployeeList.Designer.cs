namespace PresentationLayerWinform
{
    partial class EmployeeList
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
            this.BListar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            this.GrillaEmpleados = new System.Windows.Forms.DataGridView();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // BListar
            // 
            this.BListar.Location = new System.Drawing.Point(55, 12);
            this.BListar.Name = "BListar";
            this.BListar.Size = new System.Drawing.Size(75, 32);
            this.BListar.TabIndex = 0;
            this.BListar.Text = "Listar";
            this.BListar.UseVisualStyleBackColor = true;
            this.BListar.Click += new System.EventHandler(this.Listar_Empleados);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(195, 217);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(90, 28);
            this.BEliminar.TabIndex = 1;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.Eliminar_Empleados);
            // 
            // BModificar
            // 
            this.BModificar.Location = new System.Drawing.Point(103, 217);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(86, 28);
            this.BModificar.TabIndex = 2;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            this.BModificar.Click += new System.EventHandler(this.Modificar_Empleados);
            // 
            // GrillaEmpleados
            // 
            this.GrillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEmpleados.Location = new System.Drawing.Point(31, 50);
            this.GrillaEmpleados.Name = "GrillaEmpleados";
            this.GrillaEmpleados.Size = new System.Drawing.Size(240, 150);
            this.GrillaEmpleados.TabIndex = 3;
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(12, 217);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(85, 28);
            this.BAgregar.TabIndex = 4;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.Agregar_Empleados);
            // 
            // BActualizar
            // 
            this.BActualizar.Location = new System.Drawing.Point(160, 12);
            this.BActualizar.Name = "BActualizar";
            this.BActualizar.Size = new System.Drawing.Size(95, 32);
            this.BActualizar.TabIndex = 5;
            this.BActualizar.Text = "Actualizar";
            this.BActualizar.UseVisualStyleBackColor = true;
            this.BActualizar.Click += new System.EventHandler(this.Actualizar_Empleados);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 262);
            this.Controls.Add(this.BActualizar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.GrillaEmpleados);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BListar);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BListar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.DataGridView GrillaEmpleados;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BActualizar;
    }
}

