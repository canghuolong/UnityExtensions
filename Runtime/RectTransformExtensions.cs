using UnityEngine;

public static class RectTransformExtensions
{
    public static void MatchParentSize(this RectTransform rt, bool preservePivot)
    {
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.sizeDelta = Vector3.zero; // same size as anchors
        var piv = rt.pivot;
        rt.pivot = Vector2.one * .5f; // center pivot
        rt.anchoredPosition = Vector3.zero; // centered at the anchors' center

        if (preservePivot)
            rt.pivot = piv;
    }
    
    public static void SetWidth(this RectTransform rect, float width)
    {
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
    }

    public static void SetHeight(this RectTransform rect, float height)
    {
        rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
    }
}