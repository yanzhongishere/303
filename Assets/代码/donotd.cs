
using UnityEngine;

public class donotd : MonoBehaviour
{
    static donotd a;
    private void Awake()
    {
        if(a!=null)
        {
            Destroy(gameObject);
            return;
        }
        a = this;
        DontDestroyOnLoad(gameObject);
    }
}
