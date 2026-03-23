using UnityEngine.SceneManagement;
using UnityEngine;

public class stardgameb : MonoBehaviour
{
    public void Stardgameb()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
