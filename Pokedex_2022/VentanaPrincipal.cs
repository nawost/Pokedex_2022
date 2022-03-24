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
        bool a = false;
        int i = 0;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void iz_click_Click(object sender, EventArgs e)
        {
            if (idActual > 1 && !a)
            {
                idActual--;
            }else if (i > 0 && a)
            {
                i--;
                idActual = int.Parse(misPokemons.Rows[i]["id"].ToString());
            }
            muestraDatos();
        }

        private void de_click_Click(object sender, EventArgs e)
        {
            if (idActual < 151 && !a)
            {
                idActual++;
            }else if (i < 0 && a)
            {
                i++;
                idActual = int.Parse(misPokemons.Rows[i]["id"].ToString());
            }
            muestraDatos();
        }

        private void muestraDatos()
        {
            if (!a)
            {
                i = 0;
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombre_pokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                especie_pokemon.Text = misPokemons.Rows[0]["especie"].ToString();
                habitat_pokemon.Text = misPokemons.Rows[0]["habitat"].ToString();
                info_pokemon.Text = misPokemons.Rows[0]["descripcion"].ToString();
                mov1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
                mov2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
                mov3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
                mov4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
                imgpokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[i]["imagen"]);
            }else if (a)
            {
                nombre_pokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                especie_pokemon.Text = misPokemons.Rows[0]["especie"].ToString();
                habitat_pokemon.Text = misPokemons.Rows[0]["habitat"].ToString();
                info_pokemon.Text = misPokemons.Rows[0]["descripcion"].ToString();
                mov1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
                mov2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
                mov3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
                mov4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
                imgpokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[i]["imagen"]);
            }
        }

        private void cambia_info_Click(object sender, EventArgs e)
        {
            {
                mov1.Visible = true;
                mov2.Visible = true;
                mov3.Visible = true;
                mov4.Visible = true;
                info_pokemon.Visible = false;
            }
        }
        private void cambia_info1_Click(object sender, EventArgs e)
        {
            mov1.Visible = false;
            mov2.Visible = false;
            mov3.Visible = false;
            mov4.Visible = false;
            info_pokemon.Visible = true;
        }
    }
}
