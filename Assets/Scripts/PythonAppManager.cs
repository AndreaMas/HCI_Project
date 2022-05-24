using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PythonAppManager : MonoBehaviour
{
    private const string PythonAppName = "/PythonApp/dist/main/main.exe";

    private static Process PythonProcess;

    [RuntimeInitializeOnLoadMethod]
    private static void RunOnStart()
    {
        UnityEngine.Debug.Log(Application.dataPath + PythonAppName);

        ProcessStartInfo PythonInfo = new ProcessStartInfo();
        PythonInfo.FileName = Application.dataPath + PythonAppName;
        PythonInfo.WindowStyle = ProcessWindowStyle.Hidden;
        PythonInfo.CreateNoWindow = true;

        PythonProcess = Process.Start(PythonInfo);

        Application.quitting += () =>
            { if (!PythonProcess.HasExited) PythonProcess.Kill(); };
    }
}
