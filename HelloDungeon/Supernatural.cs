using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    internal class Supernatural
    {
        private float _suffering;
        private float _health;
        private float _strength;
        private string _name;

        public string GetName()
        {
            return _name;
        }

        public float GetHealth()
        {
            return _health;
        }

        public float GetStrength()
        {
            return _strength;
        }
    }
}
