using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCreate : MonoBehaviour
{
    public GameObject[] _rock;
    private Vector3 offset;
    public Transform player;
    public int rockcount;
    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(Random.Range(player.position.x - 10, player.position.x + 10),
        //Random.Range(3,8),Random.Range(player.position.z - 10, player.position.z + 10));

        for ( int i = 0; i < rockcount; i++)
        {
            offset = new Vector3(Random.Range(-30, 30), Random.Range(0, 0.3f), Random.Range(-30, 30));

            var obj = Instantiate(_rock[Random.Range(0, _rock.Length)], offset, Quaternion.Euler(Random.Range(0,360), Random.Range(0, 360), Random.Range(0, 360)));

            float ram = Random.Range(0.2f, 0.5f);

            obj.transform.localScale = new Vector3(ram, ram, ram);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
