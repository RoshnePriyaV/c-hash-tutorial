using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class DestroyText : MonoBehaviour
{
    public float AutoDestroyTime=5f;
    private TextMeshProUGUI Text;
    private float SpawnTime;

    private void Awake()
    {
        Text=GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        SpawnTime=Time.time;
    }
    

    // Update is called once per frame
    void Update()
    {
        float remainingTime=(SpawnTime+AutoDestroyTime)-Time.time;
        Text.SetText($"{remainingTime:N2}");
        if(remainingTime<=0)
        {
            Destroy(gameObject);
        }
    }
}
