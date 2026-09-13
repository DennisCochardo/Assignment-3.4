using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3._4
{
    public enum Strength
    {
        Strong=1,
        Medium,
        Weak,
    }
    public enum Size
    {
        XtraLarge =1 ,
        Large,
        Medium,
        Small,
        XtraSmall,

    }
    public abstract class Beverages
    {
        public string Name { get; set; }
        public int BevNum { get; set; }
        public int Quantity { get; set; }
        public int PhoneNum { get; set; }
    }
    public class Coffee:Beverages
    {
        public string Type { get; set; }
        public Strength Strength { get; set; }
        public string? Milk { get; set; }
        public string? Sugar { get; set; }
        public Size Cup { get; set; }
    }
}
