using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeraudiocontroler : MonoBehaviour
{

    AudioSource[] sources;

    public Rigidbody rb;
    float speed = 0;
    bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();

        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;
        if (speed > 0.1 && !isPlaying){
            isPlaying = true;
            sources[1].Play();
  
        }
        else if(speed < 0.1 && isPlaying)
        {
            isPlaying = false;
            sources[1].Stop();
        }
        sources[1].pitch = speed / 2;
    } 

    void OnCollisionEnter(Collision collision)
    {
        print("collision");
        sources[0].Play();
    }
}
