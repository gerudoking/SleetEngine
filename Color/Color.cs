using System;

namespace SleetEngine{
    public class Color{
        public const int maxColorValue = 255;
        public const int maxAlphaValue = 100;

        private int _r;
        private int _g;
        private int _b;
        private int _a;

        public int Red{
            get { return _r; }
            set{
                _r = value;
                if( _r >= maxColorValue) _r = maxColorValue;
                if( _r <= 0) _r = 0;
            }
        }

        public int Green{
            get { return _g; }
            set{
                _g = value;
                if( _g >= maxColorValue) _g = maxColorValue;
                if( _g <= 0) _g = 0;
            }
        }

        public int Blue{
            get { return _b; }
            set{
                _b = value;
                if( _b >= maxColorValue) _b = maxColorValue;
                if( _b <= 0) _b = 0;
            }
        }

        public int Alpha{
            get { return _a; }
            set{
                _a = value;
                if( _a >= maxAlphaValue) _r = maxAlphaValue;
                if( _a <= 0) _r = 0;
            }
        }

        public Color(){
            Red = 0;
            Green = 0;
            Blue = 0;
            Alpha = 0;
        }

        public Color(int red, int green, int blue, int alpha = maxAlphaValue){
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
    }
}