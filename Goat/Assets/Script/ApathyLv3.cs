using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApathyLv3 : MonoBehaviour
{
    public GameObject goingOut;

    // Update is called once per frame
    public void ApathyCheck()
    {
        if(FindObjectOfType<State>().apathyLv < 3)
        {
            GetComponent<Button>().OpenCanvas(goingOut);
        }
    }
}
