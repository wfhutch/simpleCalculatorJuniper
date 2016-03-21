using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public string LastExpression { get; set; }
        public decimal LastAnswer { get; set; }

        Dictionary<string, int> user_variables = new Dictionary<string, int>();

        public void AddVariables(string user_key, int user_value)
        {
            user_variables.Add(user_key, user_value);
        }

        public List<string> FindAllKeysAndValues()
        {
            List<string> keyvaluepairs = new List<string>();
            foreach (KeyValuePair<string, int> kvp in user_variables)
            {
                string key_value = kvp.Key + "=" + kvp.Value;
                keyvaluepairs.Add(key_value);
            }
            return keyvaluepairs;
        }
    }
}
