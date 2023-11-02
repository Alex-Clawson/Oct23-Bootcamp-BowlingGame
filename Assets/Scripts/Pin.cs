using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public bool isFallen;

    Vector3 startPosition;
    Quaternion startRotation;

    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(gameObject.activeSelf)
         *  isFallen = Quaternion.Angle(startRotation, transform.localRotation) > 5;*/

        if (gameObject.activeSelf)
        {
            isFallen = Quaternion.Angle(startRotation, transform.localRotation) > 5;
        }
    }

    public void ResetPin()
    {
        gameObject.SetActive(true);
        rb.velocity = Vector3.zero;
        rb.isKinematic = true;

        transform.position = startPosition + Vector3.up * 0.01f;
        transform.rotation = startRotation;
        isFallen = false;
        rb.isKinematic = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pit"))
        {
            isFallen = true;
        }
    }
}

//Pins   - X:  -0.2256, Y: 0.25, 4.0157??? Just did all this work, not gonna bother now
//Pin 1  - X:  0.231, Z: -0.245
//Pin 2  - X:  0.112, Z: -0.118
//Pin 3  - X:  0.347, Z: -0.118
//Pin 4  - X:  0.000, Z:  0.015 Oh, it's kinda centered on Pin 4...whatever
//Pin 5  - X:  0.231, Z:  0.015
//Pin 6  - X:  0.463, Z:  0.015
//Pin 7  - X: -0.128, Z:  0.147
//Pin 8  - X:  0.112, Z:  0.147
//Pin 9  - X:  0.347, Z:  0.147
//Pin 10 - X:  0.577, Z:  0.147