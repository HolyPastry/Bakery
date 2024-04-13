using System;

namespace Holypastry.Bakery
{
    public abstract class Timer
    {
        protected float initialTime;
        protected float currentTime;
        public bool IsRunning { get; protected set; }

        public float CurrentTime => currentTime;

        public float Progress => currentTime / initialTime;

        public Action OnTimerEnd = delegate { };
        public Action OnTimerStart = delegate { };

        protected Timer(float time)
        {
            initialTime = time;
            IsRunning = false;
        }

        public void Start()
        {
            if (IsRunning)
                return;
            currentTime = initialTime;
            IsRunning = true;
            OnTimerStart.Invoke();
        }

        public void Stop()
        {
            if (!IsRunning)
                return;
            currentTime = 0;
            IsRunning = false;
            OnTimerEnd.Invoke();
        }

        public void Pause() => IsRunning = false;
        public void Resume() => IsRunning = true;

        public abstract void Tick(float deltaTime);
    }

    public class CountdownTimer : Timer
    {
        public CountdownTimer(float time) : base(time) { }

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
        public void Reset() => currentTime = 0;
        public float GetTime() => currentTime;
    }
}