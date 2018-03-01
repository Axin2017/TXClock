using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TXClock.Interface
{
    public interface IXmlConvert
    {
        void SaveToXmlNode(XmlDocument  doc);
        void InitFromXmlNode(XmlNode node);
    }
}
