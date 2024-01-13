using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> inventario = new List<Item>();
    public int selected;
    public KeyCode toggleKey = KeyCode.Q;
    public Item vacio;
    public Item Flashlight;
    public Image imagen;

    public void addObject(Item item)
    {
        inventario.Add(item);
    }
    public void removeObject(Item item)
    {
        inventario.Remove(item);
    }

    void Start()
    {
        imagen = GameObject.Find("ItemSelected").GetComponent<Image>();
        vacio.activar();
        addObject(vacio);
        addObject(Flashlight);

        selected = 0;
        imagen.sprite = inventario[selected].ItemIcon;
        Debug.Log(inventario.Count);
        Debug.Log(inventario[selected]);
    }
    private void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (inventario.Count > selected + 1)
            {
                inventario[selected].desactivar();
                selected++;
                inventario[selected].activar();
                imagen.sprite = inventario[selected].ItemIcon;
            }
            else if (inventario.Count <= selected + 1)
            {
                inventario[selected].desactivar();
                selected = 0;
                inventario[selected].activar();
                imagen.sprite = inventario[selected].ItemIcon;
            }
        }
        
        if (inventario[selected] == null)
        {
            removeObject(inventario[selected]);
            selected = 0;
            inventario[selected].activar();
            imagen.sprite = inventario[selected].ItemIcon;
        }

    }

}
