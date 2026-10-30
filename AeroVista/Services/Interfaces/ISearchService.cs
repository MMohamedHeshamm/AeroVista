using System;
using System.Linq.Expressions;
using BusinessLogic.Models;
using AeroVista.DTO;

namespace AeroVista.Services.Interfaces;

public interface ISearchService
{
    public IEnumerable<FlightSortDTO> SortFlightsByUserPreference(IEnumerable<FlightSortDTO> flights, FlightPreference preference);
    public Expression<Func<T, bool>> BuildSearchExpression<T>(object dto);
}
