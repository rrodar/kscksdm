using System;
using Library_Gems;
using static System.Net.Mime.MediaTypeNames;
using static Library_Gems.Necklace;

namespace ТХИ_3
{
    public interface ICalculator
    {
        double CalculatingWeight();
    }
    public class ProductCalculator : ICalculator
    {
        private static List<Brilliant> listOfJews = new List<Brilliant>();
        public static int indJews = -1;
        public void InitCalculator()
        {
            if (listOfJews.Count == 0)
            {
                Brilliant makita = new Brilliant();
                Jewelry factory = new Jewelry();
                makita = factory.ProvideJew();
                listOfJews.Add(makita);
                makita = factory.ProvideJew2();
                listOfJews.Add(makita);
            }
        }
        
        public string[] GetJews()
        {
            string[] mas = new string[listOfJews.Count];
            for (int i = 0; i < listOfJews.Count; i++)
            {
                mas[i] = String.Format("{0} - {1}", listOfJews[i].Name, listOfJews[i].Carats);
            }
            return mas;
        }
        public Brilliant GetJew()
        {
            Brilliant drill = listOfJews[indJews];
            return drill;
        }
        public void DeleteJew(int index)
        {
            listOfJews.RemoveAt(index);
        }
        public double CalculatingWeight()
        {
            double totalWeight = 0;
            foreach (Brilliant drill in listOfJews){
                totalWeight += drill.Carats;
            }
            return totalWeight;
        }

        public void AddingJew(string name, int price, double carats, int capacity)
        {
            listOfJews.Add(new Brilliant() { 
                Name = name,
                Carats = carats,
                Capacity = capacity,
                Price = price,
                

            });
        }
        public void EditJew(string name, int price, double carats, int capacity)
        {
            Brilliant drill = new Brilliant()
            {
                Name = name,
                Carats = carats,
                Capacity = capacity,
                Price = price,
            };
            listOfJews[indJews] = drill;
        }
    }
    public class Jewelry
    {
        public Brilliant ProvideJew()
        {
            Brilliant drill = new Brilliant();
            drill.Name = "Audi TT";
            drill.Carats = 750000;
            drill.Capacity = 4;
            drill.Price = 250;
            return drill;
        }

        public Brilliant ProvideJew2()
        {
            Brilliant drill = new Brilliant();
            drill.Name = "Mercedes CLK";
            drill.Carats = 1000000;
            drill.Capacity = 2;
            drill.Price = 200;
            return drill;
        }
    }


}