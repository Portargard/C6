using BlazorInputFile;

namespace Thi_APP.Services.IService
{
    public interface IUploadFileService
    {
        Task UploadFileAsync(IFileListEntry file);
    }
}
