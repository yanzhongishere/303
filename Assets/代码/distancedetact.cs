using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class distancedetact : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI t;
    public Transform winline;

    // Update is called once per frame
    void Update()
    {
        int xx = (int)(player.position.x/ winline.position.x * 100);
        t.text = xx + "%";
    }
}
