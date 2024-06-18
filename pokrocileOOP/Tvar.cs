using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokrocileOOP
{
    public abstract class Tvar
    {
        public abstract double ZiskejObvod();
        public abstract double ZiskejObsah();
    }

    public class Kruh: Tvar
    {
        public double Polomer { get; set; }

        public override double ZiskejObvod()
        {
            return Math.PI * Polomer * 2;    
        }
        public override double ZiskejObsah()
        {
            
        }
    }

    public class Ctverec : Tvar 
    {
        public double DelkaStran { get; set; }

        public override double ZiskejObvod()
        {
            return DelkaStran * 4;
        }
        public override double ZiskejObsah()
        {
            throw new NotImplementedException();
        }
    }
}
