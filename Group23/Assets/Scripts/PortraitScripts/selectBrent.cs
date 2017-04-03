using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class selectBrent : MonoBehaviour
{

    protected static GameObject person;
    // Use this for initialization
    void Start()
    {
        var _person = GameObject.FindGameObjectWithTag("AvatarBrent");
        if (!_person)
        {
            Debug.LogError("Could not find person");
        }
        else
        {
            person = _person;
        }

        // code should be somewhere else:
        // hide's person on startup
        hidePerson();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showPerson()
    {
        person.SetActive(true);
    }

    public void hidePerson()
    {
        person.SetActive(false);
    }

}