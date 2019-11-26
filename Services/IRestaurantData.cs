using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.Services
{
    public interface IRestaurantData
    {
         IEnumerable<Restaurant> GetAll();
         Restaurant GetByID(int Id);
    }
}