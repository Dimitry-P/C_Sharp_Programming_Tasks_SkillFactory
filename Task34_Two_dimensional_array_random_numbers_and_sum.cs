using System;
using System.Reflection;
using System.Security.Policy;
using SFML.Learning;
using SFML.System;
using SFML.Window;

class FindCouple : Game
{
    static string[] level;
    static string[] icons;
    static int[,] cards;
    static int space = 40;
    static int cardCount = 10;
    static int cardsPerLine = 5;
    static int leftOffSet = 70;
    static int topOffSet = 20;
    static int width = 100;
    static int height = 100;
    static string cardSound = LoadSound("sound.wav");
    static bool startGame = true;
    static int firstCardOpen = -5;
    static int secondCardOpen = -5;
    static int openCardsAmount = 0;
    static int timer = 0;
    static int index = 0;
    static bool playGame = true;

    static void Shuffle(int[] arr)
    {
        Random rand = new Random();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int j = rand.Next(1, i + 1);
            int tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;
        }
    }

    static void InitCard()
    {
        cards = new int[cardCount, 6];
        int[] countId = new int[cardCount];
        int id = 0;
        Random rnd = new Random();
        for (int i = 0; i < countId.Length; i++)
        {
            if (i % 2 == 0)
            {
                id = rnd.Next(1, 7);
            }
            countId[i] = id;
        }

        Shuffle(countId);

        for (int i = 0; i < cards.GetLength(0); i++)
        {
            cards[i, 0] = -2; // state
            cards[i, 1] = (i % cardsPerLine) * (width + space) + leftOffSet; // posX
            cards[i, 2] = (i / cardsPerLine) * (height + space) + topOffSet; // posY
            cards[i, 3] = width; // width
            cards[i, 4] = height; // height
            cards[i, 5] = countId[i]; // id
        }
    }

    static void DrawCard()
    {
        for (int i = 0; i < cards.GetLength(0); i++)
        {
            if (cards[i, 0] == 1)
            {
                DrawSprite(icons[cards[i, 5]], cards[i, 1], cards[i, 2]);
            }
            if (cards[i, 0] == 0)
            {
                DrawSprite(icons[0], cards[i, 1], cards[i, 2]);
            }
        }
    }

    static int GetCardIndexByMousePosition()
    {
        for (int i = 0; i < cards.GetLength(0); i++)
        {
            if (MouseX >= cards[i, 1] && MouseX <= cards[i, 1] + cards[i, 3] && MouseY >= cards[i, 2] && MouseY <= cards[i, 2] + cards[i, 4])
            {
                return i;
            }
        }
        return -1;
    }

    static void SetStateToAllCards(int state)
    {
        for (int i = 0; i < cards.GetLength(0); i++)
        {
            cards[i, 0] = state;
        }
    }

    static void LoadIcons()
    {
        icons = new string[7];
        icons[0] = LoadTexture("Icon_0.png");
        for (int i = 0; i < icons.GetLength(0); i++)
        {
            icons[i] = LoadTexture("Icon_" + i + ".png");
        }
    }

    static void DrawLevel(int state1)
    {
        level = new string[3];
        for (int i = 0; i < level.GetLength(0); i++)
        {
            level[i] = LoadTexture("level_" + i + ".png");
        }
        if (state1 == 1)
        {
            DrawSprite(level[0], 100, 135);
            DrawSprite(level[1], 100, 240);
            DrawSprite(level[2], 100, 345);
        }
    }

    static int StartLevel()
    {
        if (MouseX >= 100 && MouseX <= 400 && MouseY >= 135 && MouseY <= 235)
        {
            return 1;
        }
        if (MouseX >= 100 && MouseX <= 400 && MouseY >= 240 && MouseY <= 340)
        {
            return 2;
        }
        if (MouseX >= 100 && MouseX <= 400 && MouseY >= 345 && MouseY <= 445)
        {
            return 3;
        }
        return 0;
    }

    static void Main()
    {
        LoadIcons();
        InitWindow(800, 600, "Find Couple");

        while (true)
        {
            DispatchEvents();

            if (playGame == false)
            {
                break;
            }
            ClearWindow(26, 46, 92);
            DrawText(100, 100, "Выберите уровень:", 24);
            DrawLevel(1);

            if (GetMouseButtonDown(0))
            {
                if (StartLevel() == 1 || StartLevel() == 2 || StartLevel() == 3)
                {
                    if (StartLevel() == 1) cardCount = 6;
                    if (StartLevel() == 2) cardCount = 10;
                    if (StartLevel() == 3) cardCount = 20;
                    int remainedCards = cardCount;
                    ClearWindow(26, 46, 92);
                    InitCard();
                    SetFont("comic.ttf");
                    SetStateToAllCards(1);
                    DrawCard();
                    DrawLevel(0);
                    DisplayWindow();
                    Delay(5000);

                    SetStateToAllCards(0);

                    while (playGame)
                    {
                        timer += 17;

                        if (timer > 60248)
                        {
                            ClearWindow();
                            SetFillColor(255, 255, 255);
                            DrawText(200, 300, "У вас закончилось время. Вы проиграли!", 24);
                            DisplayWindow();
                            Delay(5000);
                            playGame = false;
                        }
                        DispatchEvents();

                        if (remainedCards == 0)
                        {
                            ClearWindow();
                            SetFillColor(255, 255, 255);
                            DrawText(200, 300, "Поздравляю! Вы открыли все карты!", 24);
                            DisplayWindow();
                            Delay(5000);
                            playGame = false;
                        }

                        if (openCardsAmount == 2)
                        {
                            if (cards[firstCardOpen, 5] == cards[secondCardOpen, 5])
                            {
                                cards[firstCardOpen, 0] = -1;
                                cards[secondCardOpen, 0] = -1;
                                remainedCards -= 2;
                            }
                            else
                            {
                                cards[firstCardOpen, 0] = 0;
                                cards[secondCardOpen, 0] = 0;
                            }
                            Delay(2000);
                            timer += 2000;
                            if (cards[firstCardOpen, 0] == 0 && cards[secondCardOpen, 0] == 0 && cards[secondCardOpen, 0] != -1 && cards[firstCardOpen, 0] != -1) PlaySound(cardSound);
                            firstCardOpen = -1;
                            secondCardOpen = -1;
                            openCardsAmount = 0;
                        }

                        if (GetMouseButtonDown(0))
                        {
                            index = GetCardIndexByMousePosition();
                            if (index != -1 && index != firstCardOpen && cards[index, 0] != -1)
                            {
                                cards[index, 0] = 1;
                                openCardsAmount++;
                                if (openCardsAmount == 1) firstCardOpen = index; PlaySound(cardSound);
                                if (openCardsAmount == 2) secondCardOpen = index; PlaySound(cardSound);
                            }
                        }
                        ClearWindow(26, 46, 92);

                        DrawText(180, 560, "У вас есть одна минута. Ваше время: " + (timer) / 1000, 24);
                        DrawCard();

                        DisplayWindow();
                        Delay(1);
                    }
                }
            }
            DisplayWindow();
            Delay(1);
        }
    }
}