using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thi_Data.Data;

namespace Thi_Data.Repositories.IRepositories
{
    public interface IFileDataRepository
    {
        public bool FileUpload(FileData file);
    }
}
