using System;
using Examen.Models;
using Xamarin.Forms;
using static Examen.Respositories.Rspositoryrealm;

namespace Examen.Viewmodels
{
    public class ApuestaModel
    {
        RepositoryRealm repo;

        public ApuestaModel()
        {
            this.repo = new RepositoryRealm();
            this.Personaje = new Apuesta();
        }

        //PROPIEDAD PARA REALIZAR LOS BINDINGS SOBRE LAS VISTAS 
        private Apuesta _Personaje;
        public Apuesta Personaje
        {
            get { return this._Personaje; }
            set
            {
                this._Personaje = value;
                OnPropertyChanged("Personaje");
            }
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        //PROPIEDAD PARA MOSTRAR LOS RESULTADOS DE LAS ACCIONES 
        private String _Mensaje;
        public String Mensaje
        {
            get { return this._Mensaje; }
            set
            {
                this._Mensaje = value;
                OnPropertyChanged("Mensaje");
            }
        }

        public Command InsertarDato
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.Insertarapuesta(this.Personaje);
                    this.Mensaje = "Dato insertado";
                });
            }
        }

      
    }
}