using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ImageScreen : MonoBehaviour
{
    [SerializeField] private Image imgBase;
    public void Show(Sprite sprite)
    {
        imgBase.gameObject.SetActive(true);
        imgBase.sprite = sprite;
        imgBase.rectTransform.DOScale(Vector3.one, 1f).From(Vector3.zero);
    }
}
