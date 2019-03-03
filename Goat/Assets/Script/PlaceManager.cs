using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    public GameObject[] places;

    public GameObject currPlace;

    public void ChangePlaces(int placeIndex)
    {
        currPlace.SetActive(false);
        places[placeIndex].gameObject.SetActive(true);
    }

}
