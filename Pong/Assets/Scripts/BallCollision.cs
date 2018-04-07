using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        Debug.Log(rb.velocity);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "RightP")
        {
            rb.AddForce(rb.velocity*2f);
        }
        if(collisionInfo.collider.name == "LeftP")
        {
            rb.AddForce(rb.velocity * 2f);
        }

    }
}
