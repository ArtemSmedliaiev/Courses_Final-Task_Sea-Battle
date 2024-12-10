namespace Courses_Final_Task_Sea_Battle
{
    internal class Ship
    {
        private int length;
        private int x;
        private int y;
        private bool direction;

        public Ship(int length, int y, int x, bool direct)
        {
            this.length = length;
            this.x = x;
            this.y = y;
            this.direction = direct;
        }

        public int Length
        {
            get { return length; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public bool Direction
        {
            get { return direction; }
        }
    }
}
