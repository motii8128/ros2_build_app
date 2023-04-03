using UnityEngine;
using UnityEditor;
using System.IO;
using System.Diagnostics;
using System.Collections;

public class run : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        var output3 = DoBashCommand("cd ~/workdir && bash test.sh");
        UnityEngine.Debug.Log(output3);
    }
    static string DoBashCommand(string cmd){
        var p = new Process();
        p.StartInfo.FileName = "/bin/bash";
        p.StartInfo.Arguments = "-c \" " + cmd + " \"";
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.Start();

        var output = p.StandardOutput.ReadToEnd();
        p.WaitForExit();
        p.Close();

        return output;
    }
}
