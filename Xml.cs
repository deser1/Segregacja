using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XMLIK
{
    [XmlRoot("Document")]
    public class Document
    {
        [XmlElement("PositionTopLeft")]
        public int PositionTopLeft { get; set; }
        [XmlElement("Width")]
        public int Width { get; set; }
        [XmlElement("Height")]
        public int Height { get; set; }
        [XmlElement("Title")]
        public Title Titles { get; set; }
        [XmlElement("BootleType")]
        public BootleType BootleTypes { get; set; }
        [XmlElement("NumberLine")]
        public NumberLine NumberLine { get; set; }
        [XmlElement("Shift")]
        public Shift Shifts { get; set; }
        [XmlElement("DateTime")]
        public DatesTime DateTime { get; set; }
    }

    public class NumberLine
    {
        [XmlElement("Param")]
        public List<Param> Params { get; set; }
    }

    //[XmlRoot]
    public class DatesTime
    {
        [XmlElement("PosY")]
        public int PosY { get; set; }
    }

    //[XmlRoot]
    public class Shift
    {
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("TitleNoNumber")]
        public string TitleNoNumber { get; set; }
        [XmlElement("PosY")]
        public int PosY { get; set; }
        [XmlElement("Number")]
        public Number Numbers { get; set; }
        [XmlElement("DefaultOption")]
        public int DefaultOption { get; set; }
        [XmlElement("DefaultCheckedYesNoShift")]
        public int DefaultCheckedYesNoShift { get; set; }
    }

    //[XmlRoot]
    public class Number
    {
        [XmlElement("Param")]
        //[XmlElement(IsNullable = false)]
        public List<Param> Params { get; set; }
    }
    //[XmlRoot]
    public class BootleType
    {
        [XmlElement("PosY")]
        public int PosY { get; set; }
        [XmlElement("Item")]
        public Item Items { get; set; }
    }

    //[XmlRoot]
    public class Item
    {
        [XmlElement("Param")]
        //[XmlElement(IsNullable = false)]
        public List<Param> Params { get; set; }
    }

    //[XmlType("Param")]
    public class Param
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlText]
        public string Name { get; set; }
    }

    //[XmlRoot]
    public class Title
    {
        [XmlElement("PosY")]
        public int PosY { get; set; }
        [XmlElement("Text")]
        public string Text { get; set; }
    }
}
