using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    // flags

    private float GRAVITY = -20;
    private Vector3 movement_direction = new Vector3();
    private Vector2 input_direction;
    private float movement_speed = 8;

    private Rigidbody2D RB2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        RB2D.linearVelocityX = movement_direction.x * movement_speed;
    }

    public void OnMove(InputValue value){
        Debug.Log(value);
        input_direction = value.Get<Vector2>();
       
        movement_direction.x = input_direction.x;    
        movement_direction.y = 0;
        movement_direction.z = 0;
        movement_direction = movement_direction.normalized;
       
    }
}
