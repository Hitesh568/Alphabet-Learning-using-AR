using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

public GameObject appleObject;  // Assign in Unity
    public GameObject ballObject; // If multiple objects are needed

    void Start()
    {
        if (OrderController.selectedObject == "Apple")
        {
            appleObject.SetActive(true);
        }
        else if (OrderController.selectedObject == "Ball")
        {
            ballObject.SetActive(true);
        }
    }

}
