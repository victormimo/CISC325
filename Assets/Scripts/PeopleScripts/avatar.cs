using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatar : MonoBehaviour {

    protected static List<GameObject> avatarList = new List<GameObject>();
    static Vector3 SPOTLIGHT = new Vector3(10, 10, 10);

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showAvatar(GameObject a)
    {
        Debug.Log("showing  " + a.tag);
        a.SetActive(true);
    }

    public void hideAvatar(GameObject a)
    {
        Debug.Log("hiding  " + a.tag);
        Debug.Log(UnityEngine.StackTraceUtility.ExtractStackTrace());
        a.SetActive(false);
    }

    public void beckonAvatar(GameObject currAvatar)
    {
        foreach (GameObject a in avatarList)
        {
            if (a.Equals(currAvatar))
            {
                var playerPos = currAvatar.transform.position;
                Vector3.MoveTowards(playerPos, SPOTLIGHT, 0);
            }
        }
    }

    public void hideAll()
    {
        foreach (GameObject a in avatarList)
        {
            hideAvatar(a);
        }
    }
}
