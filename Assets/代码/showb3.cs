using UnityEngine;
using UnityEngine.UI;

public class showb3 : MonoBehaviour
{
    public Button button3;
    void Start()
    {
        int a = PlayerPrefs.GetInt("leveldone",0);
        if (a >= 3)
        {
            button3.gameObject.SetActive(true);
        }
    }
}
