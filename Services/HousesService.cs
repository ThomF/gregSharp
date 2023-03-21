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
    }
}