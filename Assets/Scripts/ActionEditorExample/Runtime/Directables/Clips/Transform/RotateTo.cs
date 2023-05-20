using System;
using NBC.ActionEditor;
using UnityEngine;

namespace NBC.ActionEditorExample
{
    [Name("旋转角度")]
    [Description("将对象旋转一个角度")]
    [Color(70f / 255f, 1, 140f / 255f)]
    [Attachable(typeof(ActionTrack))]
    public class RotateTo : ActionClip
    {
        [SerializeField] [HideInInspector] private float length = 1f;

        [MenuName("运动曲线")] public EaseType interpolation = EaseType.QuadInOut;
        [MenuName("旋转角度")] public Vector3 targetRotation = Vector3.zero;

        public override float Length
        {
            get => length;
            set => length = value;
        }

        public override string info => $"旋转:\n{targetRotation}";

        public override bool isValid => true;

        private ActionTrack Track => (ActionTrack)Parent;
    }
}