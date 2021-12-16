using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaseUI : MonoBehaviour
{
    [SerializeField]
    private Button Pause;               //ポーズ画面を呼び出すボタン
    [SerializeField]
    private CoinSet _coin;

    /*
    [SerializeField]
    private GameObject pauseObject;     //プレハブ化したポーズ画面
    [SerializeField]
    private GameObject canvas;          //InstantiateするCanvas

    private GameObject _pause;
    private Transform canvasTran;
    */
    private bool check = true;

    void Awake()
    {
        Pause.onClick.AddListener(PauseSW);
    }

    void PauseSW()
    {
        if (check)
        {
            //_pause= Instantiate(pauseObject, canvasTran, false);
            //_pause.transform.SetParent(canvas.transform, false);

            Time.timeScale = 0;
            check = false;
            _coin.StopSwich(false);
        }
        else
        {
            //Destroy(_pause);

            Time.timeScale = 1.0f;
            check = true;
            _coin.StopSwich(true);
        }
    }
}
