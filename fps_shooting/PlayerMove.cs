using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        speed = 1f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0.0f, -5.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, 5.0f, 0.0f);
        }
    }
}
