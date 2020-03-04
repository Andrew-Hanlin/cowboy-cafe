using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale.Extention
{
    public static class ExtionMethoids
    {
        public static T FindAnsestor<T>(this DependencyObject element) where T:DependencyObject
        {
            var parent = VisualTreeHelper.GetParent( element);
            if(parent == null)
            {
                return null;
            }

            if (parent is T) return parent as T;

            return parent.FindAnsestor<T>();


        }




    }
}
