using System.Collections.Generic;
using CleanArchitecture.Sample.Application.DTOs;

namespace CleanArchitecture.Sample.Application.Contracts.Logics
{
    public interface IGadgetLogic
    {
        List<GadgetDto> GetAll();

    }
}