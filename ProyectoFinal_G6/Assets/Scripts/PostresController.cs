using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostresController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void DonasOP(){

        SceneManager.LoadScene("DonasSC");
    }

    public void PastelOP(){

        SceneManager.LoadScene("PastelSC");
    }


    public void Regresar(){

        SceneManager.LoadScene("PostresMenu");
    }

    public void RegresarMenuPrincipal(){

        SceneManager.LoadScene("MainMenu");
    }
}
