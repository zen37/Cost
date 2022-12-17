using System;
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
        };

        //how to call    private List<UoM> variable = Cost_Common.UtilitiesUoM.GetList();
        public static List<UoM> GetList()
        {
            return lstUoM;
        }
    }
}