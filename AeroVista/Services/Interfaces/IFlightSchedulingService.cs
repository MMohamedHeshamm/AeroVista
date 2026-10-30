using BusinessLogic.Models;
using System;

namespace AeroVista.Services;

public interface IFlightSchedulingService
{
    
    public Task<IEnumerable<DateTime>> GetAvailableFlightTimeScheduleAsync(string airport, DateTime targetDate);
    public Task DeleteFlightTimeScheduleAsync(Flight f);

}
