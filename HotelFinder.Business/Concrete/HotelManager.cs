using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
            return await Task.Run(() => _hotelRepository.GetAllHotels());
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            if (id > 0)
            {
                return await Task.Run(() => _hotelRepository.GetHotelById(id));
            }

            throw new Exception("Id cannot be less than 1.");
        }

        public Hotel GetHotelByName(string name)
        {
            if (name != null)
            {
                return _hotelRepository.GetHotelByName(name);
            }

            throw new Exception("Name field cannot be blank.");
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }
    }
}