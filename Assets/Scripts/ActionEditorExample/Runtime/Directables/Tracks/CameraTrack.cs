using NBC.ActionEditor;
using UnityEngine;

namespace NBC.ActionEditorExample
{
    [Name("相机轨道")]
    [Description("这是一个相机轨道")]
    [ShowIcon(typeof(Camera))]
    [Color(1, 190f / 255f, 120f / 255f)]
    [Unique]
    public class CameraTrack : Track
    {
        public override string info => $"这是一个相机轨道啊，哈哈";
    }
}