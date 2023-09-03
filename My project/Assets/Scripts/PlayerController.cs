using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour { 

    public float MovimientoHorizontal;
    public float MovimientoVertical;
    public CharacterController Player;
    public float PlayerSpeed;
    public Vector3 MovePlayer;

    public Camera MainCamera;
    private Vector3 CamForward;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
        PlayerSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoHorizontal = Input.GetAxis("Horizontal");
        MovimientoVertical = Input.GetAxis("Vertical");

        if (MovimientoHorizontal > 0)
        {
            transform.Rotate(new Vector3(0f, 10f * Time.deltaTime * PlayerSpeed, 0f));
        }
        if (MovimientoHorizontal < 0)
        {
            transform.Rotate(new Vector3(0f, -10f * Time.deltaTime * PlayerSpeed, 0f));
        }

        CamDirection();
        MovePlayer = CamForward * MovimientoVertical;

        Player.Move(MovePlayer * PlayerSpeed * Time.deltaTime);
    }

    void CamDirection()
    {
        CamForward = MainCamera.transform.forward; 
        CamForward.y = 0f;
        CamForward = CamForward.normalized;
    }
}
