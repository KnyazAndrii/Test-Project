using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointBar : MonoBehaviour
{
    private TMP_Text _pointsText;

    private void Start()
    {
        _pointsText = GetComponentInChildren<TMP_Text>();
    }

    private void Update()
    {
        transform.LookAt(transform.position + Camera.main.transform.forward);
    }

    public void UpdatePoints(float points)
    {
        _pointsText.text = points.ToString();
    }
}
