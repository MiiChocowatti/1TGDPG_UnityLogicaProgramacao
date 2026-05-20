using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
