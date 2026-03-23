using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fro : MonoBehaviour
{
    public Camera cam;
    void FixedUpdate()
    {
        Quaternion targetRotation = Quaternion.Euler(0, cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
        cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, targetRotation, 5f * Time.deltaTime);
        if (Mathf.Abs(cam.transform.eulerAngles.x - 0f) < 0.1f)
        {
            enabled = false; 
        }

    }
}
