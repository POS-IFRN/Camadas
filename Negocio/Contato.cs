using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Contato
    {
        public void Insert(Modelo.Contato c)
        {
            // Validar o contato
            if (c.Nome != "")
            {
                //&& c.Id != && c.Fone != ""
                new Persistencia.Contato().Insert(c);
            }
        }

        public List<Modelo.Contato> Select()
        {
            return new Persistencia.Contato().Select();
        }
    }
}
