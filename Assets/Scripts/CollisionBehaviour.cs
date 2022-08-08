/*
 * When objects collide, the
 * gameObjects will be destroyed.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // bullet hits food
        if ((other.CompareTag("GoodFood") || other.CompareTag("BadFood")) &&
            (gameObject.tag != "GoodFood" && gameObject.tag != "BadFood"))
        {
            Destroy(gameObject);
        }
        // food hits bullet
        else if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        // food hits player
        else if (other.CompareTag("Player"))
        {
            if (gameObject.CompareTag("GoodFood"))
            {
                gameManager.AddScore(5);
            }
            else
            {
                gameManager.LoseLife();
            }

            Destroy(gameObject);
        }
    }
}
