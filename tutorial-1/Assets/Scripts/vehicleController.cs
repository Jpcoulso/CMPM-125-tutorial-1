using UnityEngine;
using UnityEngine.InputSystem;

public class vehicleController : MonoBehaviour
{
    float desired_acceleration;
    float desired_strafe;
    void OnMove(InputValue action)
    {
        var movement = action.Get<Vector2>();
        desired_acceleration = movement.y;
        desired_strafe = movement.x;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddRelativeForce(desired_acceleration*8, 0, 0);
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, -desired_strafe*8);
        //float dx = (Mouse.current.position.x.value - Screen.width / 2) / 200;
        //if (Mathf.Abs(dx) > 0.01f)
        //{
            //transform.Rotate(0, dx, 0);
        //}
    }
}
