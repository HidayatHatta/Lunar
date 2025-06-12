using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ChangeScene : MonoBehaviour
{
    public void ScanScene(){
        SceneManager.LoadScene("ScanScene");
    }
    public void AboutUsScene(){
        SceneManager.LoadScene("AboutUsScene");
    }
    public void ExitApp(){
        Application.Quit();
    }
    public void BackToMenu(){
        SceneManager.LoadScene("HomeScene");
    }
}
