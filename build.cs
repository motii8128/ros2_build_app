using UnityEngine;
using UnityEditor;
using System.IO;
using System.Diagnostics;
using System.Collections;

public class build : MonoBehaviour
{

	void Start(){
        
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
    public void OnClick()
    {
        var output1 = DoBashCommand("cd ~/workdir && colcon build");
        UnityEngine.Debug.Log(output1);
    }
}
