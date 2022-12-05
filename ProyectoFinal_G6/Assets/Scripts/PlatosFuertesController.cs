using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatosFuertesController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PolloOP(){

        SceneManager.LoadScene("ChickenOP");
    }

    public void PizzaOP(){

        SceneManager.LoadScene("PizzaSC");
    }

        public void BurguerOP(){

        SceneManager.LoadScene("BurguerSC");
    }


    public void Regresar(){

        SceneManager.LoadScene("FuertesMenu");
    }

    public void RegresarMenuPrincipal(){

        SceneManager.LoadScene("MainMenu");
    }
}
