using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4.0f;
    void Start()
    {
        transform.position = new Vector3(Random.Range(-9, 9), 7.55f, 0);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //damage player
            Player player = other.transform.GetComponent<Player>();

            if (player != null)
            {
                player.Damage();
            }

            Destroy(this.gameObject);
        }
        else if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }

        //if other is laser
        //destroy laser 
        //destroy us
    }
}
