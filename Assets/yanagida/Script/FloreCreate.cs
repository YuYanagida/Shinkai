using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FloreCreate : MonoBehaviour
{
    public GameObject flore;
    public GameObject player;
    public Vector3 offset;
    private float dis;
    private bool bl;
    Collider coll;
    int[] twn = { -20, 0, 20 };
    // Start is called before the first frame update
    //20m*20m�̖���flore�𐶐�����
    //offset��20�̔{��
    //player���i�񂾕����ɂP�����
    void Start()
    {
        offset = player.transform.forward;
        offset = new Vector3(offset.x + twn[0] - offset.x % 20, 0, offset.z + twn[0] - offset.z % 20);
        bl = true;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(offset,new Vector3(0,0,0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) // ����Ray�𓊎˂��ĉ��炩�̃R���C�_�[�ɏՓ˂�����
        {
            coll = hit.collider;
        }
            dis = Vector3.Distance(player.transform.position, transform.position);
        if (!(Physics.OverlapSphere(offset, 0).Any(col => col == coll)))
        {
            if (bl == true && dis <= 9)
            {
                Instantiate(flore, offset, Quaternion.identity);
                bl = false;
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
