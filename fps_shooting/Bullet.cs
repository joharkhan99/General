using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    private void Start()
    {
        speed = 1000f;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject bulet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject;
            bulet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
            Destroy(bulet, 2f);
        }
    }
}
