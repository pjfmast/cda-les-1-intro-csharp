// See https://aka.ms/new-console-template for more information
using IntroCSharp;

Console.WriteLine("All planned workouts outside");

var fakeRepo = new FakeWorkoutRepository();

var outside = fakeRepo
    .GetWorkouts()
    .Where(x => x.IsOutside ?? false);

foreach (var workout in outside) {
    Console.WriteLine($"{workout.Title} starts at {workout.StartTime}");
}