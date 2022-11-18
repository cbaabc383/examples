int Max (int arg1, int arg2, int arg3)
{
    int rusult = arg1;
    if (arg2 > rusult) rusult = arg2;
    if (arg3 > rusult) rusult = arg3;
    return rusult;
    }

int a1 =5;
int a2 = 36;
int a3 = 587;
int b1 =5;
int b2 = 36;
int b3 = 147;
int c1 =5122;
int c2 = 536;
int c3 = 7;

//int max1 = Max (a1, b1, c1);
//int max2 = Max (a2, b2, c2);
//int max3 = Max (a3, b3, c3);
//int max = Max (max1, max2, max3);

int max = Max (
    Max (a1, b1, c1), 
    Max (a2, b2, c2), 
    Max (a3, b3, c3));
    
Console.WriteLine (max);