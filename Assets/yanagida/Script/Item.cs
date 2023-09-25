using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    public string tag2 = "Hand";
    public UnityEvent ItemEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(tag2))
        {
            ItemEvent.Invoke();
            gameObject.SetActive(false);
        }
    }
}
