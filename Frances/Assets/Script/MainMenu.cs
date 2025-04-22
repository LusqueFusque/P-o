using UnityEngine;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Button ButtonStart;
    public Button ButtonExit;
    void Start()
    {
        ButtonStart.onClick.AddListener(OnStartClick);
        ButtonExit.onClick.AddListener(OnQuitClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.LoadScene("Game");
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }

}
