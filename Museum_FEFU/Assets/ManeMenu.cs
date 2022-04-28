using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManeMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadSceane(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
