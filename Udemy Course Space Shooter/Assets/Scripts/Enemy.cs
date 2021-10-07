using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4.0f;
    void Start()
    {
        transform.position = new Vector3(0, 7.55f, 0);
    }

    void Update()
    {
        //Move down 4m a sec
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime);

        //if bottom of screen
        //respawn at top with random x position

        if (transform.position.y <= -5.5)
        {
            transform.position = new Vector3(Random.Range(-10, 10), 7.55f, 0);
        }
    }
}
