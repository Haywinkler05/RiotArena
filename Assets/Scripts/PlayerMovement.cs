using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameObject player;
    private Vector3 direction;
    public float moveSpeed = 5f;
    [SerializeField] 
    private Rigidbody rb;
    [SerializeField]
    private GameObject move;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            
            if (Input.GetMouseButtonDown(0)) {
               direction = (move.transform.position - player.transform.position).normalized;   
               

            }
        }
    }
    void FixedUpdate()
    {
        if (direction != Vector3.zero)
        {
            rb.velocity = direction * moveSpeed;
           
            

        }
    }

}
