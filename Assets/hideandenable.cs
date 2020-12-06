using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideandenable : MonoBehaviour
{
    public GameObject Panel;
    int counter;
    private void hides()
    {

        counter++;
        if (counter % 2 == 1)
            Panel.SetActive(false);
        else
            Panel.SetActive(true);
    }
}
