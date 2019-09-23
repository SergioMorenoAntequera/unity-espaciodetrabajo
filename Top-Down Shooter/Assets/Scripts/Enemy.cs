﻿using System.Collections;
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
            hp = 1;
            speed = 5;
            type = "Type number 1";
        }

        if (spriteElement.sprite.name.Contains("Alien2"))
        {
            hp = 2;
            speed = 3;
            type = "Type number 2";
        }
    }
}
