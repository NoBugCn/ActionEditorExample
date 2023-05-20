using System;
using NBC.ActionEditor;
using UnityEngine;

namespace NBC.ActionEditorExample
{
    [Name("移动")]
    [Description("将对象移动一定距离")]
    [Color(70f / 255f, 1, 140f / 255f)]
    [Attachable(typeof(ActionTrack))]
    public class MoveBy : ActionClip
    {
        [SerializeField] [HideInInspector] private float length = 1;

        [MenuName("运动曲线")] public AnimationCurve curve;

        [MenuName("运动补间")] public EaseType interpolation = EaseType.QuadInOut;

        [MenuName("移动量")] public Vector3 move;

        public override string info => $"位移:\n{move}";

        public override float Length
        {
            get => length;
            set => length = value;
        }


        public override bool isValid => true;

        private ActionTrack Track => (ActionTrack)Parent;
    }
}