using TMPro;
using UnityEngine;

public class WinnerTextController : MonoBehaviour{
    private TextMeshProUGUI _textMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        _textMeshPro = GetComponent<TextMeshProUGUI>();
        _textMeshPro.enabled = false;
        SuikaBall.GameWin.AddListener(OnGameWin);
    }

    void OnGameWin(){
        Debug.Log("WinnerTextController hat GameWin empfangen");
        _textMeshPro.enabled = true;
    }
    
}
