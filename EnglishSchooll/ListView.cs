using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace EnglishSchooll
{
    public partial class Service
    {
        public string CostLable
        {
            get
            {
                int CostVal = Convert.ToInt32(Cost);
                int FinalCost = CostVal - Convert.ToInt32(CostVal * Discount);
                if (Discount > 0) {
                    return " " + FinalCost.ToString()  + " рублей за " + (Convert.ToInt32(DurationInSeconds) / 60).ToString() + " минут." +
                        "\n^ Скидка " + Discount * 100 + "%";
                }
                else
                {
                    return " рублей за " + (Convert.ToInt32(DurationInSeconds) / 60).ToString() + " минут.";
                }
            }
        }

        public string CostInt
        {
            get
            {
                return Convert.ToInt32(Cost).ToString();
            }
        }
        public string IsDiscount
        {
            get
            {
                return Discount > 0 ? "Strikethrough" : "";
            }
        }

    }
}

