﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Mitarbeiter_Polymorphie
{
    class Entwickler : Mitarbeter
    {
        public override int GetUrlaubstage(int alter, int Überstunden)
        {
            int AllgemeinUrlaubsanspruch = 26;
            if (alter < 18)
            {
                AllgemeinUrlaubsanspruch += 5;
            }
            else if (alter >= 30 || alter <= 40)
            {
                AllgemeinUrlaubsanspruch += 2;
            }
            else if (alter >= 40 || alter <= 50)
            {
                AllgemeinUrlaubsanspruch += 4;
            }
            else if (alter > 50)
            {
                AllgemeinUrlaubsanspruch += 6;
            }
            switch(Überstunden)
            {
                case 10:
                    AllgemeinUrlaubsanspruch += 1;
                    break;
                case 20:
                    AllgemeinUrlaubsanspruch += 2;
                    break;
                case 30:
                    AllgemeinUrlaubsanspruch += 3;
                    break;
                case 40:
                    AllgemeinUrlaubsanspruch += 4;
                    break;
                case 50:
                    AllgemeinUrlaubsanspruch += 5;
                    break;
            }

            return AllgemeinUrlaubsanspruch;
        }
    }
}
