using UnityEngine.SceneManagement;
using UnityEngine;

public class levelcomplete : MonoBehaviour
{
    public void gonewlevel()
    {
        int a = PlayerPrefs.GetInt("leveldone",0);
        int b = SceneManager.GetActiveScene().buildIndex;
        if(b+1>a)
        {
            PlayerPrefs.SetInt("leveldone", b+1);
            PlayerPrefs.Save();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}
