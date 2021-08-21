using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using Microsoft.MixedReality.Toolkit.UI;

public class testFile : MonoBehaviour
{
    string path;
    public GameObject btn;

    public void OpenExplorer(string name)
    {
#if ENABLE_WINMD_SUPPORT
        btn.GetComponent<ButtonConfigHelper>().MainLabelText = name;
#endif
    }
}
