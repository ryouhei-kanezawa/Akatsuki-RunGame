using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSet : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (transform.parent == null && col.gameObject.name == "field")
        {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
            transform.parent = emptyObject.transform;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (transform.parent != null && col.gameObject.name == "field")
        {
            transform.parent = null;
        }
    }
}
