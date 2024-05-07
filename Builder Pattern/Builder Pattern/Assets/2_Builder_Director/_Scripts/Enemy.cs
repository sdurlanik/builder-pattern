using UnityEngine;

namespace SDurlanik.BuilderDirector
{
    public class Enemy : MonoBehaviour
    {
        public Weapon Weapon { get; set; }
        public Health Health { get; set; }
    }

    public class EnemyData // This class is used to store data for the enemy, can be scriptable object
    {
        public WeaponStats weaponStats;
    }
}