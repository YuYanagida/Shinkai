using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hand : MonoBehaviour
{
    [SerializeField]
    public UnityEvent OSCAction;

    //public GameObject eventobj;
    // Start is called before the first frame update
    void Start()
    {
        /*eventobj.AddComponent<BoxCollider>();
        BoxCollider bcol = eventobj.GetComponent<BoxCollider>();
        bcol.isTrigger = true;
        eventobj.AddComponent<osc>();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        OSCAction.Invoke();
    }
}
