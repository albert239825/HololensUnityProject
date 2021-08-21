using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

#if !UNITY_EDITOR && UNITY_WSA_10_0
using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
#endif   

    
    public class runFilePickerScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ImportFile()
    {
#if !UNITY_EDITOR && UNITY_WSA_10_0
		Debug.Log("***********************************");
		Debug.Log("File Picker start.");
		Debug.Log("***********************************");

		UnityEngine.WSA.Application.InvokeOnUIThread(async () =>
		{
			var filepicker = new FileOpenPicker();
			// filepicker.FileTypeFilter.Add("*");
			filepicker.FileTypeFilter.Add(".pcx");

			var file = await filepicker.PickSingleFileAsync();
			}, false);

		
		Debug.Log("***********************************");
		Debug.Log("File Picker end.");
		Debug.Log("***********************************");
#endif
    }

    void ReadTextFile(string path)
    {
        StreamReader sr = new StreamReader(new FileStream(path, FileMode.OpenOrCreate), System.Text.Encoding.UTF8);
        string fileText = sr.ReadToEnd();
        sr.Dispose();
        Debug.Log("***********************************");
        Debug.Log(" Text: " + fileText);
        Debug.Log("***********************************");
    }

    IEnumerator ReadTextFileCoroutine(string path)
    {

        Debug.Log("***********************************");
        Debug.Log(" Coroutine start: " + path);
        Debug.Log("***********************************");
        var www = new WWW("file://" + path);
        yield return www;

        string fileText = www.text;
        Debug.Log("***********************************");
        Debug.Log(" Text: " + fileText);
        Debug.Log("***********************************");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
