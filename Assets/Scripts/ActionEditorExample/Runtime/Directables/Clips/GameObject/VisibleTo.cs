﻿using System;
using NBC.ActionEditor;
using UnityEngine;

namespace NBC.ActionEditorExample
{
    [Name("显示隐藏")]
    [Description("设置对象的显示或隐藏")]
    [Color(1, 90f / 255f, 90f / 255f)]
    [Attachable(typeof(ActionTrack))]
    public class VisibleTo : ActionClip
    {
        [SerializeField] [HideInInspector] private float length = 1f;

        [MenuName("显示")] public bool visible = true;

        public override float Length
        {
            get => length;
            set => length = value;
        }

        public override string info => $"{(visible ? "显示" : "隐藏")}";

        public override bool isValid => true;

        private ActionTrack Track => (ActionTrack)Parent;
    }
}