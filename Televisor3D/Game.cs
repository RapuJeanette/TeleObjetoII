using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Televisor3D
{
    public class Game: GameWindow
    {
        public Game(int width, int height, string tittle): base(width, height, GraphicsMode.Default, tittle) { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Rotate(1.0f, 0.0f, 0.1f, 0.0f);
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.ClearColor(Color4.AliceBlue);
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-3.0, 3.0, -3.0, 3.0, -3.0, 3.0);
            GL.MatrixMode(MatrixMode.Modelview);

            Escenario tele = new Escenario();
            tele.Dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e) {  
            GL.Viewport(0,0, Width, Height);
            base.OnResize(e); 
        }
    }
}
