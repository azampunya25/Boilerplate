using SIMA.Application.Interfaces.Shared;
using System;

namespace SIMA.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}