using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void start_game()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
    public void Men_u()
    {
        SceneManager.LoadScene(0);
    }
}
