using UnityEngine;
using System.Collections;

namespace Weapons
{
    public class Ability
    {

        private int damage;
        private int level;
        private string name;
        public int tier;
        private bool unlocked;
        public Ability()
        {
            unlocked = false;
            level = 1;
            damage = 10;
        }
        public Ability(string name)
        {
            this.name = name;
            level = 1;
            unlocked = false;
            damage = 10;
        }
        public void upgrade()
        {
            tier++;
            level++;
            damage += 10;
        }
        public void unlock()
        {
            unlocked = true;
        }
    }
}
