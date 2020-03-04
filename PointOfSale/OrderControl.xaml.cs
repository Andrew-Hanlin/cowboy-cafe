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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            //AngreeChicken.Height = 20;
        }

        /// <summary>
        /// when Angree chicken clicked add AngreeChicken to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AngreeChicken_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }


        /// <summary>
        /// when CowpokeChili clicked add CowpokeChili to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowpokeChilli_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// when TexasTripleBurger clicked add TexasTripleBurger to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void TexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }


        /// <summary>
        /// when PecosPulledPork clicked add PecosPulledPork to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }


        /// <summary>
        /// when RustlersRibs clicked add RustlersRibs to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }


        /// <summary>
        /// when DakotaDoubleBurger clicked add DakotaDoubleBurger to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }


        /// <summary>
        /// when TrailBurger clicked add TrailBurger to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }


        /// <summary>
        /// when ChiliCheeseFries clicked add ChiliCheeseFries to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }


        /// <summary>
        /// when BakedBeans clicked add BakedBeans to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }


        /// <summary>
        /// when CowboyCoffee clicked add CowboyCoffee to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }


        /// <summary>
        /// when Water clicked add Water to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new Water());
        }


        /// <summary>
        /// when JerkedSoda clicked add JerkedSoda to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }


        /// <summary>
        /// when TexasTea clicked add TexasTea to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }


        /// <summary>
        /// when PanDeCampo clicked add PanDeCampo to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());

        }


        /// <summary>
        /// whenCornDodgers clicked add CornDodgers to ticket
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void CornDodgers_Click(object sender, RoutedEventArgs e)
        //{
        //    OrderList.Items.Add(new CornDodgers());

        //}


        private void CornDodgers_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenueItemSkection();

        }






        public void swapScreen (FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
