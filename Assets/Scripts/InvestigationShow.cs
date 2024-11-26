
using UnityEngine;


public class InvestigationShow : MonoBehaviour
{

public GameObject PanelInvestigation;
public GameObject PanelHome;

static private bool stateActive = false;

    void Update()
    {

    }


    
public void ShowInvestigation()
    {
        if(stateActive == false){
        PanelInvestigation.SetActive(true);
        PanelHome.SetActive(false);
        stateActive = true;
        }else{
        PanelInvestigation.SetActive(false);
        PanelHome.SetActive(true);
        stateActive = false;
        }
 
    }

public void ShowHome()
    {
        
        PanelHome.SetActive(true);
        PanelInvestigation.SetActive(false);
        stateActive = false;
  
 
    }



}
