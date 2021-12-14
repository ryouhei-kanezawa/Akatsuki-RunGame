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
    private PaseUI _pose;

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
		if (_pose.CheckSend())
		{
            kyoriScore += score;
		}

        kyori.text = kyoriScore.ToString();
	}

    public void CoinUpdate()
	{
        coinScore++;

        coin.text = coinScore.ToString();
	}
}
