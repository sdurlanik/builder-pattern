using UnityEngine;

namespace SDurlanik.BuilderDirector
{
    public class Weapon : MonoBehaviour
    {
        public WeaponStats Stats { get; private set; }

        public void SetWeaponStats(WeaponStats stats)
        {
            Stats = stats;
        }
    }

    public class WeaponStats
    {
        public int Damage { get; set; }
        public float Range { get; set; }

        public WeaponStats()
        {
            Damage = 10;
            Range = 5f;
        }
    }
}