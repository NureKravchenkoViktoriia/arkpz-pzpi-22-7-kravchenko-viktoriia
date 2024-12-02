using System.Collections.Generic;
using System.Linq;
using AquaTrack.Data.Models;
using AquaTrack.Repositories;

namespace AquaTrack.Services
{
    public class WaterUsageService
    {
        private readonly IRepository<WaterUsage> _repository;

        public WaterUsageService(IRepository<WaterUsage> repository)
        {
            _repository = repository;
        }

        public WaterUsage GetCurrentUsage()
        {
            return _repository
                .GetAll()
                .OrderByDescending(w => w.Timestamp)
                .FirstOrDefault();
        }

        public IEnumerable<WaterUsage> GetUsageHistory()
        {
            return _repository
                .GetAll()
                .OrderByDescending(w => w.Timestamp);
        }

        public void AddUsageRecord(WaterUsage usage)
        {
            _repository.Add(usage);
        }

        public void DeleteUsageRecord(int id)
        {
            _repository.Delete(id);
        }
    }
}
