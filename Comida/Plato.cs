using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace Comida
{
    class Plato : INotifyPropertyChanged
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                this.NotifyPropertyChanged("Nombre");
            }
        }
        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                this.NotifyPropertyChanged("Imagen");
            }
        }
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                this.NotifyPropertyChanged("Tipo");
            }
        }
        private bool gluten;
        public bool Gluten
        {
            get { return gluten; }
            set
            {
                gluten = value;
                this.NotifyPropertyChanged("Gluten");
            }
        }
        public bool soja;
        public bool Soja
        {
            get { return soja; }
            set
            {
                soja = value;
                this.NotifyPropertyChanged("Soja");
            }
        }
        public bool leche;
        public bool Leche
        {
            get { return leche; }
            set
            {
                leche = value;
                this.NotifyPropertyChanged("Leche");
            }
        }
        public bool sulfitos;
        public bool Sulfitos
        {
            get { return sulfitos; }
            set
            {
                sulfitos = value;
                this.NotifyPropertyChanged("Sulfitos");
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato() { }
        public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>
            {
                new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true),
                new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false),
                new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true),
                new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true),
                new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true),
                new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true)
            };

            return lista;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
