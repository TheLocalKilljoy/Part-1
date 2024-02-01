using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float hz;
    float vt;

    float speed = 3f;

    Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hz = Input.GetAxis("Horizontal");
        transform.Translate(hz * speed * Time.deltaTime, 0, 0);

        vt = Input.GetAxis("Vertical");
        transform.Translate(0, vt * speed * Time.deltaTime, 0);
    }
}
