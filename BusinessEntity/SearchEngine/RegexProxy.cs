using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessEntity.SearchEngine
{
    class RegexProxy
    {
        Dictionary<String, Regex> proxy;
        
        static RegexProxy instance;

        private RegexProxy()
        {
            proxy = new Dictionary<string, Regex>();
        }

        public static RegexProxy getInstance()
        {
            if (instance == null)
                instance = new RegexProxy();
            return instance;
        }

        public Regex getRegex(string pattern)
        {
            if (proxy.Keys.Contains(pattern) == false)
                proxy[pattern] = new Regex(pattern, RegexOptions.IgnoreCase);
            return proxy[pattern];
        }
    }
}
