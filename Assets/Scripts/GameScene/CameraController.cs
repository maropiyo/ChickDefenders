using UnityEngine;

/// <summary>
/// カメラの制御を行うクラス
/// </summary>
public class CameraController : MonoBehaviour
{
    // バスのTransformコンポーネント
    [SerializeField] private Transform target;
    // バスとカメラの距離
    public Vector3 offset;

    void Update()
    {
        // バスの位置にoffsetを加えた位置にカメラを移動する
        transform.position = target.position + offset;
    }
}
