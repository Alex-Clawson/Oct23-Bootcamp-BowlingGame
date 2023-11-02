using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [HideInInspector]
    public string displayNewText;

    [SerializeField]
    string displayText = "Game Started!";

    public Transform testCube;

    public float rotateSpeed;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(displayText);

        int i = 3;

        if (i == 5 && i == 3)
        {
            Debug.Log("Value of i is 5 and 3");
        }
        else
        {
            Debug.Log("i is not equal to 5 and 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //testCube.Rotate(new Vector3(0, 1, 0) * rotateSpeed * time.deltaTime);
        //testCube.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        testCube.Rotate(Vector3.up * rotateSpeed * Input.GetAxis("Mouse X"));

        //testCube.Translate(Vector3.forward *moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A is being pressed");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B has been pressed");
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("C has been released");
        }
    }
}
