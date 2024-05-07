using UnityEngine;

namespace SDurlanik.BuilderDirector
{
    public class EnemyDirector
    {
        public Enemy Construct(EnemyBuilder builder, EnemyData data)
        {
            builder.AddWeaponComponent();
            builder.AddHealthComponent();
            builder.SetWeaponStats(data.weaponStats);

            return builder.Build();
        }
    }

    public class EnemyBuilder
    {
        Enemy enemy = new GameObject("Enemy").AddComponent<Enemy>();

        public void AddWeaponComponent()
        {
            enemy.Weapon = new GameObject("Weapon").AddComponent<Weapon>();
        }

        public void AddHealthComponent()
        {
            enemy.Health = new GameObject("Health").AddComponent<Health>();
        }

        public void SetWeaponStats(WeaponStats stats)
        {
            if (enemy.gameObject.TryGetComponent<Weapon>(out Weapon weapon))
            {
                weapon.SetWeaponStats(stats);
            }
        }

        public Enemy Build()
        {
            Enemy builtEnemy = enemy;
            enemy = new GameObject("Enemy").AddComponent<Enemy>();

            return builtEnemy;
        }
    }
}