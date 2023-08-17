using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using Thi_APP.Services.IService;

namespace Thi_APP.Pages
{
    public class UploadFileBase : ComponentBase
    {
        [Inject]
        protected IUploadFileService uploadFileService { get; set; }
        public IFileListEntry file { get; set; }
        public string uploadMessage { get; set; } = string.Empty;

        public async Task HandleFileSelected(IFileListEntry[] files)
        {
            //lay file dau tien duoc chon
            file = files.FirstOrDefault();
            
        }
        public async Task Save()
        {
            if (file != null)
            {
                await uploadFileService.UploadFileAsync(file);
                uploadMessage = "Thanh cong";
            }
            else { uploadMessage = "That Bai"; }
        }
    }
}
