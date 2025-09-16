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
    Console.WriteLine("you arrive at the temple, and step out from your automobile the chilling winter air prickles at your nose as you look up and around at the temple. it is huge! and full of arcitectural details that amazes you");
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
    Console.WriteLine("you walk back over to the door feeling proud of yourself that you found something");
    Console.WriteLine("");
    Console.WriteLine("you try to pry open the rusted over massive door, it creaks and breaks open as you fall down deep into the temple, no way back now");

}

