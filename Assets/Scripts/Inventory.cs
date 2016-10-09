using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory {

    static List<Item> items;



    List<Item> GetItems()
    {
        return items;
    }



    void RemoveItem(int id)
    {
        items.RemoveAt(id);
    }



    void AddItem(Item item)
    {
        items.Add(item);
    }
}
