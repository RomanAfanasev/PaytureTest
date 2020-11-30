using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PaytureTest
{
    [XmlRoot("Pay")]
    public class PayResponse
    {
        [XmlAttribute("Success")]
        public string Success { get; set; }

        [XmlAttribute("OrderId")]
        public string OrderId { get; set; }

        [XmlAttribute("Key")]
        public string Key { get; set; }

        [XmlAttribute("Amount")]
        public int Amount { get; set; }
    }
}
