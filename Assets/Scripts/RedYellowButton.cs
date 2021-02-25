using UnityEngine;

[DisallowMultipleComponent]
public class RedYellowButton : MonoBehaviour
{
#pragma warning disable CS0649

    [SerializeField]
    private AnimatedRectController _rect;

#pragma warning restore CS0649

    public void OnClick()
    {
        _rect.SetRed();
        _rect.SetYellow();
    }
}