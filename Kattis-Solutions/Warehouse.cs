using System;
using System.Collections.Generic;
using System.Linq;

namespace Warehouse
{
    class Program
    {
        struct Shipment
        {
            public Shipment(string n, int q)
            {
                this.name = n;
                this.quantity = q;
            }
            public string name;
            public int quantity;
        }
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            string[] ts;
            int tempq;
            for (int i = 0; i < tc; i++)
            {
                int n = int.Parse(Console.ReadLine());
                List<Shipment> shipments = new List<Shipment>();
                Dictionary<string, int> shipmentInput = new Dictionary<string, int>();
                for(int x = 0; x < n; x++)
                {
                    ts = Console.ReadLine().Split(" ");
                    if (shipmentInput.ContainsKey(ts[0]))
                    {
                        tempq = shipmentInput[ts[0]];
                        tempq += int.Parse(ts[1]);
                        shipmentInput.Remove(ts[0]);
                        shipmentInput.Add(ts[0], tempq);
                    }
                    else
                    {
                        shipmentInput.Add(ts[0], int.Parse(ts[1]));
                    }
                }
                foreach(var key in shipmentInput.Keys)
                {
                    shipments.Add(new Shipment(key, shipmentInput[key]));
                }
                List<Shipment> sorted = (from shi in shipments orderby shi.quantity descending, shi.name ascending select shi).ToList();
                Console.WriteLine(sorted.Count);
                for(int f = 0; f < sorted.Count; f++)
                {
                    Console.WriteLine("{0} {1}", sorted[f].name, sorted[f].quantity);
                }
            }
        }
    }
}
