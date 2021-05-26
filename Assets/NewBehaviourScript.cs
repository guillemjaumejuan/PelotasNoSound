using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{

    AudioSource[] sources;
 

    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnCollisionEnter(Collision collision)
    {
        print("collision");
        sources[0].Play();
    }
}
