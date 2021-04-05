using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_de_hotele.classe
{ 
    class Connextion
{
        public bool connextionvalide(usersEntities db, string Nom_user, string mot_de_passe)
        {
            Admin U = new Admin();
            U.Username = Nom_user;
            U.Pass = mot_de_passe;
            if (db.Admins.SingleOrDefault(s => s.Username == Nom_user && s.Pass == mot_de_passe) != null)
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

