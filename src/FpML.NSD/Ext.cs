using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftWell.Ctor.Api.Contract.FpmlNrd;
namespace SoftWell.Ctor.Api.Contract.FpmlNrd
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.fpml.org/FpML-5/recordkeeping/nsd-ext", IncludeInSchema = false)]
    public enum ItemChoiceType17Nrd
    {
        masterAgreementTerms,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.fpml.org/FpML-5/recordkeeping/nsd-ext", IncludeInSchema = false)]
    public enum AdditionalEventChoiceTypeNrd
    {
        transfersAndExecution,
        markToMarketValuation,
    }
    public partial class NonpublicExecutionReport
    {
        private AdditionalEvent ItemField;
        private AdditionalEventChoiceTypeNrd itemElementNameField;

        [System.Xml.Serialization.XmlElementAttribute("transfersAndExecution", typeof(TransfersAndExecution), Namespace = "http://www.fpml.org/FpML-5/recordkeeping/nsd-ext")]
        [System.Xml.Serialization.XmlElementAttribute("markToMarketValuation", typeof(MarkToMarketValuation), Namespace = "http://www.fpml.org/FpML-5/recordkeeping/nsd-ext")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public AdditionalEvent Item
        {
            get
            {
                return this.ItemField;
            }
            set
            {
                this.ItemField = value;
                this.RaisePropertyChanged("Item");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public AdditionalEventChoiceTypeNrd ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
                this.RaisePropertyChanged("ItemElementName");
            }
        }
    }
    public partial class Trade
    {
        private Product item1Field;

        private ItemChoiceType17Nrd item1ElementNameField;

        [System.Xml.Serialization.XmlElementAttribute("masterAgreementTerms", typeof(MasterAgreementTerms), Namespace = "http://www.fpml.org/FpML-5/recordkeeping/nsd-ext")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public Product Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                this.RaisePropertyChanged("Item1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType17Nrd Item1ElementName
        {
            get
            {
                return this.item1ElementNameField;
            }
            set
            {
                this.item1ElementNameField = value;
                this.RaisePropertyChanged("Item1ElementName");
            }
        }
    }
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
                //this.RaisePropertyChanged("tenorNameFieldSpecified");
            }
        }
    }
    public partial class FxSwapLeg
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
                //this.RaisePropertyChanged("tenorNameFieldSpecified");
            }
        }
    }
}
