
using UnityEngine;


public class HomeShow : MonoBehaviour
{


public GameObject PanelHome;
public GameObject PanelInvestigation;


    void Update()
    {

    }


    
public void ShowHome()
    {
        
        PanelHome.SetActive(true);
        PanelInvestigation.SetActive(false);
  
 
    }



}
