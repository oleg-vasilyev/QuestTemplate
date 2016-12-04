using System.Collections.Generic;

namespace QuestTemplate.Models
{
	class Scene
	{
		public double Id { get; private set; }
		public string ImagePath { get; private set; }
		public string Text { get; private set; }
		public IEnumerable<QuestAnswer> QuestAnswerSet { get; private set; }

		public Scene(double id, string imagePath, string text, IEnumerable<QuestAnswer> questAnswerSet)
		{
			Id = id;
			ImagePath = imagePath;
			Text = text;
			QuestAnswerSet = questAnswerSet;
		}

	}
}
