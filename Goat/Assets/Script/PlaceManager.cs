using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    public GameObject[] places;
    public GameObject currPlace;

    public int index;

    public void Start()
    {
        index = 0;
    }

    public void ChangePlaces(int placeIndex)
    {
        index = placeIndex;
        currPlace.SetActive(false);
        places[placeIndex].SetActive(true);
        currPlace = places[placeIndex];
    }

}
