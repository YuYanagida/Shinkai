using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webcamzahyo : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        gameObject.transform.position = target.transform.position;
    }
}
