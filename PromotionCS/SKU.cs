using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class SKU
    {
        public SKU(String style, String subModelNo)
        {
            this.style = style;
            this.subModelNo = subModelNo;
        }

        public static Boolean isSameStyle(SKU sku1, SKU sku2)
        {
            bool result = false;
            if (sku1.style.ToUpper().CompareTo(sku2.style.ToUpper()) == 0)
            {
                result = true;
            }
            return result;
        }

        public static Boolean isSameSKU(SKU sku1, SKU sku2)
        {
            bool result = false;
            if (sku1.style.ToUpper().CompareTo(sku2.style.ToUpper()) == 0
                && (sku1.subModelNo.ToUpper().CompareTo(sku2.subModelNo.ToUpper()) == 0))
            {
                result = true;
            }
            return result;
        }

        private String style;

        public String Style
        {
            get { return style; }
            set { style = value; }
        }
        private String subModelNo;

        public String SubModelNo
        {
            get { return subModelNo; }
            set { subModelNo = value; }
        }

        public String Name
        {
            get
            {
                return style + subModelNo;
            }
        }

    }
}
