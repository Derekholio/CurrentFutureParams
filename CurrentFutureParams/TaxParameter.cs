using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentFutureParams
{
    public class TaxParameter
    {
        public string Key;
        public string Description;
        public string TaxCode;
        public string DefaultValue;
        public bool Required;
        public TaxParameterType Type;
        public IEnumerable<TaxParameterValue> Values;
        public string StateCode;
    }
}
