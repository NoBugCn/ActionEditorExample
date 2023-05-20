using NBC.ActionEditor;

namespace NBC.ActionEditorExample
{
    [Name("打印日志")]
    [Description("测试打印一个日志")]
    [Color(1, 0, 0)]
    [Attachable(typeof(SignalTrack))]
    public class TriggerLog : ActionClip
    {
        [MenuName("打印内容")] public string log;

        public override string info => "打印\n" + log;
        public override bool isValid => !string.IsNullOrEmpty(log);
    }
}