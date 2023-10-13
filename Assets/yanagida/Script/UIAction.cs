using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UIAction : MonoBehaviour
{
    //�@�g�[�^����������
    private float totalTime;
    //�@�������ԁi���j
    //[SerializeField]
    public int minute;
    //�@�������ԁi�b�j
    //[SerializeField]
    public float seconds;
    //�@�O��Update���̕b��
    private float oldSeconds;
    public Text CowntDownTimer;

    public Slider RockCountslider;
    public float maxtime;
    public float value;
    public int nearcrystal;
    private float vacry;

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
    }

    void Update()
    {
        RockCountslider.value = value;
        #region �^�C�}�[
        //�@�������Ԃ�0�b�ȉ��Ȃ牽�����Ȃ�
        if (totalTime <= 0f)
        {
            return;
        }
        //�@��U�g�[�^���̐������Ԃ��v���G
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        //�@�Đݒ�
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        //�@�^�C�}�[�\���pUI�e�L�X�g�Ɏ��Ԃ�\������
        if ((int)seconds != (int)oldSeconds)
        {
            CowntDownTimer.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        //�@�������Ԉȉ��ɂȂ�����R���\�[���Ɂw�������ԏI���x�Ƃ����������\������
        if (totalTime <= 0f)
        {
            Debug.Log("�������ԏI��");
        }
        #endregion

        if(value >= 1)
        {
            ClearUI.SetActive(true);
            OSCAction.Invoke();
        }
    }

    public void RockSlider()
    {
        value += vacry;
    }


}
