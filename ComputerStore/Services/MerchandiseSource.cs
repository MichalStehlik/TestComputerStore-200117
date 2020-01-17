using ComputerStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStore.Services
{
    public class MerchandiseSource
    {
        public MerchandiseSource()
        {
            Offer = new List<Merchandise>
            {
                new Merchandise {Id=1, Name="AMD Ryzen 5 3600", UnitPrice=5390},
                new Merchandise {Id=2, Name="AMD Ryzen 7 2700", UnitPrice=3890},
                new Merchandise {Id=3, Name="AMD Ryzen 5 2600", UnitPrice=3190},
                new Merchandise {Id=4, Name="Intel Core i5-9400F", UnitPrice=3999},
                new Merchandise {Id=5, Name="Intel Core i7-9700K", UnitPrice=9999},
                new Merchandise {Id=6, Name="Intel Core i5-9600KF", UnitPrice=5303},
                new Merchandise {Id=7, Name="MSI B450 TOMAHAWK MAX - AMD B450", UnitPrice=2762},
                new Merchandise {Id=8, Name="MSI Z390-A PRO - Intel Z390", UnitPrice=3290},
                new Merchandise {Id=9, Name="GIGABYTE B450 AORUS ELITE - AMD B450", UnitPrice=2412},
                new Merchandise {Id=10, Name="MSI Radeon RX 570 ARMOR 4G OC, 4GB GDDR5", UnitPrice=3499},
                new Merchandise {Id=11, Name="MSI GeForce RTX 2070 SUPER GAMING X TRIO, 8GB GDDR6", UnitPrice=15480},
                new Merchandise {Id=12, Name="MSI Radeon RX 580 ARMOR 8G OC, 8GB GDDR5", UnitPrice=5086},
                new Merchandise {Id=13, Name="HyperX Fury Black 16GB (2x8GB) DDR4 3200, black", UnitPrice=1989},
                new Merchandise {Id=14, Name="HyperX Predator 16GB (2x8GB) DDR4 3200", UnitPrice=2299},
                new Merchandise {Id=15, Name="HyperX Fury Black 16GB (2x8GB) DDR4 2666, black", UnitPrice=1770},
                new Merchandise {Id=16, Name="Samsung SSD 860 EVO, 2,5\" - 250GB", UnitPrice=1299},
            };
        }

        public List<Merchandise> Offer { get; }
    }
}
