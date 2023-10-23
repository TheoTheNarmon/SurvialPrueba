using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Item : MonoBehaviour
{

    public Sprite ItemIcon;
    public bool selected;
    
    public void addToInventory(Inventory inventario)
    {
        inventario.addObject(this);
    }

    public void activar()
    {
        selected = true;
        this.gameObject.SetActive(true);
    }
    public void desactivar()
    {
        selected = false;
        this.gameObject.SetActive(false);
    }

}
