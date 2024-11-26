
using UnityEngine;


public class MapJeu : MonoBehaviour
{

    private GameObject go;
    private Camera cameraSalle0;

    private GameObject indice1accueil;
    private GameObject indice2accueil;
    private GameObject indice3accueil;

    public GameObject menuPause;
    static private GameObject PanelInvestigation;
    public GameObject PanelHome;

    static private GameObject CanvasAcceuil;
    static private GameObject CanvasStart;

    static private GameObject CanvasChris;
   static private GameObject CanvasTMSChris;
   static private GameObject CanvasOrdiChris;
    // Start is called before the first frame update
    public void ActivatePause()
    {
        menuPause.SetActive(true);
        //PanelInvestigation = GameObject.Find("PanelInvestigationMain");
        //PanelInvestigation.SetActive(false);
        //Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    public void DesactivatePause()
    {
        menuPause.SetActive(false);
        //PanelInvestigation.SetActive(false);
        //Time.timeScale = 1.0f;
    }

    public void ActivateInvestigation()
    {
        //PanelInvestigation = GameObject.Find("PanelInvestigationMain");
        //PanelInvestigation.SetActive(true);
        //menuPause.SetActive(false);
        //Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    public void DesactivateInvestigation()
    {
        //PanelInvestigation = GameObject.Find("PanelInvestigationMain");
        //PanelInvestigation.SetActive(false);
        //menuPause.SetActive(false);
        //Time.timeScale = 1.0f;
    }

    void Update()
    {

    }


    public void LoadHome()
    {
        cameraSalle0 = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        //Camera.main.transform.Translate (-46, -76, 328);
        Debug.Log(cameraSalle0.transform.position);
        Debug.Log(Camera.main.transform.position); //(-53.59, -70.34, 325.14)
        //Camera.main.transform.Rotate(0, 0, 0);
        //Camera.main.transform.position = new UnityEngine.Vector3(-47, -76, 328);
        Camera.main.transform.position = new UnityEngine.Vector3(-53, -70, 325);
        
        
        CanvasAcceuil = GameObject.Find("CanvasAcceuil");
        CanvasAcceuil.SetActive(false);

        CanvasStart = GameObject.Find("CanvasStart");
        CanvasStart.SetActive(true);


        CanvasChris = GameObject.Find("CanvasChris");
        CanvasChris.SetActive(false);

        //GameObject.Find("CanvasChris").GetComponent<Canvas>().gameObject.SetActive(false);
        CanvasTMSChris = GameObject.Find("CanvasChrisTMS");
        CanvasTMSChris.SetActive(false);

        CanvasOrdiChris = GameObject.Find("CanvasOrdi");
        CanvasOrdiChris.SetActive(false);

        PanelHome = GameObject.Find("PanelSafeWork");
        PanelHome.SetActive(true);

        //PanelInvestigation.SetActive(false);


        
        indice1accueil = GameObject.Find("indice1accueil");
        indice1accueil.gameObject.SetActive(false);

        indice2accueil = GameObject.Find("indice2acceuil");
        indice2accueil.gameObject.SetActive(false);

        indice3accueil = GameObject.Find("indice3accueil");
        indice3accueil.gameObject.SetActive(false);
    }


    public void ExitGame()
    {
        #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }



}
