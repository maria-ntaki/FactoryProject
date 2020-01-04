using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Organisation 
    {
        public List<Factory> Factories { get; set; }
        public List<Store> Stores { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public string Name { get; set; }
        public Balance MoneyBalance { get; set; }
        public List<RawMaterialOffer> Offers {get; set;}
        public List<Contract> ContractsConducted { get; set; }

        public Organisation(string name)
        {
            Name = name;
            Factories = new List<Factory>();
            Stores = new List<Store>();
            ContractsConducted = new List<Contract>();
            Suppliers = new List<Supplier>();
            MoneyBalance = new Balance(10000); //starting funds inside the parenthesis
        }
        
        public Contract ProduceContract(Factory factory)
        {
            //Generating a list of offers from all curent suppliers
            List<RawMaterialOffer> offers = RequestOffers();

            //chosing best offer
            RawMaterialOffer bestOffer = BestOffer(offers);
            //creating contract depending on an offer
            Contract newContract = new Contract(bestOffer, this, bestOffer.SupplierRelated, factory, DateTime.Now);
            //adding contract to a factory
            return newContract;
        }

        public static RawMaterialOffer BestOffer(List<RawMaterialOffer> offers)
        {
            List<double> quality = new List<double>() { };
            List<double> price = new List<double>() { };
            List<double> quantity = new List<double>() { };
            List<double> gradesOfOffers = new List<double>() { };
            double maxQuality, maxPrice, maxQuantity;

            //Populating lists of quality, price etc
            foreach (var offer in offers)
            {
                quality.Add(offer.Quality);
                price.Add(Math.Pow(offer.PricePerKilo, -1));
                quantity.Add(Math.Pow(offer.RawMaterialAmount, -1));
            }
            //finding max values
            maxPrice = price.Max();
            maxQuality = quality.Max();
            maxQuantity = quantity.Max();
            //Making all values relational to max
            //Creating grades for each offer 
            for (int i = 0; i < quality.Count; i++)
            {
                quality[i] = quality[i] / maxQuality * 100;
                quantity[i] = quantity[i] / maxQuantity * 100;
                price[i] = price[i] / maxPrice * 100;

                gradesOfOffers.Add(price[i] * 1.7 + quality[i] * 1 + quantity[i] * 0.3);
            }
            //chosing the best offer based on score
            int indexBestOffer = gradesOfOffers.IndexOf(gradesOfOffers.Max());
            return offers[indexBestOffer];
        }

        private List<RawMaterialOffer> RequestOffers()
        {
            List<RawMaterialOffer> offers = new List<RawMaterialOffer>();

            foreach (var supplier in Suppliers)
            {
                RawMaterialOffer newOffer = supplier.CreateOffer();
                offers.Add(newOffer);
                Offers.Add(newOffer);
            }

            return offers;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Name: {Name}")
                .AppendLine($"Balanace: {MoneyBalance.Value}")
                .AppendLine($"Factories: {Factories.Count}")
                .AppendLine($"Stores: {Stores.Count}")
                .AppendLine($"RawMaterial offers: {Offers.Count}")
                .AppendLine($"Contracts: {ContractsConducted.Count}")
                .AppendLine($"Contracts: {ContractsConducted.Count}");

            return sb.ToString();
        }

    }
}
