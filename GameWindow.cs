using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace SleetEngine
{
    public class enginewindow
    {
        GameWindow window;
        float x = 0;
        float y = 0;
        KeyboardState input;
        public enginewindow( GameWindow window )
        {
            this.window = window;
            Start();
        }
        void Start()
        {
            window.Load += loaded;
            window.Resize += resize;
            window.UpdateFrame += update;
            window.RenderFrame += renderF;
            window.Run(60.0);
        }
        void loaded( object o, EventArgs e)
        {
            GL.ClearColor(1.0f, 0.0f, 0.0f, 1.0f);
        }

        void update( object o, EventArgs e)
        {
            
            input = Keyboard.GetState();
            float spd = 0.5f;
            if ( input.IsKeyDown( Key.A) )
            {
                x -= spd;
            }
            if ( input.IsKeyDown( Key.D) )
            {
                x += spd;
            }
            if ( input.IsKeyDown( Key.S) )
            {
                y -= spd;
            }
            if ( input.IsKeyDown( Key.W) )
            {
                y += spd;
            }
        }
        
        void resize( object ob, EventArgs e)
        {
            GL.Viewport( 0, 0, window.Width, window.Height);
            GL.MatrixMode( MatrixMode.Projection );
            GL.LoadIdentity();
            GL.Ortho( 0.0, 50.0, 0.0, 50.0, -1.0, 1.0);
            GL.MatrixMode( MatrixMode.Modelview );
        }
        void renderF( object o, EventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear( ClearBufferMask.ColorBufferBit);
            GL.Begin(BeginMode.Triangles);
            GL.Color4( 0.0f, 0.0f, 0.0f, 0.5f);
            GL.Vertex2( x+20.0, y+20.0);
            GL.Vertex2( x+30.0, y+20.0);
            GL.Vertex2( x+20.0, y+30.0);
            GL.End();
            window.SwapBuffers();
        }
    }
}