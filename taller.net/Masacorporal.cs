using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller.net
{
   public class Masacorporal
    {
        private Double numero1;
        private Double numero2;
        public void setNumero1(Double valor)
        {
            this.numero1 = valor;

        }
        public double setnumero1()
        {
            return this.numero1;
        }
        public void setNumero2(Double valor)
        {
            this.numero2 = valor;

        }
        public double setnumero2()
        {
            return this.numero2;
        }
        public double resultado()
        {
            return (this.setnumero1() / (this.setnumero2() * this.setnumero2()));
        }
    }
}
