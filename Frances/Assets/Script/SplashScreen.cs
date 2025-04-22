using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class SplashScreen : MonoBehaviour
{
    public Image Splash;
    void Start()
    {
        Invoke("IrParaMainMenu", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IrParaMainMenu()
    {
        Splash.gameObject.SetActive(false);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.LoadScene("MainMenu");
    }
}
