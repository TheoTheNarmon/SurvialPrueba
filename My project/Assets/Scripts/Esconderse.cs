using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esconderse : MonoBehaviour
{
    [SerializeField]
    public Transform dentro, fuera;
    [SerializeField]
    private float tiempo;

    public GameObject Player;

    public bool entra;
    private bool sale;

    Transform playerT;
    public Canvas IconeCanvas;


    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerT = Player.GetComponent<Transform>();
    }

    private void Update()
    {
        if (entra == true) {
            playerT.position = Vector3.Lerp(playerT.position, dentro.position, tiempo * Time.deltaTime);
            playerT.rotation = Quaternion.Lerp(playerT.rotation, dentro.rotation, tiempo * Time.deltaTime);

            //se sale del escondite con espacio para que no se bugee con el collider
            if(Input.GetKeyDown(KeyCode.Space)) {
                entra = false;
                sale = true;
            }
        }
        if (sale == true)
        {
            playerT.position = Vector3.Lerp(playerT.position, fuera.position, tiempo * Time.deltaTime);
            playerT.rotation = Quaternion.Lerp(playerT.rotation, fuera.rotation, tiempo * Time.deltaTime);
            StartCoroutine(finEscondite());
        }

       
    }

    IEnumerator finEscondite()
    {
        yield return new WaitForSeconds(2);
        sale = false;
    }

    //que se active el escondite con la E

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activa el Canvas al entrar en la TriggerZone
            IconeCanvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Desactiva el Canvas al salir de la TriggerZone
            IconeCanvas.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            entra = true;
        }
    }
}
