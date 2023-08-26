using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour { 

    public float MovimientoHorizontal;
    public float MovimientoVertical;
    public CharacterController Player;
    public float PlayerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();
        PlayerSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoHorizontal = Input.GetAxis("Horizontal");
        MovimientoVertical = Input.GetAxis("Vertical");

        Player.Move(new Vector3(MovimientoHorizontal, 0,  MovimientoVertical) * PlayerSpeed * Time.deltaTime);
    }
}
