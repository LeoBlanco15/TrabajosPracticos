namespace MainCorreo
{
    partial class MainCorreo
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
            this.components = new System.ComponentModel.Container();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.lbEstadoIngresado = new System.Windows.Forms.Label();
            this.lbEstadoEnViaje = new System.Windows.Forms.Label();
            this.lbEntregado = new System.Windows.Forms.Label();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lbTrackingID = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.gpEstadoPaquetes = new System.Windows.Forms.GroupBox();
            this.gpPaquetes = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gpEstadoPaquetes.SuspendLayout();
            this.gpPaquetes.SuspendLayout();
            this.mostrarToolStripMenuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.ItemHeight = 16;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(17, 54);
            this.lstEstadoIngresado.Margin = new System.Windows.Forms.Padding(4);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(240, 276);
            this.lstEstadoIngresado.TabIndex = 0;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.ItemHeight = 16;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(383, 54);
            this.lstEstadoEnViaje.Margin = new System.Windows.Forms.Padding(4);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(240, 276);
            this.lstEstadoEnViaje.TabIndex = 1;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.mostrarToolStripMenuItem;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.ItemHeight = 16;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(752, 54);
            this.lstEstadoEntregado.Margin = new System.Windows.Forms.Padding(4);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(240, 276);
            this.lstEstadoEntregado.TabIndex = 2;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.rtbMostrar.Location = new System.Drawing.Point(16, 384);
            this.rtbMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(536, 154);
            this.rtbMostrar.TabIndex = 3;
            this.rtbMostrar.Text = "";
            // 
            // lbEstadoIngresado
            // 
            this.lbEstadoIngresado.AutoSize = true;
            this.lbEstadoIngresado.Location = new System.Drawing.Point(28, 34);
            this.lbEstadoIngresado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstadoIngresado.Name = "lbEstadoIngresado";
            this.lbEstadoIngresado.Size = new System.Drawing.Size(71, 17);
            this.lbEstadoIngresado.TabIndex = 4;
            this.lbEstadoIngresado.Text = "Ingresado";
            // 
            // lbEstadoEnViaje
            // 
            this.lbEstadoEnViaje.AutoSize = true;
            this.lbEstadoEnViaje.Location = new System.Drawing.Point(395, 34);
            this.lbEstadoEnViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstadoEnViaje.Name = "lbEstadoEnViaje";
            this.lbEstadoEnViaje.Size = new System.Drawing.Size(60, 17);
            this.lbEstadoEnViaje.TabIndex = 5;
            this.lbEstadoEnViaje.Text = "En Viaje";
            // 
            // lbEntregado
            // 
            this.lbEntregado.AutoSize = true;
            this.lbEntregado.Location = new System.Drawing.Point(765, 34);
            this.lbEntregado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEntregado.Name = "lbEntregado";
            this.lbEntregado.Size = new System.Drawing.Size(74, 17);
            this.lbEntregado.TabIndex = 6;
            this.lbEntregado.Text = "Entregado";
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(9, 37);
            this.mtxtTrackingID.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(268, 22);
            this.mtxtTrackingID.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(313, 22);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 52);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(313, 86);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(120, 52);
            this.btnMostrarTodos.TabIndex = 10;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // lbTrackingID
            // 
            this.lbTrackingID.AutoSize = true;
            this.lbTrackingID.Location = new System.Drawing.Point(5, 17);
            this.lbTrackingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrackingID.Name = "lbTrackingID";
            this.lbTrackingID.Size = new System.Drawing.Size(80, 17);
            this.lbTrackingID.TabIndex = 13;
            this.lbTrackingID.Text = "Tracking ID";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(5, 81);
            this.lbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(67, 17);
            this.lbDireccion.TabIndex = 14;
            this.lbDireccion.Text = "Direccion";
            // 
            // gpEstadoPaquetes
            // 
            this.gpEstadoPaquetes.Controls.Add(this.lbEntregado);
            this.gpEstadoPaquetes.Controls.Add(this.lbEstadoEnViaje);
            this.gpEstadoPaquetes.Controls.Add(this.lbEstadoIngresado);
            this.gpEstadoPaquetes.Controls.Add(this.lstEstadoEnViaje);
            this.gpEstadoPaquetes.Controls.Add(this.lstEstadoIngresado);
            this.gpEstadoPaquetes.Controls.Add(this.lstEstadoEntregado);
            this.gpEstadoPaquetes.Location = new System.Drawing.Point(16, 15);
            this.gpEstadoPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.gpEstadoPaquetes.Name = "gpEstadoPaquetes";
            this.gpEstadoPaquetes.Padding = new System.Windows.Forms.Padding(4);
            this.gpEstadoPaquetes.Size = new System.Drawing.Size(1016, 346);
            this.gpEstadoPaquetes.TabIndex = 15;
            this.gpEstadoPaquetes.TabStop = false;
            this.gpEstadoPaquetes.Text = "Estado Paquetes";
            // 
            // gpPaquetes
            // 
            this.gpPaquetes.Controls.Add(this.txtDireccion);
            this.gpPaquetes.Controls.Add(this.lbDireccion);
            this.gpPaquetes.Controls.Add(this.lbTrackingID);
            this.gpPaquetes.Controls.Add(this.btnMostrarTodos);
            this.gpPaquetes.Controls.Add(this.btnAgregar);
            this.gpPaquetes.Controls.Add(this.mtxtTrackingID);
            this.gpPaquetes.Location = new System.Drawing.Point(577, 384);
            this.gpPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.gpPaquetes.Name = "gpPaquetes";
            this.gpPaquetes.Padding = new System.Windows.Forms.Padding(4);
            this.gpPaquetes.Size = new System.Drawing.Size(455, 155);
            this.gpPaquetes.TabIndex = 16;
            this.gpPaquetes.TabStop = false;
            this.gpPaquetes.Text = "Paquetes";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(9, 101);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(268, 22);
            this.txtDireccion.TabIndex = 15;
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.AllowDrop = true;
            this.mostrarToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mostrarToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem1});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            // 
            // MainCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gpPaquetes);
            this.Controls.Add(this.gpEstadoPaquetes);
            this.Controls.Add(this.rtbMostrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainCorreo";
            this.Text = "Correo UTN por Leonardo.Blanco.2doC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainCorreo_FormClosing);
            this.gpEstadoPaquetes.ResumeLayout(false);
            this.gpEstadoPaquetes.PerformLayout();
            this.gpPaquetes.ResumeLayout(false);
            this.gpPaquetes.PerformLayout();
            this.mostrarToolStripMenuItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Label lbEstadoIngresado;
        private System.Windows.Forms.Label lbEstadoEnViaje;
        private System.Windows.Forms.Label lbEntregado;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lbTrackingID;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.GroupBox gpEstadoPaquetes;
        private System.Windows.Forms.GroupBox gpPaquetes;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ContextMenuStrip mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
    }
}

