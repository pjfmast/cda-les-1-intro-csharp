using IntroCSharp.Models;

namespace IntroCSharp
{
    public class FakeWorkoutRepository : IWorkoutRepository
    {
        private List<Workout> _workouts = new List<Workout> {
            new Workout (
                "HIT",
                new DateTime(2022,2,3,21,0,0),
                new TimeSpan(0, 45, 0)
                ),

            new Workout (
                "Mountain bike",
                new DateTime(2022,2,5,12,0,0),
                new TimeSpan(1, 30, 0)
                ) {Price = 6M, IsOutside = true},

            new Workout (
                "Survival Run",
                new DateTime(2022,2,6,10,0,0),
                new TimeSpan(1, 30, 0)
                ) {Price = 6M, IsOutside = true}

        };

        // use expression body:
        public void AddWorkout(Workout workout) => _workouts.Add(workout);

        public IEnumerable<Workout> GetWorkouts() => _workouts;
    }
}
