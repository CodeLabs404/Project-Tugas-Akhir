using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject MenuPanel;
    public GameObject KatalogPanel;
    public GameObject TutorialPanel;
    public GameObject InfoPanel;
    public GameObject ARPanel;
   

    // Start is called before the first frame update
    public void Start() {
        MenuPanel.SetActive(true);
        KatalogPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        InfoPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void btnMulaiClicked() {

        Application.LoadLevel("MuseumAR");
    }

    public void btnKatalogClicked()
    {
        MenuPanel.SetActive(false);
        KatalogPanel.SetActive(true);
        TutorialPanel.SetActive(false);
        InfoPanel.SetActive(false);
       
    }

    public void btnTutorialClicked()
    {
        MenuPanel.SetActive(false);
        KatalogPanel.SetActive(false);
        TutorialPanel.SetActive(true);
        InfoPanel.SetActive(false);
        
    }

    public void btnAboutClicked()
    {
        MenuPanel.SetActive(false);
        KatalogPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        InfoPanel.SetActive(true);
        
    }

    public void btnExitClicked()
    {
        Application.Quit();
    }

    public void btnKembaliClicked()
    {
        MenuPanel.SetActive(true);
        KatalogPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        InfoPanel.SetActive(false);
        
    }

    public void btnARBackClicked()
    {
        Application.LoadLevel("MainMenu");
    }

    public void btnARExitClicked()
    {
        Application.Quit();
    }
}
