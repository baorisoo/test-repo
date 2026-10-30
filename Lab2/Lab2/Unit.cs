namespace Lab2
{
    public abstract class Unit : GameObject
    {
        private float _hp;

        protected Unit(int id, string name, int x, int y, float hp) : base(id, name, x, y)
        {
            _hp = hp;
        }

        public bool IsAlive()
        {
            return _hp > 0;
        }

        public float GetHp()
        {
            return _hp;
        }

        public void ReceiveDamage(float damage)
        {
            _hp -= damage;
        }
    }
}