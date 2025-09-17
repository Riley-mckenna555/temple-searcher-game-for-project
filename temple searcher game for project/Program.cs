using System.Diagnostics.CodeAnalysis;

Console.WriteLine("you sit on a warm winters night, you are in your armchair all comfy by the fire. when suddenly you get interuppted by your phone ringing. who is it now, you think to yourself as you ponder even bothering picking it up");
Console.WriteLine("");
Console.WriteLine("option 1. pick up the phone");
Console.WriteLine("option 2. ignore the phone");
Console.WriteLine("");
string input = Console.ReadLine();

if (input == "pick up the phone")
{
    Console.WriteLine("you pick up the phone and hear the voice of your buisness partner, he sounds frantic and also a little excited. 'hey harold! its Raymond, sorry to bother you at this ungodly hour, i have good and bad news to tell you' you think to yourself about what he might want calling at this hour on a day before christmas eve. Raymond speaks again, 'ill start with the good news my friend, we found it!' you wonder what he might be talking about. 'we found the south arocalonian temple!' your eyes widen.");
    Console.WriteLine("");
    Console.WriteLine("Raymond continues, 'now for the more worrysome news, we kinda sorta sent some workers there to check on whats inside and they havent really come back yet which is kindof worrying, ok ok lets get down to brass tacs, we at raymonds exploration.inc would like for you to check it out for us and retrieve out lost workers.'");

}

else if (input == "ignore the phone")
{
    Console.WriteLine("you ignore the phone and go to sleep, the next day you find yourself jobless and a few months later you come to pass that your life is over, you shouldve picked up the phone you think to yourself");
    Console.WriteLine("");
    Console.WriteLine("restart?");
}


string restart = Console.ReadLine();

if (restart == "yes")
{
    Console.Clear();
    Program main = new Program();


   
    

}
Console.WriteLine("");
Console.WriteLine("option 1. ok, sounds good");
Console.WriteLine("option 2. no why do i have to?");

string input2 = Console.ReadLine();

if (input2 == "ok, sounds good")
{
    Console.WriteLine("perfect, now get going. we need those workers back immediately");
    Console.WriteLine("");
    Console.WriteLine("you get in your car and turn it on, you drive through the snowy roads");
    Console.WriteLine("");
    Console.WriteLine("you are driving, how fast do you want to go?");
    int speed = int.Parse(Console.ReadLine());

    if (speed > 60)
    {
        Console.WriteLine("the police pull you over, and give you a 30 dollar fine");
        int money = 100;
        money = money - 30;
        Console.WriteLine($"you now have {money} dollars");
        Console.WriteLine("you keep driving after paying the fine");
        Console.WriteLine("you arrive at the temple safely");
    }
    else
    {
        Console.WriteLine("you arrive at the temple safely");
    }
        Console.WriteLine("you step out from your automobile the chilling winter air prickles at your nose as you look up and around at the temple. it is huge! and full of arcitectural details that amazes you");
}

else if (input2 == "no why do i have to?")
{
    Console.WriteLine("Raymond sighs, 'look harold, i know this is a lot to ask but we really need those workers back, and you do want to keep your job right?. so do this favor for the company because i would really hate to fire you harold. so unless you want to be fired i would do what im asking you");
    Console.WriteLine("");
    Console.WriteLine("you arrive at the temple, and step out from your automobile the chilling winter air prickles at your nose as you look up and around at the temple. it is huge! and full of arcitectural details that amazes you");

}
Console.WriteLine("");
Console.WriteLine("option 1. enter the temple");
Console.WriteLine("option 2. gather your gear");

string input3 = Console.ReadLine();

if (input3 == "enter the temple")
{
    Console.WriteLine("i should gather my gear first you think to yourself, as you turn around and head back to your car");
    Console.WriteLine("");
    Console.WriteLine("you search your car for gear");
    Console.WriteLine("");
    Console.WriteLine("you find a flashlight, a rope , and one bandage");

}

else if (input3 == "gather your gear")
{
    Console.WriteLine("you search your car for gear");
    Console.WriteLine("you find a flashlight, a rope , and one bandage");
}
Console.WriteLine("");
Console.WriteLine("you walk up to the entrance of the temple, there are some big steps as you scale them straight up to the top.");
Console.WriteLine("");
Console.WriteLine("option 1. go in the big rustic looking door");
Console.WriteLine("option 2. look around the entrance");
string input4 = Console.ReadLine();

if (input4 == "go in the big rustic looking door")
{
    Console.WriteLine("you try to pry open the rusted over massive door, it creaks and breaks open as you fall down deep into the temple, no way back now");

}

else if (input4 == "look around the entrance")
{
    Console.WriteLine("you look around the walls and floor of the entrance, you see a massive pile of rubble and you see a glint of something shiny inside it");
    Console.WriteLine("");
    Console.WriteLine("you dig in the rubble and you find 16 gold coins that are weirdly shaped kind of like triangles");
    Console.WriteLine("");
    int gold = 0;
    gold = gold + 16;
    Console.WriteLine($" you now have {gold} gold coins");
    Console.WriteLine("");
    Console.WriteLine("you walk back over to the door feeling proud of yourself that you found something");
    Console.WriteLine("");
    Console.WriteLine("you try to pry open the rusted over massive door, it creaks and breaks open as you fall down deep into the temple, no way back now");

}
Console.WriteLine("");
Console.WriteLine("you hit the floor hard, you feel a sharp pain in your leg");
Console.WriteLine("");
Console.WriteLine("OH NO! you lost some health!");

int health = 100;
health = health - 20;
Console.WriteLine($" your health is now {health}");
Console.WriteLine("");

Console.WriteLine("do you want to use the bandage you found in your car?");
Console.WriteLine("");
Console.WriteLine("option 1. yes");
Console.WriteLine("option 2. no");
Console.ReadLine();

string input5 = Console.ReadLine();
if (input5 == "yes")
{
    Console.WriteLine("you wrap the bandage around your leg, you gain back 20 health");
    health = health + 20;
    Console.WriteLine($" your health is now {health}");
}


else if (input5 == "no")
{
    Console.WriteLine("you deside not to use the bandage, yet and put it back in your bag");
}


Console.WriteLine("you walk down the dark path in the temple, you dont see anything but darkness");
Console.WriteLine("");
Console.WriteLine("option 1. use your flashlight");
Console.WriteLine("option 2. keep walking in the dark");
Console.ReadLine();
string input6 = Console.ReadLine();

if ( input6 == "use your flashlight")
{
    Console.WriteLine("the room gets illuminated, you look around and find some writing on tiles as well as drips of red on the ground");
    Console.WriteLine("");
    Console.WriteLine("your eyes widen as you see more and more of these drips of a blackish red fluid");
    Console.WriteLine("");
    Console.WriteLine("you raise your flashlight, and what you see stops your heart for a moment");
    Console.WriteLine("");
    Console.WriteLine("there is a puddle of red as you get closer you see its blood");
    Console.WriteLine("");
    Console.WriteLine("your eyes widen even more as you see the dismembered parts of the workers you were sent to retrieve");
    Console.WriteLine("");
    Console.WriteLine("you recoil in horror as you see one of the workers headless body");
    Console.WriteLine("");
    Console.WriteLine("you hear a bone crunching noise");
    Console.WriteLine("");
    Console.WriteLine("option 1. turn around");
    Console.WriteLine("option 2. run into the darkness");
    string input7 = Console.ReadLine();

    if (input7 == "turn around")
    {
        Console.WriteLine("you turn around and lift your flashlight up");
        Console.WriteLine("");
        Console.WriteLine("your eyes shrink with fear as you see a massive creature, it has souless eyes and sharp teeth, with a mouth that extends");
        Console.WriteLine("");
        Console.WriteLine("you move away slowly as the creatures dead eyes look at you, it stares dead into your soul");
        Console.WriteLine("");
        Console.WriteLine("you sprint away running as fast as you can as it chases you with its arms that appear out of every place in its body");
        Console.WriteLine("");

    }

    else if (input7 == "run into the darkness")
    {
        Console.WriteLine("");
        Console.WriteLine("you sprint away running as fast as you can as it chases you with its arms that appear out of every place in its body");
        Console.WriteLine("");
    }

    Console.WriteLine("you hear its roar as it sounds like the mimiced voices of all the dead workers combining into a skin crawling scream");
    Console.WriteLine("");
    Console.WriteLine("you keep running dodging objects");
    Console.WriteLine("");
    Console.WriteLine("option 1. go right, the way looks clear but suspicious");
    Console.WriteLine("");
    Console.WriteLine("option 2. go left, the way looks like it has rubble but it looks safer somehow");

    string input8 = Console.ReadLine();

    if (input8 == "go right, the way looks clear but suspicious")
    {
        Console.WriteLine("you turn the corner on the right side and see a dead end");
        Console.WriteLine("");
        Console.WriteLine("the monster screams and swings its arm, you dodge but get hit bluntly to the left way");
        health = health - 50; 
        Console.WriteLine($"your health is now {health}");
        Console.WriteLine("");
        Console.WriteLine("you are extremely hurt but push on as you sprint down the left path");
    }

    else if (input8 == "go left, the way looks like it has rubble but it looks safer somehow")
    {
        Console.WriteLine("you turn the corner on the left side and see a path that looks like it has lots and lots of rubble,but its not bad and treversable");
        Console.WriteLine("");
        Console.WriteLine("you see a light at the end of the tunnel");
        Console.WriteLine("");
        Console.WriteLine("the creature roars behind you, but you pay it no heed as you sprint towards the light at the end of the tunnel");
        Console.WriteLine("");
        Console.WriteLine("you make it to a sunlit area of the temple as the monster still chases you");
        Console.WriteLine("");
        Console.WriteLine("you see a big sharp object in the middle of the area, maybe you can stab it if you make the right maneuver");
        Console.WriteLine("");
        Console.WriteLine("the creature swings its massive hand");
        Console.WriteLine("");
        Console.WriteLine("option 1. dodge left");
        Console.WriteLine("option 2. roll under it");

        
    }
    
    Console.WriteLine("you see a big sharp object in the middle of the area, maybe you can stab it if you make the right maneuver");
    Console.WriteLine("");
    Console.WriteLine("the creature swings its massive hand");
    Console.WriteLine("");
    Console.WriteLine("option 1. dodge left");
    Console.WriteLine("option 2. roll under it");
    string input9 = Console.ReadLine();

    if (input9 == "dodge left")
    {
        Console.WriteLine("you swiftly dodge left just as the creature swings its massive hand");
        Console.WriteLine("");
        Console.WriteLine("the creatures massive hand makes it lose balance from how heavy it is, as the creature falls and gets impailed by the spike");
        Console.WriteLine("");
        Console.WriteLine("the creature bleeds out and dies");
        Console.WriteLine("");
        Console.WriteLine("with your job all done and years of trauma under your belt, you climb back up from the depths of the temple");
        Console.WriteLine("");
        Console.WriteLine("help arrives and brings you to the hospital and therapy after");
        Console.WriteLine("");
        Console.WriteLine("you never talk about what happened at that temple again");
        Console.WriteLine("");
        Console.WriteLine("The End");
    }
    else if (input9 == "roll under it")
    {
        Console.WriteLine("what did you think this was elden ring?");
        Console.WriteLine("");
        Console.WriteLine("you get crushed by the creatures body and bleed out");
        int health2 = 0;
        Console.WriteLine($"your health is now {health2}");
        Console.WriteLine("");
        Console.WriteLine("you died");
        Console.WriteLine("");
        Console.WriteLine("restart?");
        Console.WriteLine("yes");
        string restart2 = Console.ReadLine();
        if (restart2 == "yes")
        {
            Console.Clear();
            Program main = new Program();
        }

    }
}

else if (input6 == "keep walking in the dark")
{
    Console.WriteLine("you keep walking in the dark as you feel a slosh under your foot");
    Console.WriteLine("");
    Console.WriteLine("you bend over as you feel some of the fluid under your foot and raise it to your head");
    Console.WriteLine("");
    Console.WriteLine("your eyes widen as you see a blackish red fluid all over your hand");
    Console.WriteLine("");
    Console.WriteLine("as you walk your eyes adjust to the dark and your foot bumps something solid but kinda squishy");
    Console.WriteLine("");
    Console.WriteLine("you look down and see the traumatic scene of all your coworkers dismembered all over the place");
    Console.WriteLine("");
    Console.WriteLine("suddenly you feel a sharp pain in your chest as you fall down sucumbing to your wound and sink into the dark abyss of the afterlife");
    int health2 = 0;
    Console.WriteLine($"your health is now {health2}");
    Console.WriteLine("");
    Console.WriteLine("you died");
    Console.WriteLine("");
    Console.WriteLine("restart?");
    Console.WriteLine("yes");
    
    string restart2 = Console.ReadLine();
    if (restart2 == "yes")
    {
        Console.Clear();
        Program main = new Program();

    }
}

