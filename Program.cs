using Fjord;
using Fjord.Graphics;
using Fjord.Scenes;

class MainScene : Scene
{
    double rectAngle = 0f;
    public MainScene(int width, int height, string id) : base(width, height, id)
    {
    }

    public override void Awake()
    {
        SetClearColor(255, 251, 254, 255);
    }

    public override void Sleep()
    {
        
    }

    public override void Update()
    {
        rectAngle += 10 * Game.GetDeltaTime();

        new Rectangle(new(WindowSize.X / 2, WindowSize.Y / 2, 200, 200))
            .Color(new(231, 130, 132, 255))
            .Fill(true)
            .RenderToTexture()
            .Center(Center.Middle)
            .Angle((float)rectAngle)
            .Render();
    }
}

class Program
{
    static void Main()
    {
        Game.Initialize("Fjord", 1920, 1080);

        SceneHandler.Register(new MainScene(1920, 1080, "Main").SetRelativeWindowSize(0, 0, 1, 1));
        SceneHandler.Load("Main");

        Game.Run();
    }
}