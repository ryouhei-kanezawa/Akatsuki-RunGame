using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStart : MonoBehaviour
{
    private bool active = true;

    public bool StopMoment()
	{
            return active;
	}

    public void StopLine()
    {
        if (active)
        {
            active = false;
        }
        else
        {
            active = true;
        }
    }
}
