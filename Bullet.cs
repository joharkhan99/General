using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed=10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
            bulet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
            Destroy(bulet, 2f);
        }
    }
}
