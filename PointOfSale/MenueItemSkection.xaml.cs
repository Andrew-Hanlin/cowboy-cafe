using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.Extention;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenueItemSkection.xaml
    /// </summary>
    public partial class MenueItemSkection : UserControl
    {
        public MenueItemSkection()
        {
            InitializeComponent();
        }



        private void thing (object sender, RoutedEventArgs e)
        {
            var OrderControl = this.FindAnsestor<OrderControl>();
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "cowpokechilli":
                            var item  = new cowpoke chilli;
                            var screen = new cowpokeChilliCustimazation();
                            screen.DataContex = item;


                            order.add(item);

                            OrderControl.swapscreen(screen);


                    }
                }
            }

        }

    }
}
