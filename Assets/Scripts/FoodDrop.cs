/*
 * Randomizes the speed at which food
 * drops from the top of screen.
 * Note: negative values since the
 *       speed is adjusted using the
 *       y component.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDrop : MonoBehaviour
{
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1f, 15f) * -1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
