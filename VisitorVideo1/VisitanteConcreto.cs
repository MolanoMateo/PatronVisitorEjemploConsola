using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronVisitor
{
    public class VisitanteConcreto : IVisitor
    {
        public void Visitar(string serie)
        {
            Console.WriteLine(String.Format(" s/n {0}",serie ));
        }

    }


    public class VisitanteConcreto2 : IVisitor
    {
        public void Visitar(string serie)
        {
            Console.WriteLine(String.Format("el número de serie es: {0}", serie));
        }
    }
}
