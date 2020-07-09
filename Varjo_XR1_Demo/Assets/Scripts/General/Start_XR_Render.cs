using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_XR_Render : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Aloittaa renderöinnin, jotta xr objektit näkyvät oikeassa maailmassa. 
        Varjo.XR.VarjoMixedReality.StartRender();
    }
}
