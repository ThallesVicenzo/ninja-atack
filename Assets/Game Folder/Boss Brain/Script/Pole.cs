using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public Transform spike;
    public AudioClip poleSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name.Equals("AtackColider"))
        {
            spike.GetComponent<Animator>().Play("SpikeAnimation");
            GetComponent<Animator>().Play("Pole");
            GetComponent<AudioSource>().PlayOneShot(poleSound);
        }


    }


}
