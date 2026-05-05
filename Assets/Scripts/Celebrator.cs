
using UnityEngine;

public class Celebrator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Confetti;
    void Start()
    {
        SuikaBall.Merge.AddListener(OnMerge);
    }

    public void OnMerge(int Level, Vector3 Position){
        Debug.Log("Der Celebrator hat ein Merge-Event wahrgenommen!");
        for (int i = 0; i < Level; i++){
            Instantiate(Confetti, Position, Quaternion.identity);
        }
    }
}
