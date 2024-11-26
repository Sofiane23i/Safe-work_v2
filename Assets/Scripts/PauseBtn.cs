using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public GameObject btnPause;
    // Start is called before the first frame update
    void Start()
    {
        btnPause.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
         btnPause.SetActive(true);
    }
}
