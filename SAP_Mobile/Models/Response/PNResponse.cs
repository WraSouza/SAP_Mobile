namespace SAP_Mobile.Models.Response
{
    public class PNResponse
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public string odatametadata { get; set; }
        public List<Value> value { get; set; }
        public string odatanextLink { get; set; }

        public class BusinessPartners
        {
            public string CardCode { get; set; }
            public string CardName { get; set; }
            public string Phone1 { get; set; }
            public string EmailAddress { get; set; }
        }

        public class BusinessPartnersBPAddresses
        {
            public string BPCode { get; set; }
            public string Street { get; set; }
            public string Block { get; set; }
            public string ZipCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string StreetNo { get; set; }
        }

        public class BusinessPartnersBPFiscalTaxIDCollection
        {
            public string BPCode { get; set; }
            public string TaxId1 { get; set; }
            public string TaxId4 { get; set; }
        }        

        public class Value
        {
            public BusinessPartners BusinessPartners { get; set; }            
            public BusinessPartnersBPFiscalTaxIDCollection BusinessPartnersBPFiscalTaxIDCollection { get; set; }          
            public BusinessPartnersBPAddresses BusinessPartnersBPAddresses { get; set; }
        }


    }
}
