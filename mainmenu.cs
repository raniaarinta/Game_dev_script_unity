using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {
	public int selected_minigame2;

    public void load_minigame()
    {
        SceneManager.LoadScene("mini_game");
        
    }
    public void load_quit()
    {
        Application.Quit();
    }
    public void load_storymode()
    {
        //SceneManager.LoadScene("mini_game");

    }
    public void load_quiz()
    {
        //SceneManager.LoadScene("mini_game");

    }


}
