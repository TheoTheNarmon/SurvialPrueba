using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveObject : MonoBehaviour
{
    public Inventory inventario;
    public Item item1;
    private Item item2;
    public GameObject objeto2;
    public bool giving;

    private void Start()
    {
        objeto2 = null;
        giving = false;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            if (!giving)
            {
                giving = true;
                objeto2 = Instantiate(item1.gameObject);
                inventario.addObject(objeto2.GetComponent<Item>());
                StartCoroutine(givingtrue());
            }
        }
    }

    IEnumerator givingtrue()
    {
        yield return new WaitForSeconds(1);
        giving = false;
    }


}
