using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogosRakkun : MonoBehaviour
{
    public Canvas IconeCanvas;
    public Canvas DialogueCanvas;
    public DialogueScript dialogueScript; // Agrega una referencia al DialogueScript
    public string[] Lines;
    private bool dialogue = false;

    void Start()
    {
        // Desactiva el Canvas al iniciar
        IconeCanvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activa el Canvas al entrar en la TriggerZone
            dialogue = false;
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
            // Llama al método StartDialogue del DialogueScript
            if (!dialogue)
            {
                dialogue = true;
                IconeCanvas.gameObject.SetActive(false);
                DialogueCanvas.gameObject.SetActive(true);
                dialogueScript.setLine(Lines);
                dialogueScript.StartDialogue();
            }
        }
    }

   
}

