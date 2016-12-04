using System;

namespace QuestTemplate.Models
{
	public class QuestAnswer
	{
		public string Text { get; private set; }
        public QuestAnswerResult QuestAnswerResult { get; private set; }
        public bool IsLastScene { get; private set; }
		public QuestAnswer(string text, double resultSceneId, int affectedCharacterHpChange = 0, bool isMainCharacterAlive = true, bool isLastScene = false)
		{
			Text = text;
            QuestAnswerResult = new QuestAnswerResult(resultSceneId, affectedCharacterHpChange, isMainCharacterAlive);
            IsLastScene = isLastScene;
		}

    }
}

