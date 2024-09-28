using Approvals.NET.Domain.Entities.Common;
using Approvals.NET.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Domain.Entities.Files
{
    public class StaticFileInfo : CreateAuditedEntity<Guid?>, IEntity<Guid>, IFileInfo
    {
        public Guid Id { get; set; }
        /// <summary>
        /// The real name of the attached file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The file type extension
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// The path to the folder which contains the file
        /// </summary>
        public string FolderPath { get; set; }

        /// <summary>
        /// the user who must be elligible to acces this file
        /// </summary>
        //public Guid? UserId { get; set; }
        public StaticFileProvider StaticFileProvider { get; set; }
    }

    public enum StaticFileProvider
    {
        Local,
    }
    public interface IFileInfo : IFileInfo<Guid>
    {

    }
    public interface IFileInfo<TPK> where TPK : IEquatable<TPK>
    {
        public TPK Id { get; set; }
        /// <summary>
        /// The real name of the attached file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The file type extension
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// The path to the folder which contains the file
        /// </summary>
        public string FolderPath { get; set; }

        /// <summary>
        /// the user who must be elligible to acces this file
        /// </summary>
        //public TUserPK? UserId { get; set; }
        public StaticFileProvider StaticFileProvider { get; set; }
    }
}
