
namespace Pokedex_2022
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iz_click = new System.Windows.Forms.Button();
            this.de_click = new System.Windows.Forms.Button();
            this.nombre_pokemon = new System.Windows.Forms.Label();
            this.imgpokemon = new System.Windows.Forms.PictureBox();
            this.especie_pokemon = new System.Windows.Forms.Label();
            this.habitat_pokemon = new System.Windows.Forms.Label();
            this.info_pokemon = new System.Windows.Forms.Label();
            this.cambia_info = new System.Windows.Forms.Button();
            this.mov1 = new System.Windows.Forms.Label();
            this.mov2 = new System.Windows.Forms.Label();
            this.mov3 = new System.Windows.Forms.Label();
            this.mov4 = new System.Windows.Forms.Label();
            this.cambia_info1 = new System.Windows.Forms.Button();
            this.tipo1 = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.alturaInfo = new System.Windows.Forms.Label();
            this.pesoInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_evolucion = new System.Windows.Forms.Button();
            this.boton_pos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1052, 598);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // iz_click
            // 
            this.iz_click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(106)))));
            this.iz_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iz_click.Location = new System.Drawing.Point(244, 426);
            this.iz_click.Name = "iz_click";
            this.iz_click.Size = new System.Drawing.Size(21, 23);
            this.iz_click.TabIndex = 1;
            this.iz_click.Text = "<";
            this.iz_click.UseVisualStyleBackColor = false;
            this.iz_click.Click += new System.EventHandler(this.iz_click_Click);
            // 
            // de_click
            // 
            this.de_click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(106)))));
            this.de_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.de_click.Location = new System.Drawing.Point(303, 426);
            this.de_click.Name = "de_click";
            this.de_click.Size = new System.Drawing.Size(23, 23);
            this.de_click.TabIndex = 2;
            this.de_click.Text = ">";
            this.de_click.UseVisualStyleBackColor = false;
            this.de_click.Click += new System.EventHandler(this.de_click_Click);
            // 
            // nombre_pokemon
            // 
            this.nombre_pokemon.BackColor = System.Drawing.Color.Yellow;
            this.nombre_pokemon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nombre_pokemon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nombre_pokemon.Location = new System.Drawing.Point(91, 455);
            this.nombre_pokemon.Name = "nombre_pokemon";
            this.nombre_pokemon.Size = new System.Drawing.Size(116, 43);
            this.nombre_pokemon.TabIndex = 3;
            this.nombre_pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgpokemon
            // 
            this.imgpokemon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgpokemon.Location = new System.Drawing.Point(82, 154);
            this.imgpokemon.Name = "imgpokemon";
            this.imgpokemon.Size = new System.Drawing.Size(207, 165);
            this.imgpokemon.TabIndex = 4;
            this.imgpokemon.TabStop = false;
            // 
            // especie_pokemon
            // 
            this.especie_pokemon.BackColor = System.Drawing.Color.Orange;
            this.especie_pokemon.Location = new System.Drawing.Point(460, 455);
            this.especie_pokemon.Name = "especie_pokemon";
            this.especie_pokemon.Size = new System.Drawing.Size(88, 43);
            this.especie_pokemon.TabIndex = 5;
            this.especie_pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habitat_pokemon
            // 
            this.habitat_pokemon.BackColor = System.Drawing.Color.Orange;
            this.habitat_pokemon.Location = new System.Drawing.Point(584, 455);
            this.habitat_pokemon.Name = "habitat_pokemon";
            this.habitat_pokemon.Size = new System.Drawing.Size(89, 43);
            this.habitat_pokemon.TabIndex = 6;
            this.habitat_pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_pokemon
            // 
            this.info_pokemon.BackColor = System.Drawing.Color.Lime;
            this.info_pokemon.Location = new System.Drawing.Point(451, 164);
            this.info_pokemon.Name = "info_pokemon";
            this.info_pokemon.Size = new System.Drawing.Size(232, 109);
            this.info_pokemon.TabIndex = 8;
            this.info_pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cambia_info
            // 
            this.cambia_info.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cambia_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambia_info.Location = new System.Drawing.Point(514, 396);
            this.cambia_info.Name = "cambia_info";
            this.cambia_info.Size = new System.Drawing.Size(21, 26);
            this.cambia_info.TabIndex = 9;
            this.cambia_info.Text = ">";
            this.cambia_info.UseVisualStyleBackColor = false;
            this.cambia_info.Click += new System.EventHandler(this.cambia_info_Click);
            // 
            // mov1
            // 
            this.mov1.BackColor = System.Drawing.Color.Lime;
            this.mov1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov1.Location = new System.Drawing.Point(452, 164);
            this.mov1.Name = "mov1";
            this.mov1.Size = new System.Drawing.Size(230, 23);
            this.mov1.TabIndex = 10;
            this.mov1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mov2
            // 
            this.mov2.BackColor = System.Drawing.Color.Lime;
            this.mov2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov2.Location = new System.Drawing.Point(453, 187);
            this.mov2.Name = "mov2";
            this.mov2.Size = new System.Drawing.Size(230, 28);
            this.mov2.TabIndex = 11;
            this.mov2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mov3
            // 
            this.mov3.BackColor = System.Drawing.Color.Lime;
            this.mov3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov3.Location = new System.Drawing.Point(453, 215);
            this.mov3.Name = "mov3";
            this.mov3.Size = new System.Drawing.Size(230, 29);
            this.mov3.TabIndex = 12;
            this.mov3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mov4
            // 
            this.mov4.BackColor = System.Drawing.Color.Lime;
            this.mov4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov4.Location = new System.Drawing.Point(453, 244);
            this.mov4.Name = "mov4";
            this.mov4.Size = new System.Drawing.Size(230, 29);
            this.mov4.TabIndex = 13;
            this.mov4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cambia_info1
            // 
            this.cambia_info1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cambia_info1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambia_info1.Location = new System.Drawing.Point(478, 396);
            this.cambia_info1.Name = "cambia_info1";
            this.cambia_info1.Size = new System.Drawing.Size(21, 26);
            this.cambia_info1.TabIndex = 14;
            this.cambia_info1.Text = "<";
            this.cambia_info1.UseVisualStyleBackColor = false;
            this.cambia_info1.Click += new System.EventHandler(this.cambia_info1_Click);
            // 
            // tipo1
            // 
            this.tipo1.BackColor = System.Drawing.Color.Orange;
            this.tipo1.Location = new System.Drawing.Point(460, 455);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(88, 43);
            this.tipo1.TabIndex = 15;
            this.tipo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo2
            // 
            this.tipo2.BackColor = System.Drawing.Color.Orange;
            this.tipo2.Location = new System.Drawing.Point(585, 455);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(88, 43);
            this.tipo2.TabIndex = 16;
            this.tipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alturaInfo
            // 
            this.alturaInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.alturaInfo.Location = new System.Drawing.Point(568, 287);
            this.alturaInfo.Name = "alturaInfo";
            this.alturaInfo.Size = new System.Drawing.Size(96, 28);
            this.alturaInfo.TabIndex = 17;
            this.alturaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pesoInfo
            // 
            this.pesoInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.pesoInfo.Location = new System.Drawing.Point(561, 315);
            this.pesoInfo.Name = "pesoInfo";
            this.pesoInfo.Size = new System.Drawing.Size(103, 35);
            this.pesoInfo.TabIndex = 18;
            this.pesoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(469, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(469, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Peso:";
            // 
            // boton_evolucion
            // 
            this.boton_evolucion.BackColor = System.Drawing.Color.Lime;
            this.boton_evolucion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton_evolucion.FlatAppearance.BorderSize = 0;
            this.boton_evolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton_evolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.boton_evolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_evolucion.Location = new System.Drawing.Point(95, 391);
            this.boton_evolucion.Name = "boton_evolucion";
            this.boton_evolucion.Size = new System.Drawing.Size(60, 31);
            this.boton_evolucion.TabIndex = 21;
            this.boton_evolucion.Text = "preEv";
            this.boton_evolucion.UseVisualStyleBackColor = false;
            this.boton_evolucion.Click += new System.EventHandler(this.boton_evolucion_Click);
            // 
            // boton_pos
            // 
            this.boton_pos.BackColor = System.Drawing.Color.DarkOrange;
            this.boton_pos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton_pos.FlatAppearance.BorderSize = 0;
            this.boton_pos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton_pos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.boton_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_pos.Location = new System.Drawing.Point(161, 391);
            this.boton_pos.Name = "boton_pos";
            this.boton_pos.Size = new System.Drawing.Size(69, 31);
            this.boton_pos.TabIndex = 22;
            this.boton_pos.Text = "postEv";
            this.boton_pos.UseVisualStyleBackColor = false;
            this.boton_pos.Click += new System.EventHandler(this.boton_pos_Click);
            // 
            // VentanaPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1052, 598);
            this.Controls.Add(this.boton_pos);
            this.Controls.Add(this.boton_evolucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pesoInfo);
            this.Controls.Add(this.alturaInfo);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.cambia_info1);
            this.Controls.Add(this.mov4);
            this.Controls.Add(this.mov3);
            this.Controls.Add(this.mov2);
            this.Controls.Add(this.mov1);
            this.Controls.Add(this.cambia_info);
            this.Controls.Add(this.info_pokemon);
            this.Controls.Add(this.habitat_pokemon);
            this.Controls.Add(this.especie_pokemon);
            this.Controls.Add(this.imgpokemon);
            this.Controls.Add(this.nombre_pokemon);
            this.Controls.Add(this.de_click);
            this.Controls.Add(this.iz_click);
            this.Controls.Add(this.pictureBox2);
            this.Name = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button iz_click;
        private System.Windows.Forms.Button de_click;
        private System.Windows.Forms.Label nombre_pokemon;
        private System.Windows.Forms.PictureBox imgpokemon;
        private System.Windows.Forms.Label especie_pokemon;
        private System.Windows.Forms.Label habitat_pokemon;
        private System.Windows.Forms.Label info_pokemon;
        private System.Windows.Forms.Button cambia_info;
        private System.Windows.Forms.Label mov1;
        private System.Windows.Forms.Label mov2;
        private System.Windows.Forms.Label mov3;
        private System.Windows.Forms.Label mov4;
        private System.Windows.Forms.Button cambia_info1;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Label alturaInfo;
        private System.Windows.Forms.Label pesoInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_evolucion;
        private System.Windows.Forms.Button boton_pos;
    }
}

