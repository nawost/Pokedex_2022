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
    public partial class Ventana3 : Form
    {
        Conexión miConexion = new Conexión();

        public Ventana3(int idActual, DataTable misPokemons)
        {
            InitializeComponent();

            String preevolucion = misPokemons.Rows[0]["preEvolucion"].ToString();
            if (preevolucion == "")
            {
                mensaje.Visible = true;
                pre_evolucion.Visible = false;
                nombre_pokemon.Visible = false;
            }
            else
            {
                int evolucion = Int32.Parse(preevolucion);
                misPokemons = miConexion.getPokemonPorId(evolucion);
                pre_evolucion.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                nombre_pokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                mensaje.Visible = false;
                pre_evolucion.Visible = true;
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
