using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject homePage;
    public GameObject userOneLogin;
    public GameObject userTwoLogin;

    public static int user = 1;
 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnUserOneChosen()
    {
        user = 1;
        homePage.SetActive(false);
        userOneLogin.SetActive(true);
    }

    public void OnUserTwoChosen()
    {
        user = 2;
        homePage.SetActive(false);
        userTwoLogin.SetActive(true);
    }

    public void OnUserOneBackButtonPressed()
    {
        userOneLogin.SetActive(false);
        homePage.SetActive(true);
    }

    public void OnUserTwoBackButtonPressed()
    {
        userTwoLogin.SetActive(false);
        homePage.SetActive(true);
    }

    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
}
