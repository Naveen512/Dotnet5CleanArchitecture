using System.Collections.Generic;
using System.Linq;
using CleanArchitecture.Sample.Application.Contracts.Data;
using CleanArchitecture.Sample.Application.Contracts.Logics;
using CleanArchitecture.Sample.Application.DTOs;

namespace CleanArchitecture.Sample.Application.Logics
{
    public class GadgetLogic : IGadgetLogic
    {
        private readonly IMyWorldDbContext _myWorldDbContext;
        public GadgetLogic(IMyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        public List<GadgetDto> GetAll()
        {
            return _myWorldDbContext.Gadgets
            .Select(_ => new GadgetDto{
                Brand = _.Brand,
                Cost = _.Cost,
                Id = _.Id,
                ProductName = _.ProductName,
                Type = _.Type
            }).ToList();
        }
    }
}