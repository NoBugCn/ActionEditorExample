using NBC.ActionEditor;
using UnityEngine;

namespace NBC.ActionEditorExample
{
    [Name("移动至")]
    [Description("将对象移动一定距离")]
    [Color(70f / 255f, 1, 140f / 255f)]
    [Attachable(typeof(ActionTrack))]
    public class MoveTo : ActionClip
    {
        [SerializeField] [HideInInspector] private float length = 1;

        [MenuName("运动补间")] public EaseType interpolation = EaseType.QuadInOut;
        
        [MenuName("位移终点")] [OptionParam(typeof(MoveToType))]
        public int moveType;

        
        public override string info => $"移动至:\n{AttributesUtility.GetMenuName(moveType, typeof(MoveToType))}";

        public override float Length
        {
            get => length;
            set => length = value;
        }


        public override bool isValid => true;

        private ActionTrack Track => (ActionTrack)Parent;
    }
}