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
}