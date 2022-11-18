int Max (int arg1, int arg2, int arg3)
{
    int rusult = arg1;
    if (arg2 > rusult) rusult = arg2;
    if (arg3 > rusult) rusult = arg3;
    return rusult;
    }
//              0  1   2   3    4   5  6  7   8
int [] array = {1, 422, 13, 46, 57, 16, 7, 28, 94};

int max = Max (
    Max (array[0], array[1], array[2]), 
    Max (array[3], array[4], array[5]), 
    Max (array[6], array[7], array[8]));
    
Console.WriteLine (max);