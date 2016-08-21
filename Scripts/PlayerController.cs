using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //Variables
    Vector3 velocity = Vector3.zero;
    public Vector3 gravity;
    public Vector3 flapVelocity;
    public float forwardSpeed =1f;
    public float maxSpeed = 5f;


    bool didFlap = false;
    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            didFlap = true;
            Flap();
        }
    }

    public void Flap()
    {
        didFlap = false;
        if (velocity.y < 0)
            velocity.y = 0;
        velocity += flapVelocity;
    }

    public void FixedUpdate()
    {
        velocity.x = forwardSpeed;
        velocity += gravity * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        float angle = 0;
        /*
        if (velocity.y < 0)
        {
            angle = Mathf.Lerp(0, -90, -velocity.y / maxSpeed);
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
        */
    }

}
