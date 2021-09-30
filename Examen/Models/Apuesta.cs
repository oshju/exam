using System;
using Realms;

namespace Examen.Models
{
    public class Apuesta : RealmObject
    {

       public int idusuario { get; set; }
       public String usuario { get; set; }
       public int resultado { get; set; }


    }
}
