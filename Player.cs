using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeonExpanded
{
    class Player : Entity
    {
        private float _sanity;
        private float _infection;

        public float Sanity
        {
            get { return _sanity; }
        }

        public float Infection
        {
            get { return _infection; }
        }
    }
}
