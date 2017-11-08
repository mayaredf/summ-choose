/// created by : Maya Redford-Haines
/// date       : November 8 2017
/// description: A text adventure game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at 
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        //sounds
        SoundPlayer player = new SoundPlayer(Properties.Resources.Game_Over___The_Legend_of_Zelda_Breath_of_the_Wild_OST);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Success);
        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You are lost in a forest. Do you stay calm or panic?";
            redLabel.Text = "Stay calm";
            blueLabel.Text = "Panic";
            greenLabel.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.Z)       //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 9; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 11) { scene = 8; }
                else if (scene == 13) { scene = 12; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 14; }
                else if (scene == 2) { scene = 15; }
                else if (scene == 12) { scene = 15; }
                else if (scene == 5) { scene = 15; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 14) { scene = 0; }

                if (scene == 8)
                {
                    int rand = randGen.Next(1, 101);
                    
                    if (rand > 50) { scene = 12; }
                    else { scene = 13; }
                }
            }
            else if (e.KeyCode == Keys.X)  //blue button press
            {

            
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 8; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 6) { scene = 5; }
                else if (scene == 8) { scene = 3; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 13) { scene = 3; }
                else if (scene == 11) { scene = 3; }

            }
            else if (e.KeyCode == Keys.C) //green button press
                if (scene == 1) { scene = 3; }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You are lost in a forest. Do you stay calm or panic?";
                    redLabel.Text = "Stay calm";
                    blueLabel.Text = "Panic";
                    greenLabel.Text = "";
                    break;
                case 1:
                    outputLabel.Text = "You collect your thoughts and try to decide what to do next. Do you try to find food, try to find shelter, or look around for a way out?";
                    redLabel.Text = "Find food";
                    blueLabel.Text = "Find shelter";
                    greenLabel.Text = "Look around you for a way out";
                    break;
                case 2:
                    outputLabel.Text = "You hyperventilate and pass out.";
                    redLabel.Text = "Ok";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    player.Play();
                    break;
                case 3:
                    outputLabel.Text = "You look around you for anything interesting. Suddenly, you see a dark shadow that looks like a person. Do you approach them?";
                    redLabel.Text = "Approach";
                    blueLabel.Text = "Run away";
                    greenLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "As you get closer, you notice strange features on this person. It almost looks like they're dissapearing in places, as if they're made of smoke.";
                    redLabel.Text = "Approach more";
                    blueLabel.Text = "Run away";
                    greenLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "As you run away, your body feels numb. You feel something like smoke envelop you and you pass out.";
                    redLabel.Text = "Ok";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    player.Play();
                    break;
                case 6:
                    outputLabel.Text = "You approach them more. You don't know why you ever thought it looked like a person. Suddenly, it raises a limb and points towards a part of the forest you don't recognize.";
                    redLabel.Text = "Follow where it pointed";
                    blueLabel.Text = "Run away";
                    greenLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You start walking towards where the creature pointed. Suddenly, you feel compelled to run. As you sprint through the forest, everything starts to go white... and you're back at home in your room.";
                    redLabel.Text = "Ok";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    player2.Play();
                    break;
                case 8:
                    outputLabel.Text = "You can see a small cave in the distance that might be perfect for a shelter.";
                    redLabel.Text = "Investigate";
                    blueLabel.Text = "Look elsewhere";
                    greenLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You can see a bush full of delicious looking berries.";
                    redLabel.Text = "Eat some";
                    blueLabel.Text = "Do not";
                    greenLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "The berries were poisonous!";
                    redLabel.Text = "Ok";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    player.Play();
                    break;
                case 11:
                    outputLabel.Text = "After you leave the bush alone, you see what looks like a cave. Get closer?";
                    redLabel.Text = "Check it out";
                    blueLabel.Text = "Look somewhere else";
                    greenLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "The cave collapses, killing you instantly.";
                    redLabel.Text = "Ok";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    player.Play();
                    break;
                case 13:
                    outputLabel.Text = "You feel safe and comfortable. You can take a rest, or look around more outside.";
                    redLabel.Text = "Rest";
                    blueLabel.Text = "Look around";
                    greenLabel.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "You won! Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You lost! Would you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    break;
                default:
                    break;
            }
        }

    }

}
