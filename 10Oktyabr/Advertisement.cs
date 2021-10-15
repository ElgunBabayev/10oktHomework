using System;

namespace _10Oktyabr
{
    public class Advertisement : IComparable
    {
        public string AdvName { get; set; }
        public int Cost { get; set; }
        public string SellerName { get; set; }

        public Advertisement()
        { }


        public Advertisement(string advName, int cost, string sellerName)
        {
            AdvName = advName;
            Cost = cost;
            SellerName = sellerName;

        }

        enum Category : byte
        {
            Engine, Tool, Machine
        }

        public static bool operator >(Advertisement adv1, Advertisement adv2)
        {
            return adv1.Cost > adv2.Cost;
        }

        public static bool operator <(Advertisement adv1, Advertisement adv2)
        {
            return adv1.Cost < adv2.Cost;
        }

        public override string ToString()
        {
            return $"{AdvName} {Cost} {SellerName}";
        }
        public int CompareTo(object obj)
        {
            return Cost.CompareTo(((Advertisement)obj).Cost);
        }
    }
}
