
using UnityEngine;

public class goup : MonoBehaviour
{
    public Rigidbody rb;
    public void Goup()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.AddForce(0, 15, 0, ForceMode.VelocityChange);
    }
    public void rotation()
    {
        rb.constraints = RigidbodyConstraints.None;
    }
    
}
