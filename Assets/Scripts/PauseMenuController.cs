using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public void ExitToMainMenu()
    {
        // Ganti "MainMenu" dengan nama scene Main Menu kamu
        SceneManager.LoadScene("MainMenu");
    }
}
