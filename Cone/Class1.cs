using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace Cone
{
    public class Class1
    {
       
        
        public static double Sfull(double h,double r)
        {
            double Pi = 3.14;
            return Pi*r*r+(Pi*r*(Math.Sqrt(r*r+h*h)));
        }
        public static double Spov(double r)
        {
            double Pi = 3.14;
            return Pi * r * r ;
        }
    }
   

}
