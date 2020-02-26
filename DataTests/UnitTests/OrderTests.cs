using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.UnitTests
{
    public class OrderTests
    {
        public class MocOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<String> SpecialIstructions { get; set; }
        }
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MocOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);

        }
        [Fact]
        public void ShouldBeAbleToCheackRemovItem()
        {
            var order = new Order();
            var item = new MocOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }
        [Fact]
        public void ShouldBeAbleToCheackGettingTheListOfItem() {
            var order = new Order();
            var item1 = new MocOrderItem();
            var item2 = new MocOrderItem();
            var item3 = new MocOrderItem();
            var item0 = new MocOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);

            Assert.Collection(order.Items,
                item => { Assert.Equal(item0, item); },
                item => { Assert.Equal(item1, item); },
                item => { Assert.Equal(item2, item); },

        item => { Assert.Equal(item3, item); }) ;

        }


        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0, 0 })]
        [InlineData(new double[] { 10.125, 100 })]
        [InlineData(new double[] {798})]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4,10,8 })]
        [InlineData(new double[] { 3.1416965476856856 })]
        [InlineData(new double[] { Double.NaN })]

        public void ShouldBeAbleToCheackTheSubtotalOfItemsIsPrice(double[] Prices)
       {
            var order = new Order();
            double total = 0;
            foreach(var price in Prices)
            {
                total += price;
                order.Add(new MocOrderItem() { Price = price });

            }
            Assert.Equal(total, order.Subtotal);
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]

        public void AddingItemShouldTriggerProperityChangedForPrice(string properityName )
        {
            var order = new Order();
            var item = new MocOrderItem();
            Assert.PropertyChanged(order, properityName, () =>
            {
                order.Add(item);
            });


        }
        [Theory]
        [InlineData("Price")]
        [InlineData("Items")]
        public void RemovingItemShouldTriggerProperityChangedForPrice(string properityName)
        {
            var order = new Order();
            var item = new MocOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, properityName, () =>
            {
                order.Remove(item);
            });
        }








        //[Fact]
        //public void AddingItemShouldTriggerProperityChangedForItems()
        //{

        //}
        //[Fact]
        //public void RemovingItemShouldTriggerProperityChangedForItems()
        //{

        //}
        //? Should Trigger Properity Changed For Price

        //? Should Trigger Properity Changed For Items

    }
}
