using UnityEngine;

public class FloorController : MonoBehaviour
{
    void Start()
    {
        LoseTrigger.Failure.AddListener(OnFailure);
        ResetController.GameReset.AddListener(OnReset);
    }

    void OnFailure(){
        gameObject.SetActive(false);
    }

    void OnReset(){
        gameObject.SetActive(true);
    }
}
