using UnityEngine;

public class Player : MonoBehaviour {

    public Transform transform;
    public float velocity = 0.15f;
    public KeyCode Arriba;
    public KeyCode Abajo;

    // Update is called once per frame
    void Update () {
        if(transform.position.y <= 6.5 && transform.position.y >= -6.5)
        {
            if (Input.GetKey(Arriba))
            {
                transform.Translate(new Vector3(0, velocity, 0));
            }
            if (Input.GetKey(Abajo))
            {
                transform.Translate(new Vector3(0, -velocity, 0));
            }
        } else
        {
            if (transform.position.y < 6.5)
            {
                transform.Translate(new Vector3(0, velocity, 0));
            }
            if (transform.position.y > 6.5)
            {
                transform.Translate(new Vector3(0, -velocity, 0));
            }
        }
        
    }
}
