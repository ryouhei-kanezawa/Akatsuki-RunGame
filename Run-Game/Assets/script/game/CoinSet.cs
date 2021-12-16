using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSet : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI coin;
    [SerializeField]
    private TextMeshProUGUI kyori;
    [SerializeField]
    private int score = 10;
    [SerializeField]
    private TimeStart Stop;

    private bool swich = true;
    private int coinScore;
    private int kyoriScore;

    void Start()
    {
        coinScore = 0;
        kyoriScore = 0;

        coin.text = coinScore.ToString();
        kyori.text = kyoriScore.ToString();
    }

	private void Update()
	{
        if (Stop.StopMoment())
        {
			if (swich)
			{
                kyoriScore += score;
			}
        }

        kyori.text = kyoriScore.ToString();
	}

    public void CoinUpdate()
	{
        coinScore++;

        coin.text = coinScore.ToString();
	}

    public void StopSwich(bool set)
	{
        swich = set;
	}
}
