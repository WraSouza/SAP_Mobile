using static SAP_Mobile.Models.Response.PNResponse;

namespace SAP_Mobile.Models.Response
{
    public class Value
    {
        public Value()
        {

        }
        public Value(BusinessPartners businessPartners, BusinessPartnersBPFiscalTaxIDCollection businessPartnersBPFiscalTaxIDCollection, BusinessPartnersBPAddresses businessPartnersBPAddresses)
        {
            this.businessPartners = businessPartners;
            this.businessPartnersBPFiscalTaxIDCollection = businessPartnersBPFiscalTaxIDCollection;
            this.businessPartnersBPAddresses = businessPartnersBPAddresses;
        }

        public BusinessPartners businessPartners { get; set; }
        public BusinessPartnersBPFiscalTaxIDCollection businessPartnersBPFiscalTaxIDCollection { get; set; }
        public BusinessPartnersBPAddresses businessPartnersBPAddresses { get; set; }
    }
}
