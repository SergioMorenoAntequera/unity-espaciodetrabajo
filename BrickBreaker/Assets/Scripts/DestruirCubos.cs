using UnityEngine;

public class DestruirCubos : MonoBehaviour {
	
    Collision colliderInfo;

    // Update is called once per frame

    

    public void Destruir()
    {
        /*var m = GameObject.FindObjectOfType<BallMovement>();
        m.OnCollisionEnter(colliderInfo);
        var aDestruir = colliderInfo.collider.gameObject;*/

        Destroy(gameObject);
    }
}
