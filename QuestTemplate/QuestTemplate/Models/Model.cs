using System;

namespace QuestTemplate.Models
{
	class Model
	{
        private Data _data;
        private AffectedCharacter _character;

        public string GameOverText { get; private set; }
		public event Action GameOver;

		public Model()
		{
            _data = new Data();
            _character = new AffectedCharacter();	           		
		}

        public Scene GetStartScene()
        {
            return _data.GetSceneById(1);
        }
		public Scene ProcessQuestAnswer (QuestAnswer questAnswer)
		{
            _character.HP += questAnswer.QuestAnswerResult.AffectedCharacterHpChange;
            if (_character.HP <= 0)
            {
                GameOverText = "Игра окончена. Пострадавший умер.";
                GameOver();
                return null;
            }
            if (questAnswer.IsLastScene)
            {
                if (_character.HP >= 9) GameOverText = "Игра окончена. Вы блестяще оказали первую помощь пострадавшему. Рабочий полностью выздоровел после этого проишествия.";
                else
                    if (_character.HP >= 4) GameOverText = "Игра окончена. Вам удалось оказать первую помощь вовремя. Рабочему удалось избежать серьёзных травм.";
                       else GameOverText = "Игра окончена. Вам удалось спасти жизнь рабочему, однако вы не оказали ему должной помощи и он на всю оставшуюся жизнь останется инвалидом.";

                GameOver();
                return null;
            }
            if (!questAnswer.QuestAnswerResult.IsMainCharacterAlive)
            {
                GameOverText = "Игра окончена. Вы погибли.";
                GameOver();
                return null;
            }
           
            return _data.GetSceneById(questAnswer.QuestAnswerResult.NextSceneId);
		}
        public QuestAnswer GetBlankAnswer()
        {
            return new QuestAnswer("-----", -1, 0, true);
        }
    }
}
