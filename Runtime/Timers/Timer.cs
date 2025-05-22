using System;

namespace Holypastry.Bakery
{
    /// <summary>
    /// Represents a timer that counts down from an initial time and triggers events when it starts, ends, or is paused/resumed.
    /// </summary>
    public abstract class Timer
    {
        protected float initialTime;
        protected float currentTime;
        /// <summary>
        /// Gets a value indicating whether the timer is currently running.
        /// </summary>
        public bool IsRunning { get; protected set; }

        /// <summary>
        /// Gets the current time of the timer.
        /// </summary>
        public float CurrentTime => currentTime;

        /// <summary>
        /// Gets the initial time of the timer.
        /// </summary>
        public float InitialTime => initialTime;

        /// <summary>
        /// Gets the progress of the timer as a value between 0 and 1.
        /// </summary>
        public float Progress => currentTime / initialTime;

        /// <summary>
        /// Event that is triggered when the timer ends.
        /// </summary>
        public Action OnTimerEnd = delegate { };
        /// <summary>
        /// Event that is triggered when the timer starts.
        /// </summary>
        public Action OnTimerStart = delegate { };

        protected Timer(float time)
        {
            initialTime = time;
            IsRunning = false;
        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        public void Start()
        {
            if (IsRunning)
                return;
            currentTime = initialTime;
            IsRunning = true;
            OnTimerStart.Invoke();
        }

        /// <summary>
        /// Stops the timer and resets the current time to zero.
        /// </summary>
        public void Stop()
        {
            if (!IsRunning)
                return;
            currentTime = 0;
            IsRunning = false;
            OnTimerEnd.Invoke();
        }

        /// <summary>
        /// Pauses the timer.
        /// </summary>
        public void Pause() => IsRunning = false;
        /// <summary>
        /// Resumes the timer, allowing it to continue running.
        /// </summary>
        public void Resume() => IsRunning = true;

        /// <summary>
        /// Call every frame to update the timer.
        /// </summary>
        /// <param name="deltaTime">The time elapsed since the last frame.</param>
        public abstract void Tick(float deltaTime);
    }

    /// <summary>
    /// Represents a countdown timer that counts down from a specified time.
    /// </summary>
    public class CountdownTimer : Timer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownTimer"/> class with the specified time.
        /// </summary>
        /// <param name="time">The time in seconds to count down from.</param>
        public CountdownTimer(float time) : base(time) { }

        /// <summary>
        /// Updates the timer by reducing the current time by the specified delta time.
        /// If the current time reaches or goes below zero, the timer is stopped.
        /// </summary>
        /// <param name="deltaTime">The time in seconds since the last update.</param>
        public override void Tick(float deltaTime)
        {
            if (!IsRunning)
                return;

            currentTime -= deltaTime;
            if (currentTime <= 0)
                Stop();
        }
    }

    //stopwatch timer
    public class CountUpTimer : Timer
    {
        public CountUpTimer() : base(0) { }

        public override void Tick(float deltaTime)
        {
            if (!IsRunning)
                return;

            currentTime += deltaTime;
        }
        /// <summary>
        /// Resets the timer by setting the current time to 0.
        /// </summary>
        public void Reset() => currentTime = 0;
        /// <summary>
        /// Gets the current time of the timer.
        /// </summary>
        /// <returns>The current time of the timer.</returns>
        public float GetTime() => currentTime;
    }
}