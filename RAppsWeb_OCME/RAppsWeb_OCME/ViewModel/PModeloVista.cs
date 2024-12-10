using RAppsWeb_OCME.Models;
using System.ComponentModel;
using Xamarin.Forms;


namespace RAppsWeb_OCME.ViewModel
{
    public partial class PModeloVista : INotifyPropertyChanged
    {
        private double _montoCuenta;
        private double _porcentajePropina;
        private int _numeroPersonas;

        public Pmodelo Modelo { get; set; }

        public double MontoCuenta
        {
            get => _montoCuenta;
            set
            {
                _montoCuenta = value;
                OnPropertyChanged();
                ActualizarPropina();
            }
        }

        public double PorcentajePropina
        {
            get => _porcentajePropina;
            set
            {
                _porcentajePropina = value;
                OnPropertyChanged();
                ActualizarPropina();
            }
        }

        public int NumeroPersonas
        {
            get => _numeroPersonas;
            set
            {
                _numeroPersonas = value;
                OnPropertyChanged();
                ActualizarPropina();
            }
        }

        public double TotalPropina => Modelo.TotalPropina;
        public double TotalPagar => Modelo.TotalPagar;
        public double MontoPorPersona => Modelo.MontoPorPersona;
        public string Carita => Modelo.Carita;

        public event PropertyChangedEventHandler PropertyChanged;

        public PModeloVista()
        {
            Modelo = new Pmodelo();
        }

        private void ActualizarPropina()
        {
            Modelo.MontoCuenta = MontoCuenta;
            Modelo.PorcentajePropina = PorcentajePropina;
            Modelo.NumeroPersonas = NumeroPersonas;

            OnPropertyChanged(nameof(TotalPropina));
            OnPropertyChanged(nameof(TotalPagar));
            OnPropertyChanged(nameof(MontoPorPersona));
            OnPropertyChanged(nameof(Carita));
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
