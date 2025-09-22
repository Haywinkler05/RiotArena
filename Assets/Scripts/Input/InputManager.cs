using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //Referencing the new input system
public class InputManager : MonoBehaviour
{
    private PlayerActions playeractions; //Collecting both the input map and our movements
    private PlayerActions.PlayerMovementActions movement;

    private PlayerMotor motor;
    // Start is called before the first frame update
    void Awake()
    {
        motor = GetComponent<PlayerMotor>();
        playeractions = new PlayerActions(); //Assigns both vars to a new instance of the class
        movement = playeractions.PlayerMovement;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        motor.processMove(movement.Movement.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        movement.Enable(); //Enables and disables the movement
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}
