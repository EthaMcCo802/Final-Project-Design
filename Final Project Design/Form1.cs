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

        int players = 5;

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

        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
                if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 6; }
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
                if (scene == 4) { }
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
            else if (e.KeyCode == Keys.Space)
            {
                text++;
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
                    if (text == 1)
                    {
                        subTitleLabel.Text = "The year is 2140, 10 years after Earth has been wiped out and is now uninhabitable.\n\nPress space to continue.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
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
                        subTitleLabel.Text = "There were supposed rumorsof a research crew that were sent to check out the planet years before The Incident.";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "You are the colonists, hoping to survive the terrible endeavors of space and make it to the planet to start a new life. Will you make it?";
                        text = 0;
                        scene = 3;
                    }
                    break;
                case 3:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "7:30 am, Captain Alexander Leon, captains quarters.\nYou awake to the sound of your alarm. You are in your quarters still in bed while your personal HUD reads off the schedule for job assignments for the day.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "Just then IRIS, the ships artificial intelligence, chimes in through the intercom.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "Good morning Captain. The time is currently 7:30 am. Shall I make you breakfast?";
                        aLabel.Text = "Say yes";
                        sLabel.Text = "Say no";
                        text = 1;
                    }
                    break;
                case 4:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "I'd rather not eat this morning.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "With that, IRIS dissapears. You get dressed in your uniform and exit your room.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "You grab a cup of coffee that your automatic coffee machine has already made for you.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "Since IRIS is the ships AI she controls all technology on board, which kind of worries you a little since you've never really trusted technology.";
                        text = 0;
                        scene = 6;
                    }
                    break;
                case 5:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "Yes IRIS.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "With that, IRIS dissapears. You get dressed in your uniform and exit your room.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "Once in the main area of your quarters you can smell the breakfast that your assistant robots made for you.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "Since IRIS is the ships AI she controls all technology on board, which kind of worries you a little since you've never really trusted technology.";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "You sit down and eat your breakfast.";
                        text = 0;
                        scene = 6;
                    }
                    break;
                case 6:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "You decide it is time to start the day. You exit your quarters and are greeting by Alex Sarichith, the First Officer.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "Good morning Captain.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "Good morning Alex, what's on the agenda for today?";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "Alex goes over the daily work schedule with you. You listen attentively as the two of you walk towards the bridge.";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "Once on the bridge everyone stands up and salutes. You wave and they sit back down, continuing what they were doing.";
                        aLabel.Text = "Talk to Alex";
                        sLabel.Text = "Start giving orders";
                        text = 1;
                    }
                    break;
                case 7:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "Alright let's get to it, what's the status on the ship?";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "You start to give out orders to the navigators.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "After a while you recieve a notification on your personal HUD. It requests your presence in the engineering bay.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "I have to go assist with something, can you watch over up here Alex?";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "Yes, sir.";
                    }
                    if (text == 6)
                    {
                        subTitleLabel.Text = "With that, you leave the bridge and head to engineering bay.";
                        text = 1;
                    }
                    break;
                case 8:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "How have you been holding up?";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "I'm fine.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "Something tells you that statement isn't entirely true, but you decide not to press the matter.";
                        text = 1;
                        scene = 7;
                    }
                    break;
                case 9:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "How have you been holding up?";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "Alex gets a grim look on his face";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "Somethings been bothering me lately.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "Did you want to talk about it?";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "Alex seems reluctant at first, but finally manages the courage to tell you";
                    }
                    if (text == 6)
                    {
                        subTitleLabel.Text = "A couple years before The Incident, my father went missing. He wasn't around very much when I was younger. When I asked my mother about it she just told me he was very busy. The few times I did see him he neglected to tell me what he was doing. Recently I was looking through some old family photos I managed to save from Earth and found he was a member of NASA.";
                    }
                    if (text == 7)
                    {
                        subTitleLabel.Text = "Alex pauses. He looks a little uncomfortable, but continues.";
                    }
                    if ( text == 8)
                    {
                        subTitleLabel.Text = "Right before his dissapearance, the rumours began about NASA sending a research team to find a new planet for humans. So naturally I put two and two together and came to the conclusion that he was on that expedition.";
                    }
                    if (text == 9)
                    {
                        subTitleLabel.Text = "You look at Alex deeply, not sure what to say.";
                    }
                    if (text == 10)
                    {
                        subTitleLabel.Text = "I'm sorry to hear that Alex.";
                    }
                    if (text == 11)
                    {
                        subTitleLabel.Text = "Forget about it.";
                        text = 0;
                        scene = 7;
                    }
                    break;
                case 10:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "Once in engineering you are greeted by the Head of Engineering Sarah Mackenzie";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "Right this way sir.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "You follow her to a repair room where she has powered down one of the worker robots.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "This robot was acting really weird so I had to shut it down. Kept reporting a strange anomoly in cargo bay.";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "Have you checked it out yet?";
                    }
                    if (text == 6)
                    {
                        subTitleLabel.Text = "Not yet, but it wouldn't stop so I thought maybe it was a malfunction.";
                    }
                    if (text == 7)
                    {
                        subTitleLabel.Text = "What should we do?";
                        aLabel.Text = "Send security";
                        sLabel.Text = "Ignore it";
                        text = 1;
                    }
                    break;
                case 11:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "You tap on your HUD and make an announcement.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "If there are any available security, could you please check a potential anomoly in cargo bay.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "There that should solve it. If any other problems arise, notify me.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "Yes, sir.";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "With that you leave and return to the bridge.";
                        text = 0;
                        scene = 13;
                    }
                    break;
                case 12:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "It's probably just a malfunction, try to fix the robot and leave it.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "Sarah opens her mouth to protest, but decides not to.";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "Now if you'll excuse me I have more pressing matters to tend to.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "With that you leave and return to the bridge.";
                        text = 0;
                        scene = 13;
                    }
                    break;
                case 13:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "8:15 pm, First Officer Alex Sarichith, the bridge. \nYou are overseeing operations on the bridge when suddenly.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "Sir can come take a look at this?";
                    }
                    if (text == 3)
                    {
                        subTitleLabel.Text = "You go over to the navigator and he points to a screen.";
                    }
                    if (text == 4)
                    {
                        subTitleLabel.Text = "A strange object has appeared on our radars. Our sensors aren't able to tell us what it exactly is. The weird thing is, it seems to be following us.";
                    }
                    if (text == 5)
                    {
                        subTitleLabel.Text = "You study the radar for a second trying to figure out what the object could be."
                    }
                    if (text == 6)
                    {
                        subTitleLabel.Text = "What should we do?";
                        aLabel.Text = "Stop the ship";
                        sLabel.Text = "Do nothing";
                    }
                    break;
                case 14:
                    if (text == 1)
                    {
                        subTitleLabel.Text = "Just keep the ship moving, maybe it'll go away.";
                        aLabel.Text = "";
                        sLabel.Text = "";
                        dLabel.Text = "";
                    }
                    if (text == 2)
                    {
                        subTitleLabel.Text = "Just then, the Captain enters the bridge. You think if you should tell him or not.";
                    }
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
                    subTitleLabel.Text = "8:45, Captain Alexander Leon, the bridge.\nAfter hearing that distrubing message, you think about your next course of action.";
                    aLabel.Text = "Refuse to hand over the item";
                    sLabel.Text = "Find the item";
                    dLabel.Text = "";
                    break;
                case 18:
                    subTitleLabel.Text = "Send a message saying that we refuse to give up this item they speak of.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 19:
                    subTitleLabel.Text = "Remembering the conversation you had with Sarah, you pull out your HUD and make an announcement to the worker robots on board.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 20:
                    subTitleLabel.Text = "You get an alert on your HUD that the anomoly in cargo bay has been found.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 21:
                    subTitleLabel.Text = "Open it.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 22:
                    subTitleLabel.Text = "You quickly move out of the way and the thing jumps past you.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 23:
                    subTitleLabel.Text = "The thing jumps right on your face and begins to squeeze. You can feel your skull being crushed as your vision begins to fade. Captain Alexander Leon is dead.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    player1State = "dead";
                    break;
                case 24:
                    subTitleLabel.Text = "10:00 am, First Officer Alex Sarichith, the bridge.\nYou are at the bridge awaiting the Captain when security comes into the room.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 25:
                    subTitleLabel.Text = "Put it back in the egg!";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 26:
                    subTitleLabel.Text = "Kill it!";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 27:
                    subTitleLabel.Text = "You decide not to as it probably make things worse. You eject the egg and the ship begins to take off. Just then you recieve another message.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 28:
                    subTitleLabel.Text = "The alien ship doesn't go away, but instead another message is sent.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 29:
                    subTitleLabel.Text = "The alien ship begins to fly, but then suddenly it explodes. The explosion wasn't enough to damage your ship, but you felt a bit of rocking from it.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 30:
                    subTitleLabel.Text = "You order for the ship to be stopped. The crew follows your order and slows down the ship until it is completely stopped.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 31:
                    subTitleLabel.Text = "You show the captain the radar and explain to him the situation. He gives you a weird look.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 32:
                    subTitleLabel.Text = "9:00 am, Head of Security Douglas Clark, security station.\nYou are sitting in your office when suddenly the power goes out. You go out to investigate what is going on and find that most of your men confused as well.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 33:
                    subTitleLabel.Text = " You head outside of the security station into the main area of the ship. Most of the crew is beginning to panic a bit.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 34:
                    subTitleLabel.Text = "You move through the crowded area trying to get to the bridge. The crew seem to panic a bit now that you're gone, but you just ignore them and keep moving.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 35:
                    subTitleLabel.Text = "Make sure chaos doesn't start amongst these crew mates.";
                    choice1 = true;
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 36:
                    subTitleLabel.Text = "You reach the bridge where it seems to be even worse. Everyone is in a mass panic. You look around for The Captain and find him trying to turn on his HUD.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 37:
                    subTitleLabel.Text = "The Captain gives you a worried look.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 38:
                    subTitleLabel.Text = "The Captain gives you a worried look.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 39:
                    subTitleLabel.Text = "We could increase security. A bunch of my men are just sitting around doing nothing.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 40:
                    subTitleLabel.Text = "We could increase security. A bunch of my men are just sitting around doing nothing.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 41:
                    subTitleLabel.Text = "We could get the engineers to fix the power.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 42:
                    subTitleLabel.Text = "You decide to tell them the truth.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 43:
                    subTitleLabel.Text = "You think it's best that you stay on the bridge where The Captain is. After waiting some time one of your men come in.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 44:
                    subTitleLabel.Text = "You yourself decide to patrol around the ship to make sure everything is safe. You find a group of other security members and stick with them.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 45:
                    subTitleLabel.Text = "You think it might be rats and don't waste time on it.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 46:
                    subTitleLabel.Text = "You investigate the sound.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 47:
                    subTitleLabel.Text = "You quickly get out of the way before the thing can strike you.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 48:
                    subTitleLabel.Text = "You aren't fast enough and the thing slashes at your leg and you fall to the ground. Just then it stabs you in the chest and drags you into the closet. The sound of your men shooting at the creature begin to fade.";
                    player4State = "dead";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 49:
                    subTitleLabel.Text = "10:00 am, Head Researcher Ria Das, engineering bay.\nYou are in the repair shop with Sarah.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 50:
                    subTitleLabel.Text = "You decide to stay in the room.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 51:
                    subTitleLabel.Text = "You decide to go with her as you don't want to be left alone.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 52:
                    subTitleLabel.Text = "Let it go. Won't be able to do much with wounds like those.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 53:
                    subTitleLabel.Text = "Once there you find a mess of dead crewmates and a weird green substance. The crew mates appear to have giant slash marks on their chests and are covered in blood.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 54:
                    subTitleLabel.Text = "Once there you find a mess of a weird green substance everywhere.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 55:
                    subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are sitting alone in the repair shop waiting for the power to be restored.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 56:
                    subTitleLabel.Text = "The Captain gives you a worried look.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 57:
                    subTitleLabel.Text = "Getting the power back should be our number one priority right now. I can get some of my men to escort a couple engineers to maintenance.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 58:
                    subTitleLabel.Text = "Getting the power back should be our number one priority right now. I can get some of my men to escort a couple engineers to maintenance.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 59:
                    subTitleLabel.Text = "It's just a little power outage, everything is going to be fine.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 60:
                    subTitleLabel.Text = "You decide tell them the truth.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 61:
                    subTitleLabel.Text = "9:45 am, Head of Engineering Sarah Mackenzie, engineering bay.\nYou are in the repair shop with Head Researcher Ria Das";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 62:
                    subTitleLabel.Text = "Let's just keep moving.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 63:
                    subTitleLabel.Text = "Get one of your men to check it out Douglas.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 64:
                    subTitleLabel.Text = "You manage to reach the maintenace room where the security guards block the door.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 65:
                    subTitleLabel.Text = "You go to investigate the noise.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 66:
                    subTitleLabel.Text = "You quickly jump back as something tries to stab you with a large claw.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 67:
                    subTitleLabel.Text = "You feel a sharp pain in your leg as you fall to the floor. Just then you feel another sharp pain in your chest and you're dragged into the closet.";
                    player3State = "dead";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 68:
                    subTitleLabel.Text = "10:00 am, Head of Security Douglas Clark, maintenance deck.\nYou quickly aim your sights at the closet.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 69:
                    subTitleLabel.Text = "You make it to the maintenance room and barricade the door behind you.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 70:
                    subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are blinded by the light that emits from the fixture in the repair room. You feel relieved to finally have power again.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 71:
                    subTitleLabel.Text = "You head to the main area where you don't see anyone. It feels really eerie being the only one here.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 72:
                    subTitleLabel.Text = "You head to the main area, but are stopped as you see the bodies of dead crew mates laying on the ground. You feel the urge to throw up, but manage to hold it in.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 73:
                    subTitleLabel.Text = "You follow the creature back to the main area. It's laying on the ground, spilling some weird green liquid from the bullet holes.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 74:
                    subTitleLabel.Text = "You follow the creature back to the main area. You make it there and find some of the crew mates from earlier being attacked by the creature.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 75:
                    subTitleLabel.Text = "10:30 am, Head Researcher Ria Das, engineering bay.\nYou are in the repair room with the Head of Engineering Sarah Mackenzie.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 76:
                    subTitleLabel.Text = "I'll study a sample of it's blood, but I'm not going anywhere near that thing.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 77:
                    subTitleLabel.Text = "Fine, I'll study it.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;
                case 78:
                    subTitleLabel.Text = "You return to the bridge with the item.";
                    aLabel.Text = "";
                    sLabel.Text = "";
                    dLabel.Text = "";
                    break;



            }
        }

        private void imageLabel_Click(object sender, EventArgs e)
        {

        }

        private void subTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
