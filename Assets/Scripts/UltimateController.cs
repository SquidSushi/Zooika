using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UltimateController : MonoBehaviour{
    private float _charge;
    private Slider _slider;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        _slider = GetComponent<Slider>();
        ResetController.GameReset.AddListener(OnReset);
        SuikaBall.Merge.AddListener(OnMerge);
    }
    
    [ContextMenu("Charge Fully")]
    private void ChargeFully(){
        _charge = 1;
        UpdateUI();
    }

    private void OnMerge(int level, Vector3 position){
        _charge += 0.015f;
        if (_charge > 1) _charge = 1;
        UpdateUI();
    }

    private void UpdateUI(){
        _slider.value = _charge;
    }

    private void OnReset(){
        _charge = 0;
        UpdateUI();
    }

    private void Update(){
        if (_charge >= 1 && Mouse.current.rightButton.wasPressedThisFrame){
            bool succesful = false;
            Vector3 MousePosInWorld = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            var hits = Physics2D.OverlapCircleAll(MousePosInWorld, 0.1f);
            foreach (var hit in hits){
                SuikaBall suikaBall = hit.gameObject.GetComponent<SuikaBall>();
                if (suikaBall == null) continue;
                Destroy(hit.gameObject);
                succesful = true;
                break;
            }

            if (succesful){
                _charge = 0;
                UpdateUI();
            }
        }
    }
}
