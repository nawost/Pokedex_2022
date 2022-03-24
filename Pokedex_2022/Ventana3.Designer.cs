
namespace Pokedex_2022
{
    partial class Ventana3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana3));
            this.pre_evolucion = new System.Windows.Forms.PictureBox();
            this.nombre_pokemon = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pre_evolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // pre_evolucion
            // 
            this.pre_evolucion.Location = new System.Drawing.Point(63, 132);
            this.pre_evolucion.Name = "pre_evolucion";
            this.pre_evolucion.Size = new System.Drawing.Size(197, 193);
            this.pre_evolucion.TabIndex = 0;
            this.pre_evolucion.TabStop = false;
            // 
            // nombre_pokemon
            // 
            this.nombre_pokemon.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_pokemon.Location = new System.Drawing.Point(63, 81);
            this.nombre_pokemon.Name = "nombre_pokemon";
            this.nombre_pokemon.Size = new System.Drawing.Size(197, 35);
            this.nombre_pokemon.TabIndex = 1;
            this.nombre_pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mensaje
            // 
            this.mensaje.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.Location = new System.Drawing.Point(12, 9);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(307, 413);
            this.mensaje.TabIndex = 2;
            this.mensaje.Text = "NO TIENE PREEVOLUCION PERROOOO";
            this.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ventana3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 431);
            this.Controls.Add(this.nombre_pokemon);
            this.Controls.Add(this.pre_evolucion);
            this.Controls.Add(this.mensaje);
            this.Name = "Ventana3";
            this.Text = "Ventana3";
            ((System.ComponentModel.ISupportInitialize)(this.pre_evolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pre_evolucion;
        private System.Windows.Forms.Label nombre_pokemon;
        private System.Windows.Forms.Label mensaje;
    }
}