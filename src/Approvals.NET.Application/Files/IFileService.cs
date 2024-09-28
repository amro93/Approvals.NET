using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Application.Files.Dto;

namespace Approvals.NET.Application.Files
{
    public interface IFileService
    {
        //Task<FileDto> SaveFileAsync(IFormFile file, string rootFolder = null, long? userId = null);
        Task<FileDto> SaveFileAsync(string base64File, string fileName, string rootFolder = null, long? userId = null);
        Task<FileDto> SaveFileAsync(IBase64FileVM base64FileVM, string rootFolder = null, long? userId = null);
        Task<bool> DeleteFileAsync(string path);
        bool DeleteFile(string path);
    }
}
