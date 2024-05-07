using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SDurlanik.FluentBuilder
{
    public class Enemy : MonoBehaviour
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }
        public bool IsAlive { get; private set; }

        public class Builder
        {
            private readonly Enemy _enemy = new();

            public Builder SetName(string name)
            {
                _enemy.Name = name;
                return this;
            }

            public Builder SetHealth(int health)
            {
                _enemy.Health = health;
                return this;
            }

            public Builder SetDamage(int damage)
            {
                _enemy.Damage = damage;
                return this;
            }

            public Builder SetIsAlive(bool isAlive)
            {
                _enemy.IsAlive = isAlive;
                return this;
            }

            public Enemy Build()
            {
                var enemy = new GameObject("Enemy").AddComponent<Enemy>();
                enemy.Name = _enemy.Name;
                enemy.Health = _enemy.Health;
                enemy.Damage = _enemy.Damage;
                enemy.IsAlive = _enemy.IsAlive;
                return enemy;
            }
        }
    }
}