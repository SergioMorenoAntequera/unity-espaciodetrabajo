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
        //transform.Translate(player.transform.localPosition * Time.deltaTime * properties.speed);
    }
}
