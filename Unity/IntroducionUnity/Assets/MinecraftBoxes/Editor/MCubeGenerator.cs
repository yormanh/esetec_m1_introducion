//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEditor;
//using UnityEditor.AnimatedValues;
//using UnityEditor.SceneManagement;

//namespace MinecraftTool
//{
//	public class MCubeGenerator : EditorWindow 
//	{
//		///Textura base de recursos
//		private Texture2D _resourceTex;

//		///Geometria con UVS prepadas del cubo
//		private Mesh _resourceCubeMesh;

//		///Geometria con UVS prepadas del player
//		private Mesh _resourcePlayerMesh;

//		///Posicion actual del scroll en la vista de lista
//		private Vector2 _scrollPosition;

//		///Crea el proximo cubo con un efecto bilboard
//		private bool _bBilboard;

//		///Nombre para el cubo personalziado
//		private string _nameCustom = string.Empty;

//		///Lista de iconos para la vista personalizada
//		private Texture2D[] _iconTextures;

//		///AnimBool para controlar el FadeControl de la interfaz
//		private AnimBool _fieldHeader;	
//		private AnimBool _fieldAll;	
//		private AnimBool _fieldCustom;	
//		private AnimBool _fieldList;
//		private AnimBool _fieldPlayers;

//		//User Inputs para los valores personalizados
//		private int _idTop;
//		private int _idBottom;
//		private int _idForward;
//		private int _idBack;
//		private int _idRight;
//		private int _idLeft;

//		[MenuItem("GameObject/Minecraft Tool")]
//		public static void ShowWindow()
//		{
//			var window = GetWindow<MCubeGenerator>();
//			window.Show();
//		}

//		void OnEnable()
//		{
//			Initialize();

//			// EditorSceneManager.sceneLoaded += delegate(Scene s1, LoadSceneMode s2)
//			// {
//			// 	Debug.Log("ESceneaaa");
//			// 	Initialize();
//			// };
//		}



//		void OnGUI()
//		{
//            MenuHeader();
//            _scrollPosition = GUILayout.BeginScrollView(_scrollPosition);

//			//Submenu Acerca de
//			//_fieldHeader.target = EditorGUILayout.ToggleLeft("Acerca de...", _fieldHeader.target);
//			//if (EditorGUILayout.BeginFadeGroup(_fieldHeader.faded))
//			//{
//			//	MenuHeader();
//			//}
//			//EditorGUILayout.EndFadeGroup();

//			//Submenu Lista de objetos conocidos
//			_fieldList.target = EditorGUILayout.ToggleLeft("Lista", _fieldList.target);
//			if (EditorGUILayout.BeginFadeGroup(_fieldList.faded))
//			{
//				MenuSavedList();
//			}
//			EditorGUILayout.EndFadeGroup();

//			//Submenu Personalizado (crear tu propio cubo)
//			_fieldCustom.target = EditorGUILayout.ToggleLeft("Personalizado", _fieldCustom.target);
//			if (EditorGUILayout.BeginFadeGroup(_fieldCustom.faded))
//			{
//				MenuCustom();
//			}
//			EditorGUILayout.EndFadeGroup();

//			//Submenu Jugadores
//			_fieldPlayers.target = EditorGUILayout.ToggleLeft("Jugadores", _fieldPlayers.target);
//			if (EditorGUILayout.BeginFadeGroup(_fieldPlayers.faded))
//			{
//				MenuPlayers();
//			}
//			EditorGUILayout.EndFadeGroup();

//			//Submenu Lista de tods los objetos disponibles en el resourceTexture
//			_fieldAll.target = EditorGUILayout.ToggleLeft("Todos", _fieldAll.target);
//			if (EditorGUILayout.BeginFadeGroup(_fieldAll.faded))
//			{
//				MenuAll();
//			}
//			EditorGUILayout.EndFadeGroup();

//			GUILayout.EndScrollView();
//		}

//		///<summary>
//		/// Inicia las texturas de icono para manejarlas mas rapido
//		/// asi como datos basicos de la ventana (nombre, icono, ...)
//		///</summary>
//		public void Initialize()
//		{
//			_fieldCustom = new AnimBool(true);
//			_fieldCustom.valueChanged.AddListener(Repaint);
//			_fieldCustom.value = false;

//			_fieldAll = new AnimBool(true);
//			_fieldAll.valueChanged.AddListener(Repaint);
//			_fieldAll.value = false;

//			_fieldList = new AnimBool(true);
//			_fieldList.valueChanged.AddListener(Repaint);
//			_fieldList.value = false;

//			_fieldPlayers = new AnimBool(true);
//			_fieldPlayers.valueChanged.AddListener(Repaint);
//			_fieldPlayers.value = false;

//			_fieldHeader = new AnimBool(true);
//			_fieldHeader.valueChanged.AddListener(Repaint);
//			_fieldHeader.value = true;


//			_resourceTex = Resources.Load<Texture2D>("texturePack");
//			_resourceCubeMesh = Resources.Load<Mesh>("cube");
//			_resourcePlayerMesh = Resources.Load<Mesh>("player");

//		    this.titleContent = new GUIContent
//            {
//                text = "Minecraft Tool",
//                image = Resources.Load<Texture2D>("icon")
//            };
//			GenerteThumnails();
//		}

//		///<summary>
//		/// Dibuja la introducción de esta herramienta
//		///</summary>
//		void MenuHeader()
//		{
//			GUILayout.Label("Minecraft Tool (v.1.0.0b)", EditorStyles.largeLabel);

//			//if(GUILayout.Button("Abrir Escena de Ejemplo"))
//			//{
//			//	if(EditorUtility.DisplayDialog("Abrir", "¿Quieres abrir la escena de ejemplo? Perderas el progreso actual no guardado", "Sí", "No"))
//			//	{
//			//		EditorSceneManager.OpenScene("Assets/MinecraftBoxes/exampleScene.unity", OpenSceneMode.Single);
//			//	}
//			//}
//			//if(GUILayout.Button("Recargar"))
//			//{
//			//	Initialize();
//			//}
//			GUILayout.Space(10);
//		}

//		///<summary>
//		/// Procedural para crear un cubo personalizado
//		///</summary>
//		void MenuCustom()
//		{
//			GUILayout.BeginHorizontal();
//			DrawItemCustom("FORWARD (+Z)", ref _idForward);
//			if(!_bBilboard) DrawItemCustom("LEFT (-X)", ref _idLeft);
//			if(!_bBilboard) DrawItemCustom("RIGHT (+X)", ref _idRight);
//			GUILayout.EndHorizontal();
			
//			GUILayout.Space(5);
			
//			GUILayout.BeginHorizontal();
//			if(!_bBilboard) DrawItemCustom("TOP (+Y)", ref _idTop);
//			if(!_bBilboard) DrawItemCustom("BACK (-Z)", ref _idBack);
//			if(!_bBilboard) DrawItemCustom("BOTTOM (-Y)", ref _idBottom);
//			GUILayout.EndHorizontal();

//			GUILayout.Space(15);

//			_bBilboard = GUILayout.Toggle(_bBilboard, "Bilboard");

//			GUILayout.BeginHorizontal();
//			_nameCustom = GUILayout.TextField(_nameCustom, GUILayout.Width(150));

//			//if(GUILayout.Button("Añadir a Lista"))
//			//{
//			//	string entry = string.Empty;

					
//			//	if(!_bBilboard)
//			//	{
//			//		entry = string.Format("\n{0}={1},{2},{3},{4},{5},{6}"
//			//								, _nameCustom
//			//								, _idLeft
//			//								, _idBottom
//			//								, _idForward
//			//								, _idBack
//			//								, _idRight
//			//								, _idTop);
//			//	}
//			//	else
//			//	{
//			//		entry = string.Format("\n{0}={1}"
//			//							, _nameCustom
//			//							, _idForward);
//			//	}
								
//			//	//TODO: Demasiado lento, probar otro modo
//			//	var textAsset = Resources.Load<TextAsset>("list");
//			//	System.IO.File.WriteAllText(AssetDatabase.GetAssetPath(textAsset), textAsset.text + entry);
//			//	EditorUtility.SetDirty(textAsset);
//			//	EditorApplication.RepaintProjectWindow();

//			//	Repaint();
//			//}
			
//			if(GUILayout.Button("Create"))
//			{
//				GenerateCube(new[]{
//					!_bBilboard ? _idLeft 	: 68,
//					!_bBilboard ? _idBottom : 68,
//					_idForward,
//					!_bBilboard ? _idBack 	: 68,
//					!_bBilboard ? _idRight 	: 68,
//					!_bBilboard ? _idTop 	: 68
//				}
//				, _nameCustom
//				, _bBilboard);
//			}

//			GUILayout.EndHorizontal();
//		}

//		///<summary>
//		/// Procedural auxiliar del metodo MenuCustom para dibujar
//		/// cada cara junto a su nombre, textura y valor
//		///</summary>
//		void DrawItemCustom(string name, ref int value)
//		{
//			GUILayout.FlexibleSpace();
//			GUILayout.BeginVertical();
			
//			GUILayout.BeginHorizontal();
//			GUILayout.FlexibleSpace();
//			GUILayout.Label(name,EditorStyles.boldLabel);
//			GUILayout.FlexibleSpace();
//			GUILayout.EndHorizontal();

//			GUILayout.BeginHorizontal();
//			GUILayout.FlexibleSpace();
//			GUILayout.Label(_iconTextures[value]);
//			GUILayout.FlexibleSpace();
//			GUILayout.EndHorizontal();

//			GUILayout.BeginHorizontal();
//			if(GUILayout.Button("<")) --value;
//			value = EditorGUILayout.IntField(value, GUILayout.Width(40));
//			if(GUILayout.Button(">")) ++value;
//			GUILayout.EndHorizontal();
			
			

//			value = Mathf.Clamp(value, 0, _iconTextures.Length-1);
//			GUILayout.EndVertical();
//			GUILayout.FlexibleSpace();
//		}

//		///<summary>
//		/// Procedural para crear la lista completa de objetos
//		/// que se pueden crear
//		///</summary>
//		void MenuAll()
//		{
//			for(int x = 0; x < 64; x++)
//			{
//				GUILayout.BeginHorizontal();
//				for(int y = 0; y < 4; y++)
//				{
//					GUILayout.BeginVertical();
//					int id = x*4+y;
//					Texture2D tex = _iconTextures[id];

//					if(GUILayout.Button(tex, GUILayout.Width(50)))
//					{
//						GenerateCube(new[]{id,id,id,id,id,id});
//					}
//					GUILayout.Label("ID: " + id, EditorStyles.largeLabel);

//					GUILayout.EndVertical();
//				}
//				GUILayout.EndHorizontal();
//			}
//		}

//		///<summary>
//		/// Procedural para crear la lista completa de objetos
//		/// que se pueden crear
//		///</summary>
//		void MenuPlayers()
//		{
//			var files = Resources.LoadAll<Texture2D>("skins");
//			foreach(var v in files)
//			{
//				if(GUILayout.Button(v.name)) GeneratePlayer(v.name);
//			}

//			GUILayout.Space(20);
//			if(GUILayout.Button("Más skins"))
//			{
//				Application.OpenURL("http://www.minecraftskins.net/");
//			}
//		}

//		///<summary>
//		/// Dibuja una lista de elementos basandose en el fichero
//		/// list de la carpeta resources. Para cargar cada carga preconfiguada
//		///</summary>
//		void MenuSavedList()
//		{
//			string list = Resources.Load<TextAsset>("list").text;
//			string[] lines = list.Split('\n');

//			foreach(var line in lines)
//			{
//				string[] nameValues = line.Split('=');
//				if(nameValues.Length != 2) continue;

//				string[] numberValues = nameValues[1].Split(',');
//				bool isBilboard = numberValues.Length < 6;


//				int left = 0, bottom = 0, forward = 0, back = 0, right = 0, top = 0;
				
//				bool b = 
//				numberValues.Length == 6 
//				&& int.TryParse(numberValues[0], out left)
//				&& int.TryParse(numberValues[1], out bottom)
//				&& int.TryParse(numberValues[2], out forward)
//				&& int.TryParse(numberValues[3], out back)
//				&& int.TryParse(numberValues[4], out right)
//				&& int.TryParse(numberValues[5], out top)
				
//				||

//				nameValues.Length == 2 
//				&& int.TryParse(nameValues[1], out forward);

//				GUILayout.BeginHorizontal();
//				GUILayout.Label(_iconTextures[forward]);
//				//if(GUILayout.Button("X"))
//				//{
//				//	if(EditorUtility.DisplayDialog("Borrar", "¿Quieres borrar este registro de la lista?", "Sí", "No"))
//				//	{

//				//	}
//				//}
//				GUILayout.FlexibleSpace();
				
//				if(GUILayout.Button(nameValues[0]/*, EditorStyles.largeLabel*/))
//				{
//					if(!b){
//						EditorUtility.DisplayDialog("Error", "Valoes erroneos", "ok");
//						return;
//					}
					
//					GenerateCube(new int[]{left,bottom,forward,back,right,top}, nameValues[0],  isBilboard);
//				}
//				GUILayout.FlexibleSpace();
				
//				GUILayout.EndHorizontal();
//			}
//		}
		

//		///<summary>
//		/// Crea un cubo de caras personalizadas
//		///</summary>
//		public void GenerateCube(int[] sides, string nameCube = "Cube", bool bBilboard = false)
//		{
//			if(sides.Length != 6) throw new System.ArgumentException("sides debe tener una longitud de 6");

//			Texture2D texture = !bBilboard ? GenerteTex(sides) : GenerteTex(new[] {68, 68, sides[2], 68, 68, 68});

//			texture.wrapMode = TextureWrapMode.Clamp;
//			texture.filterMode = FilterMode.Point;

//			GameObject cube = new GameObject(nameCube);
//			MeshRenderer ren = cube.AddComponent<MeshRenderer>();
//			MeshFilter fil = cube.AddComponent<MeshFilter>();

//			fil.mesh = _resourceCubeMesh;
			
//			//Creamos un material Standard-Cutout
//			Material material = new Material(Shader.Find("Standard"));
//			material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
//			material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
//			material.SetInt("_ZWrite", 1);
//			material.EnableKeyword("_ALPHATEST_ON");
//			material.DisableKeyword("_ALPHABLEND_ON");
//			material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
//			material.renderQueue = 2450;
//			material.name = "MinecratMaterial";

//			ren.sharedMaterial = material;
//			ren.sharedMaterial.SetTexture("_MainTex", texture);

//			if(bBilboard)
//			{
//				cube.AddComponent<MBillboard>();
//				cube.transform.localScale = new Vector3(1,1,0.1f);
//			}
//		}

//        /// <summary>
//        /// Crea la geometria para personajes de Minecraft 1.0.0 (FatBody) y le
//        /// aplica la textura indicada por nameSkin
//        /// </summary>
//		private void GeneratePlayer(string nameSkin)
//		{
//			Texture2D tex = Resources.Load<Texture2D>("skins/" + nameSkin);
//			tex.wrapMode = TextureWrapMode.Clamp;
//			tex.filterMode = FilterMode.Point;

//			if(!tex)
//			{
//				EditorUtility.DisplayDialog("Error", "No se puede cargar el skin", "Ok");
//				return;
//			}

//			var player = new GameObject(nameSkin);
//			var ren = player.AddComponent<MeshRenderer>();
//			var fil = player.AddComponent<MeshFilter>();
//			var mat = new Material(Shader.Find("Standard"));

//			mat.SetTexture("_MainTex", tex);
//			fil.mesh = _resourcePlayerMesh;
//			ren.sharedMaterial = mat;
//		}

//		///<summary>
//		/// Genera todos los iconos de los botones disponibles
//		/// en la ventana de Minecraft Tool
//		///</summary>
//		void GenerteThumnails()
//		{
//			_iconTextures = new Texture2D[256];
//			for(int x = 0; x < 16; x++)
//			{
//				for(int y = 0; y < 16; y++)
//				{
//					int id = x * 16 + y;

//					int row = id % 16;
//					int colum = id / 16;

//					Texture2D tex = new Texture2D(32,32);
//					Color[] colors = _resourceTex.GetPixels(row*32,colum*32,32,32,0);
//					tex.SetPixels(colors);

//					tex.Apply();
//					_iconTextures[id] = tex;
//				}
//			}
//		}

//		///<summary>
//		/// Genera una textura de 6 caras, donde cada cara
//		/// corresponde con uno de los id del resourceTex
//		/// indicados por su parametro int[] sides
//		///</summary>
//		Texture2D GenerteTex(int[] sides)
//		{
//			Texture2D tex = new Texture2D(96,96); // 32pixeles plus 3 rows
			
//			var pixels = tex.GetPixels();
//			for(int i = 0; i < pixels.Length; i++)
//			{
//				pixels[i] = Color.black;
//			}
//			tex.SetPixels(pixels);
			
			
//			for(int x = 0; x < 3; x++)
//			{
//				for(int y = 0; y < 2; y++)
//				{
//					int index = x*2+y;
//					int row = sides[index] % 16;
//					int colum = sides[index] / 16;
//					Color[] colors = _resourceTex.GetPixels(row*32,colum*32, 32,32,0);

//					tex.SetPixels(x * 32, y * 32, 32, 32, colors, 0);
//				}	
//			}

//			tex.Apply();
//			return tex;
//		}
//	}

//}
