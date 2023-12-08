using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public string tag2 = "Hand";
    public UnityEvent actionEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(tag2))
            {
                actionEvent.Invoke();
            }
        }
    }
}
