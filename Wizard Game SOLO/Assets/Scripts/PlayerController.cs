using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Vector3 theScale;

    public bool left, right;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || right)
        {
            GetComponent<Rigidbody2D>().velocity = 30 * Vector2.right;
            theScale = transform.localScale;
            if (theScale.x != 1)
            {
                theScale.x *= -1;
                transform.localScale = theScale;
            }
            else
            {
                //do nothing
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || left)
        {
            GetComponent<Rigidbody2D>().velocity = -30 * Vector2.right;
            theScale = transform.localScale;
            if (theScale.x != -1)
            {
                theScale.x *= -1;
                transform.localScale = theScale;
            }
            else
            {
                //do nothing
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
	}


    public void Left()
    {
        left = true;
    }


    public void Right()
    {
        right = true;
    }


    public void LeftF()
    {
        left = false;
    }


    public void RightF()
    {
        right = false;
    }
}
