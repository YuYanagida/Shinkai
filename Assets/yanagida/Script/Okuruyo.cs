using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okuruyo : MonoBehaviour
{
    void Update()
    {
        var client = GetComponent<uOSC.uOscClient>();
        client.Send("/uOSC/test", 10, "hoge", 1.234f, new byte[] { 1, 2, 3 });
    }
}
