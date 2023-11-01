using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneCheck : MonoBehaviour
{
    public Text ZoneText;

    public void TextChange(int zoneLv)
    {
        ZoneText.text = $"Zone : {zoneLv}";
    }
}
