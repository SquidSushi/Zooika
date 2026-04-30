using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class Dropper : MonoBehaviour
{
    // Todo D zeigt an, welches Objekt er fallen lassen wird

    public float XRange = 3;
    public float YPos = 4;
    public GameObject NextItem; // <- Umbenannt
    public GameObject[] Items;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        RollNewItem();
    }

    private void RollNewItem(){
        NextItem = Items[Random.Range(0, Items.Length)];
        Debug.Log($"{NextItem.name}");
    }

    // Update is called once per frame
    void Update(){
        Move();
        if (Mouse.current.leftButton.wasPressedThisFrame){
            Instantiate(NextItem, transform.position, Quaternion.identity);
            RollNewItem();
        }
    }


    private void Move(){
        var MousePos = Mouse.current.position.value;
        var WorldPos = Camera.main.ScreenToWorldPoint(MousePos);
        WorldPos.z = 0;
        WorldPos.y = YPos;
        WorldPos.x = Math.Clamp(WorldPos.x, -XRange, +XRange);
        transform.position = WorldPos;
    }
}
