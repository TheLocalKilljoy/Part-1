using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 360;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, -speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}