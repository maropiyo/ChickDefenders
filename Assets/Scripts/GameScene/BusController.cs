using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// バスの制御を行うクラス
/// </summary>
public class BusController : MonoBehaviour
{
    // アクセルトグル
    [SerializeField] private Toggle accelerateToggle;
    // 前進速度
    [SerializeField] private float speed;

    void Update()
    {
        if (accelerateToggle.isOn)
        {
            // 前進する
            MoveForward();
        }
    }

    /// <summary>
    /// 前進する
    /// </summary>
    private void MoveForward()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
