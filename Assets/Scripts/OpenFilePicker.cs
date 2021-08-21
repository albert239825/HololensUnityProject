using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if ENABLE_WINMD_SUPPORT
using Windows.Storage;
using Windows.Storage.Streams;
#endif

public class OpenFilePicker : MonoBehaviour
{
    public void OpenFile()
    {

#if ENABLE_WINMD_SUPPORT
        FilePicker();
#endif
    }

    private async void FilePicker()
    {
#if ENABLE_WINMD_SUPPORT
        var picker = new Windows.Storage.Pickers.FileOpenPicker();
        picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
        picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
        picker.FileTypeFilter.Add(".jpg");
        picker.FileTypeFilter.Add(".jpeg");
        picker.FileTypeFilter.Add(".png");
        
        await picker.PickSingleFileAsync();
#endif
    }
}
