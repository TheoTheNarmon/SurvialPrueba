using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject lightObject;
    public Transform playerModel;
    public KeyCode toggleKey = KeyCode.F;

    private bool isLightOn = false;

    private void Update()
    {
        // Encender o apagar la linterna al presionar la tecla asignada
        if (Input.GetKeyDown(toggleKey))
        {
            isLightOn = !isLightOn;
            lightObject.SetActive(isLightOn);
        }

        // Obtener la rotación del modelo del jugador
        Quaternion modelRotation = playerModel.rotation;

        // Rotar la linterna para que coincida con la rotación del modelo del jugador
        lightObject.transform.rotation = modelRotation;
    }
}
