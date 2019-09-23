using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour 
{
    GameObject player;
    Enemy properties;

    private void Start()
    {
        player = GameObject.Find("Player");
        properties = gameObject.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcction = player.transform.localPosition - transform.localPosition;
        direcction = Vector3.Normalize(direcction);

        this.gameObject.transform.Translate(direcction * properties.speed * Time.deltaTime);
    }
}
