using System;
using UnityEngine;

namespace SDurlanik.BuilderDirector
{
    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            // builder director usage:

            var enemyData = new EnemyData();
            var enemyDirector = new EnemyDirector();

            var enemy = enemyDirector.Construct(new EnemyBuilder(), enemyData);
        }
    }
}