using BlazorInputFile;
using Thi_APP.Services.IService;

namespace Thi_APP.Services
{
    public class UploadFileService : IUploadFileService
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        //ctor
        public UploadFileService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task UploadFileAsync(IFileListEntry file)
        {
            //Lay Path cua file
            var filePath = Path.Combine(webHostEnvironment.ContentRootPath, "wwwroot", "File", file.Name);
            //tao memorystream
            var memoryStream = new MemoryStream();
            //chuyen data cua file duoc chon len stream
            await file.Data.CopyToAsync(memoryStream);
            //luu data o trong stream vao dia chi filePath
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                //data tu memorystream duoc ghi vao file stream
                memoryStream.WriteTo(fileStream);
            }
        }
    }
}
