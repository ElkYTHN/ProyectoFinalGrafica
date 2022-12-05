using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioEscenaEntradas(){

        SceneManager.LoadScene("EntradasMenu");
    }

        public void CambioEscenaBebidas(){

        SceneManager.LoadScene("BebidasMenu");
    }

        public void CambioEscenaPlatosFuertes(){

        SceneManager.LoadScene("FuertesMenu");
    }

        public void CambioEscenaEntradasPostres(){

        SceneManager.LoadScene("PostresMenu");
    }

    public void Exit(){

        Application.Quit();
        Debug.Log("Salir");
    }
    
}
