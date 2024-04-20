using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Televisor3D
{
    internal class Objeto
    {
        private Dictionary<string, Cara> caraLista;
        private Double alto, largo, ancho;
        private Vector3d vector; //posicion del objeto

        public Objeto(Double centroX, Double centroY, Double centroZ)
        {
            this.caraLista = new Dictionary<string, Cara>();
            this.vector = new Vector3d(centroX, centroY, centroZ);
            this.alto = 100;
            this.largo = 100;
            this.ancho = 100;
        }
        public Objeto(Dictionary<string, Cara> caralis, Vector3d v, Double largo, Double alto, Double ancho)
        {
            this.caraLista =  caralis;
            this.vector = v;
            this.alto = alto;
            this.largo = largo;
            this.ancho = ancho;
        }

        public Objeto(Objeto objeto)
        {
            this.vector = objeto.vector;
            this.caraLista = new Dictionary<string, Cara>(objeto.caraLista);
            this.largo=objeto.largo;
            this.ancho=objeto.ancho;
            this.alto=objeto.alto;
        }

        public Double CenterX
        {
            get { return this.vector.X; }
            set { this.vector.X = value; }
        }

        public void addCara(string nombre, Cara cara)
        {
            this.caraLista.Add(nombre, cara);
        }

        public void removeCara(string nombre)
        {
            this.caraLista.Remove(nombre);
        }

        public void Dibujar()
        {
                foreach (var caras in this.caraLista)
                {
                caras.Value.Dibujar(this.vector);
                }
            
        }

    }
}
