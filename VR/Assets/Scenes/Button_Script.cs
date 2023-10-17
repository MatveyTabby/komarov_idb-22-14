using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Testobj;
    public bool isCubeActive = true;

    private void Start()
    {
        // Инициализация состояния объекта
        SetCubeActive(isCubeActive);
    }
    public void Active()
    {
        isCubeActive =! isCubeActive;
        SetCubeActive(isCubeActive);
    }

    private void SetCubeActive(bool isActive)
    {
        // Устанавливаем состояние активности объекта
        gameObject.SetActive(isActive);
    }
}