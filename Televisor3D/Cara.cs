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
    internal class Cara
    {
        protected List<Double[]> listaVertices;
        protected Color color;
        protected PrimitiveType primitiveType;

        public Cara() 
        {
            listaVertices = new List<Double[]>();
            color = Color.Transparent;
            primitiveType = new PrimitiveType();
        }

        public Cara(List<double[]> listaVertices, Color color, PrimitiveType primitiveType)
        {
            this.listaVertices = listaVertices;
            this.color = color;
            this.primitiveType = primitiveType;
        }

        public Cara(Color color, PrimitiveType primitiveType) 
        {
            this.color = color;
            this.primitiveType = primitiveType;
            listaVertices = new List<double[]>();
        }

        //virtual porque podemos personalizarlo o cambiar el comportamiento
        public virtual void Dibujar(Vector3d punto) 
        {
            GL.Begin(this.primitiveType);
            GL.Color3(this.color);
            //va iterando sobre cada vertice en nuestra lista de vertices
            foreach (Double[] vertice in this.listaVertices) 
            {
                GL.Vertex3(punto.X + vertice[0], punto.Y + vertice[1], punto.Z + vertice[2]);
            }
            GL.End();
        }

        //esta clase nos ayuda a agregar vertices a nuestra lista de vertices
        public void addVertice(Double[] vertice)
        {
            listaVertices.Add(new Double[] { vertice[0], vertice[1], vertice[2] });
        }
    }
}
