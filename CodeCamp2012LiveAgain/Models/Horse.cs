using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeCamp2012LiveAgain.Models
{


    public class Horse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }

    }


    public class HorseRepository
    {
        private IList<Horse> horses;
        private int nextID;

        public HorseRepository()
        {
            horses = new List<Horse>();
            horses.Add(new Horse { Id = 1, Name = "Steve Suing", Weight = 8540m, });
            horses.Add(new Horse { Id = 2, Name = "Kane Croft", Weight = 34m, });
            horses.Add(new Horse { Id = 3, Name = "Bob Harris", Weight = 2m, });
            horses.Add(new Horse { Id = 4, Name = "John Smith", Weight = 5065m, });
            nextID = horses.Count + 1;

        }

        public void Update(Horse updatedEntity)
        {
            var player = this.Get(updatedEntity.Id);
            player.Name = updatedEntity.Name;
            player.Weight = updatedEntity.Weight;

        }

        public List<Horse> GetAll()
        {
            return horses.ToList();
        }

        public Horse Get(int id)
        {
            return horses.SingleOrDefault(c => c.Id == id);
        }

        public void Post(Horse player)
        {
            player.Id = nextID;
            horses.Add(player);
        }

        public void Delete(int id)
        {
            var player = this.Get(id);
            horses.Remove(player);
        }

    }

}