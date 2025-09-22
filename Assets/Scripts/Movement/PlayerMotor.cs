using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controller; //Calls the character controller
    [Header("Player movement settings")]
    [SerializeField] private float speed = 2f; //Player move speed
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); //Assigns the character controller
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void processMove(Vector2 input) //Moves the player based on the input
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection *  speed * Time.deltaTime));
    }
}
