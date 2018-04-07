using UnityEngine;

public class PlayerColision : MonoBehaviour {

    public PlayerMovement movement;
    public Transform transform;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

        }
    }

   

}
