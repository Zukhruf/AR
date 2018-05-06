using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayWatch : MonoBehaviour {

    public Text Jam;
	
	
	// Update is called once per frame
	void Update () {

        DateTime waktu = DateTime.Now;
        String jam = waktu.Hour.ToString().PadLeft(2, '0');
        String menit = waktu.Minute.ToString().PadLeft(2, '0');
        String detik = waktu.Second.ToString().PadLeft(2, '0');

        Jam.text = jam + ":" + menit + ":" + detik;

    }
}
