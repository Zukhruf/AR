using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayGPS : MonoBehaviour {

    public Text displayGPS;
	
	// Update is called once per frame
	void Update () {
        displayGPS.text = "Lat : " + GPS.Instance.latitude.ToString() + "  Lon : " + GPS.Instance.longitude.ToString();
    }
}
