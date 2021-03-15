using System;
using System.Security.Cryptography.X509Certificates;
using Octopus.CoreParsers.Hcl;
using Sprache;

namespace Reform.Core
{
    public class Parser
    {

        public HclElement Parse(string src)
        {

            var parser = HclParser.HclTemplate.Parse(src);
            return parser;

        }



    }
}
