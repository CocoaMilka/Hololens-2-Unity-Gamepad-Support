using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Material cubeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        // Access the material of the Renderer component
        cubeMaterial = GetComponent<Renderer>().material;
        cubeMaterial.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("joystick button 0"))
        {
            cubeMaterial.color = Color.green;
        }
        else
        {
            cubeMaterial.color = Color.red;
        }
    }
}
