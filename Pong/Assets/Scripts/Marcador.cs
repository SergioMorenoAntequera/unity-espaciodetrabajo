using UnityEngine.UI;
using UnityEngine;

public class Marcador : MonoBehaviour {

    private Collision collisionInfo;
    public Text texto;
	public Transform bola;
	bool dentro = false;
	int puntuacion = 0;
    private BallMovement ballMovement;

	// Update is called once per frame
	void Start()
    {
		texto.text = puntuacion.ToString();
    }

	void Update ()
    {
		if (ballMovement.OnCollisionEnter(collisionInfo) == 2)
        {
            Start();
            ballMovement.Start();
        }
	}
}
