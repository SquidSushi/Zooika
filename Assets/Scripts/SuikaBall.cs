using System;
using UnityEngine;

public class SuikaBall : MonoBehaviour{
    private void OnCollisionEnter2D(Collision2D other){
        var otherSuika = other.gameObject.GetComponent<SuikaBall>();
    //  ^ var deklariert eine Variable, dessen Typ vom Kontext ermittelt wird.
    //  In diesem fall "SuikaBall"
    //                         ^ Wir holen vom anderen Collider das gameObject
    //                                    ^ Und holen uns davon einen Component vom Typen "SuikaBall"
        if (otherSuika == null){ //Also wenn das andere Objekt keinen Suika Ball hat
            return; //early return, wir brechen die Funktion ab.
        }
        Debug.Log("Ich habe einen Ball berührt!");
    }
}