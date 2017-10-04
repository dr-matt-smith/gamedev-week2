using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room {

    private int id; //each room has an id
    private int[] exits; //array of 1 and 0 to determine which exit is open
    private ArrayList items = new ArrayList(); //array of items in the room 

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public string GetItem(string itemReturn)
    {

        if (items.Contains(itemReturn) == true)
        {
            items.Remove(itemReturn);
            return itemReturn;
        }
        else {
            string itemNotFound = "item not found";
            return itemNotFound;
        } 
    }





}
