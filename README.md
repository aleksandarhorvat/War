<h1 align="center">Simple card game - War</h1>
<p align="center">- graduation thesis for high school -</p>

# The content

1. [Introduction](#1-introduction)

2. [The used components in the program](#2-the-used-components-in-the-program)

3. [Software solution](#3-software-solution)

    3.1 [Use of resources](#31-use-of-resources)

    3.2 [Initialization of variables](#32-initialization-of-variables)

    3.3 [Initialization of form components](#33-initialization-of-form-components)

    3.4 [MenuStrip](#34-menustrip)

    3.5 [Draw button](#35-draw-button)

    3.6 [Again button](#36-again-button)

    3.7 [Shuffle button](#37-shuffle-button)

    3.8 [Closing the form](#38-closing-the-form)

4. [Conclusion](#4-conclusion)

5. [Literature](#5-literature)

# 1. Introduction

The idea of this graduation thesis was to show one of the many applications of programming, for example, how an old card game can be revived and attract the interest of people who encounter it for the first time.

Programming is a very broad term and the application of programming itself is incredibly large. It contains elements of art, science, mathematics and engineering.

Every programmer writes programming code in a programming language. Different programming languages support different programming styles (**programming paradigm**).

I chose the C# programming language for my graduation thesis because it is based on the C syntax that I know best, C is used in low-level programming, such programs are written for the console without a GUI (**graphical user interface**) that provides much more possibilities for creativity and overall allows more "freedom" to the programmer to create the program as he envisioned, and C# supports GUI.

C# is supported by the .NET Framework, which means that such applications can be launched with the Windows operating system that has been introduced in our region and in the world.

# 2. The used components in the program

Button - represents an ordinary button that, when clicked, performs some task.

Label - represents some simple text written on the screen.

PictureBox - represents a place where a picture of our choice can appear.

MenuStrip - represents a single "strip" above the interface that serves to make it easier to find your way around the program or provides some additional information about the program itself.

# 3. Software solution

## 3.1 Use of resources

It is used when we work with several images that we need to call during the execution of the program, they are saved in the **Resources** folder.
![1](https://user-images.githubusercontent.com/108305750/183123605-c8e23dc1-0f43-40af-8c15-2a8de51f8cf4.png)
![image](https://user-images.githubusercontent.com/108305750/183123503-5e6d70ec-6f58-4b86-840e-497f4a78c409.png)

```C#
using System.Resources; //added to use images from the resource
```

## 3.2 Initialization of variables

```C#
public partial class Form1 : Form
{
    private bool[] fillDeck = new bool[52]; //fill the deck with 52 cards

    private Random rand = new Random(); //initialize a random value

    private int myWins, hisWins;
    private int myCard, hisCard; //initialize cards
    private int myValue, hisValue; //initialize card values
    private int myPoints, hisPoints; //initialize the points
    private PictureBox[] selectCards; ////initialize card images
}
```

## 3.3 Initialization of form components

```C#
public Form1()
{
    InitializeComponent();
    myWins = hisWins = 0;
    myCard = hisCard = -1; //cards get a value of -1 so they don't start at some value that is defined
    myValue = hisValue = 0; //values are zero at the beginning
    myPoints = hisPoints = 0; //points are zero at the beginning
    btAgain.Visible = false; //we can't use the button to repeat if we haven't even started

    selectCards = new PictureBox[52]; //we assign images to cards
    ResourceManager rm = War.Properties.Resources.ResourceManager; //we take them from resources
    for (int i = 0; i < 52; ++i) //we assign to each card
    {
        selectCards[i] = new PictureBox();
        selectCards[i].Image = (Image)rm.GetObject("_" + (i + 1).ToString());
    }
}
```

## 3.4 MenuStrip

![strip](https://user-images.githubusercontent.com/108305750/183134226-88463400-4a1b-4cc2-8719-f058f35c6616.png)

By pressing the **Help** button, a window with a message (**MessageBox**) about the rules of the game appears.

```C#
private void helpToolStripMenuItem_Click(object sender, EventArgs e)
{
    MessageBox.Show("War is a game in which two players receive the same number of cards.\nBoth players draw cards and compare them.\nIf the first player's card has a higher value then it is put aside together with the second player's card, in case the cards are of equal value each player puts his side card.\nThe ace ranks as the strongest card, then all other cards in order from king to two.\nThe winner is the player with the most cards on the side when both players have used up all the cards in their decks.");
}
```
![hlep](https://user-images.githubusercontent.com/108305750/183135140-601b4d44-fadb-43a6-ab28-6b6d2a876a90.png)

Pressing the **Version** button displays the current version of the program.

![version](https://user-images.githubusercontent.com/108305750/183135179-265050a1-aac5-4ffe-8104-957f5c231694.png)

## 3.5 Draw button

After pressing the **Draw button** we first lose the ability to shuffle the cards, because we started the game.

```C#
btShuffle.Visible = false; //it is no longer available to us to shuffle the cards when we have already started to play
```
We assign cards to the first player.

```C#
//get separate cards
do
{
    //takes a value from 0 to 52
    myCard = rand.Next(52);
}
while (fillDeck[myCard]); //until it gets a non-false bool value

pbMyCard.Image = new Bitmap(selectCards[myCard].Image); //we display a specific card image
fillDeck[myCard] = true; //states that the card has already been taken
myValue = (myCard % 13) + 2; //the value of the card is the remainder divided by 13 because each type of card has 13 cards, we add two more because we are working in 13 field and the value of the last card is 14
```

We do the same for the opponent.

```C#
//we do the same for the computer
do
{
    hisCard = rand.Next(52);
}
while (fillDeck[hisCard]);

pbHisCard.Image = new Bitmap(selectCards[hisCard].Image);
fillDeck[hisCard] = true;
hisValue = (hisCard % 13) + 2;
```

Here we distribute points depending on the value of our cards.

```C#
//divide the points
if (myValue > hisValue)
    myPoints += 2;
else if (myValue < hisValue)
    hisPoints += 2;
else
{
    myPoints++;
    hisPoints++;
}
```

We test whose victory it is.

```C#
//test whose victory
if ((myPoints + hisPoints) >= 52)
{
    pbDeck1.Image = null;
    pbDeck2.Image = null;
    if (myPoints > hisPoints)
    {
        lbResult.Text = "The first player wins!";
        myWins++;
    }
    else if (hisPoints > myPoints)
    {
        lbResult.Text = "The other player won!";
        hisWins++;
    }
    else
        lbResult.Text = "A draw!";
    btAgain.Visible = true;
    btDraw.Visible = false;

}
```

At the end we show the results.

```C#
//display points
lbPoints1.Text = Convert.ToString(myPoints);
lbPoints2.Text = Convert.ToString(hisPoints);
```

## 3.6 Again button

Pressing this button resets everything to the beginning and we are ready to start the match again.

```C#
private void btAgain_Click(object sender, EventArgs e) //here everything is being adjusted again for the next match
{
    myCard = hisCard = -1;
    myValue = hisValue = 0;
    myPoints = hisPoints = 0;
    for (int i = 0; i < 52; ++i)
        fillDeck[i] = false;
    lbResult.Text = null;
    lbPoints1.Text = null;
    lbPoints2.Text = null;
    pbDeck1.Image = War.Properties.Resources.yellow_back;
    pbDeck2.Image = War.Properties.Resources.red_back;
    pbMyCard.Image = pbHisCard.Image = null;
    btDraw.Visible = true;
    btAgain.Visible = false;
    btShuffle.Visible = true;
}
```

## 3.7 Shuffle button

Pressing this button shuffles the cards in the decks.

```C#
private void btShuffle_Click(object sender, EventArgs e) //this is where the first card is shuffled
{
    btShuffle.Visible = true;
    do
    {
        myCard = rand.Next(52);
    }
    while (fillDeck[myCard]);

    do
    {
        hisCard = rand.Next(52);
    }
    while (fillDeck[hisCard]);
}
```

## 3.8 Closing the form

When we close the form, a window appears showing the number of wins of both players.

```C#
private void Form1_FormClosed(object sender, FormClosedEventArgs e) //the number of wins is displayed here after exiting the application
{
    MessageBox.Show("Results!\n\nThe number of wins of the first player: " + myWins + "\n\nNumber of wins by the other player: " + hisWins + "\n");
    Application.Exit();
}
```
![end](https://user-images.githubusercontent.com/108305750/183139228-8b8bb568-8353-4fd3-9cac-729008130c5b.png)

# 4. Conclusion

In my opinion, the point of programming is to constantly learn something new and improve ourselves, as the old saying goes "One learns while living", for example I learned a lot of new things during the development of this program, one of those things is how to work with **Resources** folder.

With each new project, I learn something new and how to implement it in the real world, which is very important, no matter how important theory is, it is very important that it is balanced with practical application.

# 5. Literature

* S. Matković, D. Vuković, M. Đurišić, Računarstvo i informatika za treći razred gimnazije

* John Sharp, Microsoft Visual C#, step by step

* Class notes
