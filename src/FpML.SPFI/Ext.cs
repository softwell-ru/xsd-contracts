using System.Xml;
using System.Xml.Serialization;

namespace SoftWell.Fpml.Spfi
{
    public partial class FxSingleLeg
    {
        private bool tenorNameFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tenorNameSpecified
        {
            get
            {
                return this.tenorNameFieldSpecified;
            }
            set
            {
                this.tenorNameFieldSpecified = value;
            }
        }
    }
    public partial class moexSpfiReport
    {
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation { get; set; }
    }
}