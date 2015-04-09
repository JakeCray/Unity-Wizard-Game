using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hover : MonoBehaviour {

    private float time = 1f;

    public GameObject go;

    public GameObject text;

    Text txt;

    RectTransform rt;

    bool spin;

    bool unspin;

    bool pOut;

	// Use this for initialization
	void Start () {
        go = gameObject;
        rt = go.GetComponent<RectTransform>();
        txt = text.GetComponent<Text>();
        if (PlayerPrefs.GetInt("new game") == 0)
        {
            txt.text = "New Game";
        }
        else if (PlayerPrefs.GetInt("new game") == 1)
        {
            txt.text = "Continue Game";
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (spin && !pOut)
        {
            time -= Time.deltaTime;
            rt.Rotate(Vector3.up, (-33 * Time.deltaTime));
            if (time <= 0)
            {
                spin = false;
                time = 1f;
                pOut = true;
            }
        }

        if(pOut && !spin && unspin)
        {
            time -= Time.deltaTime;
            rt.Rotate(Vector3.up, (33 * Time.deltaTime));
            if (time <= 0)
            {
                unspin = false;
                time = 1f;
                pOut = false;
            }
        }
	}

    public void run()
    {
        if (!unspin)
        {
            spin = true;
        }
    }

    public void unRun()
    {
        unspin = true;
    }

    public void goGame()
    {
        PlayerPrefs.SetInt("new game", 1);
        Application.LoadLevel(1);
    }

}
