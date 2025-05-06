using System;
using TMPro;
using UnityEngine;

public class MoedasTextController : MonoBehaviour
{
    private TMP_Text moedasText;

    private void OnValidate()
    {
        if (moedasText == null)
        {
            moedasText = GetComponent<TMP_Text>();
        }
    }

    private void AtualizaMoedas(int grana)
    {
        moedasText.text = "Moedas: " + grana.ToString();
    }

    private void OnEnable()
    {
        PlayerObserverManager.OnMoedasChanged += AtualizaMoedas;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnMoedasChanged -= AtualizaMoedas;   
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
