using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    private Transform shootingPoint;
    private Rigidbody2D rb;
    public float _speed = 5f;
    private float timerToDestroy = 1f;

    //Everything related with the things that happens onces the sword is created
    //  1- Instantiating it
    //  2- Rotate it
    //  3- Destroying it
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //Here we find the shooting point transform
        shootingPoint = GameObject.Find("Player").transform.GetChild(1);
        //Here we stablish the spawning point as that one
        transform.localPosition = shootingPoint.position;
        //Here we stablish the rotation of the object so it is the same one as the cannon
        transform.rotation = shootingPoint.rotation;

        
    }

    // Here is where we will put everything related with the movement of the sword
    //  1- Move the swords
    //  2- Start the timer, manage it and destroy the sword
    void Update()
    {
        //What we do is to impulse the swoprd in the y direction bc it's facing it
        //Debug.Log(transform.localRotation.eulerAngles.z + " // " + transform.rotation.y); (nice try kid)
        transform.Translate(new Vector3(0, 10, 0) * _speed * Time.deltaTime);

        //Here we are gonna create a timer in order to destroy de sword 
        //so it dosent use memory when we cant see it (1 second pass)
        //We are also updating and cheking the timer
        if (timerToDestroy >= 0)
            timerToDestroy -= Time.deltaTime;
        else
            Destroy(gameObject);
    }

    //Here is where all the things related with the collision will appear
    //  1- Destroy de sword
    void OnTriggerEnter2D(Collider2D other)
    {
        //To avoid destroying the object at the beggining
        if (other.gameObject.name.Equals("Player"))
            return;

        //If it collides with an Alien
        if (other.gameObject.name.Contains("Alien"))
        {
            other.gameObject.GetComponent<Enemy>().hp--;
            Debug.Log("hp: " + other.gameObject.GetComponent<Enemy>().hp);
            if (other.gameObject.GetComponent<Enemy>().hp <= 0)
            {
                
                Destroy(other.gameObject);
                
            }
            
            //Rigidbody2D alienRb = other.gameObject.GetComponent<Rigidbody2D>();
            //alienRb.AddForce(new Vector2(100, 10));
        }

        Destroy(gameObject);
    }
}
