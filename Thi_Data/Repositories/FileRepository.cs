using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thi_Data.Data;
using Thi_Data.Repositories.IRepositories;

namespace Thi_Data.Repositories
{
    public class FileRepository : IFileDataRepository
    {
        private readonly ThiDbC6 _db;
        public FileRepository()
        {
            _db = new ThiDbC6();
        }
        public bool FileUpload(FileData file)
        {
            try
            {
                _db.FileDatas.Add(file);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
