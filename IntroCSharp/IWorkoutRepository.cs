using IntroCSharp.Models;

namespace IntroCSharp
{
    public interface IWorkoutRepository
    {

        IEnumerable<Workout> GetWorkouts();
        void AddWorkout(Workout workout);
    }
}
