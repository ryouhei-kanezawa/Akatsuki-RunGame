using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoad : MonoBehaviour
{
    [SerializeField]
    private bool moveBoad = true;
    [SerializeField]
    private float speed = 0.1f;
    [SerializeField]
    private GameObject boadbody;
    [SerializeField]
    private bool optionSW = true;
    [SerializeField]
    private GameObject optionOJ;

    private Vector3 pos = new Vector3();
    private Vector3 posO = new Vector3();

    private void Awake()
    {
        pos = boadbody.transform.position;

		if (optionSW)
		{
            posO = optionOJ.transform.position;
		}
    }

    private void FixedUpdate()
    {
        if (moveBoad)
        {
            pos.x -= speed;
            posO.x -= speed;

            boadbody.transform.position = pos;

			if (optionSW)
			{
                optionOJ.transform.position = posO;
			}
        }
    }

    private void stopBoad()
    {
        moveBoad = false;
    }
}
