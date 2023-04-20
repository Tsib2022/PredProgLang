
Console.WriteLine("Введите пятизначное число: ");
string str_num = Console.ReadLine();
int num = Convert.ToInt32(str_num);
int num_10000,num_1000,num_100, num_10, num_1;
//if (num >10000)
//{
num_1 = num%10;
num_10 = ((num%100)-num_1)/10;
num_100 = ((num%1000)-(num_10*10)-num_1)/100;
num_1000 = (((num%10000)-(num_100*100)-(num_10*10)-num_1)/1000);
num_10000 =((num)-(num_1000*1000)-(num_100*100)-(num_10*10)-num_1)/10000;
//}
//else Console.WriteLine("Число не пятизначное");
int mir_num_1 = num_1*10000;
int mir_num_10 = num_10*1000;
int mir_num_100 = num_100*100;
int mir_num_1000 = num_1000*10;
int mir_num_10000 = num_10000;
int mir_num = mir_num_1 + mir_num_10 + mir_num_100 +  mir_num_1000 + mir_num_10000;
if (mir_num == num) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");