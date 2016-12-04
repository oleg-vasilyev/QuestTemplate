namespace QuestTemplate.Models
{
	class AffectedCharacter
	{
		//public AffectedCharacterState State { get; private set; }
		public int HP { get; set; }
		private readonly int DefaultHp = 10;

		//public AffectedCharacter(AffectedCharacterState originalState)
		public AffectedCharacter()
		{
			//State = originalState;
			HP = DefaultHp;
		}
	}
}
