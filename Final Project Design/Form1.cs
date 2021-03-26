using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Design
{
    public partial class Form1 : Form
    {
        string player1State = "alive";
        string player2State = "alive";
        string player3State = "alive";
        string player4State = "alive";
        string player5State = "alive";

        List<int> stars = new List<int>();

        int scene = 1;

        bool qT = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        bool choice1 = false;
        bool choice2 = false;
        bool choice3 = false;
        bool choice4 = false;
        bool choice5 = false;

        int text = 1;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) //Blue button
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { }
                else if (scene == 3) { }
                else if (scene == 4) { }
                else if (scene == 5) { }
                else if (scene == 6) { }
                else if (scene == 7) { }
                else if (scene == 8) { }
                else if (scene == 9) { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { }
                else if (scene == 14) { }
                else if (scene == 15) { }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { }
                else if (scene == 19) { }
                else if (scene == 20) { }
                else if (scene == 21) { }
                else if (scene == 22) { }
                else if (scene == 23) { }
                else if (scene == 24) { }
                else if (scene == 25) { }
                else if (scene == 26) { }
                else if (scene == 27) { }
                else if (scene == 28) { }
                else if (scene == 29) { }
                else if (scene == 30) { }
                else if (scene == 31) { }
                else if (scene == 32) { }
                else if (scene == 33) { }
                else if (scene == 34) { }
                else if (scene == 35) { }
                else if (scene == 36) { }
                else if (scene == 37) { }
                else if (scene == 38) { }
                else if (scene == 39) { }
                else if (scene == 40) { }
                else if (scene == 41) { }
                else if (scene == 42) { }
                else if (scene == 43) { }
                else if (scene == 44) { }
                else if (scene == 45) { }
                else if (scene == 46) { }
                else if (scene == 47) { }
                else if (scene == 48) { }
                else if (scene == 49) { }
                else if (scene == 50) { }
                else if (scene == 51) { }
                else if (scene == 52) { }
                else if (scene == 53) { }
                else if (scene == 54) { }
                else if (scene == 55) { }
                else if (scene == 56) { }
                else if (scene == 57) { }
                else if (scene == 58) { }
                else if (scene == 59) { }
                else if (scene == 60) { }
                else if (scene == 61) { }
                else if (scene == 62) { }
                else if (scene == 63) { }
                else if (scene == 64) { }
                else if (scene == 65) { }
                else if (scene == 66) { }
                else if (scene == 67) { }
                else if (scene == 68) { }
                else if (scene == 69) { }
                else if (scene == 70) { }
                else if (scene == 71) { }
                else if (scene == 72) { }
                else if (scene == 73) { }
                else if (scene == 74) { }
                else if (scene == 75) { }
                else if (scene == 76) { }
                else if (scene == 77) { }
                else if (scene == 78) { }
                else if (scene == 79) { }
                else if (scene == 80) { }
            }
            else if (e.KeyCode == Keys.S) //Red button
            {
                if (scene == 1) { }
                else if (scene == 2) { }
                else if (scene == 3) { }
                else if (scene == 4) { }
                else if (scene == 5) { }
                else if (scene == 6) { }
                else if (scene == 7) { }
                else if (scene == 8) { }
                else if (scene == 9) { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { }
                else if (scene == 14) { }
                else if (scene == 15) { }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { }
                else if (scene == 19) { }
                else if (scene == 20) { }
                else if (scene == 21) { }
                else if (scene == 22) { }
                else if (scene == 23) { }
                else if (scene == 24) { }
                else if (scene == 25) { }
                else if (scene == 26) { }
                else if (scene == 27) { }
                else if (scene == 28) { }
                else if (scene == 29) { }
                else if (scene == 30) { }
                else if (scene == 31) { }
                else if (scene == 32) { }
                else if (scene == 33) { }
                else if (scene == 34) { }
                else if (scene == 35) { }
                else if (scene == 36) { }
                else if (scene == 37) { }
                else if (scene == 38) { }
                else if (scene == 39) { }
                else if (scene == 40) { }
                else if (scene == 41) { }
                else if (scene == 42) { }
                else if (scene == 43) { }
                else if (scene == 44) { }
                else if (scene == 45) { }
                else if (scene == 46) { }
                else if (scene == 47) { }
                else if (scene == 48) { }
                else if (scene == 49) { }
                else if (scene == 50) { }
                else if (scene == 51) { }
                else if (scene == 52) { }
                else if (scene == 53) { }
                else if (scene == 54) { }
                else if (scene == 55) { }
                else if (scene == 56) { }
                else if (scene == 57) { }
                else if (scene == 58) { }
                else if (scene == 59) { }
                else if (scene == 60) { }
                else if (scene == 61) { }
                else if (scene == 62) { }
                else if (scene == 63) { }
                else if (scene == 64) { }
                else if (scene == 65) { }
                else if (scene == 66) { }
                else if (scene == 67) { }
                else if (scene == 68) { }
                else if (scene == 69) { }
                else if (scene == 70) { }
                else if (scene == 71) { }
                else if (scene == 72) { }
                else if (scene == 73) { }
                else if (scene == 74) { }
                else if (scene == 75) { }
                else if (scene == 76) { }
                else if (scene == 77) { }
                else if (scene == 78) { }
                else if (scene == 79) { }
                else if (scene == 80) { }
            }
            else if (e.KeyCode == Keys.D) //Yellow button
            {
                if (scene == 1) { }
                else if (scene == 2) { }
                else if (scene == 3) { }
                else if (scene == 4) { }
                else if (scene == 5) { }
                else if (scene == 6) { }
                else if (scene == 7) { }
                else if (scene == 8) { }
                else if (scene == 9) { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { }
                else if (scene == 14) { }
                else if (scene == 15) { }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { }
                else if (scene == 19) { }
                else if (scene == 20) { }
                else if (scene == 21) { }
                else if (scene == 22) { }
                else if (scene == 23) { }
                else if (scene == 24) { }
                else if (scene == 25) { }
                else if (scene == 26) { }
                else if (scene == 27) { }
                else if (scene == 28) { }
                else if (scene == 29) { }
                else if (scene == 30) { }
                else if (scene == 31) { }
                else if (scene == 32) { }
                else if (scene == 33) { }
                else if (scene == 34) { }
                else if (scene == 35) { }
                else if (scene == 36) { }
                else if (scene == 37) { }
                else if (scene == 38) { }
                else if (scene == 39) { }
                else if (scene == 40) { }
                else if (scene == 41) { }
                else if (scene == 42) { }
                else if (scene == 43) { }
                else if (scene == 44) { }
                else if (scene == 45) { }
                else if (scene == 46) { }
                else if (scene == 47) { }
                else if (scene == 48) { }
                else if (scene == 49) { }
                else if (scene == 50) { }
                else if (scene == 51) { }
                else if (scene == 52) { }
                else if (scene == 53) { }
                else if (scene == 54) { }
                else if (scene == 55) { }
                else if (scene == 56) { }
                else if (scene == 57) { }
                else if (scene == 58) { }
                else if (scene == 59) { }
                else if (scene == 60) { }
                else if (scene == 61) { }
                else if (scene == 62) { }
                else if (scene == 63) { }
                else if (scene == 64) { }
                else if (scene == 65) { }
                else if (scene == 66) { }
                else if (scene == 67) { }
                else if (scene == 68) { }
                else if (scene == 69) { }
                else if (scene == 70) { }
                else if (scene == 71) { }
                else if (scene == 72) { }
                else if (scene == 73) { }
                else if (scene == 74) { }
                else if (scene == 75) { }
                else if (scene == 76) { }
                else if (scene == 77) { }
                else if (scene == 78) { }
                else if (scene == 79) { }
                else if (scene == 80) { }
            }

            switch (scene)
            {
                case 1:
                    subTitleLabel.Text = "";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    imageLabel.Text = "";
                    break;
                case 2:
                    subTitleLabel.Text = "The year is 2140, 10 years after Earth has been wiped out and is now uninhabitable.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 3:
                    subTitleLabel.Text = "7:30 am, Captain Alexander Leon, captains quarters.\nYou awake to the sound of your alarm. You are in your quarters still in bed while your personal HUD reads off the schedule for job assignments for the day.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 4:
                    subTitleLabel.Text = "I'd rather not eat this morning.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 5:
                    subTitleLabel.Text = "Yes IRIS.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 6:
                    subTitleLabel.Text = "You decide it is time to start the day. You exit your quarters and are greeting by Alex Sarichith, the First Officer.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 7:
                    subTitleLabel.Text = "Alright let's get to it, what's the status on the ship?";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 8:
                    subTitleLabel.Text = "How have you been holding up?";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 9:
                    subTitleLabel.Text = "How have you been holding up?";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 10:
                    subTitleLabel.Text = "Once in engineering you are greeted by the Head of Engineering Sarah Mackenzie";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 11:
                    subTitleLabel.Text = "You tap on your HUD.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 12:
                    subTitleLabel.Text = "It's probably just a malfunction, try to fix the robot and leave it.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 13:
                    subTitleLabel.Text = "8:15 pm, First Officer Alex Sarichith, the bridge. \nYou are overseeing operations on the bridge when suddenly.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 14:
                    subTitleLabel.Text = "Just keep the ship moving, maybe it'll go away.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 15:
                    subTitleLabel.Text = "Captain, can you come here for a second.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 16:
                    subTitleLabel.Text = "It's not worth it to worry the Captain right now, lets just ignore it for now.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 17:
                    subTitleLabel.Text = "8:45, Captain Alexander Leon, the bridge.\nAfter hearing that distrubing, you think about your next course of action.";
                    aLabel.Text = "Refuse to hand over the item";
                    sLabel.Text = "Find the item";
                    dLabel.Text = "";
                    break;
                case 18:
                    subTitleLabel.Text = "Send a message saying that we refuse to give up this item they speak of.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 19:
                    subTitleLabel.Text = "Remembering the conversation you had with Sarah, you pull out your HUD and make an announcement to the worker robots on board.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 20:
                    subTitleLabel.Text = "You get an alert on your HUD that the anomoly in cargo bay has been found.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 21:
                    subTitleLabel.Text = "Open it.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 22:
                    subTitleLabel.Text = "You quickly move out of the way and the thing jumps past you.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 23:
                    subTitleLabel.Text = "The thing jumps right on your face and begins to squeeze. You can feel your skull being crushed as your vision begins to fade. Captain Alexander Leon is dead.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    player1State = "dead";
                    break;
                case 24:
                    subTitleLabel.Text = "10:00 am, First Officer Alex Sarichith, the bridge.\nYou are at the bridge awaiting the Captain when security comes into the room.";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 25:
                    subTitleLabel.Text = "Put it back in the egg!";
                    aLabel.Text = "Continue";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                    


            }
        }
    }
}
