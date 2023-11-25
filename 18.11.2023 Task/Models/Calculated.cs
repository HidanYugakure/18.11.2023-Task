using _18._11._2023_Task.Interface;

namespace _18._11._2023_Task.Models
{
    public class Calculated : IToplama, ICixma, IVurma, IBolme
    {
        public double Bolme(int Numbers1, int Numbers2)
        {
            if (Numbers2 == 0) {
            
            return 0;
            }
            return Numbers1 / Numbers2;
        }

        public int Cixma(int Numbers1, int Numbers2)
        {
            return Numbers1 - Numbers2;
        }


        // public int Numbers1;
        //public int Numbers2;
        public int Toplama(int Numbers1, int Numbers2)
        {
            return Numbers1 + Numbers2;
        }

        public int Vurma(int Numbers1, int Numbers2)
        {
            return Numbers1 * Numbers2;
        }

        
    }
}
