using System.Xml;

namespace TXClock.Interface
{
    public interface IXmlConvert
    {
        void SaveToXmlNode();
        void DeleteFromXmlNode();
        void InitFromXmlNode(XmlNode node);
    }
}
