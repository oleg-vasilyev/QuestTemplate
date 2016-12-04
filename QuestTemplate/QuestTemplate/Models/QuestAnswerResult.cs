namespace QuestTemplate.Models
{
    public class QuestAnswerResult
    {
        public double NextSceneId { get; private set; }
        public int AffectedCharacterHpChange { get; private set; }
        public bool IsMainCharacterAlive  { get; private set; }

        public QuestAnswerResult(double nextSceneId, int affectedCharacterHpChange, bool isMainCharacterAlive = true)
        {
            NextSceneId = nextSceneId;
            AffectedCharacterHpChange = affectedCharacterHpChange;
            IsMainCharacterAlive = isMainCharacterAlive;
        }
    }
}
