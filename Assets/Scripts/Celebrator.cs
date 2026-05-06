
using UnityEngine;

public class Celebrator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Confetti;
    private AudioSource _audioSource;
    
    void Start()
    {
        SuikaBall.Merge.AddListener(OnMerge);
        _audioSource = GetComponent<AudioSource>();
    }

    public void OnMerge(int Level, Vector3 Position){
        Position -= Vector3.forward;
        const float minimumPitch = 2;
        const float maximumPitch = 0.5f;
        float t = Level / 10f;
        _audioSource.pitch = Mathf.Lerp(minimumPitch, maximumPitch, t);
        _audioSource.Play();
        for (int i = 0; i < Level * Level; i++){
            Instantiate(Confetti, Position, Quaternion.identity);
        }
    }
}
