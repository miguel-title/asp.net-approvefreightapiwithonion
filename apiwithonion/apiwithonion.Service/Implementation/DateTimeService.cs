using apiwithonion.Service.Contract;
using System;

namespace apiwithonion.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}