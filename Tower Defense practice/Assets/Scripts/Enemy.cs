using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;
    private Transform target;
    private int index = 0;

    void Start()
    {
        //Usamos la variable para ir cambiandola por el objetivos al que queremos ir
        target = WayPoints.points[index];
    }
	
	void Update ()
    {
        //Conseguiismos èl vector que queremso al restar de esta manera
        Vector3 direc = target.position - transform.position;
        //Creamso un vector unitario, le aplciamos la velocidad elegida y Time.dentaTime
        transform.Translate(direc.normalized * speed * Time.deltaTime);

        //Para cambiar el objetivo cuando es el mismo se cambia
        //No se pone que sean iguales ya que se pueden dar distintos fallos al llegar
        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }
    
    //Cuando está muy cerca cogemos el siguiente y a correr
    void GetNextWaypoint()
    {
        if (index >= WayPoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        index++;
        target = target = WayPoints.points[index];
    }
}
