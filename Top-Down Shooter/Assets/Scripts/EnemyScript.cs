using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour 
{
    private GameObject player;
    private Enemy properties;

    public Rigidbody2D rb;
    private bool firstAttack;
    private bool aux;
    public Vector3 posicionAAtacar = Vector3.zero;
    public float timeToAttack = 0f;
    public GameObject testThing;

    private void Start()
    {
        player = GameObject.Find("Player");
        properties = gameObject.GetComponent<Enemy>();

        if (properties.gameObject.GetComponent<Enemy>().type == "Type number 2")
        {
            firstAttack = true;
            rb = gameObject.GetComponent<Rigidbody2D>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcction = player.transform.localPosition - transform.localPosition;

        if (properties.gameObject.GetComponent<Enemy>().type == "Type number 1")
        {
            direcction = Vector3.Normalize(direcction);
            if (Vector3.Distance(transform.position, player.transform.localPosition) > 0.5)
            {
                this.gameObject.transform.Translate(direcction * properties.speed * Time.deltaTime);
            }
        }

        if (properties.gameObject.GetComponent<Enemy>().type == "Type number 2")
        {
            if (firstAttack)
            {
                rb.AddForce(-direcction * 1000f * Time.deltaTime);
                timeToAttack = 1f;

                firstAttack = false;
            }
            else
            {
                if (timeToAttack > 0.1f)
                {
                    timeToAttack -= Time.deltaTime;
                    if (timeToAttack < 0.1f)
                    {
                        aux = true;
                    }
                }
                else
                {
                    if (aux)
                    {
                        rb.velocity = Vector3.zero;
                        posicionAAtacar = player.transform.position;
                        
                        Debug.Log(rb.velocity);
                        aux = false;
                    }
                    else
                    {
                        rb.AddForce((posicionAAtacar - transform.position).normalized * 1000f * Time.deltaTime);
                        //Instantiate(testThing, posicionAAtacar, new Quaternion());

                        if (Vector3.Distance(posicionAAtacar, transform.position) <= 1)
                        {
                            rb.velocity = Vector3.zero;
                            firstAttack = true;
                            Debug.Log("4-HE LLEGAO");
                        }
                    }   
                }
            }            
        }
    }
}
