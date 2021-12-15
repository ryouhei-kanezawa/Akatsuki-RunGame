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
    private float interval = 2f;
    [SerializeField]
    private TimeStart Stop;

    private float nextSpawnTime = 0;
    private int Rnum = 0;
    private bool active = false;
    private void LocalInstantate()
    {
        GameObject obj = (GameObject)GameObject.Instantiate(boadObject);
		if (Stop.StopMoment())
		{
            Rnum = Random.Range(0, item.Length);
            GameObject opt = (GameObject)GameObject.Instantiate(item[Rnum]);
		}
    }

    void Update()
    {
        if (nextSpawnTime < Time.timeSinceLevelLoad)
        {
            nextSpawnTime = Time.timeSinceLevelLoad + interval;
            LocalInstantate();
        }
    }

    public void SetActive(bool _active)
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
