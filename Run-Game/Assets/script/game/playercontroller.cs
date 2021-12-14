using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]
    private GameObject player_body;
    [SerializeField]
    private float junmp = 20.0f;
    [SerializeField]
    private CoinSet _coin;

    private Rigidbody2D player_jump;
    private bool check = true;
    private int jumpCount;

    void Start()
    {
        player_jump = player_body.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		if (check)
		{
			if (jumpCount<=1)
			{
                if (Input.GetKeyDown("space"))
		        {
                    Jump_getkey();
                    jumpCount++;
		        }
			}
		}
		
    }

    private void Jump_getkey()
	{
        player_jump.velocity = Vector2.up * junmp;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("coin"))
		{
            Debug.Log("coinSet");
            _coin.CoinUpdate();
            Destroy(collision.gameObject);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "field")
        {
            jumpCount = 0;
        }
    }
}
