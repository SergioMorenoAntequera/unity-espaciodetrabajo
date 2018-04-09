using UnityEngine.UI;
using UnityEngine;

public class FIN : MonoBehaviour {

	public Text textIzq;
	public Text textoDer;
	public Text won;
	public GameObject bola;
	
	// Update is called once per frame
	void Update () {
		if (textIzq.text == "1") {
			textIzq.enabled = false;
			textoDer.enabled = false;
			won.enabled = true;
			bola.SetActive(false);
			won.text = "¡Player1 gana!";

		}

		if (textoDer.text == "1") {
			textIzq.enabled = false;
			textoDer.enabled = false;
			won.enabled = true;
			bola.SetActive(false);
			won.text = "¡Player2 gana!";
		}
	}
}
