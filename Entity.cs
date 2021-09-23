using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeonExpanded
{
    class Entity
    {
        private string _name;
        private float _health;

        public string Name
        {
            get { return _name; }
        }

        public float Health
        {
            get { return _health; }
        }

        public Entity()
        {
            _name = "None";
            _health = 0;
        }

        public Entity(string name, float health)
        {
            _name = name;
            _health = health;
        }
    }
}
