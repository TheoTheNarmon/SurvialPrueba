using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogosRakkun : MonoBehaviour
{
    public Canvas canvas;
    public DialogueScript dialogueScript; // Agrega una referencia al DialogueScript

    void Start()
    {
        // Desactiva el Canvas al iniciar
        canvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activa el Canvas al entrar en la TriggerZone
            canvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Desactiva el Canvas al salir de la TriggerZone
            canvas.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            // Llama al método StartDialogue del DialogueScript
            dialogueScript.StartDialogue();
        }
    }

   
}

