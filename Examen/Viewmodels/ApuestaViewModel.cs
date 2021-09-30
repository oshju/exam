using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Examen.Models;
using Examen.Viewmodels.@base;
using static Examen.Respositories.Rspositoryrealm;

namespace Examen.Viewmodels
{
    public class ApuestaViewModel : ViewModelBase
    {
        private RepositoryRealm repo;

        public ApuestaViewModel()
        {
            this.repo = new RepositoryRealm();
            List<Apuesta> lista = this.repo.GetApuestas();
            this.Personajes = new ObservableCollection<Apuesta>(lista);
        }


        private ObservableCollection<Apuesta> _Personajes;
        public ObservableCollection<Apuesta> Personajes
        {
            get { return this._Personajes; }
            set
            {
                this._Personajes = value;
                OnPropertyChanged("Personajes");
            }
        }
    }
}

