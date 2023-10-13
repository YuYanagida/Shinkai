using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WorldSpaceCanvas : MonoBehaviour
{
    public float x;
    public float z;
    private int h;
    public GameObject Player;
    public GameObject uipannel;
    public GameObject _hand;
    public GameObject _head;
    public float Speed = 1.0f;
    float smooth = 10f;
    private Rigidbody rb;
    public UnityAction unieve;
    private UnityAction uac;
    public float dist;
    private float count;
    public GameObject _ui;
    public Transform tra;
    public Vector3 bec;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        #region 歩行

        _ui.SetActive((tra.localEulerAngles.y >= 70) && (tra.localEulerAngles.y <= 200) ? true : false);

        //x = Input.GetAxis("Horizontal");
        //z = Input.GetAxis("Vertical");
        var img = uipannel.GetComponent<Image>();
        bec = _head.transform.forward;
        

        
        #endregion

        float dd = Vector3.Distance(uipannel.transform.position, _hand.transform.position);

        if (dd < dist && _ui.activeSelf == true)
        {
            Vector3 target_dir = new Vector3(bec.x, 0, bec.z);
            rb.velocity = target_dir.normalized * Speed;         //歩く速度

            Vector3 comFoward = new Vector3(Player.transform.forward.x, 0, Player.transform.forward.z).normalized;

            if (target_dir.magnitude > 0.1)
            {
                //キーを押し方向転換
                /*Quaternion rotation = Quaternion.LookRotation(target_dir);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);*/
            }

            img.color = new Color(0.6f, 0.6f, 0.6f);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
            img.color = new Color(1, 1, 1);
        }
    }
}

    

    /*void OnTriggerStay(Collider other)
    {
        unieve?.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        x = 0;
        z = 0;
    }

    void gofront()
    {
        x = 1;
        z = 0;
    }

    void goright()
    {
        x = 0;
        z = 1;
    }

    void goleft()
    {
        x = 0;
        z = -1;
    }

    void back()
    {
        x = -1;
        z = 0;
    }*/

