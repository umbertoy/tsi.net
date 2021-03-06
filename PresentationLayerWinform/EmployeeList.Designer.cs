﻿namespace PresentationLayerWinform
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
            this.BEliminar = new System.Windows.Forms.Button();
            this.BModificar = new System.Windows.Forms.Button();
            EmployeeList.GrillaEmpleados = new System.Windows.Forms.DataGridView();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BActualizar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(EmployeeList.GrillaEmpleados)).BeginInit();
            this.SuspendLayout();
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
            EmployeeList.GrillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeList.GrillaEmpleados.Location = new System.Drawing.Point(31, 50);
            EmployeeList.GrillaEmpleados.MaximumSize = new System.Drawing.Size(500, 150);
            EmployeeList.GrillaEmpleados.Name = "GrillaEmpleados";
            EmployeeList.GrillaEmpleados.Size = new System.Drawing.Size(357, 150);
            EmployeeList.GrillaEmpleados.TabIndex = 3;
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
            this.ClientSize = new System.Drawing.Size(501, 262);
            this.Controls.Add(this.BActualizar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(EmployeeList.GrillaEmpleados);
            this.Controls.Add(this.BModificar);
            this.Controls.Add(this.BEliminar);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(EmployeeList.GrillaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BModificar;
        public static System.Windows.Forms.DataGridView GrillaEmpleados;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BActualizar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

