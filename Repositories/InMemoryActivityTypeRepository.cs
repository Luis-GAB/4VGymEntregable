using _4VGymEF.Models;

namespace _4VGymEF.Repositories {
    public class InMemoryActivityTypeRepository {
        private List<ActivityType> _activityTypes = new();
        private int _nextId = 1; // Para el autonumerico
        public InMemoryActivityTypeRepository() {
            SeedData(); // Precargamos algunos datos de prueba
        }

        private void SeedData()
        {
            _activityTypes = new List<ActivityType>()
            {
                new ActivityType (_nextId++, "BodyPump",  2 ),
                new ActivityType ( _nextId++, "Spinning",  1 ),
                new ActivityType { Id = _nextId++, Name = "Pilates", NumberMonitors = 1 }
            };
            _activityTypes.Add(new ActivityType(40, "CrossFit", 3));
        }

    }
}
