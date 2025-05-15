using UnityEngine;

public class Exitgame : MonoBehaviour
{
    public void ExitGameApp()
    {
        Debug.Log("Exiting game...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
