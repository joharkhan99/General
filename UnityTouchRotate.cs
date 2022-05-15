using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float rotationSpeed;
    private void Start()
    {
        rotationSpeed = 2f;
    }
    void Update()
    {
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved))
        {
            Vector3 Rotation = -Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, Rotation.x * rotationSpeed * Time.deltaTime, 0);
        }
    }
}
