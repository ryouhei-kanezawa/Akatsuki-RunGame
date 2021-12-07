using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoadManager : MonoBehaviour
{
    [SerializeField]
    private GameObject boadObject;
    [SerializeField]
    private float nextSpawnTime = 0;
    [SerializeField]
    private float interval = 15f;

    private bool active = false;
    private void LocalInstantate()
    {
        GameObject obj = (GameObject)GameObject.Instantiate(boadObject);
        obj.transform.parent = transform;

        float y = Random.Range(-1f, 1f);
        obj.transform.localPosition = new Vector3(0, y, 0);
    }

    void Update()
    {
        if (active)
        {
        if (nextSpawnTime < Time.timeSinceLevelLoad)
        {
            nextSpawnTime = Time.timeSinceLevelLoad + interval;
            LocalInstantate();
        }
        }
    }

    public void setActive(bool _active)
    {
        active = _active;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.attachedRigidbody.gameObject);
    }

    public void CleanBoadObject()
    {
        GameObject[] boads = GameObject.FindGameObjectsWithTag("Boad");

        foreach(var VARIABLE in boads)
        {
            Destroy(VARIABLE);
        }
    }
}
