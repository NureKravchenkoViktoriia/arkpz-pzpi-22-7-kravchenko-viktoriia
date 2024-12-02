using System.Collections.Generic;
using AquaTrack.Data.Models;
using AquaTrack.Repositories;

namespace AquaTrack.Services
{
    public class LimitService
    {
        private readonly IRepository<Limit> _repository;

        public LimitService(IRepository<Limit> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Limit> GetAllLimits()
        {
            return _repository.GetAll();
        }

        public Limit GetLimitById(int id)
        {
            return _repository.GetById(id);
        }

        public void CreateLimit(Limit limit)
        {
            _repository.Add(limit);
        }

        public void UpdateLimit(Limit limit)
        {
            _repository.Update(limit);
        }

        public void DeleteLimit(int id)
        {
            _repository.Delete(id);
        }
    }
}
