using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class limitations : MonoBehaviour
    {
        public static int num, num_2, num_3;
        public static List<GameObject> obj = new List<GameObject>();
        public static List<GameObject> obj_2 = new List<GameObject>();
        public static List<GameObject> obj_3 = new List<GameObject>();

        public static void LimitSky()
        {
            if (Game.CreateInput._menuId == 0)
            {
                num++;
                obj.Add(Game.CreateInput.obj);
                if (num > 5)
                {
                    Destroy(obj[0]);
                    obj.RemoveAt(0);
                    num = 5;
                }
            }
            else if (Game.CreateInput._menuId == 1)
            {
                num_2++;
                obj_2.Add(Game.CreateInput.obj);
                if (num_2 > 5)
                {
                    Destroy(obj_2[0]);
                    obj_2.RemoveAt(0);
                    num_2 = 5;
                }
            }
            else if (Game.CreateInput._menuId == 2)
            {
                num_3++;
                obj_3.Add(Game.CreateInput.obj);
                if (num_3 > 5)
                {
                    Destroy(obj_3[0]);
                    obj_3.RemoveAt(0);
                    num_3 = 5;
                }
            }


        }

    }
}
