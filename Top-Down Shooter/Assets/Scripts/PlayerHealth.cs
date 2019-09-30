using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private SpriteRenderer _cannonSprite;

    private float _hp = 3;
    private bool _canGetHurted = true;
    private float _timer = 2f;
    private float _maxTimer = 2f;


    // Start is called before the first frame update
    void Start()
    {
        _cannonSprite = transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Here out character cant recieve damage
        // 1- Run the timer to remove the invencivility
        // 2- Make him invincible
        // 3- Make the sprite blink
        if (!_canGetHurted && _timer > 0)
        {
            _timer = Time.deltaTime;
            if (_timer < 2f && _timer > 1.5f || _timer < 1f && _timer > 0.5f)
            {
                _cannonSprite.enabled = false;
            }

            if (_timer < 1.5f && _timer > 1f || _timer < 0.5f && _timer > 0f)
            {
                _cannonSprite.enabled = true;
            }

        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the player collides with an alien and can be hurted we start the invincibility
        if (collision.collider.gameObject.name.Contains("Alien") && _canGetHurted)
        {
            _timer = _maxTimer;
            _canGetHurted = false;
        }
    }
}
