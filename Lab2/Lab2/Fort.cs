namespace Lab2
{
    public class Fort : Building, IAttacker
    {
        private float Damage = 30f;

        public Fort(int id, string name, int x, int y, bool built) : base(id, name, x, y, built)
        {
        }

        public void Attack(Unit unit)
        {
            unit.ReceiveDamage(Damage);
        }
    }
}