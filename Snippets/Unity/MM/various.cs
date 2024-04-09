// Events


// System
public class GameManager : MonoBehaviour {
	
	// Singleton
	public static GameManager Instance;
	
	protected void Awake() {
		if (Instance == null){
			Instance = this;
		}
	}
	protected void OnEnable(){
		
	}
	protected void OnDisable(){
		
	}

	// Events
	public class Events {
		public UnityEvent<string data> OnGameStart;
		// etc...
	}
	
	// Level
	public class LevelManager {
	 public static void CompleteLevel(string levelName);
	}
	
	public class IOManager {
	 public static void Pause();
	 public static void SetCheckpoint(string currentSavePoint);
	 public static void SetSaveFile(string saveFileName);
	 public static void Save(string currentSaveFileName);
	 public static void Load(string saveFileName)
	}
	
	// Screen FX
	public class VFXManager {
	 public void VFXScreenFreeze(/* args */);
	 public void VFXTakeHeavyDamage(/* args */);
	 public void VFXSuperAttack(/* args */);
	 public void VFXBossDefeatedFX(/* args */);
	}

	// Tips + UI
	public class TutorialManager {
		public void FetchTip();
		public void ShowNextTip();
		public void HideTip();
	}
	
	
	// Game IO
	public void HandleLoadNextLevel(string levelName);
	public void 
	
} 

	public void HandleGameOver();
public class PlayableCharacter : MonoBehaviour;

// Bot
public class Bot : MonoBehaviour;
public class BotXXXComponent : MonoBehaviour;

// Player
public class XXXXComponent : MonoBehaviour;
