using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    bool endtime = false;

    public void endgame()
    {
        if(!endtime)
        {
            Debug.Log("gameover");
            endtime = true;
            Invoke("restart",2f);
        }

        
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
