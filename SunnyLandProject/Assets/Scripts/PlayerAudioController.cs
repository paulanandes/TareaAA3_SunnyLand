using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{

    // keep track of the jumping state ... 
    bool isJumping = false;
    // make sure to keep track of the movement as well !

    Rigidbody2D rb; // note the "2D" prefix 
    public AudioSource audioSourceJump;    
    public AudioSource audioSourceCrouch;    
    public AudioSource audioSourceLand;    
    public AudioSource audioSourceFootsteps;  
    public AudioSource audioSourceCherry; 


    // Start is called before the first frame update
    void Start()
    {
        
	    rb = GetComponent<Rigidbody2D>();
	// get the references to your audio sources here !        
    }

    // FixedUpdate is called whenever the physics engine updates
    void FixedUpdate()
    {
	// Use the ridgidbody instance to find out if the fox is
	// moving, and play the respective sound !
	// Make sure to trigger the movement sound only when
	// the movement begins ...

	// Use a magnitude threshold of 1 to detect whether the
	// fox is moving or not !
	// i.e.
	// if ( ??? > 1 && ???) {
	//    play sound here !
	// } else if ( ??? < 1 &&) {
	//   stop sound here !
	// }	
    }
    
    // trigger your landing sound here !
    public void OnLanding() {
        audioSourceLand.Play();
        isJumping = false;
        print("the fox has landed");
	// to keep things cleaner, you might want to
	// play this sound only when the fox actually jumoed ...
    }

    // trigger your crouching sound here
    public void OnCrouching() {
        audioSourceCrouch.Play();
        print("the fox is crouching");
    }
 
    // trigger your jumping sound here !
    public void OnJump() {
        audioSourceJump.Play();
        isJumping = true;
        print("the fox has jumped");
    }

    // trigger your cherry collection sound here !
    public void OnCherryCollect() {
        audioSourceCherry.Play();
        print("the fox has collected a cherry");
    }

    public void OnStep()
    {
         audioSourceFootsteps.Play();
    }
}


