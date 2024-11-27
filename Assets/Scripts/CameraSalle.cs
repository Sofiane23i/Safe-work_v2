
using UnityEngine;


public class CameraSalle : MonoBehaviour
{

 public AudioSource audioSource;

  static private Camera cameraSalle1;
  static private GameObject go;
  public GameObject MainCarnetPanel;
  public GameObject indice1accueil;
  public GameObject indice2accueil;
  public GameObject indice3accueil;

  public GameObject indice1accueilv;
  public GameObject indice2accueilv;

  public GameObject indice1accueilf;
  public GameObject indice2accueilf;

  
  public GameObject indice1accueils2;
  public GameObject indice2accueils2;
  public GameObject indice3accueils2;

  public GameObject indice1accueils2v;
  public GameObject indice2accueils2v;
  public GameObject indice3accueils2v;

  public GameObject indice1accueils3;
  public GameObject indice2accueils3;
  public GameObject indice3accueils3;

  public GameObject button2s1;
  public GameObject button2s2;

  public GameObject button2s1v;
  public GameObject button2s2v;
  public GameObject button2s3;

    public GameObject button2s1f;
    public GameObject button2s2f;
     public GameObject button2s3f;
    public GameObject button2s4f;

  public GameObject CanvasStart;
  public GameObject CanvasAcceuil;
  public GameObject CanvasAcceuilv;
  public GameObject CanvasAcceuilf;
  
  public GameObject CanvasBE;
  public GameObject CanvasRH;

  public GameObject CanvasAcceuilFade;
  public GameObject CanvasAcceuilFadev;


   public GameObject CanvasChris1;
   public GameObject CanvasDidier1;
   public GameObject CanvasChrisv1;
   public GameObject CanvasDidierv1;
   public GameObject CanvasChrisf1;
   public GameObject CanvasDidierf1;

  public GameObject CanvasChris2;
   public GameObject CanvasDidier2;
   public GameObject CanvasChrisv2;
   public GameObject CanvasDidierv2;

  public  GameObject CanvasTMSChrisAcuueil;
  public GameObject CanvasHorloge;

  public GameObject CanvasCalendrier;
  public GameObject CanvasSemaineCalendirer;

  public GameObject CanvasCalendrier2;
  public GameObject CanvasSemaineCalendirer2;

  public GameObject CanvasCalendrier3;
  public GameObject CanvasSemaineCalendirer3;

  public GameObject CanvasCalendrierv1;
  public GameObject CanvasSemaineCalendirerv1;

  public GameObject CanvasCalendrier2v1;
  public GameObject CanvasSemaineCalendirer2v2;


  public GameObject CanvasStartStage;
  public GameObject CanvasStartStagev;

  public GameObject PauseAccueilPanel;

  public GameObject Chris1;
  public GameObject Didier1;

  public GameObject Chrisv1;
  public GameObject Didierv1;

  public GameObject Chrisf1;
  public GameObject Didierf1;

  public GameObject Chrisv2;
  public GameObject Didierv2;
  
  public GameObject Chris2;
  public GameObject Didier2;
  public GameObject Joe;
  public GameObject Patel;
  public GameObject Horloge1;
  public GameObject Horloge2;

  public GameObject fenwick;

  public GameObject wheelpack1;
  public GameObject wheelpack2;
  public GameObject wheelpack3;
  public GameObject wheelpack4;

 
 

  public void LoadSelectedSalle(int salle)
  {
    //Debug.Log("salle");
    //Debug.Log(salle);
    //SceneManager.LoadScene(salle);

    go = GameObject.FindGameObjectWithTag("menupausebtn");
    go.SetActive(true);

    //GameObject objective = GameObject.Find("GameObjective");
    //objective = objective.GetComponent<TextMeshPro>();
    //Debug.Log(objective);

   
    
  if(salle == 0){

  
    CanvasStart.SetActive(true);

    TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
    script.enabled = false;


    cameraSalle1 = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    //Camera.main.transform.Translate (-46, -76, 328);
    Debug.Log(cameraSalle1.transform.position);
    Debug.Log(Camera.main.transform.position); //(-53.59, -70.34, 325.14)
    //Camera.main.transform.Rotate(0, 0, 0);
    //Camera.main.transform.position = new UnityEngine.Vector3(-47, -76, 328);
     Camera.main.transform.position = new UnityEngine.Vector3(-53, -70, 325);
     Camera.main.transform.rotation = Quaternion.Euler(42f, 75f, 0f);
    
 
    CanvasAcceuil.SetActive(false);
    CanvasAcceuilv.SetActive(false);
    CanvasAcceuilf.SetActive(false);
    CanvasBE.SetActive(false);
    CanvasRH.SetActive(false);
    
    //CanvasAttelier.SetActive(false);
    //CanvasLProduction.SetActive(false);
    //CanvasMachine.SetActive(false);
    //CanvasMontage.SetActive(false);

    indice1accueil.SetActive(false);
    indice2accueil.SetActive(false);
    indice3accueil.SetActive(false);

    indice1accueilv.SetActive(false);
    indice2accueilv.SetActive(false);

    indice1accueilf.SetActive(false);
    indice2accueilf.SetActive(false);

    indice1accueils2.SetActive(false);
    indice2accueils2.SetActive(false);
    indice3accueils2.SetActive(false);

    indice1accueils2v.SetActive(false);
    indice2accueils2v.SetActive(false);

    indice1accueils3.SetActive(false);
    indice2accueils3.SetActive(false);
    indice3accueils3.SetActive(false);

    button2s1.SetActive(false);
    button2s2.SetActive(false);
    button2s3.SetActive(false);

    button2s1v.SetActive(false);
    button2s2v.SetActive(false);

    button2s1f.SetActive(false);
    button2s2f.SetActive(false);
    button2s3f.SetActive(false);
    button2s4f.SetActive(false);

    PauseAccueilPanel.SetActive(false);

    

    //GameObject.FindGameObjectWithTag("indice1accueil").GetComponent<Image>().gameObject.SetActive(true);
    //GameObject.FindGameObjectWithTag("indice2accueil").GetComponent<Image>().gameObject.SetActive(true);
    //GameObject.FindGameObjectWithTag("indice3accueil").GetComponent<Image>().gameObject.SetActive(true);
    //indice1accueil.SetActive(true);
    //indice2accueil = GameObject.FindGameObjectWithTag("indice2acceuil");
    //indice2accueil.SetActive(true);
    //indice3accueil = GameObject.FindGameObjectWithTag("indice3accueil");
    //indice3accueil.SetActive(true);
 
  
  }
  
    if(salle == 1){

       if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }


    CanvasStart.SetActive(false);
    
    
    CanvasAcceuilFade.SetActive(true);
    

    TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
    script.enabled = true;

    
    //CanvasAcceuilFade.SetActive(true);

    cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle1").GetComponent<Camera>();
    //Camera.main.transform.Translate (-46, -76, 328);
    Debug.Log(cameraSalle1.transform.position);
    Debug.Log(Camera.main.transform.position); //(-53.59, -70.34, 325.14)
    //Camera.main.transform.Rotate(0, 0, 0);
    //Camera.main.transform.position = new UnityEngine.Vector3(-47, -76, 328);
    Camera.main.transform.position = cameraSalle1.transform.position;
    
 
    CanvasAcceuil.SetActive(true);
    //CanvasAttelier.SetActive(false);
    //CanvasLProduction.SetActive(false);
    //CanvasMachine.SetActive(false);
    //CanvasMontage.SetActive(false);
    //cameraFade.StartFadeIn();
      CanvasStartStage.SetActive(true);
      DialogChris1.enableInteraction = true;

    indice1accueil.SetActive(true);
    indice2accueil.SetActive(true);
    indice3accueil.SetActive(true);

    indice1accueils2.SetActive(false);
    indice2accueils2.SetActive(false);
    indice3accueils2.SetActive(false);

    indice1accueils3.SetActive(false);
    indice2accueils3.SetActive(false);
    indice3accueils3.SetActive(false);

    indice1accueilv.SetActive(false);
    indice2accueilv.SetActive(false);

    indice1accueilf.SetActive(false);
   indice2accueilf.SetActive(false);

    button2s1.SetActive(false);
    button2s2.SetActive(false);
    button2s3.SetActive(false);

    button2s1v.SetActive(false);
    button2s2v.SetActive(false);

    Chrisv1.SetActive(false);
    Didierv1.SetActive(false);

    Chrisv2.SetActive(false);
    Didierv2.SetActive(false);

    Chris1.SetActive(true);
    Didier1.SetActive(true);

    

    //GameObject.FindGameObjectWithTag("indice1accueil").GetComponent<Image>().gameObject.SetActive(true);
    //GameObject.FindGameObjectWithTag("indice2accueil").GetComponent<Image>().gameObject.SetActive(true);
    //GameObject.FindGameObjectWithTag("indice3accueil").GetComponent<Image>().gameObject.SetActive(true);
    //indice1accueil.SetActive(true);
    //indice2accueil = GameObject.FindGameObjectWithTag("indice2acceuil");
    //indice2accueil.SetActive(true);
    //indice3accueil = GameObject.FindGameObjectWithTag("indice3accueil");
    //indice3accueil.SetActive(true);
 
  
  }

    if(salle == 2){

    /*cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle2").GetComponent<Camera>();

    Debug.Log(cameraSalle1.transform.position);

    Camera.main.transform.position = cameraSalle1.transform.position;

   CanvasAcceuil.SetActive(false);*/


    if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }


    CanvasStart.SetActive(false);

    CanvasBE.SetActive(true);
    CanvasRH.SetActive(false);

    TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
    script.enabled = true;

    cameraSalle1 = GameObject.FindGameObjectWithTag("CameraBE1").GetComponent<Camera>();

    Debug.Log(cameraSalle1.transform.position);
    Debug.Log(Camera.main.transform.position); 

    Camera.main.transform.position = cameraSalle1.transform.position;


  
  
  }


if(salle == 3){

   
    if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }


    CanvasStart.SetActive(false);

    CanvasBE.SetActive(false);
    CanvasRH.SetActive(true);

    TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
    script.enabled = true;

    cameraSalle1 = GameObject.FindGameObjectWithTag("CameraRH1").GetComponent<Camera>();

    Debug.Log(cameraSalle1.transform.position);
    Debug.Log(Camera.main.transform.position); 

    Camera.main.transform.position = cameraSalle1.transform.position;
    /*cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle3").GetComponent<Camera>();

    Debug.Log(cameraSalle1.transform.position);

    Camera.main.transform.position = cameraSalle1.transform.position;

   CanvasAcceuil.SetActive(false);*/

  
  
  }


if(salle == 4){


if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }


    CanvasStart.SetActive(false);
    CanvasAcceuilFadev.SetActive(true);

    CanvasBE.SetActive(false);
    CanvasRH.SetActive(false);
    CanvasAcceuil.SetActive(false);
    CanvasAcceuilv.SetActive(true);
    CanvasAcceuilf.SetActive(false);

    TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
    script.enabled = true;

    cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle4").GetComponent<Camera>();

    Debug.Log(cameraSalle1.transform.position);

    Camera.main.transform.position = cameraSalle1.transform.position;

    CanvasStartStagev.SetActive(true);
      DialogChris1.enableInteraction = true;

    indice1accueil.SetActive(false);
    indice2accueil.SetActive(false);
    indice3accueil.SetActive(false);

    indice1accueils2.SetActive(false);
    indice2accueils2.SetActive(false);
    indice3accueils2.SetActive(false);

    indice1accueils3.SetActive(false);
    indice2accueils3.SetActive(false);
    indice3accueils3.SetActive(false);

    button2s1.SetActive(false);
    button2s2.SetActive(false);
    button2s3.SetActive(false);

    button2s1v.SetActive(false);
    button2s2v.SetActive(false);


    Didier1.SetActive(false);
    Chris1.SetActive(false);

    Chrisv1.SetActive(true);
    Didierv1.SetActive(true);

    Chrisv2.SetActive(false);
    Didierv2.SetActive(false);

    indice1accueilv.SetActive(true);
    indice2accueilv.SetActive(true);


    indice1accueils2v.SetActive(false);
    indice2accueils2v.SetActive(false);
    indice3accueils2v.SetActive(false);


    


   

  }


if(salle == 5){

  if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }


    CanvasStart.SetActive(false);
    CanvasAcceuilFade.SetActive(true);

    CanvasBE.SetActive(false);
    CanvasRH.SetActive(false);
    CanvasAcceuil.SetActive(false);
    CanvasAcceuilv.SetActive(false);
    CanvasAcceuilf.SetActive(true);

    TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
    script.enabled = true;

    cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle6").GetComponent<Camera>();

    Debug.Log(cameraSalle1.transform.position);

    Camera.main.transform.position = cameraSalle1.transform.position;

   
    button2s1f.SetActive(false);
    button2s2f.SetActive(false);
    button2s3f.SetActive(false);
    button2s4f.SetActive(false);


    indice1accueilf.SetActive(true);
     indice2accueilf.SetActive(false);
  
  
  }






  }

  

    // Start is called before the first frame update
    void Start()
  {

    TrackballCamera_sansZoom script = Camera.main.GetComponent<TrackballCamera_sansZoom>();
    script.enabled = false;

    //MainCarnetPanel = GameObject.Find("PanelInvestigationMain");
    MainCarnetPanel.SetActive(false);
    fenwick.SetActive(false);

    wheelpack1.SetActive(false);
    wheelpack2.SetActive(false);
    wheelpack3.SetActive(false);
    wheelpack4.SetActive(false);

    Camera.main.transform.position = new UnityEngine.Vector3(-53, -70, 325); 
    Camera.main.transform.rotation = Quaternion.Euler(42f, 75f, 0f);

    

    CanvasHorloge.SetActive(false);
    CanvasCalendrier.SetActive(false);
    CanvasSemaineCalendirer.SetActive(false);

    CanvasCalendrier2.SetActive(false);
    CanvasSemaineCalendirer2.SetActive(false);

    CanvasCalendrier3.SetActive(false);
    CanvasSemaineCalendirer3.SetActive(false);

    CanvasCalendrierv1.SetActive(false);
    CanvasSemaineCalendirerv1.SetActive(false);

    CanvasCalendrier2v1.SetActive(false);
    CanvasSemaineCalendirer2v2.SetActive(false);

    CanvasChris1.SetActive(false);
    CanvasDidier1.SetActive(false);

    CanvasChrisv1.SetActive(false);
    CanvasDidierv1.SetActive(false);

    CanvasChrisf1.SetActive(false);
    CanvasDidierf1.SetActive(false);

    CanvasChrisv2.SetActive(false);
    CanvasDidierv2.SetActive(false);
    
    CanvasChris2.SetActive(false);
    CanvasDidier2.SetActive(false);
    
    //CanvasTMSChris = GameObject.Find("PanelChrisTMS");
    CanvasTMSChrisAcuueil.SetActive(false);
    //CanvasOrdiChris = GameObject.Find("PanelChrisOrdi");
    //CanvasOrdiChrisAcuueil.SetActive(false);

    //indice1accueil = GameObject.Find("indice1accueil");
    indice1accueil.SetActive(false);
    //indice2accueil = GameObject.Find("indice2acceuil");
    indice2accueil.SetActive(false);
    //indice3accueil = GameObject.Find("indice3accueil");
    indice3accueil.SetActive(false);

    indice1accueilv.SetActive(false);
    //indice2accueil = GameObject.Find("indice2acceuil");
    indice2accueilv.SetActive(false);
    //indice3accueil = GameObject.Find("indice3accueil");
   
    //GameObject.FindGameObjectWithTag("indice2accueil").GetComponent<Image>().gameObject.SetActive(false);
    //GameObject.FindGameObjectWithTag("indice3accueil").GetComponent<Image>().gameObject.SetActive(false);
   
    //CanvasAcceuil = GameObject.Find("CanvasAcceuil");
    CanvasAcceuil.SetActive(false);
    CanvasBE.SetActive(false);
    Joe.SetActive(false);
    Patel.SetActive(false);


    Chris2.SetActive(false);
    Didier2.SetActive(false);


    Chrisv1.SetActive(false);
    Didierv1.SetActive(false);

    
    Chrisv2.SetActive(false);
    Didierv2.SetActive(false);

    Horloge2.SetActive(false);

    //CanvasAttelier = GameObject.Find("CanvasAttelier");
    //CanvasAttelier.SetActive(false);

    //CanvasLProduction = GameObject.Find("CanvasLProduction");
    //CanvasLProduction.SetActive(false);

    //CanvasMachine = GameObject.Find("CanvasMachine");
    //CanvasMachine.SetActive(false);

    //CanvasMontage = GameObject.Find("CanvasMontage");
    //CanvasMontage.SetActive(false);
  

    /*GameObject tempObject = GameObject.Find("CanvasAcceuil");
    EscCan = tempObject.GetComponent<Canvas>();

    EscCan.enabled = false;*/
    //EscCan.enabled = false; 
  }

  // Update is called once per frame
  void Update()
  {

  }

  void Awake()
  {

  }



}
