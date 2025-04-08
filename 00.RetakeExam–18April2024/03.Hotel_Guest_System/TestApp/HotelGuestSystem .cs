using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp;

public class HotelGuestSystem
{
    private List<string> guests;

    public HotelGuestSystem()
    {
        guests = new List<string>();
    }

    public int GuestsCount { get => guests.Count; }

    public void RegisterGuest(string guestName)
    {
        if (string.IsNullOrWhiteSpace(guestName))
        {
            throw new ArgumentException("Guest name cannot be empty or whitespace.");
        }

        guests.Add(guestName);
    }

    public void RemoveGuest(string guestName)
    {
        if (!guests.Contains(guestName))
        {
            throw new ArgumentException("Guest not found in the system.");
        }

        guests.Remove(guestName);
    }

    public List<string> GetAllGuests()
    {
        return guests;
    }
}

