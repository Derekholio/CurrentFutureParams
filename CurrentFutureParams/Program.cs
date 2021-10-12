using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentFutureParams
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentJson = @"[{'Key':'2020_W4','Description':'2020 W4','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'TRUE','Required':true,'Type':3,'Values':[{'Value':'TRUE','Description':'True','IsFutureValue':false},{'Value':'FALSE','Description':'False','IsFutureValue':false}],'StateCode':'FED'},{'Key':'TOTALALLOWANCES','Description':'Total Allowances','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0','Required':true,'Type':2,'Values':null,'StateCode':'FED'},{'Key':'FILINGSTATUS','Description':'Filing Status','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'S','Required':true,'Type':3,'Values':[{'Value':'S','Description':'Single','IsFutureValue':false},{'Value':'M','Description':'Married','IsFutureValue':false},{'Value':'H','Description':'Head of Household','IsFutureValue':false},{'Value':'NRA','Description':'Nonresident Alien','IsFutureValue':false}],'StateCode':'FED'},{'Key':'TWO_JOBS','Description':'Two Jobs','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'FALSE','Required':true,'Type':3,'Values':[{'Value':'TRUE','Description':'True','IsFutureValue':false},{'Value':'FALSE','Description':'False','IsFutureValue':false}],'StateCode':'FED'},{'Key':'MOST_RECENT_WH','Description':'Most Recent Withholding Amount','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'DEPENDENTS_AMT','Description':'Dependent Amount','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'OTHER_INCOME','Description':'Other Income','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'DEDUCTIONS','Description':'Deductions','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'NRA_EXEMPTION_AMT','Description':'NRA Exemption Amount','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'FILINGSTATUS','Description':'Filing Status','TaxCode':'08 - 000 - 0000 - SIT - 000','DefaultValue':'S','Required':true,'Type':3,'Values':[{'Value':'S','Description':'Single','IsFutureValue':false},{'Value':'M','Description':'Married','IsFutureValue':false},{'Value':'MH','Description':'Married Withhold at Higher Rate','IsFutureValue':false},{'Value':'H','Description':'Head of Household','IsFutureValue':false}],'StateCode':'CO'},{'Key':'POLITICALSUBDIVISION','Description':'Colorado Political Subdivision','TaxCode':'08 - 000 - 0000 - ER_SUTA - 000','DefaultValue':'FALSE','Required':true,'Type':3,'Values':[{'Value':'TRUE','Description':'True','IsFutureValue':false},{'Value':'FALSE','Description':'False','IsFutureValue':false}],'StateCode':'CO'}]";
            string futureJson = @"[{'Key':'2020_W4','Description':'2020 W4','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'TRUE','Required':true,'Type':3,'Values':[{'Value':'TRUE','Description':'True','IsFutureValue':false},{'Value':'FALSE','Description':'False','IsFutureValue':false}],'StateCode':'FED'},{'Key':'TOTALALLOWANCES','Description':'Total Allowances','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0','Required':true,'Type':2,'Values':null,'StateCode':'FED'},{'Key':'FILINGSTATUS','Description':'Filing Status','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'S','Required':true,'Type':3,'Values':[{'Value':'S','Description':'Single','IsFutureValue':false},{'Value':'M','Description':'Married','IsFutureValue':false},{'Value':'H','Description':'Head of Household','IsFutureValue':false},{'Value':'NRA','Description':'Nonresident Alien','IsFutureValue':false}],'StateCode':'FED'},{'Key':'TWO_JOBS','Description':'Two Jobs','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'FALSE','Required':true,'Type':3,'Values':[{'Value':'TRUE','Description':'True','IsFutureValue':false},{'Value':'FALSE','Description':'False','IsFutureValue':false}],'StateCode':'FED'},{'Key':'MOST_RECENT_WH','Description':'Most Recent Withholding Amount','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'DEPENDENTS_AMT','Description':'Dependent Amount','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'OTHER_INCOME','Description':'Other Income','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'DEDUCTIONS','Description':'Deductions','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'NRA_EXEMPTION_AMT','Description':'NRA Exemption Amount','TaxCode':'00 - 000 - 0000 - FIT - 000','DefaultValue':'0.0','Required':true,'Type':1,'Values':null,'StateCode':'FED'},{'Key':'FILINGSTATUS','Description':'Filing Status','TaxCode':'08 - 000 - 0000 - SIT - 000','DefaultValue':'S','Required':true,'Type':3,'Values':[{'Value':'S','Description':'Single','IsFutureValue':false},{'Value':'M','Description':'Married','IsFutureValue':false},{'Value':'MH','Description':'Married Withhold at Higher Rate','IsFutureValue':false},{'Value':'H','Description':'Head of Household','IsFutureValue':false}],'StateCode':'CO'},{'Key':'POLITICALSUBDIVISION','Description':'Colorado Political Subdivision','TaxCode':'08 - 000 - 0000 - ER_SUTA - 000','DefaultValue':'FALSE','Required':true,'Type':3,'Values':[{'Value':'TRUE','Description':'True','IsFutureValue':false},{'Value':'FALSE','Description':'False','IsFutureValue':false}],'StateCode':'CO'}]";

            IEnumerable<TaxParameter> currentParameters = JsonConvert.DeserializeObject<IEnumerable<TaxParameter>>(currentJson);
            IEnumerable<TaxParameter> futureParameters = JsonConvert.DeserializeObject<IEnumerable<TaxParameter>>(futureJson);


            for (int i = 0; i <= 100; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                IEnumerable<TaxParameter> results = AppendFutureParameters(currentParameters, futureParameters);
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }

            Console.ReadLine();
        }

        static IEnumerable<TaxParameter> AppendFutureParameters(IEnumerable<TaxParameter> currentParameters, IEnumerable<TaxParameter> futureParameters)
        {
            Dictionary<string, TaxParameter> futureParametersLookupMap = new Dictionary<string, TaxParameter>();

            foreach (TaxParameter futureParam in futureParameters)
            {
                futureParametersLookupMap.Add(CreateParameterKey(futureParam), futureParam);
            }

            foreach (TaxParameter currentParam in currentParameters)
            {
                string parameterKey = CreateParameterKey(currentParam);
                bool futureParamForCurrentParamExists = futureParametersLookupMap.TryGetValue(parameterKey, out TaxParameter futureParamForCurrentParam);

                if (!futureParamForCurrentParamExists)
                {
                    futureParametersLookupMap.Add(parameterKey, currentParam);
                    continue;
                }


                if (futureParamForCurrentParam.Values == null)
                {
                    if (currentParam.Values != null)
                    {
                        futureParamForCurrentParam.Values = currentParam.Values;
                    }

                    continue;
                }

                if (currentParam.Values == null)
                {
                    foreach (TaxParameterValue futureParamValue in futureParamForCurrentParam.Values)
                    {
                        futureParamValue.IsFutureValue = true;
                    }

                    continue;
                }

                Dictionary<string, TaxParameterValue> futureParamValuesMap = new Dictionary<string, TaxParameterValue>();
                foreach (TaxParameterValue futureParamValue in futureParamForCurrentParam.Values)
                {
                    futureParamValuesMap.Add(futureParamValue.Value, futureParamValue);
                }

                foreach (TaxParameterValue currentParamValue in currentParam.Values)
                {
                    if (futureParamValuesMap.ContainsKey(currentParamValue.Value))
                    {
                        futureParamValuesMap.Remove(currentParamValue.Value);
                    }
                }

                List<TaxParameterValue> newList = new List<TaxParameterValue>();
                foreach (var a in futureParamValuesMap.Values)
                {
                    a.IsFutureValue = true;
                    newList.Add(a);
                }


                futureParamForCurrentParam.Values = currentParam.Values.Concat(newList);
            }

            return futureParametersLookupMap.Values;
        }

        static string CreateParameterKey(TaxParameter parameter)
        {
            return $"{parameter.Key}-${parameter.TaxCode}";
        }
    }
}
