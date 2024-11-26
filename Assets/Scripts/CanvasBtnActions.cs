using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBtnActions : MonoBehaviour
{
   public GameObject button2s1;
   public GameObject button2s2;
   public GameObject button2s3;

   public GameObject button2s1v;
    public GameObject button2s2v;

    static private GameObject CanvasChris;
    static private GameObject Wheelout;
    static private GameObject CanvasTMSChris;
    static private GameObject CanvasOrdiChris;
    // Start is called before the first frame update

    public GameObject Carnet1;
    public GameObject Carnet2;
    public GameObject Carnet3;

    public GameObject CanvasCalendrier;
    public GameObject CanvasSemaineCalendirer;
    public GameObject CanvasCalendrier2;
    public GameObject CanvasSemaineCalendirer2;

    public GameObject CanvasCalendrier3;
    public GameObject CanvasSemaineCalendirer3;

    public GameObject CanvasStart2;
    public GameObject CanvasStart2fade;
    public GameObject CanvasStart3;
    public GameObject CanvasStart3fade;
    public GameObject CanvasValidation;
    public GameObject CarR1;
    public GameObject CarR2;
    public GameObject CarR3;

    public GameObject CarB1;
    public GameObject CarB2;

    public GameObject LiftCar1;
    public GameObject LiftCar2;

    public GameObject imageCarnet1;
    public GameObject imageCarnet2;
    public GameObject imageCarnet3;
    public GameObject textCarnet1;
    public GameObject textCarnet2;
    public GameObject textCarnet3;
    public GameObject Joe;

    public GameObject Joe2;
    public GameObject Patel;

    public GameObject Horloge1;
    public GameObject Horloge2;

    public GameObject Chris1;
  public GameObject Didier1;
  
  public GameObject Chris2;
  public GameObject Didier2;

  public GameObject Chris3;
  public GameObject Didier3;


   public GameObject Chrisv1;
  public GameObject Didierv1;
  
  public GameObject Chrisv2;
  public GameObject Didierv2;



  public GameObject fenwick;

  public GameObject wheelpack1;
  public GameObject wheelpack2;
  public GameObject wheelpack3;
  public GameObject wheelpack4;

    
    
    private GameObject SaveBtnChrisTms;
    private GameObject SaveBtnChrisOrdi;
    private GameObject SaveBtnChris;
    public GameObject indice1accueil;
    static private bool indice1accueilActive = false;
    public GameObject indice2accueil;
    static private bool indice2accueilActive = false;
    public GameObject indice3accueil;
    static private bool indice3accueilActive = false;
    static private Camera cameraSalle1;

    public GameObject indice1accueilv;
    static private bool indice1accueilActivev = false;
    public GameObject indice2accueilv;
    static private bool indice2accueilActivev = false;


    public GameObject indice1accueils2;
    static private bool indice1accueilActives2 = false;
    public GameObject indice2accueils2;
    static private bool indice2accueilActives2 = false;
    public GameObject indice3accueils2;
    static private bool indice3accueilActives2 = false;

    public GameObject indice1accueils2v;
    static private bool indice1accueilActives2v = false;
    public GameObject indice2accueils2v;
    static private bool indice2accueilActives2v = false;
    public GameObject indice3accueils2v;
    static private bool indice3accueilActives2v = false;

    public GameObject indice1accueils3;
    static private bool indice1accueilActives3 = false;
    public GameObject indice2accueils3;
    static private bool indice2accueilActives3 = false;
    public GameObject indice3accueils3;
    static private bool indice3accueilActives3 = false;

  



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CloseCanvasSemaineCalendrier()
    {
        CanvasChris = GameObject.Find("CanvasSemaineCalendrier");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasCalendrier()
    {
        CanvasChris = GameObject.Find("CanvasCalendrier");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasSemaineCalendrier2()
    {
        CanvasChris = GameObject.Find("CanvasSemaineCalendrier2");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasSemaineCalendrier3()
    {
        CanvasChris = GameObject.Find("CanvasSemaineCalendrier3");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasCalendrier2()
    {
        CanvasChris = GameObject.Find("CanvasCalendrier2");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasCalendrier3()
    {
        CanvasChris = GameObject.Find("CanvasCalendrier3");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasChris()
    {
        CanvasChris = GameObject.Find("CanvasChris1");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasChrisv1()
    {
        CanvasChris = GameObject.Find("CanvasChrisv1");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasChrisv2()
    {
        CanvasChris = GameObject.Find("CanvasChrisv2");
        CanvasChris.SetActive(false);
        DialogChris1.enableInteraction = false;

    }

    public void CloseCanvasPatel()
    {
        CanvasChris = GameObject.Find("CanvasPatel");
        CanvasChris.SetActive(false);
        DialogPatel.enableInteraction3 = false;

    }

    public void Quizz()
    {

        CanvasValidation.SetActive(true);

    }

    public void CloseCanvasChris2()
    {
         CanvasChris = GameObject.Find("CanvasChris2");
        CanvasChris.SetActive(false);
        DialogChris2.enableInteraction2 = false;

    }

    public void CloseCanvasChris3()
    {
         CanvasChris = GameObject.Find("CanvasChris3");
        CanvasChris.SetActive(false);

        DialogPatel.enableInteraction3 = false;

    }

    public void CloseTMSCanvasChris()
    {

        CanvasTMSChris = GameObject.Find("CanvasChrisTMS");
        CanvasTMSChris.SetActive(false);
        DialogChris1.enableInteraction = false;
    }

    public void CloseTMSCanvasChrisv1()
    {

        CanvasTMSChris = GameObject.Find("CanvasChrisTMSv1");
        CanvasTMSChris.SetActive(false);
        DialogChris1.enableInteraction = false;
    }

    

    public void CloseCanvasDidier()
    {

        CanvasOrdiChris = GameObject.Find("CanvasDidier");
        CanvasOrdiChris.SetActive(false);
        DialogChris1.enableInteraction = false;
    }

    public void CloseCanvasDidierv1()
    {

        CanvasOrdiChris = GameObject.Find("CanvasDidierv1");
        CanvasOrdiChris.SetActive(false);
        DialogChris1.enableInteraction = false;
    }

    public void CloseCanvasDidierv2()
    {

        CanvasOrdiChris = GameObject.Find("CanvasDidierv2");
        CanvasOrdiChris.SetActive(false);
        DialogChris1.enableInteraction = false;
    }


    public void CloseCanvasDidier2()
    {

        CanvasOrdiChris = GameObject.Find("CanvasDidier2");
        CanvasOrdiChris.SetActive(false);
        DialogChris2.enableInteraction2 = false;
    }


    public void CloseCanvasHorloge()
    {

        CanvasOrdiChris = GameObject.Find("CanvasHorlogesTravail");
        CanvasOrdiChris.SetActive(false);
        DialogChris1.enableInteraction = false;
        
        


    }

    public void CloseCanvasStartStage()
    {

        CanvasOrdiChris = GameObject.Find("CanvasStartStage");
        CanvasOrdiChris.SetActive(false);
        DialogChris1.enableInteraction = false;
    }


    public void CloseCanvasStartStagev()
    {

        CanvasOrdiChris = GameObject.Find("CanvasStartStagev");
        CanvasOrdiChris.SetActive(false);
        DialogChris1.enableInteraction = false;
    }


    public void CloseCanvasStart2()
    {

        CanvasOrdiChris = GameObject.Find("CanvasStartStage2");
        CanvasOrdiChris.SetActive(false);
        DialogChris2.enableInteraction2 = false;
    }


    public void CloseCanvasStart3()
    {

        CanvasOrdiChris = GameObject.Find("CanvasStartStage3");
        CanvasOrdiChris.SetActive(false);
        DialogPatel.enableInteraction3 = false;
    }


    public void CloseCanvasJoe()
    {
        CanvasOrdiChris = GameObject.Find("CanvasJoe");
        CanvasOrdiChris.SetActive(false);
        DialogChris2.enableInteraction2 = false;
       
    }

    public void CloseCanvasJoe2()
    {
        CanvasOrdiChris = GameObject.Find("CanvasJoe2");
        CanvasOrdiChris.SetActive(false);
        DialogPatel.enableInteraction3 = false;
    }

     public void SaveObjectCarnet3()
    {

        Debug.Log("hereobjectcarnet2");
        Debug.Log(indice1accueilActives2);
        Debug.Log(indice2accueilActives2);
        Debug.Log(indice3accueilActives2);
        SaveBtnChrisTms = GameObject.Find("ButtonSaveChrisTMS3");
        SaveBtnChrisTms.SetActive(false);

        

        if (indice1accueilActives3 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            

            Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
            textCarnet1.GetComponent<TextMeshProUGUI>().text = "Hello World";

            indice1accueilActives3 = true;

            
            

        }

        else if (indice2accueilActives3 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //indice2accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
        

            Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice2accueilActives3 = true;

        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
           

            Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice3accueilActives3 = true;

        }

        if (indice1accueilActives3 & indice2accueilActives3 & indice3accueilActives3)
        {
            button2s3.SetActive(true);
        }



        //Carnet1 = GameObject.Find("carnet1");
        //Carnet1.SetActive(false);
        //Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
    }


    public void SaveObjectCarnet2()
    {

        Debug.Log("hereobjectcarnet2");
        Debug.Log(indice1accueilActives2);
        Debug.Log(indice2accueilActives2);
        Debug.Log(indice3accueilActives2);
        SaveBtnChrisTms = GameObject.Find("ButtonSaveChrisTMS2");
        SaveBtnChrisTms.SetActive(false);

        

        if (indice1accueilActives2 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            

            Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
            textCarnet1.GetComponent<TextMeshProUGUI>().text = "Hello World";

            indice1accueilActives2 = true;

            
            

        }

        else if (indice2accueilActives2 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //indice2accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
        

            Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice2accueilActives2 = true;

        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
           

            Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice3accueilActives2 = true;

        }

        if (indice1accueilActives2 & indice2accueilActives2 & indice3accueilActives2)
        {
            button2s2.SetActive(true);
        }



        //Carnet1 = GameObject.Find("carnet1");
        //Carnet1.SetActive(false);
        //Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
    }


    public void SaveObjectCarnet()
    {

        Debug.Log("here");
        Debug.Log(indice1accueilActive);
        Debug.Log(indice2accueilActive);
        Debug.Log(indice3accueilActive);
        SaveBtnChrisTms = GameObject.Find("ButtonSaveChrisTMS");
        SaveBtnChrisTms.SetActive(false);

        

        if (indice1accueilActive == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            

            Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
            textCarnet1.GetComponent<TextMeshProUGUI>().text = "Hello World";

            indice1accueilActive = true;
            

        }

        else if (indice2accueilActive == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //indice2accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
        

            Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice2accueilActive = true;

        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
           

            Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice3accueilActive = true;

        }

        if (indice1accueilActive & indice2accueilActive & indice3accueilActive)
        {
            button2s1.SetActive(true);
        }



        //Carnet1 = GameObject.Find("carnet1");
        //Carnet1.SetActive(false);
        //Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
    }

    
      public void SaveObjectCarnetv1()
    {

        Debug.Log("here");
        Debug.Log(indice1accueilActivev);
        Debug.Log(indice2accueilActivev);

        SaveBtnChrisTms = GameObject.Find("ButtonSaveChrisTMSv");
        SaveBtnChrisTms.SetActive(false);

        

        if (indice1accueilActivev == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueilv.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            

            //Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
            //textCarnet1.GetComponent<TextMeshProUGUI>().text = "Hello World";

            indice1accueilActivev = true;
            

        }

        else 
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueilv.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //indice2accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
        

            //Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice2accueilActivev = true;

        }

        

        if (indice1accueilActivev & indice2accueilActivev )
        {
            button2s1v.SetActive(true);
        }



        //Carnet1 = GameObject.Find("carnet1");
        //Carnet1.SetActive(false);
        //Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
    }


     public void SaveObjectCarnetv2()
    {

        Debug.Log("here");
        Debug.Log(indice1accueilActivev);
        Debug.Log(indice2accueilActivev);

        SaveBtnChrisTms = GameObject.Find("ButtonSaveChrisTMSv2");
        SaveBtnChrisTms.SetActive(false);

        

        if (indice1accueilActives2v == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils2v.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            

            //Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
            //textCarnet1.GetComponent<TextMeshProUGUI>().text = "Hello World";

            indice1accueilActives2v = true;
            

        }

        else 
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils2v.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //indice2accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
        

            //Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            //imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

            indice2accueilActives2v = true;

        }

        

        if (indice1accueilActives2v & indice2accueilActives2v )
        {
            button2s2v.SetActive(true);
        }



        //Carnet1 = GameObject.Find("carnet1");
        //Carnet1.SetActive(false);
        //Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
    }
    
    public void SaveChrisObjectCarnet()
    {

        Debug.Log("hereChris");
        Debug.Log(indice1accueilActive);
        Debug.Log(indice2accueilActive);
        Debug.Log(indice3accueilActive);
        SaveBtnChris = GameObject.Find("ButtonEnregisChris");
        SaveBtnChris.SetActive(false);

        if (indice1accueilActive == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActive = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        else if (indice2accueilActive == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActive = true;

         Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
         imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActive = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActive & indice2accueilActive & indice3accueilActive)
        {
            button2s1.SetActive(true);
        }


    }

    public void SaveChrisOrdiObjectCarnet()
    {

        Debug.Log("hereChrisOrdi");
        Debug.Log(indice1accueilActive);
        Debug.Log(indice2accueilActive);
        Debug.Log(indice3accueilActive);
        SaveBtnChrisOrdi = GameObject.Find("ButtonSaveOrdi");
        SaveBtnChrisOrdi.SetActive(false);

        if (indice1accueilActive == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActive = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        else if (indice2accueilActive == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActive = true;

             Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueil.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActive = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActive & indice2accueilActive & indice3accueilActive)
        {
            button2s1.SetActive(true);
        }


    }


 public void SaveChris2s2()
    {

        Debug.Log("hereChris");
        Debug.Log(indice1accueilActives2);
        Debug.Log(indice2accueilActives2);
        Debug.Log(indice3accueilActives2);
        SaveBtnChris = GameObject.Find("ButtonSaveChris2");
        SaveBtnChris.SetActive(false);

        if (indice1accueilActives2 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActives2 = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        else if (indice2accueilActives2 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActives2 = true;

         Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
         imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActives2 = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActives2 & indice2accueilActives2 & indice3accueilActives2)
        {
            button2s2.SetActive(true);
        }


    }


    public void SaveDidier2s2()
    {

        Debug.Log("hereChris");
        Debug.Log(indice1accueilActives2);
        Debug.Log(indice2accueilActives2);
        Debug.Log(indice3accueilActives2);
        SaveBtnChris = GameObject.Find("ButtonSaveDider2");
        SaveBtnChris.SetActive(false);

        if (indice1accueilActives2 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActives2 = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        else if (indice2accueilActives2 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActives2 = true;

         Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
         imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActives2 = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActives2 & indice2accueilActives2 & indice3accueilActives2)
        {
            button2s2.SetActive(true);
        }


    }


      public void SaveJoe2s2()
    {

        Debug.Log("hereChris");
        Debug.Log(indice1accueilActives2);
        Debug.Log(indice2accueilActives2);
        Debug.Log(indice3accueilActives2);
        SaveBtnChris = GameObject.Find("ButtonSaveJoe2");
        SaveBtnChris.SetActive(false);

        if (indice1accueilActives2 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActives2 = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
             

        }

        else if (indice2accueilActives2 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActives2 = true;

         Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
         imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils2.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActives2 = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActives2 & indice2accueilActives2 & indice3accueilActives2)
        {
            button2s2.SetActive(true);
        }


    }


  public void SaveJoe2s3()
    {

        Debug.Log("hereChris");
        Debug.Log(indice1accueilActives2);
        Debug.Log(indice2accueilActives2);
        Debug.Log(indice3accueilActives2);
        SaveBtnChris = GameObject.Find("ButtonSaveJoe3");
        SaveBtnChris.SetActive(false);

        if (indice1accueilActives3 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActives3 = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
             

        }

        else if (indice2accueilActives3 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActives3 = true;

         Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
         imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActives3 = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActives3 & indice2accueilActives3 & indice3accueilActives3)
        {
            button2s3.SetActive(true);
        }


    }


 public void SaveChris2s3()
    {

       
        SaveBtnChris = GameObject.Find("ButtonSaveChris3");
        SaveBtnChris.SetActive(false);

        if (indice1accueilActives3 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActives3 = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        else if (indice2accueilActives3 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActives3 = true;

         Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
         imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActives3 = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActives3 & indice2accueilActives3 & indice3accueilActives3)
        {
            button2s3.SetActive(true);
        }


    }


public void SavePatel()
    {

       
        SaveBtnChris = GameObject.Find("ButtonSavePatel");
        SaveBtnChris.SetActive(false);

        if (indice1accueilActives3 == false)
        {

            //indice1accueil = GameObject.Find("indice1accueil");
            //indice1accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice1accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice1accueilActives3 = true;

             Carnet1.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet1.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        else if (indice2accueilActives3 == false)
        {

            //indice2accueil = GameObject.Find("indice2acceuil");
            Image indice2accueil2 = indice2accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice2accueilActives3 = true;

         Carnet2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
         imageCarnet2.GetComponent<Image>().color = new Color32(255, 255, 36, 200);
        }

        else
        {

            //indice3accueil = GameObject.Find("indice3accueil");
            //indice3accueil.GetComponent<Image>().color = new Color32(255, 158, 36, 200);

            Image indice2accueil2 = indice3accueils3.GetComponent<Image>();
            indice2accueil2.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
            indice3accueilActives3 = true;

             Carnet3.GetComponent<Image>().color = new Color32(255, 158, 36, 200);
             imageCarnet3.GetComponent<Image>().color = new Color32(255, 255, 36, 200);

        }

        if (indice1accueilActives3 & indice2accueilActives3 & indice3accueilActives3)
        {
            button2s3.SetActive(true);
        }


    }




public void Goscene2(){

        CanvasStart2fade.SetActive(true);
        DialogChris2.enableInteraction2 = true;
        
        
        Horloge1.SetActive(false);

        cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle2").GetComponent<Camera>();
        Camera.main.transform.position = cameraSalle1.transform.position;

        Joe.SetActive(true);
        CanvasOrdiChris = GameObject.Find("CanvasJoe");
        CanvasOrdiChris.SetActive(false);

        Wheelout = GameObject.FindGameObjectWithTag("wheelout");
        Wheelout.SetActive(false);

       
        Horloge1.SetActive(false);
        Horloge2.SetActive(true);

        Chris1.SetActive(false);
        Didier1.SetActive(false);

        Chris2.SetActive(true);
        Didier2.SetActive(true);

        CanvasStart2.SetActive(true);

        CanvasCalendrier.SetActive(false);
        CanvasSemaineCalendirer.SetActive(false);

        CanvasCalendrier2.SetActive(true);
        CanvasSemaineCalendirer2.SetActive(true);

        //CarR1.SetActive(false);
        //CarR2.SetActive(false);
        //CarR3.SetActive(true);

        //LiftCar1.SetActive(false);
        //LiftCar2.SetActive(true);

        //CarB1.SetActive(false);
        //CarB2.SetActive(true);

        button2s1.SetActive(false);

        indice1accueil.SetActive(false);
        indice2accueil.SetActive(false);
        indice3accueil.SetActive(false);

        indice1accueils2.SetActive(true);
        indice2accueils2.SetActive(true);
        indice3accueils2.SetActive(true);


        fenwick.SetActive(true);

        wheelpack1.SetActive(true);
        wheelpack2.SetActive(true);
        wheelpack3.SetActive(true);
        wheelpack4.SetActive(true);

        
}



public void Goscene3(){

        
CanvasStart3fade.SetActive(true);
        
       

        cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle3").GetComponent<Camera>();
        Camera.main.transform.position = cameraSalle1.transform.position;
        Camera.main.transform.rotation = cameraSalle1.transform.rotation;

        CanvasCalendrier2.SetActive(false);
        CanvasSemaineCalendirer2.SetActive(false);

        CanvasCalendrier3.SetActive(true);
        CanvasSemaineCalendirer3.SetActive(true);


        DialogPatel.enableInteraction3 = true;

        //Patel.SetActive(true);

        //Didier3.SetActive(true);
        Didier2.SetActive(false);

        Chris3.SetActive(true);
        Chris2.SetActive(false);

        Joe2.SetActive(true);
        Joe.SetActive(false);

        CanvasStart3.SetActive(true);


        button2s2.SetActive(false);

        indice1accueils2.SetActive(false);
        indice2accueils2.SetActive(false);
        indice3accueils2.SetActive(false);

        indice1accueils3.SetActive(true);
        indice2accueils3.SetActive(true);
        indice3accueils3.SetActive(true);

        
}



public void Goscene2v(){

        CanvasStart2fade.SetActive(true);
        DialogChris2.enableInteraction2 = true;
        
        
        Horloge1.SetActive(false);

        cameraSalle1 = GameObject.FindGameObjectWithTag("CameraSalle5").GetComponent<Camera>();
        Camera.main.transform.position = cameraSalle1.transform.position;

        //Joe.SetActive(true);
        //CanvasOrdiChris = GameObject.Find("CanvasJoe");
        //CanvasOrdiChris.SetActive(false);

        //Wheelout = GameObject.FindGameObjectWithTag("wheelout");
        //Wheelout.SetActive(false);

       
        //Horloge1.SetActive(false);
        //Horloge2.SetActive(true);

        //Chris1.SetActive(false);
        //Didier1.SetActive(false);

        //Chris2.SetActive(true);
        //Didier2.SetActive(true);

        //CanvasStart2.SetActive(true);

        //CanvasCalendrier.SetActive(false);
       //CanvasSemaineCalendirer.SetActive(false);

        //CanvasCalendrier2.SetActive(true);
        //CanvasSemaineCalendirer2.SetActive(true);

        //CarR1.SetActive(false);
        //CarR2.SetActive(false);
        //CarR3.SetActive(true);

        //LiftCar1.SetActive(false);
        //LiftCar2.SetActive(true);

        //CarB1.SetActive(false);
        //CarB2.SetActive(true);

        button2s1.SetActive(false);

        

        indice1accueils2v.SetActive(true);
        indice2accueils2v.SetActive(true);
        indice3accueils2v.SetActive(true);


        Chrisv1.SetActive(false);
        Didierv1.SetActive(false);

        Chrisv2.SetActive(true);
        Didierv2.SetActive(true);

        
}

}


