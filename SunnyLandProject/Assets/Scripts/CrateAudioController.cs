using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAudioController : MonoBehaviour
{
      public AudioSource audioSourceImpacto; 
      public AudioSource audioSourceArrastrar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSourceImpacto.Play();
        audioSourceArrastrar.Play();

    }
}
