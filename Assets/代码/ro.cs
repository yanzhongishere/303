using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ro : MonoBehaviour
{

    public Camera cam;
    void FixedUpdate()
    {
        
        Quaternion targetRotation = Quaternion.Euler(30, cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
        cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, targetRotation, 4f * Time.deltaTime);
    }
}
