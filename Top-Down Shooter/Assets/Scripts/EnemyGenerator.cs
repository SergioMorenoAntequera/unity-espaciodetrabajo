using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    private GameObject player;
    public GameObject enemyType1, enemyType2;
    private float _distanceX = 25f, _distanceY = 10f;
    private float timer = 0, maxTimer = 2f;
    private bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //HEre we are going to spawn the enemy
        //1- Get the position
        //2- Assign the coordinates depending of the position 
        

        if (canSpawn)
        {
            float position = Random.Range(0, 4); //0 up, 1 right, 2 down, 3 left
            float _xToSpawn = 0, _yToSpawn = 0;
            float _xRandom = Random.Range(player.transform.position.x - _distanceX, player.transform.position.x + _distanceX);
            float _yRandom = Random.Range(player.transform.position.y - _distanceY, player.transform.position.y + _distanceY);

            if (position == 0) {
                _xToSpawn = _xRandom;
                _yToSpawn = player.transform.position.y + _distanceY;
            } else if (position == 1) {
                _xToSpawn = player.transform.position.x + _distanceX;
                _yToSpawn = _yRandom;
            } else if (position == 2) {
                _xToSpawn = _xRandom;
                _yToSpawn = player.transform.position.y - _distanceY;
            } else if (position == 3) {
                _xToSpawn = player.transform.position.x - _distanceX;
                _yToSpawn = _yRandom;
            }

            //We randomly generate enemies 
            if (Random.Range(0,5) < 3)
            {
                GameObject.Instantiate(enemyType1, new Vector3(_xToSpawn, _yToSpawn, 0), new Quaternion());
            } else {
                GameObject.Instantiate(enemyType2, new Vector3(_xToSpawn, _yToSpawn, 0), new Quaternion());
            }
            

            canSpawn = false;
            if(maxTimer > 0.5f)
                maxTimer -= 0.1f;
            timer = maxTimer;

        } else {

            if (timer > 0)
            {
                timer -= Time.deltaTime;
            } else {
                canSpawn = true;
            }
        }
    }
}
