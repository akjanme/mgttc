using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ITI.Data
{
    public static class StaticData
    {
        public static List<SelectListItem> GetCategories()
        {             
            return new List<SelectListItem>
            {
                new SelectListItem{ Text="S.C.", Value="SC" },
                new SelectListItem{ Text="S.T.", Value="ST" },
                new SelectListItem{ Text="OBC", Value="OBC" },
                new SelectListItem{ Text="SBC", Value="SBC" },
                new SelectListItem{ Text="GEN.", Value="GEN" },
                new SelectListItem{ Text="OTHER", Value="OTHER" }
            };
        }

        public static List<SelectListItem> GetStaffAT()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text="Technical", Value="Technical" },
                new SelectListItem{ Text="Academic", Value="Academic" }
            };
        }

        public static List<SelectListItem> GetTrade()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text="Electrician", Value="Electrician" },

                new SelectListItem{ Text="Mechanic Diesel", Value="Mechanic" },

                new SelectListItem{ Text="Fitter", Value="Fitter" },

                new SelectListItem{ Text="Electro Mechanic", Value="Electro Mechanic" },

                new SelectListItem{ Text="Copa.", Value="Cope" }
            };
        }

        public static List<SelectListItem> GetUnit()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text="01", Value="1" },

                new SelectListItem{ Text="02", Value="2" },

                new SelectListItem{ Text="03", Value="3" },

                new SelectListItem{ Text="04", Value="4" },

                new SelectListItem{ Text="05", Value="5" },

                new SelectListItem{ Text="06", Value="6" },
                new SelectListItem{ Text="07", Value="7" },

                new SelectListItem{ Text="08", Value="8" },

                new SelectListItem{ Text="09", Value="9" },

                new SelectListItem{ Text="10", Value="10" },

                new SelectListItem{ Text="11", Value="11" },

                new SelectListItem{ Text="12", Value="12" }

            };
        }

        public static List<SelectListItem> GetSession()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text="2008", Value="2008" },

                new SelectListItem{ Text="2009", Value="2009" },

                new SelectListItem{ Text="2010", Value="2010" },

                new SelectListItem{ Text="2011", Value="2011" },

                new SelectListItem{ Text="2012", Value="2012" },

                new SelectListItem{ Text="2013", Value="2013" },

                 new SelectListItem{ Text="2014", Value="2014" },

                new SelectListItem{ Text="2015", Value="2015" },

                new SelectListItem{ Text="2016", Value="2016" },

                new SelectListItem{ Text="2017", Value="2017" },

                new SelectListItem{ Text="2018", Value="2018" },

                new SelectListItem{ Text="2019", Value="2019" },

                new SelectListItem{ Text="2020", Value="2020" },

                new SelectListItem{ Text="2021", Value="2021" },

                new SelectListItem{ Text="2022", Value="2022" },

                new SelectListItem{ Text="2023", Value="2023" },

            };
        }

        public static List<SelectListItem> GetStaffAdmin()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{ Text="01", Value="1" },

                new SelectListItem{ Text="02", Value="2" },

                new SelectListItem{ Text="03", Value="3" },

                new SelectListItem{ Text="04", Value="4" },

                new SelectListItem{ Text="05", Value="5" },

                new SelectListItem{ Text="06", Value="6" },

                new SelectListItem{ Text="07", Value="7" },

                new SelectListItem{ Text="08", Value="8" },

                new SelectListItem{ Text="09", Value="9" },

                new SelectListItem{ Text="10", Value="10" },

                new SelectListItem{ Text="11", Value="11" },

                new SelectListItem{ Text="12", Value="12" }

            };
        }
    }

}
