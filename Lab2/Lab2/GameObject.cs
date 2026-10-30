namespace Lab2
{
    public abstract class GameObject
    {
        private int _id;
        private string _name;
        protected int _x;
        protected int _y;

        protected GameObject(int id, string name, int x, int y)
        {
            _id = id;
            _name = name;
            _x = x;
            _y = y;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }
    }
}