using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public TimeSpan Duration
        {
            get
            {
                return _stopTime - _startTime;
            }
        }

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch has not been started");

            _stopTime = DateTime.Now;
            _isRunning = false;
        }
    }
}
