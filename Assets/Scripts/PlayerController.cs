/*
 * Script for player control. Uses float
 * constraints to keep player movement in 
 * one area. Controls are based on keyboard
 * inputs in ver 1.
 *   
 * To do:  1: add gamecontroller support using plug-in
 *         2: add projectile launching DONE 7.27.21
 *   
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 8f;

    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    // Update is called once per frame
    void Update()
    {
        // x-range constraint
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // player move left/right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // launch projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletPrefab.transform.rotation);
        }
    }
}
