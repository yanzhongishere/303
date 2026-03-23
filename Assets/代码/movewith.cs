
using UnityEngine;

public class movewith : MonoBehaviour
{
    public Transform player;
    public Vector3 place;
    void Update()
    {
        transform.position = player.position+place;
    }
}
