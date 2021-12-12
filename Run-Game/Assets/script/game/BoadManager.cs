using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoadManager : MonoBehaviour
{
    [SerializeField]
    private GameObject boadObject;
    [SerializeField]
    private GameObject[] item;
    [SerializeField]
    private float nextSpawnTime = 0;
    [SerializeField]
    private float interval = 2f;

    private int Rnum = 0;
    private bool active = true;
    private GameObject obj;
    private GameObject opt;
    private void LocalInstantate()
    {
        Rnum = Random.Range(0, item.Length);
        obj = (GameObject)GameObject.Instantiate(boadObject);
        opt = (GameObject)GameObject.Instantiate(item[Rnum]);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(111);
        Destroy(collision.gameObject);
    }

	public void CleanBoadObject()
    {
        GameObject[] boads = GameObject.FindGameObjectsWithTag("field");

        foreach(var VARIABLE in boads)
        {
            Destroy(VARIABLE);
        }
    }
}
