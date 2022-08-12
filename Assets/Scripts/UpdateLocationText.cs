using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateLocationText : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI location;

    private void Update()
    {
        if (Location.Instance == null )
        {
             location.text = $"緯度: {null}\n経度: {null}\n高度: {null}\n\nCount: {null}\nMessage:\n{null}";
        }
        else
        {
            location.text = $"緯度: {Location.Instance.latitude}\n経度: {Location.Instance.longitude}\n高度: {Location.Instance.altitude}\n\nCount: {Location.Instance.gps_count}\nMessage:\n{Location.Instance.message}";
        }
    }
}