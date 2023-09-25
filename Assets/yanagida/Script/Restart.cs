using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string tag3 = "Hand";
    Scene loadscene;
    // Start is called before the first frame update
    void Start()
    {
        loadscene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(tag3))
        {
            SceneManager.LoadScene("test");
        }
    }
}
