using UnityEngine;
using System.Collections;

namespace Weapons
{
    public class Weapon : MonoBehaviour
    {
        private int level;
        //public Ability[] abilities;
        private int basicDamage;
        private int speed;
        private int strength;
        private int intellect;
        private int willpower;

        public Weapon()
        {
            level = 1;
            basicDamage = 10;
        }

        private void levelUp()
        {
            level++;
        }
        private void increaseSpeed(int speedIncrease)
        {
            speed += speedIncrease;
        }
        private void increaseStrength(int strengthIncrease)
        {
            strength += strengthIncrease;
        }
        private void increaseIntellect(int intellectIncrease)
        {
            intellect += intellectIncrease;
        }
        private void increaseWillpower(int willpowerIncrease)
        {
            willpower += willpowerIncrease;
        }

    }
}