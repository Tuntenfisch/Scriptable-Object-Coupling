using Unity.Mathematics;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Variables
{
    [CreateAssetMenu(fileName = "Camera Variable", menuName = "Tuntenfisch/Commons/Coupling/Variables/New Camera Variable")]
    public class CameraVariable : Variable<Camera>
    {

    }

    [CreateAssetMenu(fileName = "Float 1 Variable", menuName = "Tuntenfisch/Commons/Coupling/Variables/New Float 1 Variable")]
    public class Float1Variable : Variable<float>
    {

    }

    [CreateAssetMenu(fileName = "Float 2 Variable", menuName = "Tuntenfisch/Commons/Coupling/Variables/New Float 2 Variable")]
    public class Float2Variable : Variable<float2>
    {

    }

    [CreateAssetMenu(fileName = "Float 3 Variable", menuName = "Tuntenfisch/Commons/Coupling/Variables/New Float 3 Variable")]
    public class Float3Variable : Variable<float3>
    {

    }

    [CreateAssetMenu(fileName = "Game Object Variable", menuName = "Tuntenfisch/Commons/Coupling/Variables/New Game Object Variable")]
    public class GameObjectVariable : Variable<GameObject>
    {

    }

    [CreateAssetMenu(fileName = "String Variable", menuName = "Tuntenfisch/Commons/Coupling/Variables/New String Variable")]
    public class StringVariable : Variable<string>
    {

    }

    [CreateAssetMenu(fileName = "Transform Variable", menuName = "Tuntenfisch/Commons/Coupling/Variables/New Transform Variable")]
    public class TransformVariable : Variable<Transform>
    {

    }
}