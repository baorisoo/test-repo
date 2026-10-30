namespace Lab2
{
    public class Archer : Unit, IAttacker, IMoveable
    {
        private float Damage = 10f;

        public Archer(int id, string name, int x, int y, float hp) : base(id, name, x, y, hp)
        {
        }

        public void Attack(Unit unit)
        {
            unit.ReceiveDamage(Damage);
        }

        public void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}