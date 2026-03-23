using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float ff=500;
    public Transform p;
    public gamemanager gm;

    void FixedUpdate()
    {
        rb.AddForce(ff * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -ff * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, ff * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (p.position.y <= -1f)
        {
            gm.endgame();

        }
        if(Input.GetKey("q"))
        {
            Application.Quit();
            Debug.Log("leave");
        }
    }
    
}
