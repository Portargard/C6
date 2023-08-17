using Microsoft.AspNetCore.Components;
using Thi_APP.Services;
using Thi_APP.Services.IService;
using Thi_Data.Data;

namespace Thi_APP.Pages
{
    public class GetAllProductBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IAppProductService ProductService { get; set; }
        public IEnumerable<Product> products { get; set; }
        public Product Product { get; set; } = new Product();
        public int Count = 1;
        protected override async Task OnInitializedAsync()
        {
            products = (await ProductService.GetAllProducts()).ToList();
        }

        public async Task DeleteProduct(Guid id)
        {
            await ProductService.DeleteProduct(id);
            NavigationManager.NavigateTo("/GetAllProduct", forceLoad: true);
        }
        public async Task UpdateProduct(Guid id)
        {
            NavigationManager.NavigateTo($"/UpdateProduct/{id}", forceLoad: true);
        }
    }
}
