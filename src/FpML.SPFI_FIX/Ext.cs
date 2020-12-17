using System.Xml;
using System.Xml.Serialization;

namespace FpML.SPFI_FIX
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
}