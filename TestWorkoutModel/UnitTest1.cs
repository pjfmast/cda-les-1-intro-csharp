using IntroCSharp.Models;
using System;
using Xunit;

namespace TestWorkoutModel
{
    public class UnitTest1
    {
        [Fact]
        public void Workout_ENdTime_ShouldReturn_11h45m() {
            // Arrange
            Workout workout = new Workout(
                "survival run",
                new DateTime(2022, 2, 3, 10, 0, 0),
                new TimeSpan(0, 105, 0)
                );

            // Act
            DateTime expected = new DateTime(2022, 2, 3, 11, 45, 0);
            DateTime actual = workout.EndTime;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}