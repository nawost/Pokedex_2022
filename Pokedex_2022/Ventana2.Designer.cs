
namespace Pokedex_2022
{
    partial class Ventana2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana2));
            this.posevolucion = new System.Windows.Forms.PictureBox();
            this.nombre_pokemon = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.posevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // posevolucion
            // 
            this.posevolucion.Location = new System.Drawing.Point(47, 119);
            this.posevolucion.Name = "posevolucion";
            this.posevolucion.Size = new System.Drawing.Size(224, 199);
            this.posevolucion.TabIndex = 0;
            this.posevolucion.TabStop = false;
            // 
            // nombre_pokemon
            // 
            this.nombre_pokemon.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_pokemon.Location = new System.Drawing.Point(47, 53);
            this.nombre_pokemon.Name = "nombre_pokemon";
            this.nombre_pokemon.Size = new System.Drawing.Size(224, 32);
            this.nombre_pokemon.TabIndex = 1;
            this.nombre_pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mensaje
            // 
            this.mensaje.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.Location = new System.Drawing.Point(12, 9);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(330, 403);
            this.mensaje.TabIndex = 2;
            this.mensaje.Text = "NO HAY EVOLUCION PERROOOO";
            this.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 421);
            this.Controls.Add(this.nombre_pokemon);
            this.Controls.Add(this.posevolucion);
            this.Controls.Add(this.mensaje);
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            ((System.ComponentModel.ISupportInitialize)(this.posevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox posevolucion;
        private System.Windows.Forms.Label nombre_pokemon;
        private System.Windows.Forms.Label mensaje;
    }
}