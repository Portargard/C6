using Microsoft.AspNetCore.Components;
using Thi_APP.Services.IService;
using Thi_Data.Data;

namespace Thi_APP.Pages
{
    public class AddProductBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        IAppProductService appProductService { get; set; }
        public Product product { get; set; } = new Product();
        public async Task AddProduct()
        {
            appProductService.AddProduct(product);
            NavigationManager.NavigateTo("/GetAllProduct", forceLoad: true);
        }
    }
}
