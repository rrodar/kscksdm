using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_Gems
{
    public class Necklace
    {
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        private double _allSemiJewel;
        public double AllSemiJewel
        {
            get { return _allSemiJewel; }
            set { _allSemiJewel = value; }
        }
        private double _jewelCount;
        private double _semiJewelCount;
        public double JewelCount
        {
            get { return _jewelCount; }
            set { _jewelCount = value; }
        }
        public double SemiJewelCount
        {
            get { return _semiJewelCount; }
            set { _semiJewelCount = value; }
        }
        public double JewelWeight(double jewelCount, double jewel_carats)
        {
            double overall_weight = jewelCount * jewel_carats;
            return overall_weight;
        }
        public double SemiJewelWeight(double semiJewelCount, double semiJewel_weight)
        {
            double overall_weight = semiJewelCount * semiJewel_weight * 0.2;
            return overall_weight;
        }
    }

        public class AbstractJewellery : Necklace
    {
        private int _price;
        private string _form;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Form
        {
            get { return _form; }
            set { _form = value; }
        }
    }


    public class Jewel : AbstractJewellery
    {
        private double _carats;
        private int _transparency;

        public double Carats
        {
            get { return _carats; }
            set { _carats = value; }
        }
        public int Transparency
        {
            get { return _transparency; }
            set { _transparency = value; }
        }
    }


    public class Ruby : Jewel
    {
        private int _colorSaturation;

        public int ColorSaturation
        {
            get { return _colorSaturation; }
            set { _colorSaturation = value; }
        }

    }


    public class Brilliant : Jewel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }


    public class SemiJewel : AbstractJewellery
    {
        private double _weight;
        private string _color;


        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

    }


    public class Amethyst : SemiJewel   
    {
        private int _purity;

        public int Purity
        {
            get { return _purity; }
            set { _purity = value; }
        }
      
    }


    public class Topaz : SemiJewel
    {
        private string _rarity;

        public string Rarity
        {
            get { return _rarity; }
            set { _rarity = value; }
        }
    }
}
