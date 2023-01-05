using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kursi : MonoBehaviour
{
    string objName;
    void Start(){

    }


    void Update(){
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit)) {
                objName = Hit.transform.name;
                switch (objName) {
                    case "Kursi_AR":
                        Application.OpenURL("https://www.tokopedia.com/ricoartfurniture/kursi-makan-cafe-stol-dingklik");
                        break;

                }
            }
        }
    }
}
