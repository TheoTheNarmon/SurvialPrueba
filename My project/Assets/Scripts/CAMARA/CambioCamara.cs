using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CambioCamara : MonoBehaviour
{
    public CinemachineVirtualCamera thirdPersonCamera;
    public CinemachineVirtualCamera firstPersonCamera;
    public GameObject jugador;
    public CharacterController Player;

    private void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        Player = jugador.GetComponent<CharacterController>();
    }
    void Update()
    {
        if (Input.GetMouseButton(1)) // Verifica si se mantiene presionado el clic derecho
        {
            // Activa la primera persona y desactiva la tercera persona
            firstPersonCamera.gameObject.SetActive(true);
            thirdPersonCamera.gameObject.SetActive(false);
            Player.enabled = false;
        }
        else
        {
            // Activa la tercera persona y desactiva la primera persona
            firstPersonCamera.gameObject.SetActive(false);
            thirdPersonCamera.gameObject.SetActive(true);
            Player.enabled = true;

        }
    }
}
