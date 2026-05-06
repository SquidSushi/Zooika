using UnityEngine;
using UnityEngine.Events;

public class ResetController : MonoBehaviour{
    public static UnityEvent GameReset = new();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnClick(){
        GameReset.Invoke();
    }
}
