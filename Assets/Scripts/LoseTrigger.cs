using UnityEngine;
using UnityEngine.Events;

public class LoseTrigger : MonoBehaviour{
    public static UnityEvent Failure = new();

    private void OnTriggerEnter2D(Collider2D other){
        Failure.Invoke();
    }
}
