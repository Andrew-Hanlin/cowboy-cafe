using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrdernumber = 0;
        public Order(){
            lastOrdernumber = lastOrdernumber + 1;
        }
        public event PropertyChangedEventHandler PropertyChanged;


        private List<IOrderItem> items = new List<IOrderItem>();

        public uint OrderNumber { get; } = lastOrdernumber + 1;


        public IEnumerable<IOrderItem> Items => items;





        public double Subtotal {
            get {
                double total = 0;
                foreach(IOrderItem item in items){
                    total += item.Price;
                }
                return total;
            }

        }
       
            
        public void Add(IOrderItem item)
        {
            if (item != null) { items.Add(item); }
            if(item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged += OnItemChanged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }
        public void Remove(IOrderItem item) {
            if (item != null) { items.Remove(item); }
            if (item is INotifyPropertyChanged pcitem)
            {
                pcitem.PropertyChanged -= OnItemChanged;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));


        }
        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName=="Price")  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal")); 
]


        }
    }
}
