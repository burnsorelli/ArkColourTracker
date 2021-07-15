using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArkColourTracker.Form1Results;

namespace ArkColourTracker.Form1Results.Objects
{
    class Vulture
    {
        public string Name;
        public int ID;
        public bool Male;
        public float Body;
        public float Head;
        public float Face;
        public float Tips;

        public Vulture(string _name, int _id, bool _gender, float _body, float _head, float _face, float _tips)
        {
            Name = _name;
            ID = _id;
            Male = _gender;
            Body = _body;
            Head = _head;
            Face = _face;
            Tips = _tips;
        }
    }
}
