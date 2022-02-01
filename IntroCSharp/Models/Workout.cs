namespace IntroCSharp.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }

        // nullable value type:
        public bool? IsOutside { get; set; }

        // get-only calculated property:
        public DateTime EndTime { get { return StartTime + Duration; } }

        public Workout(string title, DateTime startTime, TimeSpan duration, decimal price = 0M) {
            Title = title;
            StartTime = startTime;
            Duration = duration;
            Price = price;
        }
    }
}
