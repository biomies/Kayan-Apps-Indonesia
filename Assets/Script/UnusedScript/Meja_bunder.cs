using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meja_bunder : MonoBehaviour
{
    string objName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit)) {
                objName = Hit.transform.name;
                switch (objName) {
                    case "Meja_Bunder_AR":
                        Application.OpenURL("https://www.tokopedia.com/ricoartfurniture/meja-tamu-bulat-bundar-besi-dan-kayu-jati-foyer-dispalay?extParam=whid%3D707986");
                        break;

                }
            }
        }
    }
}
