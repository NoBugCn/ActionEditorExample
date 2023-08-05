namespace NBC.ActionEditorExample
{
    /// <summary>
    /// 技能配置，（模拟真实项目存在的技能数值配置）
    /// </summary>
    public class SkillConfig
    {
        public int Id;

        public int Atk;
        public int Def;

        /// <summary>
        /// 时间轴配置名
        /// </summary>
        public string EventName;


        private SkillAsset _skillAsset;

        public SkillAsset EventConfig
        {
            get
            {
                if (_skillAsset == null)
                {
#if UNITY_EDITOR
                    //演示直接使用editor的资源方法
                    _skillAsset =
                        UnityEditor.AssetDatabase.LoadAssetAtPath<SkillAsset>($"Assets/ResRaw/Skill/{EventName}.asset");
#endif
                }

                return _skillAsset;
            }
        }
    }
}