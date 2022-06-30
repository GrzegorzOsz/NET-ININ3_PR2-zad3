using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_ININ3_PR2_z1
{
    public class Film : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        readonly static Dictionary<string, string[]> powiązaneWłaściwości = new Dictionary<string, string[]>()
        {
            ["Tytul"] = new string[] { "TytulFilmu" },
            ["Rezyser"] = new string[] { "Rezyser" },
            ["Producent"] = new string[] { "Producent" },
            ["Nosnik"] = new string[] { "Nosnik" },
            ["DataWydania"] = new string[] { "DataWydania" },
            ["TytulFilmu"] = new string[] { "Szczegóły" },
        };
        public void OnPropertyChanged(
           [CallerMemberName] string właściwość = null,
           HashSet<string> załatwioneWłaściwości = null
           )
        {
            if (załatwioneWłaściwości == null)
                załatwioneWłaściwości = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(właściwość));
            załatwioneWłaściwości.Add(właściwość);

            if (powiązaneWłaściwości.ContainsKey(właściwość))
                foreach (string powiązanaWłaściwość in powiązaneWłaściwości[właściwość])
                    if (!załatwioneWłaściwości.Contains(powiązanaWłaściwość))
                        OnPropertyChanged(
                            powiązanaWłaściwość,
                            załatwioneWłaściwości
                            );
        }

        public static uint następneID = 0;

        public uint ID { get; } = następneID++;
        string
            tytul,
            rezyser,
            producent,
            nosnik
            ;
        DateTime?
            dataWydania
            ;

        public string FilmRezyser
        {
            get { return $"{Tytul},{Rezyser}"; }
        }

        public string Tytul
        {
            get => tytul;
            set
            {
                tytul = value;
                OnPropertyChanged();
            }
        }
        public string Rezyser
        {
            get => rezyser;
            set
            {
                rezyser = value;
                OnPropertyChanged();
            }
        }
        public string Producent
        {
            get => producent;
            set
            {
                producent = value;
                OnPropertyChanged();
            }
        }
        public string Nosnik
        {
            get => nosnik;
            set
            {
                nosnik = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                OnPropertyChanged();
            }
        }


        public string Szczegóły => $"{FilmRezyser}, {Nosnik} ";
    }
}