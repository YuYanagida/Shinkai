using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendSerialHandler : MonoBehaviour
{
    //��قǍ쐬�����N���X
    public SerialHandler serialHandler;


  void Start()
    {
        //�M������M�����Ƃ��ɁA���̃��b�Z�[�W�̏������s��
        serialHandler.OnDataReceived += OnDataReceived;
    }

    void Update()
    {
        //������𑗐M
        serialHandler.Write("hogehoge");
    }

    //��M�����M��(message)�ɑ΂��鏈��
    void OnDataReceived(string message)
    {
        var data = message.Split(
                new string[] { "\t" }, System.StringSplitOptions.None);
        if (data.Length < 2) return;

        try
        {

        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }
}

