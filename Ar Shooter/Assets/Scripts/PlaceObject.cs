using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class PlaceObject : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject objectToPlace;
    public Camera arCamera;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private GameObject placedObject;

    // Update is called once per frame
    void TouchToPlaceObject()
    {
        if(Input.touchCount > 0)
        {
            Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);
            if(Input.GetMouseButton(0)){
                if(raycastManager.Raycast(ray, hits, TrackableType.Planes))
                {
                    
                    Pose hitpose = hits[0].pose;
                    //If the position we touched it empty, place the object here
                    if(placedObject == null){
                        placedObject = Instantiate(objectToPlace, hitpose.position, hitpose.rotation);
                    }
                    //Otherwise, we update the position and rotation
                    else{
                        placedObject.transform.position = hitpose.position; 
                        placedObject.transform.rotation = hitpose.rotation; 

                    }
                }
            }
    }
    }
    void Update()
    {
        TouchToPlaceObject();
    }
}
