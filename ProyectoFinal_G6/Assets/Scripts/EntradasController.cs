using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntradasController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TacosOP(){

        SceneManager.LoadScene("TacosSC");
    }

    public void HotDogOP(){

        SceneManager.LoadScene("HotDogSC");
    }


    public void Regresar(){

        SceneManager.LoadScene("EntradasMenu");
    }

    public void RegresarMenuPrincipal(){

        SceneManager.LoadScene("MainMenu");
    }
}
