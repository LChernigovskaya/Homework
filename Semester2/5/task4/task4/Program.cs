using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var cursor = new Cursor();

            eventLoop.LeftHandler += cursor.OnLeft;
            eventLoop.RightHandler += cursor.OnRight;
            eventLoop.UpHandler += cursor.OnUp;
            eventLoop.DownHandler += cursor.OnDown;

            eventLoop.Run();
        }
    }
}
