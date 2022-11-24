string[] pole = new string[9]{"1","2","3","4","5","6","7","8","9"};
//Чертим поле 
void PrintPole(string[] pole){
    Console.WriteLine($"{pole[0]}  |  {pole[1]}  | {pole[2]}" );
    Console.WriteLine("---  ---  ---" );
    Console.WriteLine($"{pole[3]}  |  {pole[4]}  | {pole[5]}"  );
    Console.WriteLine("---  ---  ---" );
    Console.WriteLine($"{pole[6]}  |  {pole[7]}  | {pole[8]}" );
    }
//Случайным образом выбираем кто будет ходить первым. 0 - компьютер, 1 - человек  
int Player(){
    int who = new Random().Next(0,2);
    if (who == 0) Console.WriteLine("Первым будет ходить компьютер!");
    else Console.WriteLine("Вы будете ходить первым!");
    return who;
    }
//Делаем ход
string[] Move(int who, string[] pole){
    if (who == 0){     //Ход компьютера
        int x = 0;
        while (x == 0){ //Важно проверить номер ячейки ,оно может уже быть использован
            int move = new Random().Next(0,9);
            if (pole[move] == "0" || pole[move] == "X") x = 0;
            else {
                Console.WriteLine($"Компьютер выбрал поле {move + 1}");
                x = 1;
                pole[move] = "0";
            }
        }
        }
    else{               //Ход человека. Проверки на правильность нет
        Console.WriteLine("Введите номер поля");
        int move = Convert.ToInt32(Console.ReadLine()) - 1;
        pole[move] = "X";
        } 
    return pole;    
    }
//Создаем функцию проверки на победу
string CheckVictory(string[] pole){
    if (pole[0]==pole[1] && pole[1]==pole[2]) return pole[0]; //В случае выигрышной комбинации возвращаем значение 
    if (pole[3]==pole[4] && pole[4]==pole[5]) return pole[3]; 
    if (pole[6]==pole[7] && pole[7]==pole[8]) return pole[6];
    if (pole[0]==pole[3] && pole[3]==pole[6]) return pole[0];
    if (pole[1]==pole[4] && pole[4]==pole[7]) return pole[1];
    if (pole[2]==pole[5] && pole[5]==pole[8]) return pole[2];
    if (pole[0]==pole[4] && pole[4]==pole[8]) return pole[0];
    if (pole[6]==pole[4] && pole[4]==pole[2]) return pole[6];
    return " ";
    }

void Game(){
    PrintPole(pole);
    int who = Player(); //В переменную who заносим цифру игрока. 0 - компьютер, 1 - человек 
    int i = 0;
    while(i < 9){
        Move(who,pole); // Делаем ход
        PrintPole(pole);
        //После каждого хода выполняем проверку на победителя
        if (CheckVictory(pole) == "X"){  //Победа человека
            Console.WriteLine("Вы победили!");
            break;
            }
        if (CheckVictory(pole) == "0"){   //Победа компьютера
            Console.WriteLine("Компьютер победил!");
            break;
            }
        i += 1;
        if (who == 0) who = 1; // Меняем значение переменной who чтобы изменить игрока
        else who = 0;       
    }
    }
Game();