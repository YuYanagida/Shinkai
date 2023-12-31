using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UIAction : MonoBehaviour
{
    //　トータル制限時間
    private float totalTime;
    //　制限時間（分）
    //[SerializeField]
    public int minute;
    //　制限時間（秒）
    //[SerializeField]
    public float seconds;
    //　前回Update時の秒数
    private float oldSeconds;
    public Text CowntDownTimer;

    public Slider RockCountslider;
    public float maxtime;
    public float value;
    public int nearcrystal;
    private float vacry;
    public GameObject webcam;

    public GameObject ClearUI;

    public UnityEvent OSCAction;

    void Start()
    {
        totalTime = minute * 60 + seconds;
        oldSeconds = 0f;
        maxtime = totalTime;
        RockCountslider.value = value;
        value = 0;
        ClearUI.SetActive(false);
        vacry = 1f / nearcrystal;
        webcam.SetActive(false);
    }

    void Update()
    {
        RockCountslider.value = value;
        #region タイマー
        //　制限時間が0秒以下なら何もしない
        if (totalTime <= 0f)
        {
            return;
        }
        //　一旦トータルの制限時間を計測；
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        //　再設定
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        //　タイマー表示用UIテキストに時間を表示する
        if ((int)seconds != (int)oldSeconds)
        {
            CowntDownTimer.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        //　制限時間以下になったらコンソールに『制限時間終了』という文字列を表示する
        if (totalTime <= 0f)
        {
            Debug.Log("制限時間終了");
        }
        #endregion

        if(value >= 1)
        {
            webcam.SetActive(true);
            ClearUI.SetActive(true);
            OSCAction.Invoke();
            Invoke("Webcamoff", 5.0f);
        }
    }

    public void Webcamoff()
    {

        ClearUI.SetActive(false);
        value = 0;
    }

    public void RockSlider()
    {
        value += vacry;
    }


}
