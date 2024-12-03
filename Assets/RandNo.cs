using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNum : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text1;
    [SerializeField] private float minBoundry = 0f;
    [SerializeField] private float maxBoundry = 0f;

    private float ranNumber = 0f;

    // Update is called once per frame
    void Update()
    {

        ranNumber = Random.Range(minBoundry, maxBoundry);
        text1.SetText(ranNumber.ToString("N2"));


    }

}