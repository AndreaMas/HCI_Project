using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] handPoints;
    [Space]
    public Button startButton;
    public Text startButtonText;
    [Space]
    public float t = 0.1f;
    public float waitStartTime = 2.75f;

    private bool isHandDetectorTransmitting = false;

    private void Start()
    {
        StartCoroutine(WaitForPythonLoading());
    }

    private void Update()
    {
        if (!isHandDetectorTransmitting) return;

        string data = udpReceive.data;
        if (data != null)
        {
            data = data.Remove(0, 1);
            data = data.Remove(data.Length - 1, 1);
        }
        //print(data);
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

    private IEnumerator WaitForPythonLoading()
    {
        string data;

        do
        {
            data = udpReceive.data;
            yield return null;
        }
        while (!data.Equals("True"));

        yield return new WaitForSecondsRealtime(waitStartTime);

        startButton.interactable = true;
        startButtonText.text = "Play!";

        isHandDetectorTransmitting = true;
        //StartCoroutine(GetHandData());
    }

    private IEnumerator GetHandData()
    {
        while (true)
        {
            string data = udpReceive.data;
            if (data != null)
            {
                data = data.Remove(0, 1);
                data = data.Remove(data.Length - 1, 1);
            }
            //print(data);
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

            yield return null;
        }
    }
}
