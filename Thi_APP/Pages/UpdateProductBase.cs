using Microsoft.AspNetCore.Components;
using Thi_APP.Services.IService;
using Thi_Data.Data;

namespace Thi_APP.Pages
{
    public class UpdateProductBase :ComponentBase
    {
        [Inject]
        IAppProductService appProductService { get; set; }
        [Parameter]
        public string id { get; set; }
        public Product product { get; set; } = new Product();
        protected override async Task OnInitializedAsync()
        {
            product = (await appProductService.GetProductById(Guid.Parse(id)));
        }
        public async Task Update()
        {
            appProductService.UpdateProduct(product);
        }
    }
}
