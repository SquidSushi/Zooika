using System;
using UnityEngine;

public class SuikaBall : MonoBehaviour{
    public int Level = 0;
    public GameObject Next;

    private void OnCollisionEnter2D(Collision2D other){
        var otherSuika = other.gameObject.GetComponent<SuikaBall>();
        //  ^ var deklariert eine Variable, dessen Typ vom Kontext ermittelt wird.
        //  In diesem fall "SuikaBall"
        //                         ^ Wir holen vom anderen Collider das gameObject
        //                                    ^ Und holen uns davon einen Component vom Typen "SuikaBall"
        if (otherSuika == null){ //Also wenn das andere Objekt keinen Suika Ball hat
            return; //early return, wir brechen die Funktion ab.
        }

        //Debug.Log("Ich habe einen Ball berührt!");
        if (Level == otherSuika.Level){
            //Debug.Log($"Und wir sind vom selben Level ({Level})");
            Destroy(gameObject);
            if (Next != null){
                if (gameObject.GetInstanceID() > other.gameObject.GetInstanceID()){
                    Vector3 middle = Vector3.Lerp(transform.position, other.transform.position, 0.5f);
                    Instantiate(Next, middle, Quaternion.identity);
                }
            }
        }
    }
}