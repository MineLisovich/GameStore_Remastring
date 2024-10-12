using GameStore.DAL.Entities.Dictionaries;

namespace GameStore.DAL.Predefined.Dictionaries
{
    public class PdGameLabels
    {
        public GameLabel pve = new() { Id = 1, Name = "PVE" };
        public GameLabel pvp = new() { Id = 2, Name = "PVP" };
        public GameLabel single = new() { Id = 3, Name = "Одиночная" };
        public GameLabel coop = new() { Id = 4, Name = "Co-op" };

        public List<GameLabel> Listlabels;

        public PdGameLabels() 
        {
            Listlabels = new()
            {
                pve, pvp, single, coop
            };
        }
    }
}
     
