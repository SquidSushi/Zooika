using UnityEngine;

public class FloorController : MonoBehaviour
{
    void Start()
    {
        LoseTrigger.Failure.AddListener(OnFailure);
    }

    void OnFailure(){
        gameObject.SetActive(false);
    }

}
