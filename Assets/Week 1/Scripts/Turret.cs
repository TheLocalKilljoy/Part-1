using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateT = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, rotateT * speed * Time.deltaTime);
    }
}