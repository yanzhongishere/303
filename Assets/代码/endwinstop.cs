

using UnityEngine;

public class playercol : MonoBehaviour
{
    public move ff;
    public gamemanager gm;
    public winp winpp;
    public goup mov;
    public Camera cam;
    public ro rota;
    public fro frota;
    public Renderer rend;

    void OnCollisionEnter(Collision collsionInfo)
    {
        if (collsionInfo.collider.tag=="o")
        {
            ff.enabled = false;
            gm.endgame();
        }
        if (collsionInfo.collider.tag == "winlineT") 
        {
            Debug.Log("win");
            ff.enabled = false;
            winpp.win();
        }
        if (collsionInfo.collider.tag == "j") 
        {
            mov.Goup();
            rota.enabled = true;
            Color c = rend.material.color;
            c.a = 0.5f;
            rend.material.color = c;
        }
        if (collsionInfo.collider.tag == "ground")
        {
            mov.rotation();
            rota.enabled = false;
            frota.enabled = true;
            Color c = rend.material.color;
            c.a = 1f;
            rend.material.color = c;
        }
    }
}
