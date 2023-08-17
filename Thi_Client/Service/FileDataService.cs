using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Thi_Client.Service.Iservices;
using Thi_Data.Data;
using Thi_Data.Repositories;
using Thi_Data.Repositories.IRepositories;
using System.IO;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Thi_Client.Service
{
    public class FileDataService : IFileDataService
    {
        private readonly IWebAssemblyHostEnvironment webAssemblyHostEnvironment;

        //ctor
        public FileDataService(IWebAssemblyHostEnvironment webAssemblyHostEnvironment)
        {
            this.webAssemblyHostEnvironment = webAssemblyHostEnvironment;
        }

        public async Task UploadFileAsync(IFileListEntry file)
        {
            //Lay Path cua file
            var filePath = Path.Combine(this.webAssemblyHostEnvironment.ContentRootPath., "wwwroot", "uploaded", file.Name);
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
