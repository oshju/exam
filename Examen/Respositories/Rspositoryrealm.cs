using System;
using System.Collections.Generic;
using System.Linq;
using Examen.Models;
using Realms;
using System.Text;

namespace Examen.Respositories
{
    public class Rspositoryrealm
    {
        public class RepositoryRealm
        {
            private Realm conexionrealm;
            Transaction transaction;

            public RepositoryRealm()
            {
                //CREAMOS EL OBJETO QUE NOS PERMITIRA CONECTARNOS 
                //CON REALM EN CADA DISPOSITIVO 
                this.conexionrealm = Realm.GetInstance();
            }

            //METODO PARA DEVOLVER TODOS LOS OBJETOS PERSONAJES 
            public List<Apuesta> GetApuestas()
            {
                List<Apuesta> lista = this.conexionrealm.All<Apuesta>().ToList();
                return lista;
            }




            //METODO PARA INSERTAR EN REALM.   
            public void Insertarapuesta(Apuesta apuesta)
            {
                transaction = conexionrealm.BeginWrite();
                var entry = conexionrealm.Add(apuesta);
                transaction.Commit();
                //this.conexionrealm.Write(() => 
                //{ 
                //    //CREAMOS UN NUEVO PERSONAJE PARA INSERTAR 
                //    //EN EL METODO WRITE 
                //    Personaje newpersonaje = new Personaje(); 
                //    newpersonaje.IdPersonaje = this.GetMaximoIdPersonaje(); 
                //    newpersonaje.Nombre = personaje.Nombre; 
                //    newpersonaje.Serie = personaje.Serie; 
                //}); 
            }

            
        }
    }
}
