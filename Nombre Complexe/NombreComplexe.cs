using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre_Complexe
{
    class NombreComplexe
    {
        public double Reel { get; set; }
        public double Imaginaire { get; set; }

        public NombreComplexe(double v1, double v2)
        {
            this.Reel = v1;
            this.Imaginaire = v2;
        }
        public NombreComplexe()
        {
        }
        public override string ToString()
        {
            return $"{Reel} + {Imaginaire}i";
        }
        public override bool Equals(Object obj)
        {
            var obj2 = (NombreComplexe) obj;
            return (this.Reel == obj2.Reel) && (this.Imaginaire == obj2.Imaginaire);
        }
        public static NombreComplexe operator +(NombreComplexe a, NombreComplexe b)
        {
            return new NombreComplexe(a.Reel + b.Reel,a.Imaginaire+b.Imaginaire);
        }
        public static NombreComplexe operator -(NombreComplexe a, NombreComplexe b)
        {
            return new NombreComplexe(a.Reel - b.Reel, a.Imaginaire - b.Imaginaire);
        }
        public static NombreComplexe operator *(NombreComplexe a, NombreComplexe b)
        {
            if (a == !b)
                return new NombreComplexe(Math.Pow(a.Reel, 2) + Math.Pow(a.Imaginaire, 2), 0.0);
            if (b == !a)
                return new NombreComplexe(Math.Pow(b.Reel, 2) + Math.Pow(b.Imaginaire, 2), 0.0);
            if ((a.Reel == 0 && a.Imaginaire == 1) || (b.Reel == 0 && b.Imaginaire == 1))
                return new NombreComplexe((b.Reel==0)?(-a.Imaginaire): (-b.Imaginaire), (b.Reel == 0) ? (a.Reel) : (b.Reel));

            return new NombreComplexe((a.Reel * b.Reel)-(a.Imaginaire * b.Imaginaire),(a.Reel * b.Imaginaire + a.Imaginaire * b.Reel));
        }
        public static NombreComplexe operator *(double a, NombreComplexe b)
        {
            return new NombreComplexe(a*b.Reel,b.Imaginaire);
        }
        public static NombreComplexe operator *(NombreComplexe b, double a)
        {
            return new NombreComplexe(a * b.Reel, b.Imaginaire);
        }
        public static NombreComplexe operator !(NombreComplexe a)
        {
            return new NombreComplexe(a.Reel , - a.Imaginaire);
        }
        public static NombreComplexe operator /(double a, NombreComplexe b)
        {
            return new NombreComplexe((b.Reel / (Math.Pow(b.Reel, 2) + Math.Pow(b.Imaginaire, 2))), (-b.Imaginaire / (Math.Pow(b.Reel, 2) + Math.Pow(b.Imaginaire, 2))));
        }
        public static NombreComplexe operator /(NombreComplexe a, NombreComplexe b)
        {
            return new NombreComplexe((a.Reel*b.Reel + a.Imaginaire*b.Imaginaire) / (Math.Pow(b.Reel,2)+ Math.Pow(b.Imaginaire, 2)), (a.Imaginaire*b.Reel - a.Reel*b.Imaginaire) / (Math.Pow(b.Reel, 2) + Math.Pow(b.Imaginaire, 2)));
        }
        public static bool operator ==(NombreComplexe a, NombreComplexe b)
        {
            return (a.Reel==b.Reel) && (a.Imaginaire==b.Imaginaire);
        }
        public static bool operator !=(NombreComplexe a, NombreComplexe b)
        {
            return !(a.Reel == b.Reel) || !(a.Imaginaire == b.Imaginaire);
        }
        public static bool operator <(NombreComplexe a, NombreComplexe b)
        {
            return (a.Reel < b.Reel) && (a.Imaginaire <= b.Imaginaire);
        }
        public static bool operator >(NombreComplexe a, NombreComplexe b)
        {
            return (a.Reel > b.Reel) && (a.Imaginaire >= b.Imaginaire);
        }
        public static bool operator <=(NombreComplexe a, NombreComplexe b)
        {
            return (a.Reel <= b.Reel) && (a.Imaginaire <= b.Imaginaire);
        }
        public static bool operator >=(NombreComplexe a, NombreComplexe b)
        {
            return (a.Reel >= b.Reel) && (a.Imaginaire >= b.Imaginaire);
        }
    }
}
