using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initVictor : avatar
{

    protected static string avatarTag = "AvatarVictor";
    protected static GameObject avatar;

    // Use this for initialization
    void Start()
    {
        var a = GameObject.FindGameObjectWithTag(avatarTag);
        if (!a)
        {
            Debug.LogError("Could not find " + avatarTag);
        }
        else
        {
            avatar = a;
            avatarList.Add(a);
        }

        hideAvatar(avatar);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
