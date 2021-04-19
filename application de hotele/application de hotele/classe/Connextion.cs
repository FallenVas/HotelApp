using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_de_hotele.classe
{ 
    class Connextion
{
        public bool connextionvalide(HotelAppEntities db, string Nom_user, string mot_de_passe)
        {
            user U = new user();
            U.username = Nom_user;
            U.pass = mot_de_passe;
            if (db.users.SingleOrDefault(s => s.username == Nom_user && s.pass == mot_de_passe) != null)
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

