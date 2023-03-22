using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregSharp.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;

        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }

        internal List<House> Find()
        {
            List<House> houses = _repo.FindAllHouses();
            return houses;
        }

        internal House Find(int id)
        {
            House house = _repo.FindOne(id);
            if(house == null) throw new Exception($"No House At Id: {id}");
            return house;
        }

        internal House Create(House houseData)
        {
            House house = _repo.Create(houseData);
            return house;
        }

        internal string Remove(int id)
        {
            House house = this.Find(id);
            bool result = _repo.Remove(id);
            if(!result) throw new Exception($"something horrible happened with {house.Title}");
            return $"delorted {house.Title}";
        }
        internal House Update(House updateData)
        {
            House original = this.Find(updateData.Id);
            original.Title = updateData.Title != null ? updateData.Title : original.Title;
            original.Floors = updateData.Floors != 0 ? updateData.Floors : original.Floors;
            original.Bedrooms = updateData.Bedrooms != 0 ? updateData.Bedrooms : original.Bedrooms;
            original.Bathrooms = updateData.Bathrooms != 0 ? updateData.Bathrooms : original.Bathrooms;
            original.SquareFt = updateData.SquareFt != 0 ? updateData.SquareFt : original.SquareFt;
            original.Price = updateData.Price != 0 ? updateData.Price : original.Price;
            original.Description = updateData.Description != null ? updateData.Description : original.Description;
            int rowsAffected = _repo.Updated(original);
            if(rowsAffected == 0)throw new Exception($"couldnt modify the house at id {updateData.Id}");
            if(rowsAffected > 1) throw new Exception($"something just broke, what did you do?? You made at least {rowsAffected} of houses. Check the DB NOW!!! OOPS!");
            return original;
        }
    }
}