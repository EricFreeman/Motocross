using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        var MaxSpeed = 500;
        var Acceleration = 25;

        if (Input.GetKey(KeyCode.D))
        {
            if(rigidbody.velocity.x < MaxSpeed)
                transform.rigidbody.AddForce(Acceleration, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (rigidbody.velocity.x > -MaxSpeed)
                transform.rigidbody.AddForce(-Acceleration, 0, 0);
        }
    }
}