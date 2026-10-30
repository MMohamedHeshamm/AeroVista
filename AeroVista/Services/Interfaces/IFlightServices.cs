using System;
using BusinessLogic.Models;

namespace AeroVista.Services.Interfaces;

public interface IFlightServices
{
    public Task NotifyDeletedFlightSubscribersAsync(Flight flightToDelete, IEnumerable<Ticket> ticketsToNotify);
}
