using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_2022
{
    public partial class VentanaPrincipal : Form
    {
        Conexión miConexion = new Conexión();
        DataTable misPokemons = new DataTable();
        int idActual = 1;//guarda el id del pokemon que se está viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
            muestraDatos();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void iz_click_Click(object sender, EventArgs e)
        {
            if (idActual == 1)
            {
                idActual = 151;
            }else
            {
                idActual--;
            }
            muestraDatos();
        }

        private void de_click_Click(object sender, EventArgs e)
        {
            if (idActual == 151)
            {
                idActual = 1;
            }else
            {
                idActual++;
            }
            muestraDatos();
        }

        private void muestraDatos()
        {
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombre_pokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            especie_pokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            habitat_pokemon.Text = misPokemons.Rows[0]["habitat"].ToString();
            info_pokemon.Text = misPokemons.Rows[0]["descripcion"].ToString();
            mov1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            mov2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            mov3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            mov4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            tipo1.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            pesoInfo.Text = misPokemons.Rows[0]["peso"].ToString();
            alturaInfo.Text = misPokemons.Rows[0]["altura"].ToString();
            imgpokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void cambia_info_Click(object sender, EventArgs e)
        {
            {
                mov1.Visible = true;
                mov2.Visible = true;
                mov3.Visible = true;
                mov4.Visible = true;
                tipo1.Visible = true;
                tipo2.Visible = true;
                especie_pokemon.Visible = false;
                habitat_pokemon.Visible = false;
                info_pokemon.Visible = false;
            }
        }
        private void cambia_info1_Click(object sender, EventArgs e)
        {
            mov1.Visible = false;
            mov2.Visible = false;
            mov3.Visible = false;
            mov4.Visible = false;
            tipo1.Visible = false;
            tipo2.Visible = false;
            especie_pokemon.Visible = true;
            habitat_pokemon.Visible = true;
            info_pokemon.Visible = true;
        }

        private void boton_pos_Click(object sender, EventArgs e)
        {
            Ventana2 v = new Ventana2(idActual, misPokemons);
            v.Show();
        }

        private void boton_evolucion_Click(object sender, EventArgs e)
        {
            Ventana3 v2 = new Ventana3(idActual, misPokemons);
            v2.Show();
        }
    }
}
