using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [SerializeField]
    private GameObject player_body;
    [SerializeField]
    private float junmp = 10.0f;

    private Rigidbody2D player_jump;

    void Start()
    {
        player_jump = player_body.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown("space"))
		{
            Jump_getkey();
		}
    }

    private void Jump_getkey()
	{
        player_jump.velocity = Vector2.up * junmp;
	}
}
