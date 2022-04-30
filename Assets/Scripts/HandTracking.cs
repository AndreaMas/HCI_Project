using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] handPoints;
    public float t = 0.1f;

    // Update is called once per frame
    void Update()
    {
        //string data = udpReceive.data;
        string data = udpReceive.data;
        if (data != null)
        {
            data = data.Remove(0, 1);
            data = data.Remove(data.Length - 1, 1);
        }
        print(data);
        string[] points = data.Split(',');
        //print(points[0]);

        for (int i = 0; i < 21; i++)
        {
            float x = 6.5f - float.Parse(points[i * 3]) / 90;
            float y = float.Parse(points[i * 3 + 1]) / 100;
            float z = float.Parse(points[i * 3 + 2]) / 100;

            

            // instant movement
            handPoints[i].transform.localPosition = new Vector3(-x, -z, y);

        }

    }
}
