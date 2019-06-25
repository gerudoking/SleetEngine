using System;

namespace SleetEngine{
    ///<sumary>
    ///Vec2 is a class that represents a point in 2D space.
    ///</sumary>
    public class Vec2{
        ///<sumary>
        ///X-coordinate of the Vec2. Has private set and public get.
        ///</sumary>
        public float x{get; private set;}
        ///<sumary>
        ///Y-coordinate of the Vec2. Has private set and public get.
        ///</sumary>
        public float y{get; private set;}

        ///<sumary>
        ///Class constructor. Initializes x and y as 0.
        ///</sumary>
        public Vec2(){
            x = 0.0f;
            y = 0.0f;
        }

        ///<sumary>
        ///Class constructor. Initializes x and y as the values passed in the parameters.
        ///</sumary>
        /// <param name="x"> The value to initialize x with</param>
        /// <param name="y"> The value to initialize y with</param>
        public Vec2(float x, float y){
            this.x = x;
            this.y = y;
        }

        public static Vec2 operator+ (Vec2 a, Vec2 b){
            return new Vec2(a.x + b.x, a.y + b.y);
        }

        public static Vec2 operator- (Vec2 a, Vec2 b){
            return new Vec2(a.x - b.x, a.y - b.y);
        }

        public static Vec2 operator*(Vec2 a, float b){
            return new Vec2(a.x * b, a.y * b);
        }

        public static Vec2 operator/(Vec2 a, float b){
            return new Vec2(a.x / b, a.y / b);
        }

        public float Dot(Vec2 other){
            return (x * other.x + y * other.y);
        }

        public float Abs(){
            return (float)Math.Sqrt(x * x + y * y);
        }

        public float Norm(){
            return this.Abs();
        }

        public Vec2 Normalized(){
            float norm = Abs();
            return new Vec2(x / norm, y = y / norm); //Não tenho certeza do funcionamento disso ainda.
        }

        public static float Distance(Vec2 a, Vec2 b){
            return (a - b).Abs();
        }

        public static bool operator==(Vec2 a, Vec2 b){
            return (a.x == b.x) && (a.y == b.y);
        }

        public static bool operator!=(Vec2 a, Vec2 b){
            return !(a == b);
        }

        public float Angle(){
            return (float)Math.Atan2(y, x);
        }

        public Vec2 Rotate(float ang){
            return new Vec2((float)(x * Math.Cos(ang) - y * Math.Sin(ang)), (float)(y * Math.Cos(ang) + x * Math.Sin(ang)));
        }
    }
}