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
    public partial class Ventana2 : Form
    {
        Conexión miConexion = new Conexión();

        public Ventana2(int idActual, DataTable misPokemons)
        {
            InitializeComponent();
            String postevolucion = misPokemons.Rows[0]["posEvolucion"].ToString();
            if (postevolucion == "")
            {
                mensaje.Visible = true;
                posevolucion.Visible = false;
                nombre_pokemon.Visible = false;
            }
            else
            {
                int evolucion = Int32.Parse(postevolucion);
                misPokemons = miConexion.getPokemonPorId(evolucion);
                posevolucion.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                nombre_pokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                mensaje.Visible = false;
                posevolucion.Visible = true;
                nombre_pokemon.Visible = true;
            }
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
    }
}
