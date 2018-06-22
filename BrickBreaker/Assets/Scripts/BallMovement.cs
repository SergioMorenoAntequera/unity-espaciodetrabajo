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
        rigidbody.velocity = Vector3.zero;
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
        //Para que rompa los bloques
        if (colliderInfo.collider.tag == "Bloque")
        {
            var m = GameObject.FindObjectOfType<DestruirCubos>();
            m.Destruir(colliderInfo.collider.name);
        }

        //Para perder al tocar el suelo
        if (colliderInfo.collider.name == "Suelo")
        {
            Start();
        }
    }
}
