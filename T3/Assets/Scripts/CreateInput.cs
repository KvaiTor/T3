using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class CreateInput : MonoBehaviour
    {
        Ray ray;
        public GameObject[] spriteRenderer, Menu;
        public List<int> idItemActiv = new List<int>();
        public static GameObject obj;
        public static int _menuId;
        private bool _act, _menuSelect;

        void Start()
        {
            _menuId = 0;
        }

        void Update()
        {
            ClickLayer();
        }

        private void ClickLayer()
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 20))
            {

                if (hit.collider.name == "sky")
                {
                    _menuId = 0;
                    _menuSelect = true;
                }
                else if (hit.collider.name == "sea")
                {
                    _menuId = 1;
                    _menuSelect = true;
                }
                else if (hit.collider.name == "bich")
                {
                    _menuId = 2;
                    _menuSelect = true;
                }
                else
                {
                    _menuSelect = false;
                }

                Local();
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    if (_act && _menuSelect)
                    {
                        obj = Instantiate(spriteRenderer[Game.SelectObject.id],
                            new Vector3(hit.point.x, hit.point.y, 0), Quaternion.identity) as GameObject;
                        Game.limitations.LimitSky();
                        idItemActiv.Add(Game.SelectObject.id);
                    }
                }

                ForMenuid();
            }
           
        }
        private void ForMenuid()
        {
            for (int i = 0; i <= Menu.Length; i++)
            {
                if (i != _menuId)
                    Menu[i].SetActive(false);
                else
                    Menu[i].SetActive(true);
            }
        }
        private void Local()
        {
            if (_menuId == 0 && Game.SelectObject.id <= 6)
            {
                _act = true;
            }
            else if (_menuId == 1 && Game.SelectObject.id > 6 && Game.SelectObject.id < 10)
            {
                _act = true;
            }
            else if (_menuId == 2 && Game.SelectObject.id > 9 && Game.SelectObject.id < 14)
            {
                _act = true;
            }
            else
                _act = false;

        }
    }
}