namespace PresentationLayerWinform
{
    partial class EmployeeAddEdit
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
            this.LNombre = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LSalario = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.LTarifa = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.inputSalario = new System.Windows.Forms.TextBox();
            this.inputTarifa = new System.Windows.Forms.TextBox();
            this.inputTipo = new System.Windows.Forms.ComboBox();
            this.inputFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.BCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(23, 87);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(23, 208);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(75, 13);
            this.LFecha.TabIndex = 1;
            this.LFecha.Text = "Fecha Ingreso";
            // 
            // LSalario
            // 
            this.LSalario.AutoSize = true;
            this.LSalario.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LSalario.Location = new System.Drawing.Point(23, 123);
            this.LSalario.Name = "LSalario";
            this.LSalario.Size = new System.Drawing.Size(39, 13);
            this.LSalario.TabIndex = 2;
            this.LSalario.Text = "Salario";
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Location = new System.Drawing.Point(23, 46);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(28, 13);
            this.LTipo.TabIndex = 3;
            this.LTipo.Text = "Tipo";
            // 
            // LTarifa
            // 
            this.LTarifa.AutoSize = true;
            this.LTarifa.Location = new System.Drawing.Point(23, 159);
            this.LTarifa.Name = "LTarifa";
            this.LTarifa.Size = new System.Drawing.Size(34, 13);
            this.LTarifa.TabIndex = 4;
            this.LTarifa.Text = "Tarifa";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(92, 87);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(100, 20);
            this.inputNombre.TabIndex = 5;
            // 
            // inputSalario
            // 
            this.inputSalario.Location = new System.Drawing.Point(92, 123);
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.Size = new System.Drawing.Size(100, 20);
            this.inputSalario.TabIndex = 6;
            this.inputSalario.EnabledChanged += new System.EventHandler(this.inputSalario_EnabledChanged);
            // 
            // inputTarifa
            // 
            this.inputTarifa.Location = new System.Drawing.Point(92, 159);
            this.inputTarifa.Name = "inputTarifa";
            this.inputTarifa.Size = new System.Drawing.Size(100, 20);
            this.inputTarifa.TabIndex = 7;
            this.inputTarifa.EnabledChanged += new System.EventHandler(this.inputTarifa_EnabledChanged);
            // 
            // inputTipo
            // 
            this.inputTipo.FormattingEnabled = true;
            this.inputTipo.Location = new System.Drawing.Point(92, 43);
            this.inputTipo.Name = "inputTipo";
            this.inputTipo.Size = new System.Drawing.Size(121, 21);
            this.inputTipo.TabIndex = 8;
            this.inputTipo.TextChanged += new System.EventHandler(this.comboBox1_ValueMemberChanged);
            // 
            // inputFechaIngreso
            // 
            this.inputFechaIngreso.Location = new System.Drawing.Point(115, 208);
            this.inputFechaIngreso.Name = "inputFechaIngreso";
            this.inputFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.inputFechaIngreso.TabIndex = 9;
            // 
            // BCrear
            // 
            this.BCrear.Location = new System.Drawing.Point(115, 257);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(75, 23);
            this.BCrear.TabIndex = 10;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            this.BCrear.Click += new System.EventHandler(this.Crear_Empleados);
            // 
            // EmployeeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 311);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.inputFechaIngreso);
            this.Controls.Add(this.inputTipo);
            this.Controls.Add(this.inputTarifa);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.LTarifa);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.LSalario);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LNombre);
            this.Name = "EmployeeAddEdit";
            this.Text = "EmployeeAddEdit";
            this.Load += new System.EventHandler(this.EmployeeAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LSalario;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LTarifa;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.TextBox inputSalario;
        private System.Windows.Forms.TextBox inputTarifa;
        private System.Windows.Forms.ComboBox inputTipo;
        private System.Windows.Forms.DateTimePicker inputFechaIngreso;
        private System.Windows.Forms.Button BCrear;
    }
}