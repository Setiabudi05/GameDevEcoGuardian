using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void ExitToMainMenu()
    {
        // Wajib: pastikan scene "MainMenu" sudah masuk ke Build Settings
        SceneManager.LoadScene("MainMenu");
    }
}
