using System.Xml;
using System.Xml.Serialization;

namespace SoftWell.Fpml.Confirmation
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

    public partial class CreditSupportAgreement
    {
        private bool dateFieldSpecified;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
    }

    public partial class ExchangeRate
    {
        private bool spotRateFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool spotRateSpecified
        {
            get
            {
                return this.spotRateFieldSpecified;
            }
            set
            {
                this.spotRateFieldSpecified = value;
            }
        }

        private bool forwardPointsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forwardPointsSpecified
        {
            get
            {
                return this.forwardPointsFieldSpecified;
            }
            set
            {
                this.forwardPointsFieldSpecified = value;
            }
        }
    }
}