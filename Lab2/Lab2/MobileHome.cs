namespace Lab2
{
    public class MobileHome : Building, IMoveable
    {
        public MobileHome(int id, string name, int x, int y, bool built) : base(id, name, x, y, built)
        {
        }

        public void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}