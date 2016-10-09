using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour, IPickupable {

    public string m_name;
    public Sprite m_icon;
    public int m_quality;

    public void OnPickup()
    {

    }

    public void OnDrop()
    {

    }

}
