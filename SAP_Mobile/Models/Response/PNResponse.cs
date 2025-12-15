namespace SAP_Mobile.Models.Response
{
    public class PNResponse
    {
        public PNResponse()
        {
            
        }
        public PNResponse(List<Value> value)
        {
            this.value = value;
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public string odatametadata { get; set; }
        public List<Value> value { get; set; }
        public string odatanextLink { get; set; }

        public class BusinessPartners
        {
            public BusinessPartners()
            {
                
            }
            public BusinessPartners(string cardCode, string cardName, string phone1, string emailAddress)
            {
                this.cardCode = cardCode;
                this.cardName = cardName;
                this.phone1 = phone1;
                this.emailAddress = emailAddress;
            }

            public string cardCode { get; set; }
            public string cardName { get; set; }
            public string phone1 { get; set; }
            public string emailAddress { get; set; }
        }

        public class BusinessPartnersBPAddresses
        {
            public BusinessPartnersBPAddresses()
            {
                
            }
            public BusinessPartnersBPAddresses(string bPCode, string street, string block, string zipCode, string city, string state, string streetNo)
            {
                this.bPCode = bPCode;
                this.street = street;
                this.block = block;
                this.zipCode = zipCode;
                this.city = city;
                this.state = state;
                this.streetNo = streetNo;
            }

            public string bPCode { get; set; }
            public string street { get; set; }
            public string block { get; set; }
            public string zipCode { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string streetNo { get; set; }
        }

        public class BusinessPartnersBPFiscalTaxIDCollection
        {
            public BusinessPartnersBPFiscalTaxIDCollection()
            {
                
            }
            public BusinessPartnersBPFiscalTaxIDCollection(string bPCode, string taxId1)
            {
                this.bPCode = bPCode;
                this.taxId1 = taxId1;               
            }

            public string bPCode { get; set; }
            public string taxId1 { get; set; }
            public string taxId4 { get; set; }
        }
    }
}
