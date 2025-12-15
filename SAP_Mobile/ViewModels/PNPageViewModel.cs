using SAP_Mobile.Helpers;
using SAP_Mobile.Models.Response;
using SAP_Mobile.Repositories.PN;

namespace SAP_Mobile.ViewModels
{
    public partial class PNPageViewModel(IPNRepository repository) : BaseViewModel
    {
        public ObservableCollection<Value> BusinessPartners { get; set; }
        = new ObservableCollection<Value>();   
        
        [ObservableProperty]
        public string? searchText;

        private char startLetter;


        [RelayCommand]
        internal async Task GetPartnersAsync()
        {
            IsBusy = true;

            BusinessPartners.Clear();

            if(SearchText == "Fornecedor")
            {
                startLetter = 'F';
            }
            else
            {
                startLetter = 'C';
            }

            var hasConnection = Conectividade.GetConnectivity();

            if (hasConnection)
            {
                var allPN = await repository.GetAllPNAsync();

                foreach (var item in allPN.value.Where(p => p.businessPartners.cardCode.StartsWith(startLetter)))
                {
                    if (!BusinessPartners.Any(p => p.businessPartners.cardCode == item.businessPartners.cardCode))
                    {
                        BusinessPartners.Add(item);
                    }

                }
            }
        }
    }
}
