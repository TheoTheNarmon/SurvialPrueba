using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueScript : MonoBehaviour
{
   
  public TextMeshProUGUI dialogueText;
 //lineas
   public string[] Lines;
 //velocidad
   public float textSpeed= 0.1f;
 //saber que linea estamos
   int index; 

    void Start()
    {
        dialogueText.text = string.Empty;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
       {
           if (dialogueText.text == Lines[index])
              {
                    NextLine();
              }
          else
              {
               StopAllCoroutines();
               dialogueText.text = Lines[index];
              }
      }
    }

    public void StartDialogue()
    {
        index = 0;

        StartCoroutine(WriteLine());
    }
    
  IEnumerator WriteLine()
{
    foreach (char letter in Lines[index].ToCharArray())
    {
        dialogueText.text += letter;

        yield return new WaitForSeconds(textSpeed);
    }

    // Asegurarse de que index no exceda la longitud del arreglo
    if (index < Lines.Length - 1)
    {
        index++;
        dialogueText.text = string.Empty;
        StartCoroutine(WriteLine());
    }
}


public void NextLine()
{
    if (index< Lines.Length -1)
    {
      index++;
      dialogueText.text = string.Empty;
      StartCoroutine(WriteLine());
    }
    else
    {
       gameObject.SetActive(false);
    }
}



}
