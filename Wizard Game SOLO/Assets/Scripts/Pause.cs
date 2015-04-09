using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    public bool paused = true;

    public Animator left, right;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void play(Animator anim)
    {
        anim.SetBool("paused", !paused);
        left.SetBool("paused", !paused);
        right.SetBool("paused", !paused);
        paused = !paused;
    }

    public void close(Animator anim)
    {
        anim.SetBool("paused", false);
        left.SetBool("paused", false);
        right.SetBool("paused", false);
        paused = false;
    }

}
