using BlazorInputFile;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Thi_Data.Data;

namespace Thi_Client.Service.Iservices
{
    public interface IFileDataService
    {
        Task UploadFileAsync(IFileListEntry file);
    }
}
