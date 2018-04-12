using UnityEngine;

public class BallMovement : MonoBehaviour {

    public Transform transform;
    public Rigidbody rigidbody;
    public float velocidad = 1f;
    public float aceleracion = 0f;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0, 3, 0);
        GiveRandomDirection();
    }
	
	// Update is called once per frame
	void Update () {
        rigidbody.velocity += rigidbody.velocity * aceleracion * Time.deltaTime;
    }

    void GiveRandomDirection()
    {
        if (Random.Range(0, 2) == 1)
        {
            rigidbody.velocity += new Vector3(velocidad, velocidad, 0);
        }
        else
        {
             rigidbody.velocity += new Vector3(-velocidad, velocidad, 0);
        }
    }

    public void OnCollisionEnter(Collision colliderInfo)
    {
        if (colliderInfo.collider.tag == "Bloque")
        {
            var m = GameObject.FindObjectOfType<DestruirCubos>();
            m.Destruir();
        }
    }
}
