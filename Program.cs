using Fjord;
using Fjord.Modules.Game;

namespace Template_Game {
    // Scene class this is where your game is 

    public class main : scene
    {
        public override void on_load()
        {
            // This is where you load all your scenes 
            // The if statement is so that it doesn't trigger multiple times

            if(!scene_handler.get_scene("game-template")) {

                // Add all scenes
                scene_handler.add_scene("game-template", new main());

                // Load the first scene this can later be called in any file as for example a win condition to switch scene.
                scene_handler.load_scene("game-template");
            }
        }

        // Update method
        // This is where all your gamelogic is

        public override void update()
        {

        }

        // Render method
        // This is where all your rendering is

        public override void render()
        {

        }
    }

    // Main Class

    class Program 
    {
        public static void Main(string[] args) 
        {
            // Function that starts game
            // The parameter should be your start scene
            game.set_resource_folder("resources");
            game.run(new main());
        }
    }
}