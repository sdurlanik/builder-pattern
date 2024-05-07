using UnityEngine;

namespace SDurlanik.FluentBuilder
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            // fluent builder usage:

            var enemy = new Enemy.Builder()
                .SetName("Test Enemy")
                .SetHealth(1)
                .SetDamage(1)
                .SetIsAlive(true)
                .Build();
        }
    }
}