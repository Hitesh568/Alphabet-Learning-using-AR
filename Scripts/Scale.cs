using UnityEngine;
using System.Collections;

public class Scale : MonoBehaviour
{
    void OnMouseDown()
    {
        CSharpScaling.ScaleTransform = this.transform;
    }
}