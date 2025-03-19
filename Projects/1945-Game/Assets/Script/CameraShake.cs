using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;
    // Impulse Source 컴포넌트 참조
    private CinemachineImpulseSource impulseSource;

    void Awake()
    {
        CameraShake.instance.SetImpulseSource(gameObject.GetComponent<CinemachineImpulseSource>());
        CameraShake.instance.cameraShakeShow();
    }

    public void SetImpulseSource(CinemachineImpulseSource source)
    {
        impulseSource = source;
    }

    // 카메라쉐이크 동작
    public void cameraShakeShow()
    {
        if (impulseSource != null)
        {
            // 기본 설정으로 임펄스 생성
            impulseSource.GenerateImpulse();
        }
    }
}
