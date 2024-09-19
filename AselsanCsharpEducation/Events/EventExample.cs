using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Events
{
    public class StockExchangedEventArgs : EventArgs
    {
        public int Count { get; set; }
        public string Barcode { get; set; }
    }

    public class Stock
    {
        public event Action<StockExchangedEventArgs> StockChangedEvent;

        public int ProductId { get; set; }

        private int _stockCount;

        private string Barcode => Guid.NewGuid().ToString();

        public int StockCount
        {
            get => _stockCount;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("");
                }


                if (value != _stockCount)
                {
                    _stockCount = value;

                    if (StockChangedEvent is not null)
                    {
                        StockChangedEvent(new StockExchangedEventArgs() { Barcode = Barcode, Count = _stockCount });
                    }

                    //StockChanged();
                }
                else
                {
                    _stockCount = value;
                }
            }
        }


        //public void StockChanged()
        //{
        //    Console.WriteLine($"Stock has changed: {_stockCount}");
        //}
    }
}