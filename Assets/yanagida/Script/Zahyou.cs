using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zahyou : MonoBehaviour
{
    public Transform m_head;
    public Transform m_handleft;
    public Transform m_handright;
    public Transform o_head;
    public Transform o_handleft;
    public Transform o_handright;

    private Quaternion  offset;
    

    void Start()
    {
      offset = new Quaternion(0, 0,0,0);
    }

    void Update()
    {
        o_head.position = m_head.position;
        o_head.rotation = m_head.rotation * offset;

        o_handleft.position = m_handleft.position;
        o_handleft.rotation = m_handleft.rotation;

        o_handright.position = m_handright.position;
        o_handright.rotation = m_handright.rotation;
    }
}
