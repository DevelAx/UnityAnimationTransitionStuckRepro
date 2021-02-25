using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class YellowButton : MonoBehaviour
{
#pragma warning disable CS0649

    [SerializeField]
    private AnimatedRectController _rect;

#pragma warning restore CS0649

    public void OnClick()
    {
        _rect.SetYellow();
    }
}