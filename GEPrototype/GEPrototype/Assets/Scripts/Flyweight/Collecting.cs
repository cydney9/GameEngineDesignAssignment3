using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collecting: MonoBehaviour { 
        List<Item> allItem = new List<Item>();
        List<Vector2> red;
        List<Vector2> green;
        List<Vector2> blue;
        void Start()
        {
            //List used when flyweight is enabled
            red = GetPos();
            green = GetPos();
            blue = GetPos();

            
            for (int i = 0; i < 2; i++)
            {
                Item newItem = new Item();

                //With flyweight
                newItem.red = red;
                newItem.green = green;
                newItem.blue = blue;

                allItem.Add(newItem);
            }
        }


        //Generate a list with body part positions
        List<Vector2> GetPos()
        {
            //Create a new list
            List<Vector2> pos = new List<Vector2>();

            //Add body part positions to the list
            for (int i = 0; i < 2; i++)
            {
                pos.Add(new Vector2());
            }

            return pos;
        }


    }
