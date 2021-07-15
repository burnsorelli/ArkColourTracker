using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkColourTracker.Form1Results.Objects
{
    class Dino
    {
        public string Name;
        public string Type;
        public bool Male;
        public float Region0;
        public float Region1;
        public float Region2;
        public float Region3;
        public float Region4;
        public float Region5;
        public string Reg0Name;
        public string Reg1Name;
        public string Reg2Name;
        public string Reg3Name;
        public string Reg4Name;
        public string Reg5Name;
        public bool Reg0Active;
        public bool Reg1Active;
        public bool Reg2Active;
        public bool Reg3Active;
        public bool Reg4Active;
        public bool Reg5Active;


        public Dino(string _name, string _type, bool _gender, float _reg0, float _reg1,
            float _reg2, float _reg3, float _reg4, float _reg5, string _reg0Name, string _reg1Name,
            string _reg2Name, string _reg3Name, string _reg4Name, string _reg5Name)
        {
            Name = _name;
            Type = _type;
            Male = _gender;
            Region0 = _reg0;
            Region1 = _reg1;
            Region2 = _reg2;
            Region3 = _reg3;
            Region4 = _reg4;
            Region5 = _reg5;
            Reg0Name = _reg0Name;
            Reg1Name = _reg1Name;
            Reg2Name = _reg2Name;
            Reg3Name = _reg3Name;
            Reg4Name = _reg4Name;
            Reg5Name = _reg5Name;
            Reg0Active = false;
            Reg1Active = false;
            Reg2Active = false;
            Reg3Active = false;
            Reg4Active = false;
            Reg5Active = false;

            GetActive();
        }

        void GetActive()
        {
            if(Reg0Name != "")
            {
                Reg0Active = true;
            }
            if (Reg1Name != "")
            {
                Reg1Active = true;
            }
            if (Reg2Name != "")
            {
                Reg2Active = true;
            }
            if (Reg3Name != "")
            {
                Reg3Active = true;
            }
            if (Reg4Name != "")
            {
                Reg4Active = true;
            }
            if (Reg5Name != "")
            {
                Reg5Active = true;
            }
        }
    }
}
