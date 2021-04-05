using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_de_hotele.classe
{ 
    class Connextion
{
        public bool connextionvalide(UserEntities db, string Nom_user, string mot_de_passe)
        {
            connection U = new connection();
            U.username = Nom_user;
            U.pass = mot_de_passe;
            if (db.connections.SingleOrDefault(s => s.username == Nom_user && s.pass == mot_de_passe) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

