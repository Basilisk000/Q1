using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject objectToDisable,objectToEnable;
public void ButtonChange()
{objectToDisable.SetActive(False);
objectToEnable.SetActive(True);}
}
