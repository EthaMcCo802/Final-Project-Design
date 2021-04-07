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

namespace Final_Project_Design
{
    public partial class Form1 : Form
    {
        List<int> starsYList = new List<int>();
        List<int> starsXList = new List<int>();
        int starSpeed = 50;
        int starSize = 5;

        int scene = 1;

        bool qT = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);

        bool choice1 = false;
        bool choice2 = false;
        bool choice3 = false;

        int text = 1;

        Random randGen = new Random();

        int qTCounter = 0;

        bool nKeyDown = false;
        bool tKeyDown = false;
        bool wKeyDown = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                nKeyDown = true;
            }
            if (e.KeyCode == Keys.T)
            {
                tKeyDown = true;
            }
            if (e.KeyCode == Keys.W)
            {
                wKeyDown = true;
            }
            if (e.KeyCode == Keys.A) //Blue button
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6)
                {
                    Random ranGen = new Random();
                    int value = ranGen.Next(1, 11);

                    if (value >= 1) { scene = 8; }
                    else { scene = 9; }
                }
                else if (scene == 10) { scene = 11; }
                else if (scene == 13) { scene = 30; }
                else if (scene == 14) { scene = 15; }
                else if (scene == 17) { scene = 18; }
                else if (scene == 19) { scene = 18; }
                else if (scene == 20) { scene = 18; }
                else if (scene == 22) { scene = 26; }
                else if (scene == 25) { scene = 18; }
                else if (scene == 26) { scene = 18; }
                else if (scene == 29) { scene = 81; }
                else if (scene == 33) { scene = 35; }
                else if (scene == 36) { scene = 41; }
                else if (scene == 37) { scene = 60; }
                else if (scene == 39) { scene = 44; }
                else if (scene == 40) { scene = 42; }
                else if (scene == 41)
                {
                    if (choice2 == true) { scene = 59; }
                    else { scene = 58; }
                }
                else if (scene == 42) { scene = 44; }
                else if (scene == 44) { scene = 46; }
                else if (scene == 47)
                {
                    if (choice3 == true) { scene = 74; }
                    else { scene = 75; }
                }
                else if (scene == 49) { scene = 51; }
                else if (scene == 58) { scene = 60; }
                else if (scene == 62) { scene = 65; }
                else if (scene == 76) { scene = 78; }
                else if (scene == 79)
                {


                    Random ranGen = new Random();
                    int value = ranGen.Next(1, 11);

                    if (value >= 3) { scene = 29; }
                    else { scene = 28; }


                }
                else if (scene == 80) { scene = 1; }
                else if (scene == 81) { scene = 1; }
                else if (scene == 82) { scene = 44; }
                else if (scene == 83)
                {
                    if (choice2 == true) { scene = 39; }
                    else { scene = 40; }
                }
            }
            else if (e.KeyCode == Keys.S) //Red button
            {
                if (scene == 1) { scene = 0; }
                if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 10) { scene = 12; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 17)
                {
                    if (choice1 == true) { scene = 20; }
                    else { scene = 19; }
                }
                else if (scene == 19) { scene = 79; }
                else if (scene == 20) { scene = 79; }
                else if (scene == 22) { scene = 25; }
                else if (scene == 25) { scene = 79; }
                else if (scene == 26) { scene = 79; }
                else if (scene == 33) { scene = 34; }
                else if (scene == 36)
                {
                    if (choice2 == true) { scene = 39; }
                    else { scene = 40; }
                }
                else if (scene == 37) { scene = 61; }
                else if (scene == 39) { scene = 43; }
                else if (scene == 40) { scene = 82; }
                else if (scene == 41) { scene = 83; }
                else if (scene == 42) { scene = 43; }
                else if (scene == 44) { scene = 45; }
                else if (scene == 47) { scene = 52; }
                else if (scene == 49) { scene = 50; }
                else if (scene == 57) { scene = 61; }
                else if (scene == 58) { scene = 61; }
                else if (scene == 62) { scene = 64; }
                else if (scene == 76) { scene = 77; }
                else if (scene == 79) { scene = 27; }
                else if (scene == 81) { this.Close(); }
                else if (scene == 82) { scene = 43; }
                else if (scene == 83)
                {
                    if (choice2 == true) { scene = 56; }
                    else { scene = 57; }
                }
            }
            else if (e.KeyCode == Keys.D) //Yellow button
            {
                if (scene == 1) { scene = 80; }
                else if (scene == 20) { scene = 21; }
                else if (scene == 36)
                {
                    if (choice2 == true) { scene = 38; }
                    else { scene = 37; }
                }
                else if (scene == 62) { scene = 63; }

            }
            else if (e.KeyCode == Keys.Space)
            {
                text++;
                if (scene == 52)
                {
                    if (choice3 == true) { scene = 54; }
                    else { scene = 53; }
                }
                if (scene == 71)
                {
                    if (choice3 == true) { scene = 72; }
                    else { scene = 73; }
                }
            }

            switch (scene)
            {
                case 1:
                    subTitleLabel.Visible = true;
                    characterLabel.Visible = true;
                    imageLabel.Visible = false;
                    imageBox.Visible = false;
                    characterLabel.Text = "";
                    subTitleLabel.Text = "Press start to begin";
                    aLabel.Text = "Start";
                    sLabel.Text = "Exit";
                    dLabel.Text = "Credits";
                    imageLabel.Text = "";
                    break;
                case 2:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The year is 2140, 10 years after Earth has been wiped out and is now uninhabitable.\n\nPress space to continue.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        spaceShipBox.Visible = true;
                        imageBox.Visible = true;

                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "This has forced the few remaining survivors of The Incident to retreat onto a spaceship known as Odysseus and abandon the planet.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "The colonists onboard are on route to a new planet that they have been researching for years in a far off galaxy.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "There were supposed rumors of a research crew that were sent to check out the planet years before The Incident.";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "You are the colonists, hoping to survive the terrible endeavors of space and make it to the planet to start a new life. Will you make it?";
                    }
                    if (text == 6)
                    {
                        subTitleLabel.Text = "7:30 am, Captain Alexander Leon, captains quarters.\nYou awake to the sound of your alarm. You are in your quarters still in bed while your personal HUD reads off the schedule for job assignments for the day.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        spaceShipBox.Visible = false;
                        imageBox.BackgroundImage = Properties.Resources.Captain_room;
                        text = 0;
                        scene = 3;
                    }
                    break;
                case 3:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "Just then IRIS, the ships artificial intelligence, chimes in through the intercom.";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "IRIS";
                        subTitleLabel.Text = "Good morning Captain. The time is currently 7:30 am. Shall I make you breakfast?";
                        aLabel.Text = "Say yes";
                        sLabel.Text = "Say no";
                        text = 1;
                    }
                    break;
                case 4:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "I'd rather not eat this morning.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "With that, IRIS dissapears. You get dressed in your uniform and exit your room.";
                        imageBox.BackgroundImage = Properties.Resources.Captain_quarters;
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You grab a cup of coffee that your automatic coffee machine has already made for you.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Since IRIS is the ships AI he controls all technology on board, which kind of worries you a little since you've never really trusted technology.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You decide it is time to start the day. You exit your quarters and are greeted by Alex Sarichith, the First Officer.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.hallway;
                        text = 0;
                        scene = 6;
                    }
                    break;
                case 5:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Yes, IRIS.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "With that, IRIS dissapears. You get dressed in your uniform and exit your room.";
                        imageBox.BackgroundImage = Properties.Resources.Captain_quarters;
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once in the main area of your quarters you can smell the breakfast that your assistant robots made for you.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Since IRIS is the ships AI he controls all technology on board, which kind of worries you a little since you've never really trusted technology.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You sit down and eat your breakfast.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You decide it is time to start the day. You exit your quarters and are greeted by Alex Sarichith, the First Officer.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.hallway;
                        text = 0;
                        scene = 6;
                    }
                    break;
                case 6:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Good morning Captain.";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Good morning Alex, what's on the agenda for today?";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Alex goes over the daily work schedule with you. You listen attentively as the two of you walk towards the bridge.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once on the bridge everyone stands up and salutes. You wave and they sit back down, continuing what they were doing.";
                        aLabel.Text = "Talk to Alex";
                        sLabel.Text = "Start giving orders";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        text = 1;
                    }
                    break;
                case 7:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Alright let's get to it, what's the status on the ship?";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You start to give out orders to the Navigators.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "After a while you recieve a notification on your personal HUD. It requests your presence in the engineering bay.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "I have to go assist with something, can you watch over up here Alex?";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Yes, sir.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "With that, you leave the bridge and head to the engineering bay.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once in engineering you are greeted by the Head of Engineering Sarah Mackenzie";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        text = 0;
                        scene = 10;
                    }
                    break;
                case 8:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "How have you been holding up?";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "I'm fine.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Something tells you that statement isn't entirely true, but you decide not to press the matter.";
                        text = 0;
                        scene = 7;
                    }
                    break;
                case 9:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "How have you been holding up?";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Alex gets a grim look on his face";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Somethings been bothering me lately.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Did you want to talk about it?";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Alex seems reluctant at first, but finally manages the courage to tell you";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "A couple years before The Incident, my father went missing. He wasn't around very much when I was younger. When I asked my mother about it she just told me he was very busy. The few times I did see him he neglected to tell me what he was doing. Recently I was looking through some old family photos I managed to save from Earth and found he was a member of NASA.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Alex pauses. He looks a little uncomfortable, but continues.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Right before his disappearance, the rumours began about NASA sending a research team to find a new planet for humans. So naturally I put two and two together and came to the conclusion that he was on that expedition.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You look at Alex deeply, not sure what to say.";
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "I'm sorry to hear that Alex.";
                    }
                    if (text == 11)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Forget about it.";
                        text = 0;
                        scene = 7;
                    }
                    break;
                case 10:
                    if (text == 1)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Right this way sir.";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You follow her to a repair room where she has powered down one of the worker robots.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "This robot was acting really weird so I had to shut it down. Kept reporting a strange anomaly in the cargo bay.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Have you checked it out yet?";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Not yet, but it wouldn't stop so I thought maybe it was a malfunction.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "What should we do?";
                        aLabel.Text = "Send security";
                        sLabel.Text = "Ignore it";
                        text = 1;
                    }
                    break;
                case 11:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You tap on your HUD and make an announcement.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "If there are any available security personnel, could you please check a potential anomoly in the cargo bay.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "There that should solve it. If any other problems arise, notify me.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Yes, sir.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "With that you leave and return to the bridge.";
                        choice1 = true;
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "8:15 pm, First Officer Alex Sarichith, the bridge. \nYou are overseeing operations on the bridge when suddenly.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        text = 0;
                        scene = 13;
                    }
                    break;
                case 12:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "It's probably just a malfunction, try to fix the robot and leave it.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Sarah opens her mouth to protest, but decides not to.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Now if you'll excuse me I have more pressing matters to tend to.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "With that you leave and return to the bridge.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "8:15 pm, First Officer Alex Sarichith, the bridge. \nYou are overseeing operations on the bridge when suddenly.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        text = 0;
                        scene = 13;
                    }
                    break;
                case 13:
                    if (text == 1)
                    {
                        characterLabel.Text = "Navigator";
                        subTitleLabel.Text = "Sir can you come take a look at this?";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You go over to the navigator and he points to a screen.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "A strange object has appeared on our radars. Our sensors aren't able to tell us what it exactly is. The weird thing is, it seems to be following us.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You study the radar for a second trying to figure out what the object could be.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Navigator";
                        subTitleLabel.Text = "What should we do?";
                        aLabel.Text = "Stop the ship";
                        sLabel.Text = "Do nothing";
                        text = 1;
                    }
                    break;
                case 14:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Just keep the ship moving, maybe it'll go away.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then, the Captain enters the bridge. You think if you should tell him or not.";
                        aLabel.Text = "Tell the Captain";
                        sLabel.Text = "Don't tell the Captain";
                        text = 1;
                    }
                    break;
                case 15:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Captain, can you come here for a second.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain walks over to you and you show him the radar.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "Apparently it's been following us and we're moving way too fast for it to just be space debris.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Alright, you see that meteor?";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain points to a giant meteor through the giant window looking out from the bridge.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "We're going to maneuver around that a couple times before setting back on course. Maybe that'll lose it.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The navigators direct the ship behind the meteor and circle around it a couple of times before returning back on course.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Navigator";
                        subTitleLabel.Text = "I think we lost it, it's not showing up on the radar anymore!";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You're not sure why, but you feel that you just avoided a very bad situation. You feel relieved that it's over, but is it really over?";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 16:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "It's not worth it to worry the Captain right now, lets just ignore it for now.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The navigator seems a little perturbed, but obliges and goes back to what he was doing. You sit down next to the Captain when suddenly your communications are interrupted.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Navigator";
                        subTitleLabel.Text = "Captain, there appears to be a message being broadcasted to our communications.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Display the message.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Navigator";
                        subTitleLabel.Text = "Yes, sir.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Navigator displays the message and the feed displays a hideous creature. You feel the urge to look away from it, but you force yourself to watch the broadcast.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You begin to hear what sounds like deep inhales coming from the creature. You assume that it must be trying to communicate with you.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Turn on the universal translator.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "A Navigator presses a button and some subtitles appear at the bottom of the screen. You didn't even know you had a translator.";
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The subtitles read:\nGreetings, it appears that you have stolen a very important piece of property that belongs to us, if you do not return this item to us we will be forced to launch an all out attack on your ship. We have already hacked into your ships database and have full control over your artificial intelligence. Do as we ask and we may let you live. This is your only warning.";
                    }
                    if (text == 11)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The feed cuts out and there is complete silence through out the bridge.";
                    }
                    if (text == 12)
                    {
                        characterLabel.Text = "Navigator";
                        subTitleLabel.Text = "Captain, what should we do?";
                        text = 0;
                        scene = 17;
                    }
                    break;
                case 17:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "8:45, Captain Alexander Leon, the bridge.\nAfter hearing that disturbing message, you think about your next course of action.";
                        aLabel.Text = "Refuse to hand over the item";
                        sLabel.Text = "Find the item";
                        dLabel.Text = "";
                    }
                    break;
                case 18:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Send a message saying that we refuse to give up this item they speak of and let's get out of here.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "After the message is sent you try to escape.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Navigator";
                        subTitleLabel.Text = "Captain, you're going to want to see this.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You walk over and look at the radar. You see hundred of blips from different directions.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "We're surrounded!";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then, the power is cut and everything is silent.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:00 am, Head of Security Douglas Clark, security station.\nYou are sitting in your office when suddenly the power goes out. You go out to investigate what is going on and find that most of your men confused as well. You press on your earpiece, but hear nothing except static, the connection must've been lost.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        scene = 32;
                        text = 0;
                    }
                    break;
                case 19:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Remembering the conversation you had with Sarah, you pull out your HUD and make an announcement to the worker robots on board.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Attention, we have a code blue, dangerous item on board in the cargo bay. Search initiated for item class Foreign Item.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "After a couple minutes one of the robots enter the bridge and approachs you.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Robot";
                        subTitleLabel.Text = "Item classified as Foreign Item found in cargo bay, please follow me.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You follow the robot to cargo bay where a group of robots are crowded around an item. They clear room for you to see it.";
                        imageBox.BackgroundImage = Properties.Resources.Cargo_bay;
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "It appears to be an egg shaped item, but a lot more mechanical. There are tubes all around it flowing with some sort of green glowing liquid. The egg itself appears to have a purple and black armored shell. It's like nothing you've ever seen before.";
                        aLabel.Text = "Keep the item";
                        sLabel.Text = "Give it back.";
                        text = 1;
                    }
                    break;
                case 20:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You get an alert on your HUD from security that the anomoly in cargo bay has been found.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You run down to cargo bay and find them near them near an egg shapped item, but more mechanical. The egg itself seems to have a purple and black armored shell. It's like nothing you've ever seen before.";
                        aLabel.Text = "Keep the item";
                        sLabel.Text = "Give it back.";
                        dLabel.Text = "Get security to open it.";
                        imageBox.BackgroundImage = Properties.Resources.Cargo_bay;
                        text = 1;
                    }
                    break;
                case 21:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Open it.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The guards seem hesitant at first, but eventually open it.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once they do you peer inside.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Suddenly something jumps out at you.";
                        qT = true;
                        imageBox.Visible = false;
                        imageLabel.Visible = true;
                        imageLabel.Text = "PRESS N";
                        text = 1;
                    }
                    break;
                case 22:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You quickly move out of the way and the thing jumps past you.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The guards shoot at it, injuring it.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "It starts squirming on the ground.";
                        aLabel.Text = "Kill it";
                        sLabel.Text = "Put it back";
                        text = 1;
                    }
                    break;
                case 23:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The thing jumps right on your face and begins to squeeze. You can feel your skull being crushed as your vision begins to fade. Captain Alexander Leon is dead.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:00 am, First Officer Alex Sarichith, the bridge.\nYou are at the bridge awaiting the Captain when security comes into the room.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        text = 0;
                        scene = 24;
                    }
                    break;
                case 24:
                    if (text == 1)
                    {
                        characterLabel.Text = "Guard";
                        subTitleLabel.Text = "The Captain's dead.";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You stare at them in disbelief.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Guard";
                        subTitleLabel.Text = "In the event that the Captain dies, protocol 683 takes place where the First Officer gets transfered the rank of Captain.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You feel a pit in your stomach and have the urge to vomit. You take a moment to absorb this information, then you finally give your first command.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "We need to get out of here, now.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Navigators start to move the ship again and you are able to make a swift get away from the alien ship.";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 25:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Put it back in the egg!";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They pick it up and put as it's still wiggling and throw it back in the egg, then close it.";
                        aLabel.Text = "Keep the item";
                        sLabel.Text = "Give it back";
                        text = 1;
                    }
                    break;
                case 26:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Kill it!";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They shoot it until it stops moving.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Well, we can't give this thing back now, but we can send the egg back empty.";
                        aLabel.Text = "Keep the item";
                        sLabel.Text = "Give it back";
                        text = 1;
                    }
                    break;
                case 27:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You decide not to as it would probably make things worse. You eject the egg and the ship begins to take off. Just then you recieve another message.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The message reads:\nDid you really think we would just let you go?";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then the power goes out and everything is silent.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:00 am, Head of Security Douglas Clark, security station.\nYou are sitting in your office when suddenly the power goes out. You go out to investigate what is going on and find that most of your men confused as well. You press on your earpiece, but hear nothing except static, the connection must've been lost.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.Security;
                        scene = 32;
                        text = 0;
                    }
                    break;
                case 28:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The alien ship doesn't go away, but instead another message is sent.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The message reads:\nDid you really think we would fall for this trick?";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then the power goes out and everything is silent.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:00 am, Head of Security Douglas Clark, security station.\nYou are sitting in your office when suddenly the power goes out. You go out to investigate what is going on and find that most of your men confused as well. You press on your earpiece, but hear nothing except static, the connection must've been lost.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.Security;
                        scene = 32;
                        text = 0;
                    }
                    break;
                case 29:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The alien ship begins to fly, but then suddenly it explodes. The explosion wasn't enough to damage your ship, but you felt a bit of rocking from it.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You celebrate for a short moment before setting back on course. You think that was the end of it, but was it really?";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 30:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You order for the ship to be stopped. The crew follows your order and slows down the ship until it is completely stopped.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then the Captain walks in.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Why is the ship being stopped?";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You show the captain the radar and explain to him the situation. He gives you a weird look.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 31;
                    }
                    break;
                case 31:
                    if (text == 1)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "This unknown object showed up on the radar. Apparently it's been following us.";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Send out a scout pod to investigate it.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You go to the pod terminal. The terminal displays a screen showing all the pod option and you choose the one that says Scout.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You eject the pod and a feed shows up on the terminal displaying the outside of the ship from the pods view. You navigate the pod to the back of the ship.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The sight on the feed makes your jaw drop as there appears to be another ship behind yours, although this one looks like nothing you've ever seen before. Just then the feed on the pod gets cut and you're left in shock.";
                        imageBox.BackgroundImage = Properties.Resources.alien_ship;
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "What's wrong?";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then the power goes out and everything is silent.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:00 am, Head of Security Douglas Clark, security station.\nYou are sitting in your office when suddenly the power goes out. You go out to investigate what is going on and find that most of your men confused as well. You press on your earpiece, but hear nothing except static, the connection must've been lost.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.Security;
                        scene = 32;
                        text = 0;
                    }
                    break;
                case 32:
                    characterLabel.Text = "";
                    subTitleLabel.Text = " You head outside of the security station into the main area of the ship. Most of the crew is beginning to panic a bit.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.Main_area;
                    scene = 33;
                    break;
                case 33:
                    characterLabel.Text = "Douglas";
                    subTitleLabel.Text = "Everything will be fine, remain calm.";
                    aLabel.Text = "Calm them";
                    sLabel.Text = "Leave them";
                    text = 1;
                    break;
                case 34:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You move through the crowded area trying to get to the bridge. The crew seem to panic a bit more now that you're gone, but you ignore them.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You reach the bridge where it seems to be even worse. Everyone is in a mass panic. You look around for the captain and find him trying to turn on his HUD.";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        text = 0;
                        scene = 36;
                    }
                    break;
                case 35:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Make sure chaos doesn't start amongst these crew mates.";
                        choice2 = true;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Your men head out into the main area and you hope that will keep everyone calm. You head to the bridge.";
                        text = 0;
                        scene = 36;
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You reach the bridge where it seems to be even worse. Everyone is in a mass panic. You look around for The Captain and find him trying to turn on his HUD.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        text = 0;
                        scene = 36;
                    }
                    break;
                case 36:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You walk over to him and he looks relieved to see you";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "What the hell is going on?";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "We just encountered aliens.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You look at him like he belongs in a mental ward, but at the same time you know it's not entirely impossible.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "What do you think we should do?";
                        aLabel.Text = "Restore the power";
                        sLabel.Text = "Increase security";
                        dLabel.Text = "Don't know";
                        text = 1;
                    }
                    break;
                case 37:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "I don't know.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain gives you a worried look.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "We could try to get the power back up and running.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain seems uneasy about this idea, but since it's the only one he goes with it.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Get some of your men and head to the engineering bay to gather some engineers and restore the power.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the deck.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "There seems to be full on panic ensuing in the main area. Some of the crew are yelling and some of them are beginning to cry.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Everyone remain calm, the situation is under control.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "This doesn't seem to work as they are all demanding answers from you.";
                        aLabel.Text = "Tell the truth";
                        sLabel.Text = "Lie";
                        text = 1;
                    }
                    break;
                case 38:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "I don't know.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain gives you a worried look.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "We could try to get the power back up and running.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain seems uneasy about this idea, but since it's the only one he goes with it.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Get some of your men and head to the engineering bay to gather some engineers and restore the power.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the deck.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You return back to the main area.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Attention everyone, at this time you should all return to your quarters in an orderly fashion and remain there until further instructions are given.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Crewmates begin walking back to their quarters calmly and you signal to your men to follow you. With that, you head to engineering bay.";
                        choice3 = true;
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:45 am, Sarah Mackenzie, engineering bay.\nYou're talking with the Head Researcher Ria Das about the power outage.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 62;
                    }
                    break;
                case 39:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "We could increase security. A bunch of my men are just sitting around doing nothing.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Yes good idea, get your men to do patrols around the ship.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the bridge.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You return back to the main area.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Attention everyone, at this time you should all return to your quarters in an orderly fashion and remain there until further instructions are given.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Everyone walks back to their quarters calmly and you head into the security station.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Alright new orders from the Captain, we need to patrol around the entire ship and make sure everything is secure. Since comms are down you'll need to tell any other security personnel of the new orders.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They begin their patrol around the ship.";
                        aLabel.Text = "Patrol";
                        sLabel.Text = "Go to the bridge";
                        choice3 = true;
                        text = 1;
                    }
                    break;
                case 40:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "We could increase security. A bunch of my men are just sitting around doing nothing.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Yes good idea, get your men to do patrols around the ship.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the bridge.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "There seems to be full on panic ensuing in the main area. Some of the crew are yelling and some of them are beginning to cry.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Everyone remain calm, the situation is under control.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "This doesn't seem to work as they are all demanding answers from you.";
                        aLabel.Text = "Tell the truth";
                        sLabel.Text = "Lie";
                        text = 1;
                    }
                    break;
                case 41:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "We could get the engineers to fix the power.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain seems a little reluctant of this idea.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "It might not be safe after what just happened.";
                        aLabel.Text = "Persist";
                        sLabel.Text = "Do something else";
                        text = 1;
                    }
                    break;
                case 42:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "You decide to tell them the truth.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "We are being invaded by aliens, you all need to return to your quarters until further instructions are given.";
                        choice3 = true;
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Mass chaos ensues as everyone begins to run back to their quarters. You push your way through the crowd into the security room.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Alright new orders from the Captain, we need to patrol around the entire ship and make sure everything is secure. Since comms are down you'll need to tell any other security personnel of the new orders.";
                        imageBox.BackgroundImage = Properties.Resources.Security;
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They begin their patrol around the ship.";
                        aLabel.Text = "Patrol";
                        sLabel.Text = "Go to the bridge";
                        text = 1;
                    }
                    break;
                case 43:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You think it's best that you stay on the bridge where The Captain is. After waiting some time one of your men come in.";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Guard";
                        subTitleLabel.Text = "We've searched the entire ship and there were no signs of any hostiles.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Alright, now go to engineering and get some engineers to fix the power.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and head off to engineering with your men.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:45 am, Sarah Mackenzie, engineering bay.\nYou're talking with the Head Researcher Ria Das about the power outage.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 62;
                    }
                    break;
                case 44:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You yourself decide to patrol around the ship to make sure everything is safe. You find a group of other security members and stick with them.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "While patrolling on the maintenance deck, you hear a loud thud come from one of the closets.";
                        imageBox.BackgroundImage = Properties.Resources.Maintenance_hall;
                        aLabel.Text = "Investigate";
                        sLabel.Text = "Ignore it";
                        text = 1;
                    }
                    break;
                case 45:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You think it might be rats and don't waste time on it.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "After all the patrols have reported back that the ship is secure, you head to the bridge to notify the Captain.";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "The ship is safe, sir.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Alright, now go to engineering and get some engineers to fix the power.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and head off to engineering with your men.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:45 am, Sarah Mackenzie, engineering bay.\nYou're talking with the Head Researcher Ria Das about the power outage.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 62;
                    }
                    break;
                case 46:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You investigate the sound.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Slowly, you walk towards the closet and open it with your gun in hand.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then something jumps out at you.";
                        imageLabel.Text = "PRESS T";
                        imageLabel.Visible = true;
                        imageBox.Visible = false;
                        qT = true;
                        text = 1;
                    }
                    break;
                case 47:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You quickly get out of the way before the thing can strike you.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You and your men have your guns trained on it as it bursts out of the closet. You all open fire on it and runs in the other direction, severly wounded.";
                        aLabel.Text = "Chase after it";
                        sLabel.Text = "Keep patrolling";
                        text = 1;
                    }
                    break;
                case 48:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "You aren't fast enough and the thing slashes at your leg and you fall to the ground. Just then it stabs you in the chest and drags you into the closet. The sound of your men shooting at the creature begin to fade.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:00 am, Head Researcher Ria Das, engineering bay.\nYou are in the repair shop with Sarah.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        text = 0;
                        scene = 49;
                    }
                    break;
                case 49:
                    if (text == 1)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "This power outage is really strange, how does the generator just shut down?";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "I don't know, it's weird, the generator wouldn't just shut down like this, it's built to last.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Suddenly, you hear gun shots coming from the main area.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "What was that?";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "I don't know.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Sarah gets up and starts to head towards the door.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "Where are you going?";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "To check it out.";
                        aLabel.Text = "Go with her";
                        sLabel.Text = "Stay in the room";
                        text = 1;
                    }
                    break;
                case 50:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You decide to stay in the room.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Half an hour passes and the lights turn back on. You feel a wave of relief wash over you.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You get a notification on your HUD of a meeting on the bridge. You head there.";
                        text = 0;
                    }
                    break;
                case 51:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You decide to go with her as you don't want to be left alone.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You both enter the main area where some security guards are standing around something.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "What is happening?";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Guard";
                        subTitleLabel.Text = "Douglas is dead, this thing killed him.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Sarah looks horrified and you can feel yourself turn pale.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "How can that be possible?";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "Guard";
                        subTitleLabel.Text = "You need to gather a team of engineers and fix the power right now. We will escort you to the maintenance room.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You return to the repair room and sit down to think about what just happened. Half an hour passes and the lights turn back on. You feel a wave of relief wash over you, but still dread the situation.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You get a notification on your HUD of a meeting on the bridge. You head there.";
                        text = 0;
                    }
                    break;
                case 52:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Let it go, won't be able to do much with wounds like those.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You keep your patrol on the maintenance level making sure every room is secure before moving back to the main area.";
                        text = 0;
                    }
                    break;
                case 53:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once there you find a mess of dead crewmates and a weird green substance. The crew mates appear to have giant slash marks on their chests and are covered in blood.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You follow the trail of green stuff into a room where the creature is laying on the ground. You decide to lock it in there and let it die.";
                        text = 0;
                    }
                    break;
                case 54:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once there you find a mess of a weird green substance everywhere.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You follow the trail of green stuff into a room where the creature is laying on the ground. You decide to lock it in there and let it die.";
                        text = 0;
                        text = 55;
                    }
                    break;
                case 55:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are sitting alone in the repair shop waiting for the power to be restored.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then the power flickers on and you're able to see again.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You get a notification on your HUD of a meeting on the bridge. You head there.";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 56:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "I don't know.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "The Captain gives you a worried look.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "You were right before about getting the power up. That seems like our best bet at this time.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain seems uneasy about this idea, but since it's the only one he goes with it.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Get some of your men and head to engineering bay to gather some engineers and restore the power.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the bridge.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You return back to the main area.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Attention everyone, at this time you should all return to your quarters in an orderly fashion and remain there until further instructions are given.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Crewmates begin walking back to their quarters calmly and you signal to your men to follow you. With that, you head to engineering bay.";
                        choice3 = true;
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:45 am, Sarah Mackenzie, engineering bay.\nYou're talking with the Head Researcher Ria Das about the power outage.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 62;
                    }
                    break;
                case 57:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "I don't know.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "The Captain gives you a worried look.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Alex";
                        subTitleLabel.Text = "You were right before about getting the power up. That seems like our best bet at this time.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Captain seems uneasy about this idea, but since it's the only one he goes with it.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Get some of your men and head to engineering bay to gather some engineers and restore the power.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the bridge.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "There seems to be full on panic ensuing in the main area. Some of the crew are yelling and some of them are beginning to cry.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Everyone remain calm, the situation is under control.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "This doesn't seem to work as they are all demanding answers from you.";
                        aLabel.Text = "Tell the truth";
                        sLabel.Text = "Lie";
                        text = 1;
                    }
                    break;
                case 58:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Getting the power back should be our number one priority right now. I can get some of my men to escort a couple engineers to maintenance.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Alright you're right. Get some of your men and head to the engineering bay to gather some engineers and restore the power.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the bridge.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "There seems to be full on panic ensuing in the main area. Some of the crew are yelling and some of them are beginning to cry.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Everyone remain calm, the situation is under control.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "This doesn't seem to work as they are all demanding answers from you.";
                        aLabel.Text = "Tell the truth";
                        sLabel.Text = "Lie";
                        text = 1;
                    }
                    break;
                case 59:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Getting the power back should be our number one priority right now. I can get some of my men to escort a couple engineers to maintenance.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Alright you're right. Get some of your men and head to the engineering bay to gather some engineers and restore the power.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You nod and leave the bridge.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You return back to the main area.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Attention everyone, at this time you should all return to your quarters in an orderly fashion and remain there until further instructions are given.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Crewmates begin walking back to their quarters calmly and you signal to your men to follow you. With that, you head to engineering bay.";
                        choice3 = true;
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:45 am, Sarah Mackenzie, engineering bay.\nYou're talking with the Head Researcher Ria Das about the power outage.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 62;
                    }
                    break;
                case 60:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You decide to tell them the truth.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "We are being invaded by aliens, you all need to return to your quarters until further instructions are given.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Mass chaos ensues as everyone begins to run back to their quarters. You push your way through the crowd into the security room.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "On me.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You and your men head to engineering bay.";
                        choice3 = true;
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:45 am, Sarah Mackenzie, engineering bay.\nYou're talking with the Head Researcher Ria Das about the power outage.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 62;
                    }
                    break;
                case 61:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "It's just a power outage, nothing serious. We're going to fix the power and everything will be fine.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They seem a little suspicious of this, but calm down. You head into the security station and signal to your men to follow you. You and your men head to engineering bay.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "9:45 am, Sarah Mackenzie, engineering bay.\nYou're talking with the Head Researcher Ria Das about the power outage.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 62;
                    }
                    break;
                case 62:
                    if (text == 1)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "This feels wrong. The generator was designed to never just shut down on it's own. So how could this happen?";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "I don't know. Maybe there was a malfunction? I'm not an engineer.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then, Douglas and a couple of his men enter into the room.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Alright, new orders from the Captain. You need to gather a team and fix the power. We'll give you an escort there.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Why do we need an escort?";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Doesn't matter right now, just get a team together.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You get up to leave and Ria goes to follow.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "I think it would be best if you stayed here.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Ria sits back down and you exit the room.";
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You gather a small team of engineers and head to the maintenance room to fix the power. On the way you hear a loud noise come from one of the closets in the hall.";
                        imageBox.BackgroundImage = Properties.Resources.Maintenance_hall;
                        aLabel.Text = "Check it out";
                        sLabel.Text = "Send a guard";
                        dLabel.Text = "Ignore it";
                        text = 1;
                    }
                    break;
                case 63:
                    if (text == 1)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Let's just keep going, it's probably rats.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Everyone seems to agree and you make it to the maintenance room";
                        imageBox.BackgroundImage = Properties.Resources.maintenance;
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Alright, check for any faulty wiring or issues that could've caused the outage.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You take a look at the generator and find that the power outlet has been destroyed along with the cord running from the generator to the outlet.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "What would have caused this?";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Douglas shrugs, even though you were mostly talking to yourself.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You manage to fix the wiring in the outlet and the damage done to the cord. Once finished, you plug the cord back into the outlet and start the generator. The generator whirrs to life and the power is restored.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are blinded by the light that emits from the fixture in the room.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 71;
                    }
                    break;
                case 64:
                    if (text == 1)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Douglas, get one of your men to check it out.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Alright, Derek you go.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Derek slowly walks over to the closet and opens it.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then, something slashes at him, but misses. He begins to shoot at whatever is in the closet, then it suddenly bursts out. The other guards begin to shoot at it also.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Run!";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You don't think twice and begin to run to the maintenance room with the other engineers, with the guards following.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once in maintenance, the guards block the door.";
                        imageBox.BackgroundImage = Properties.Resources.maintenance;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 68;
                    }
                    break;
                case 65:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You go to investigate the noise.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Sarah, don't.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You ignore him and continue to the closet. Once at the door, you slowly open it, but can't quite see because of how dark it is.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then something slashes at you.";
                        imageLabel.Text = "PRESS W";
                        imageLabel.Visible = true;
                        imageBox.Visible = false;
                        qT = true;
                        text = 1;
                    }
                    break;
                case 66:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You quickly jump back as the thing slashes at you.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "AHHHHHHHH!";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The thing bursts out of the closet. The guards begin to shoot at it and it runs in the other direction. You and the rest of the team run down to the maintenance room.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once in maintenance, the guards block the door.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Douglas what was that thing? What is going on here?";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "The Captain called me to the bridge and told me that we're being attacked by aliens or something. This whole situation is getting out of control.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You feel your heart drop as you realize you might die here before you even reach the new planet. Douglas puts a hand on your shoulder.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Look I know things seem bad right now, but I need you to pull yourself together and get this power fixed. We'll get through.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You can't stop shaking, but you know you have to get the power back up so you pull yourself together.";
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Alright, check for any faulty wires or issues that could've caused the outage.";
                    }
                    if (text == 11)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You take a look at the generator and find that the power outlet has been destoryed along with the cord that powered the generator.";
                    }
                    if (text == 12)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "That thing must've been what caused the outage.";
                    }
                    if (text == 13)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Yeah, good thing we got that sorted out.";
                    }
                    if (text == 14)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You manage to fix the wiring in the outlet and the damage done to the cord. Once finished, you plug the cord back into the outlet and start the generator. The generator whirrs to life and the power is restored.";
                    }
                    if (text == 15)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are blinded by the light that emits from the fixture in the room.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 71;
                    }
                    break;
                case 67:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You feel a sharp pain in your leg as you fall to the floor. Just then you feel another sharp pain in your chest and you're dragged into the closet.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:00 am, Head of Security Douglas Clark, maintenance deck.\nYou quickly aim your sights at the closet.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 69;
                    }
                    break;
                case 68:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Once in maintenance, the guards block the door.";
                        imageBox.BackgroundImage = Properties.Resources.maintenance;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Douglas what was that thing? What is going on here?";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "The Captain called me to the bridge and told me that we're being attacked by aliens or something. This whole situation is getting out of control.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You feel your heart drop as you realize you might die here before you even reach the new planet. Douglas puts a hand on your shoulder.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Look I know things seem bad right now, but I need you to pull yourself together and get this power fixed. We'll get through.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You can't stop shaking, but you know you have to get the power back up so you pull yourself together.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Alright, check for any faulty wires or issues that could've cause the outtage.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You take a look at the generator and find that the power outlet has been destoryed along with the cord that powered the generator.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "That thing must've been what caused the outtage.";
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Yeah, good thing we got that sorted out.";
                    }
                    if (text == 11)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You manage to fix the wiring in the outlet and the damage done to the cord. Once finished, you plug the cord back into the outlet and start the generator. The generator whirrs to life and the power is restored.";
                    }
                    if (text == 12)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are blinded by the light that emits from the fixture in the room.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 71;
                    }
                    break;
                case 69:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:00 am, Head of Security Douglas Clark, maintenance deck.\nYou quickly aim your sights at the closet.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Fire!";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then something bursts out of the closet and runs in the other direction.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Get to the maintenance room!";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You all run to the maintenance room and barricade the door behind you.";
                        imageBox.BackgroundImage = Properties.Resources.maintenance;
                        text = 0;
                        scene = 70;
                    }
                    break;
                case 70:
                    if (text == 1)
                    {
                        characterLabel.Text = "Engineer";
                        subTitleLabel.Text = "What was that thing? What's going on?";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "The Captain called me to the bridge and told me that we're being attacked by aliens or something. This whole siutation is getting out of control.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The engineers look at you in panic.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Look, all that matters right now is getting the power back up and running.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They seem to agree and get to it immediately.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Engineer";
                        subTitleLabel.Text = "Hey, I think I found the problem. This outlet and power cord are broken.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They manage to fix them both and turn on the generator. It whirrs to life and the power is restored.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are blinded by the light that emits from the fixture in the room.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 71;
                    }
                    break;
                case 71:
                    if (text == 1)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "Oh good, the powers back.";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You get a notification on your HUD that the Captain has a requested a meeting on the bridge. You head there.";
                        text = 0;
                    }
                    break;
                case 72:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You head to the main area where you don't see anyone. It feels really eerie being the only one here.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You go up to the bridge where the Navigators are trying to start the ship again. You find the Captain who appears to be talking to someone on his HUD. Once he finishes you approach him.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "Captain, what's going on?";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "It's going to sound crazy, but I think we were just attacked by aliens.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You stare at him not sure if he's joking or telling the truth, but he's never been one to joke around. You sit down at the table and wait for everyone else to arrive.";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 73:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You head to the main area, but are stopped as you see the bodies of dead crewmates laying on the ground. You feel the urge to throw up, but manage to hold it in. You notice another corpse on the ground that's laying in a pool of green liquid.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You quickly run away from the scene, up to the bridge where the Navigators are trying to start the ship again. You find the Captain who seems to be talking to someone on his HUD. You approach him immediately.";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "Captain, there's crew mates, dead in the main area and there's this other corpse there too that I've never seen before and-";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Woah what? You need to calm down and breathe. You said there were dead bodies in the main area?";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "You need to tell me what's going on right now!";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Alright listen, there were these blips on the radar that came up as unidentified. So it turns out that these blips were apparently alien ships.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You look at the Captain in complete shock. You aren't able to say anything and just sit down.";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 74:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You follow the creature back to the main area. You make it there and find it laying on the ground bleeding some green liquid from the gun wounds.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You walk up to it and it slashes at you, but since it's so weak it doesn't do much.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You aim your gun at it and fire, killing it.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "That's that. Inform the Captain that the creature is dead.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Your men take off to the bridge, while you go to engineering bay.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are sitting in the repair room with Head Engineer Sarah Mackenzie.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 76;
                    }
                    break;
                case 75:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You follow the creature back to the main area where it's attacking a crew mate. You take a shot and the creture falls over onto the ground.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Run! Get out of here!";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The crew mate gets up and runs away. The creature is heavily injured and is bleeding some weird green liquid from the gun wounds.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You walk up to it and it slashes at you, but since it's so weak it doesn't do much.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You aim your gun at it and fire, killing it.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Damn monstrosity. Inform the Captain that the creature is dead.";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Your men take off to the bridge, while you go to engineering bay.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are sitting in the repair room with Head Engineer Sarah Mackenzie.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        text = 0;
                        scene = 76;
                    }
                    break;
                case 76:
                    if (text == 1)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "This power outage is pretty weird, don't you think?";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Sarah";
                        subTitleLabel.Text = "Yeah, the generator shouldn't just shut down, it's built to withstand running for long periods of time.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Just then Douglas enters into the room.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Ria, you need to come with me, I need to speak with you.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You follow Douglas in confusion. He leads you to the main area where the corpse of some creature lays on the ground. You hold the urge to throw up as the smell coming from the corpse is very pungent.";
                        imageBox.BackgroundImage = Properties.Resources.Main_area;
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Have you ever studied anything like this before?";
                    }
                    if (text == 7)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "No, I've never seen anything like this in my life. It's so...... artificial.";
                    }
                    if (text == 8)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Looking at the corpse it looks like it has a mechanical suit of armor on, but upon further inspection you think it might be it's skin.";
                    }
                    if (text == 9)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "I think you should study this. It might give us some useful information about what kinds of lifeforms there are here.";
                    }
                    if (text == 10)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You think for a moment. Douglas does have a good point, but you feel very uneasy about being around this thing.";
                        aLabel.Text = "Study it";
                        sLabel.Text = "Don't";
                        text = 1;
                    }
                    break;
                case 77:
                    if (text == 1)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "No way, I don't want to be anywhere near this thing.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Douglas gives you an angry look and goes to say something, but decides to hold his tongue.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Fine, I'll just have my men eject it or something.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You both head back to engineering bay where Sarah is.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Sarah, gather a team and let's fix the power. I'll get an escort ready in case there's trouble on the way.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Sarah gets up and follows Douglas out of the room. A few moments later the power comes back on. You sit still, thinking about everything that's happened. Just then you get a notification on your HUD of a meeting on the bridge. You head there.";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 78:
                    if (text == 1)
                    {
                        characterLabel.Text = "Ria";
                        subTitleLabel.Text = "Alright, I suppose it would be nice to know what's out there.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You don't feel entirely safe with this, but knowing more about space is your job after all, even if it means taking risks.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Great, I'll have my men put it in containment and you can do your thing.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You both head back to engineering bay where Sarah is.";
                        imageBox.BackgroundImage = Properties.Resources.engineering_bay;
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Sarah, gather a team and let's fix the power. I'll get an escort ready in case there's trouble on the way.";
                    }
                    if (text == 6)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "Sarah gets up and follows Douglas out of the room. A few moments later the power comes back on. You sit still, thinking about everything that's happened. Just then you get a notification on your HUD of a meeting on the bridge. You head there.";
                        text = 0;
                        scene = 81;
                    }
                    break;
                case 79:
                    if (text == 1)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You return to the bridge with the item.";
                        imageBox.BackgroundImage = Properties.Resources.bridge;
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "Alexander";
                        subTitleLabel.Text = "Send a message saying we will return the item.";
                    }
                    if (text == 3)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The Navigators do so and another message is sent back.";
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The message reads:\nEject the object into space and we will pick it up.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You think about whether or not you want to sabatoge their ship.";
                        aLabel.Text = "Sabatoge the alien ship";
                        sLabel.Text = "Don't";
                        text = 1;
                    }
                    break;
                case 80:
                    characterLabel.Visible = false;
                    imageLabel.Visible = true;
                    imageLabel.Text = "Creators:\nVoyagers - Ethan McComb\nDesert Void - Joey Gerber\n\nVoice Actors(Order of Appearance):\nAlexander Leon - Ethan McComb\nAlex Sarichith - Charles Sarichith\nSarah Mackenzie - Julia Dowson\nDouglas Clark - Parker Railton\nRia Das - Herself\nOthers - Ryan Prosper";
                    subTitleLabel.Visible = false;
                    aLabel.Text = "Back";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 81:
                    characterLabel.Text = "";
                    subTitleLabel.Text = "You have completed the first chapter of the Voyagers storyline. Stay tuned for chapter two which will probably come out in a year.";
                    imageBox.Visible = false;
                    aLabel.Text = "Menu";
                    sLabel.Text = "Exit";
                    dLabel.Text = "";
                    break;
                case 82:
                    if (text == 1)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "It's just a power outage, nothing serious. We're going to fix the power and everything will be fine.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They seem a little suspicious of this, but calm down. You head into the security station.";
                        imageBox.BackgroundImage = Properties.Resources.Security;
                        text = 0;
                        scene = 62;
                    }
                    if (text == 4)
                    {
                        characterLabel.Text = "Douglas";
                        subTitleLabel.Text = "Alright new orders from the Captain, we need to patrol around the entire ship and make sure everything is secure. Since comms are down you'll need to tell any other security personnel of the new orders.";
                    }
                    if (text == 5)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "They begin their patrol around the ship.";
                        aLabel.Text = "Patrol";
                        sLabel.Text = "Go to the bridge";
                        text = 1;
                    }
                    break;
                case 83:
                    characterLabel.Text = "";
                    subTitleLabel.Text = "";
                    aLabel.Text = "Increase security";
                    sLabel.Text = "Don't know";
                    dLabel.Text = "";
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (qT == true)
            {
                qTCounter++;
                if (scene == 21)
                {
                    if (qTCounter == 20)
                    {
                        scene = 23;
                        imageBox.Visible = true;
                        qT = false;
                        imageLabel.Visible = false;
                        characterLabel.Text = "";
                        subTitleLabel.Text = "The thing jumps right on your face and begins to squeeze. You can feel your skull being crushed as your vision begins to fade. Captain Alexander Leon is dead.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    else if (nKeyDown == true)
                    {
                        scene = 22;
                        imageBox.Visible = true;
                        imageLabel.Visible = false;
                        qT = false;
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You quickly move out of the way and the thing jumps past you.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                }
                if (scene == 46)
                {
                    if (qTCounter == 20)
                    {
                        scene = 48;
                        imageBox.Visible = true;
                        imageLabel.Visible = false;
                        qT = false;
                        subTitleLabel.Text = "You aren't fast enough and the thing slashes at your leg and you fall to the ground. Just then it stabs you in the chest and drags you into the closet. The sound of your men shooting at the creature begin to fade.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";

                    }
                    else if (tKeyDown == true)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You quickly get out of the way before the thing can strike you.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        scene = 47;
                        imageBox.Visible = true;
                        imageLabel.Visible = false;
                        qT = false;
                    }
                }

                if (scene == 65)
                {
                    if (qTCounter == 20)
                    {
                        scene = 67;
                        imageBox.Visible = true;
                        imageLabel.Visible = false;
                        qT = false;
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You feel a sharp pain in your leg as you fall to the floor. Just then you feel another sharp pain in your chest and you're dragged into the closet.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    else if (wKeyDown == true)
                    {
                        characterLabel.Text = "";
                        subTitleLabel.Text = "You quickly jump back as the thing slashes at you.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                        scene = 66;
                        imageBox.Visible = true;
                        imageLabel.Visible = false;
                        qT = false;
                    }
                }
                Refresh();
            }
            if (scene == 2)
            {
                starsXList.Add(randGen.Next(25, 400 - starSize * 2));
                starsYList.Add(randGen.Next(25, 400 - starSize * 2));

                for (int i = 0; i < starsYList.Count(); i++)
                {
                    starsXList[i] -= starSpeed;
                }

                for (int i = 0; i < starsXList.Count(); i++)
                {
                    if (starsYList[i] > 450)
                    {
                        starsXList.RemoveAt(i);
                        starsYList.RemoveAt(i);
                        break;
                    }
                }

            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (scene == 2)
            {
                for (int i = 0; i < starsYList.Count; i++)
                {
                    e.Graphics.FillEllipse(whiteBrush, starsXList[i], starsYList[i], starSize, starSize);
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                nKeyDown = false;
            }
            if (e.KeyCode == Keys.T)
            {
                tKeyDown = false;
            }
            if (e.KeyCode == Keys.W)
            {
                wKeyDown = false;
            }
        }
    }
}
