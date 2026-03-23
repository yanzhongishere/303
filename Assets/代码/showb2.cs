
using UnityEngine;
using UnityEngine.UI;

public class showb2 : MonoBehaviour
{
    public Button button2;
    void Start()
    {
        int a = PlayerPrefs.GetInt("leveldone",0);
        if(a>=2)
        {
            Debug.Log("leveldone = " + a);
            button2.gameObject.SetActive(true);
        }
    }
}
