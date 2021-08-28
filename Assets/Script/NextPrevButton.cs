using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPrevButton : MonoBehaviour
{
    public void GoToPlace(int placeIndex)
    {
        FindObjectOfType<PlaceManager>().ChangePlaces(placeIndex);
    }
}
