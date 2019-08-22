using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer spriteElement;

    public int hp;
    public float speed;
    public string type;
    
    private void Start()
    {
        spriteElement = gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
        

        //I should change it to identify it for the sprite
        if (spriteElement.sprite.name.Contains("Alien1"))
        {
            Debug.Log("Tipo numero uno");
            hp = 3;
            speed = 4;
            type = "Type number 1";
        }

        if (spriteElement.sprite.name.Contains("Alien2"))
        {
            Debug.Log("Tipo numero dos");
            hp = 30;
            speed = 40;
            type = "Type number 2";
        }
    }
}
