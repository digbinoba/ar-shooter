using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    private Indicator indicator;
    public GameObject objectToPlace;
    private GameObject newPlacedObject;
    void Start()
    {
        indicator = FindObjectOfType<Indicator>();
    }

    public void PressToPlace()
    {
        newPlacedObject = Instantiate(objectToPlace, indicator.transform.position, indicator.transform.rotation);
        Debug.Log("Enemy was placed");
    }

    
}
