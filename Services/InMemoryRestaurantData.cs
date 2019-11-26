using System;
using System.Collections.Generic;
using System.Linq;
using SampleASPCore.Models;

namespace SampleASPCore.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;
        
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1, Name="Sate Klathak Pak Jeje", Image="/wwwroot/images/sate.jpg", Description="Sate klatak adalah sebuah hidangan sate kambing asal Kecamatan Pleret, Kabupaten ... Dalam bahasa Jawa, kegiatan membakar sate di pembakaran terbuka ..."},
                new Restaurant{Id=2, Name="Bakmi Jawa Mbah Hadi", Image="/wwwroot/images/miejawa.jpg", Description="Alamat: Jl. C. Simanjuntak No.1, Terban, Kec. Gondokusuman, Kota Yogyakarta, Daerah Istimewa Yogyakarta 55223 Jam buka: Tutup ⋅ Buka pukul 18.00 Telepon: 0812-2721-670"},
                new Restaurant{Id=3, Name="Soto Ayam Kadipiro", Image="/wwwroot/images/soto.jpg", Description="Warung soto Kadipiro yang pertama berdiri yakni sejak tahun 1928. ... Yang spesial di warung ini adalah hanya ayam kampung asli yang ..."}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Id);
        }

        public Restaurant GetByID(int Id)
        {
            var result = _restaurants.Where(r => r.Id == Id).SingleOrDefault();

            return result;
        }
    }
}