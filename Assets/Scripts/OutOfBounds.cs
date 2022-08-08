/*
 * Destroys bullets and food once the
 * pass through the camera limits to 
 * manage in-game clones.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float upperBound = 10f;
    private float lowerBound = -5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // check if out of bound
        if (transform.position.y > upperBound) Destroy(gameObject);
        else if (transform.position.y < lowerBound) Destroy(gameObject);
    }
}
