namespace Lab2
{
    public abstract class Building : GameObject
    {
        private bool _built;

        protected Building(int id, string name, int x, int y, bool built) : base(id, name, x, y)
        {
            _built = built;
        }

        public bool IsBuilt()
        {
            return _built;
        }
    }
}