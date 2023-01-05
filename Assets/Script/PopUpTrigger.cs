using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTrigger : MonoBehaviour
{
    public void popupActiveT(GameObject obj) {
        obj.SetActive(true);
    }
    public void popupActiveF(GameObject obj) {
        obj.SetActive(false);
    }
    public void openToko(string toko) {
        Application.OpenURL(toko);
    }

    public void openItem(string item) {
        Application.OpenURL(item);
    }
}
