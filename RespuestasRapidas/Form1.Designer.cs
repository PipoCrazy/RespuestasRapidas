
namespace RespuestasRapidas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAgregarResp = new System.Windows.Forms.Button();
            this.CajaDeTextoCrearRespuesta = new System.Windows.Forms.TextBox();
            this.ListaRespuestas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnAgregarResp
            // 
            this.BtnAgregarResp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarResp.Location = new System.Drawing.Point(1263, 14);
            this.BtnAgregarResp.Name = "BtnAgregarResp";
            this.BtnAgregarResp.Size = new System.Drawing.Size(25, 25);
            this.BtnAgregarResp.TabIndex = 0;
            this.BtnAgregarResp.Text = "+";
            this.BtnAgregarResp.UseVisualStyleBackColor = true;
            this.BtnAgregarResp.Click += new System.EventHandler(this.BtnAgregarRespuesta_Click);
            // 
            // CajaDeTextoCrearRespuesta
            // 
            this.CajaDeTextoCrearRespuesta.Location = new System.Drawing.Point(12, 14);
            this.CajaDeTextoCrearRespuesta.Name = "CajaDeTextoCrearRespuesta";
            this.CajaDeTextoCrearRespuesta.Size = new System.Drawing.Size(1245, 25);
            this.CajaDeTextoCrearRespuesta.TabIndex = 1;
            // 
            // ListaRespuestas
            // 
            this.ListaRespuestas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListaRespuestas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListaRespuestas.FormattingEnabled = true;
            this.ListaRespuestas.HorizontalScrollbar = true;
            this.ListaRespuestas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListaRespuestas.ItemHeight = 17;
            this.ListaRespuestas.Location = new System.Drawing.Point(0, 46);
            this.ListaRespuestas.Name = "ListaRespuestas";
            this.ListaRespuestas.Size = new System.Drawing.Size(1350, 412);
            this.ListaRespuestas.TabIndex = 2;
            this.ListaRespuestas.DoubleClick += new System.EventHandler(this.ListaRespuestas_DoubleClick);
            this.ListaRespuestas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListaRespuestas_RightClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 458);
            this.Controls.Add(this.ListaRespuestas);
            this.Controls.Add(this.CajaDeTextoCrearRespuesta);
            this.Controls.Add(this.BtnAgregarResp);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Respuestas Rápidas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarResp;
        private System.Windows.Forms.TextBox CajaDeTextoCrearRespuesta;
        private System.Windows.Forms.ListBox ListaRespuestas;
    }
}

