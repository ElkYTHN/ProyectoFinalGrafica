using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BebidaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SodaOP(){

        SceneManager.LoadScene("SodaSC");
    }

    public void CafeOP(){

        SceneManager.LoadScene("CafeSC");
    }

    public void AguaOP(){

        SceneManager.LoadScene("AguaSC");
    }

    public void Regresar(){

        SceneManager.LoadScene("BebidasMenu");
    }

    public void RegresarMenuPrincipal(){

        SceneManager.LoadScene("MainMenu");
    }

}
