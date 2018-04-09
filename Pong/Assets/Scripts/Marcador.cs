using UnityEngine.UI;
using UnityEngine;

public class Marcador : MonoBehaviour {

	public Text texto;
	public Transform bola;
	bool dentro = false;
	int puntuacion = 0;

	// Update is called once per frame
	void Start() {
		texto.text = ""+puntuacion;
		dentro = false;
	}

	void Update () {
		if (bola.position.x < -21f && !dentro){
			puntuacion++;
			dentro = true;
		}

		if (dentro) {
			Invoke ("Start", 0.2f);
		}
	}
}
