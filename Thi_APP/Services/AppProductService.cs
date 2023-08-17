using Newtonsoft.Json;
using Thi_APP.Services.IService;
using Thi_Data.Data;

namespace Thi_APP.Services
{
    public class AppProductService : IAppProductService
    {
        private readonly HttpClient httpClient;
        public AppProductService()
        {

        }
        public AppProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Product> AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            string apiUrl = "https://localhost:7266/api/Product/Add";
            var httpClient = new HttpClient(); // tạo ra để callApi
            var response = await httpClient.PostAsJsonAsync(apiUrl,product);// Lấy dữ liệu ra
                                                             // Lấy dữ liệu Json trả về từ Api được call dạng string
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kqua trả về từ API
            // Đọc từ string Json vừa thu được sang List<T>
            var sanphams = JsonConvert.DeserializeObject<Product>(apiData);
            return sanphams;
        }

        public async Task DeleteProduct(Guid id)
        {
            string apiUrl = $"https://localhost:7266/api/Product/Delete/{id}";
            var httpClient = new HttpClient(); // tạo ra để callApi
            var response = await httpClient.DeleteAsync(apiUrl);// Lấy dữ liệu ra
                                                             // Lấy dữ liệu Json trả về từ Api được call dạng string
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            string apiUrl = "https://localhost:7266/api/Product/GetAll";
            var httpClient = new HttpClient(); // tạo ra để callApi
            var response = await httpClient.GetAsync(apiUrl);// Lấy dữ liệu ra
                                                             // Lấy dữ liệu Json trả về từ Api được call dạng string
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kqua trả về từ API
            // Đọc từ string Json vừa thu được sang List<T>
            var sanphams = JsonConvert.DeserializeObject<List<Product>>(apiData);
            return sanphams;
        }
        public async Task<Product> GetProductById(Guid id)
        {
            string apiUrl = $"https://localhost:7266/api/Product/GetById/{id}";
            var httpClient = new HttpClient(); // tạo ra để callApi
            var response = await httpClient.GetAsync(apiUrl);// Lấy dữ liệu ra
                                                             // Lấy dữ liệu Json trả về từ Api được call dạng string
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kqua trả về từ API
            // Đọc từ string Json vừa thu được sang List<T>
            var sanphams = JsonConvert.DeserializeObject<Product>(apiData);
            return sanphams;
        }
        public async Task UpdateProduct(Product product)
        {
            string apiUrl = "https://localhost:7266/api/Product/Update";
            var httpClient = new HttpClient(); // tạo ra để callApi
            var response = await httpClient.PutAsJsonAsync(apiUrl, product);// Lấy dữ liệu ra
                                                                            // Lấy dữ liệu Json trả về từ Api được call dạng string
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kqua trả về từ API
            // Đọc từ string Json vừa thu được sang List<T>
            var sanphams = JsonConvert.DeserializeObject<Product>(apiData);
        }
    }
}
