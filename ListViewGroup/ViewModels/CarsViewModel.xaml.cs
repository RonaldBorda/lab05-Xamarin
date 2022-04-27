using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ListViewGroup.Models;
using Xamarin.Forms;

namespace ListViewGroup.ViewModels
{
    public partial class CarsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Car> items;
        public ObservableCollection<Car> Items
        {
            get { return items; }
            set
            {

                items = value;
            }
        }
        public CarsViewModel()
        {
            Items = new ObservableCollection<Car>() {
                new Car()
                {
                    Modelo = "BMW i8",
                    Placa= "TX-291"
                },
                  new Car()
                {
                    Modelo = "Camaro Chevrolet",
                    Placa= "CQ-310"
                },
                new Car()
                {
                    Modelo = "Convertte",
                    Placa= "XTQ-211"
                },
                new Car()
                {
                    Modelo = "Ferrari enzo",
                    Placa= "F-1"
                },
                new Car()
                {
                    Modelo = "Nissan GTR",
                    Placa= "BR-189"
                },
                new Car()
                {
                    Modelo = "Toyota",
                    Placa= "EET-209"
                },
                new Car()
                {
                    Modelo = "Astor Martin",
                    Placa= "JM-22"
                },
                new Car()
                {
                    Modelo = "Porsche",
                    Placa= "GS-78"
                },
            };
        }
    }
}
