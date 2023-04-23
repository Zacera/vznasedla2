using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pohyb : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float upwardForce;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float speed;
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private TextMeshPro text;

    private void Start()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            speed = Mathf.Clamp(speed + 0.1f, minSpeed, maxSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed = Mathf.Clamp(speed - 0.1f, minSpeed, maxSpeed);
        }
        if (speed >= -3)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
            }
        }
        /*if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }*/
        rb.AddForce(Vector3.up * upwardForce);
        //transform.position += transform.forward * speed * Time.deltaTime;
        rb.AddForce(-transform.right * speed * 1580);
        //text.SetText(speed.ToString());
    }
}
