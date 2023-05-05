using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public override int Health
        {
            get { return base.Health + XP; }
            set { base.Health = value; }
        }

        public override float Cost => AttackPower + XP;

        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int movement, int health, int attackPower)
            : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            u.Health -= AttackPower;
            XP++;
        }
    }
}