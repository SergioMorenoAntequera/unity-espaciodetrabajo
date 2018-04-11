using UnityEngine.UI;
using UnityEngine;

public class Marcador : MonoBehaviour
{
    //private Collision collisionInfo;
    public Text texto;
	//public Transform bola;
	int puntuacion = 0;
    //private BallMovement ballMovement;

	// Update is called once per frame
	void Start()
    {
		texto.text = puntuacion.ToString();
    }

    public void add()
    {
        puntuacion++;
        texto.text = puntuacion.ToString();
    }
}
