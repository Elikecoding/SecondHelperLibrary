using SecondHelperLibrary.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ServiceClasses
{
    public static class BookingHelper
    {
        //This class will help me deal with overlapping bookings
        public static string OverlappingBooking(BookingModel booking)
        {
            //Remove bookings that are cancelled
            if (booking.Status == "Cancelled")
            {
                return string.Empty;
            }

            //Call my queryable list
            var unitOfWork = new UnitOfWork();
            var bookings =
                unitOfWork.Query<BookingModel>().Where(
                    b => b.Id != booking.Id && b.Status != "Cancelled"
                    );

            //Return my overlapping bookings 
            var overlappingBooking =
                bookings.FirstOrDefault(
                    b =>
                        booking.ArrivalTime >= b.ArrivalTime
                        && booking.ArrivalTime < b.LeavingTime
                        || booking.LeavingTime > b.ArrivalTime
                        && booking.LeavingTime >= b.LeavingTime);
            
            //Only return overlapping bookings
            return overlappingBooking == null ? string.Empty : overlappingBooking.Reference;

        }
    }

    //Turn my bookings into a queryable list
    public class UnitOfWork
    {
        public IQueryable<T> Query<T>()
        {
            return new List<T>().AsQueryable();
        }
    }
}

