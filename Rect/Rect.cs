using System;

namespace SleetEngine{
    ///<sumary>
    ///Rect is a class that represents a rectangle in 2D space.
    ///</sumary>
    public class Rect{
        public Vec2 origin;
        public float width;
        public float height;

        public Rect(){
            origin = new Vec2();
            width = 0.0f;
            height = 0.0f;
        }

        public Rect(Vec2 origin, float width, float height){
            this.origin = origin;
            this.width = width;
            this.height = height;
        }

        public Rect(float x, float y, float width, float height){
            this.origin = new Vec2(x, y);
            this.width = width;
            this.height = height;
        }
    }
}