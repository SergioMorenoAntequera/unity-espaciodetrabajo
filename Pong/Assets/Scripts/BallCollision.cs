using UnityEngine;

public class BallCollision : MonoBehaviour {

	public BallMovement movimiento;

	void OnCollisionEnter (Collision collisionInfo){
		if (collisionInfo.collider.name == ("Decoracion3-ParedDer")) {
			movimiento.Invoke("BallMovement", 0);
		}
	}
}
