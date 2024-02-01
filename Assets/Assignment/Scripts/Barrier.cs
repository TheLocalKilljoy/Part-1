using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{

    Rigidbody2D poleRB;

    // Start is called before the first frame update
    void Start()
    {
        poleRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(poleRB);
    }
}
