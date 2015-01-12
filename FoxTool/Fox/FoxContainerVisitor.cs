using System;
using System.Collections.Generic;

namespace FoxTool.Fox
{
    public class FoxContainerVisitor
    {
        public FoxContainerVisitor()
        {
            FoxStringMapAction = map => { };
            FoxListBaseAction = list => { };
        }

        public Action<IEnumerable<IFoxKeyValuePair<FoxName, IFoxValue>>> FoxStringMapAction { get; set; }
        public Action<IEnumerable<IFoxValue>> FoxListBaseAction { get; set; }

        public void Visit(IEnumerable<IFoxKeyValuePair<FoxName, IFoxValue>> foxStringMap)
        {
            FoxStringMapAction(foxStringMap);
        }

        public void Visit(IEnumerable<IFoxValue> foxListBase)
        {
            FoxListBaseAction(foxListBase);
        }
    }
}
