using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LefthandUI : MonoBehaviour
{
    public GameObject _ui;
    public Transform tra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ui.SetActive((tra.localEulerAngles.y >= 70) && (tra.localEulerAngles.y <= 200) ? true : false);
 
    }
}
