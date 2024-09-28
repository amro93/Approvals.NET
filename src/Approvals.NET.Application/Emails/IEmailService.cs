using Approvals.NET.Application.Emails.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Emails
{
    public interface IEmailService
    {
        Task<SendEmailResult> SendAsync(SendEmailInputDto request);
    }
}
