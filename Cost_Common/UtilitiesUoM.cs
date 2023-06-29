using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cost_Common
{
    public static class UtilitiesUoM
    {
        private static List<string> lstNameUoM = new List<string>();
        private static List<UoM> lstClass = new List<UoM>();
        private static string? className;
        private static string? abbreviation;
        private static string? name;
        private static double factor;

        private static readonly List<UoM> lstUoM = new List<UoM>()
        {
            //weight
            (new UoM { Name = "gram",       Abbreviation = "g",     Class = "weight", Factor = 1 }),
            (new UoM { Name = "kilogram",   Abbreviation = "kg",    Class = "weight", Factor = 1000 }),
            (new UoM { Name = "miligram",   Abbreviation = "mg",    Class = "weight", Factor = 0.001 }),
            (new UoM { Name = "pound",      Abbreviation = "lb",    Class = "weight", Factor = 453.59237 }),
            (new UoM { Name = "ounce",      Abbreviation = "oz",    Class = "weight", Factor = 28.3495231 }),

            //volume
            (new UoM { Name = "milliliter", Abbreviation = "ml",    Class = "volume", Factor = 1 }),
            (new UoM { Name = "liter",      Abbreviation = "l",     Class = "volume", Factor = 1000 }),
            (new UoM { Name = "US pint",    Abbreviation = "pt",    Class = "volume", Factor = 473.176472 }),
            (new UoM { Name = "US quart",   Abbreviation = "qt",    Class = "volume", Factor = 946.352945 }),
            (new UoM { Name = "US gallon",  Abbreviation = "gal",   Class = "volume", Factor = 3785.41178 }),

            //time  
            (new UoM { Name = "minute",     Abbreviation = "m",     Class = "time", Factor = 1 }),
            (new UoM { Name = "hour",       Abbreviation = "h",     Class = "time", Factor = 60 }),

            //energy
            (new UoM { Name = "kWh",        Abbreviation = "kWh",   Class = "energy", Factor = 1 }),
            
            //material
            (new UoM { Name = "each",        Abbreviation = "ea",   Class = "material", Factor = 1 })
           // (new UoM { Name = "lid",        Abbreviation = "ea",   Class = "material", Factor = 1 }),
           // (new UoM { Name = "bag",        Abbreviation = "ea",   Class = "material", Factor = 1 })
        };

        public static List<UoM> GetList()
        {
            return lstUoM;
        }

        public static List<string> GetNameUoM()
        {
            if (!lstNameUoM.Any())
            {
                foreach (UoM unit in lstUoM)
                {
                    lstNameUoM.Add(unit.Name);
                }
            }
            return lstNameUoM;
        }

        public static List<UoM> GetListbyAbbreviation(string abbreviation)
        {
            lstClass.Clear();
            var cls = GetClassbyAbbreviation(abbreviation);
            if (!lstClass.Any())
            {
                foreach (UoM unit in lstUoM)
                {
                    if (unit.Class == cls)
                    {
                        lstClass.Add(unit);
                    }
                }
            }
            return lstClass;
        }

        public static List<UoM> GetListbyName(string name)
        {
            lstClass.Clear();
            var cls = GetClassbyName(name);
            if (!lstClass.Any())
            {
                foreach (UoM unit in lstUoM)
                {
                    if (unit.Class == cls)
                    {
                        lstClass.Add(unit);
                    }
                }
            }
            return lstClass;
        }

        public static string GetClassbyAbbreviation(string abbreviation)
        {
            foreach (UoM unit in lstUoM)
            {
                if (abbreviation == unit.Abbreviation)
                {
                    className= unit.Class;
                }
            }
            return className;
        }

        public static string GetNamebyAbbreviation(string abbreviation)
        {
            foreach (UoM unit in lstUoM)
            {
                if (abbreviation == unit.Abbreviation)
                {
                    name = unit.Name;
                }
            }
            return name;
        }

        public static string GetClassbyName(string name)
        {
            foreach (UoM unit in lstUoM)
            {
                if (name == unit.Name)
                {
                    className = unit.Class;
                }
            }
            return className;
        }

        public static string GetAbbreviationbyName(string name)
        {
            foreach (UoM unit in lstUoM)
            {
                if (name == unit.Name)
                {
                    abbreviation = unit.Abbreviation;
                }
            }
            return abbreviation;
        }

        public static double GetFactorbyUoMName(string UoMName)
        {
            foreach (UoM unit in lstUoM)
            {
                if (UoMName == unit.Name)
                {
                    factor = unit.Factor;
                }
            }
            return factor;
        }

        public static string GetBaseUnit(string name)
        {
            var cls = GetClassbyAbbreviation(name);
            if (cls == "weight")
            {
                return "g";
            }
            else if (cls == "volume")
            {
                return "ml";
            }
            else if (cls == "time")
            {
                return "m";
            }
            else if (cls == "energy")
            {
                return "kWh";
            }
            else
            {
                return "ea";
            }
        }
    }
}