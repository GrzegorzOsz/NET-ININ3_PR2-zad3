using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_ININ3_PR2_z1
{
    public class Model
    {
        public ObservableCollection<Film> ListaFilmow { get; set; } = new ObservableCollection<Film>(new Film[]{
            new Film(){
                Tytul="Incepcja",
                Rezyser="Christopher Nolan",
                Producent="Lee Smith",
                Nosnik="DVD",
                DataWydania=DateTime.Parse("30.07.2010"),
            },
            new Film(){Tytul="Lśnienie", Rezyser="Stanley Kubrick", Producent="Warner Bros", Nosnik = "DVD", DataWydania=DateTime.Parse("23.05.1980")},
            new Film(){Tytul="Mroczny Rycerz", Rezyser="Christopher Nolan", Producent="DC Films", Nosnik = "DVD", DataWydania=DateTime.Parse("02.08.2008")},
            new Film(){Tytul="Życie jest piękne", Rezyser="Roberto Benigni", Producent="Miramax", Nosnik = "DVD", DataWydania=DateTime.Parse("12.03.1999")},
        });

        internal Film NowyFilm()
        {
            Film nowa = new Film();
            ListaFilmow.Add(nowa);
            return nowa;
        }
    }
}
