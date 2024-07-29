// Question No. 1
int[] numbers1 = new int[8] { 15, -9, 0, 45, 87, 98, 23, 56 };

Console.WriteLine();

// Question No. 2
void printGivenArray()
{
    for (int i = 0; i < numbers1.Length; i++)
    {
        Console.WriteLine($"Index {i} of Array is: {numbers1[i]}");
    }
}
printGivenArray();

Console.WriteLine();

// Question No. 3
Console.Write("Enter A for Ascending order or D for Descending order: ");
string? inputQ3 = Console.ReadLine();
char userEntryQ3 = 'D'; // Default value

if (inputQ3 != null && inputQ3.Length > 0)
{
    userEntryQ3 = Convert.ToChar(inputQ3.ToUpper());
}
else
{
    Console.WriteLine("Input is null or empty.");
}

void SortData(int[] numberArray, char? userEntryQ3 = 'D')
{
    int temp;
    if (userEntryQ3 == 'A')
    {
        for (int i = 0; i < numberArray.Length - 1; i++)
        {
            for (int j = 0; j < numberArray.Length - i - 1; j++)
            {
                if (numberArray[j] > numberArray[j + 1])
                {
                    temp = numberArray[j];
                    numberArray[j] = numberArray[j + 1];
                    numberArray[j + 1] = temp;
                }
            }
        }
        Console.Write("Ascending order of Array is: ");
        foreach (int num in numberArray)
        {
            Console.Write($"{num}, ");
        }
        Console.WriteLine();
    }
    else if (userEntryQ3 == 'D')
    {
        for (int i = 0; i < numberArray.Length - 1; i++)
        {
            for (int j = 0; j < numberArray.Length - i - 1; j++)
            {
                if (numberArray[j] < numberArray[j + 1])
                {
                    temp = numberArray[j];
                    numberArray[j] = numberArray[j + 1];
                    numberArray[j + 1] = temp;
                }
            }
        }
        Console.Write("Descending order of Array is: ");
        foreach (int num in numberArray)
        {
            Console.Write($"{num}, ");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Enter either A or D.");
    }
}
SortData(numbers1, userEntryQ3);

Console.WriteLine();
// Question No. 4
Console.Write("Enter the number input for which you want to check the existence: ");
int userInput4 = Convert.ToInt32(Console.ReadLine());
bool isItemFound(int[] numberArray, int entery)
{
    bool isNumberExist = false;
    for (int i = 0; i < numbers1.Length; i++)
    {
        if (numbers1[i] == entery)
        {
            isNumberExist = true;
            break;
        }
    }
    return isNumberExist;
}
Console.WriteLine(isItemFound(numbers1, userInput4));
Console.WriteLine();

// Question No. 5
void SearchData(int[] numberArray, int entery)
{
    if (isItemFound(numberArray, entery))
    {
        for (int i = 0; i < numberArray.Length; i++)
        {
            if (numberArray[i] == entery)
            {
                Console.WriteLine($"The index of given number is:  { i }");
                break;
            }
        }
    }
}
SearchData(numbers1, userInput4);

Console.WriteLine();
// Question No. 6
void ReverseData(int[] reverseArray)
{
    int start = 0;
    int end = reverseArray.Length - 1;
    int temp;

    while(start < end)
    {
        temp = reverseArray[start];
        reverseArray[start] = reverseArray[end];
        reverseArray[end] = temp;
        start++;
        end--;
    }
}
Console.Write("The Reverse Array is: ");
ReverseData(numbers1);

Console.WriteLine("The Revese Array is: ");
foreach (int i in numbers1)
{
    Console.WriteLine(i);
}

Console.WriteLine();
// Question No. 7
void FindMax()
{
    int maximumNum = 0;
    for (int i = 0; i < numbers1.Length; i++)
    {
        if(numbers1[i] > maximumNum)
        {
            maximumNum = numbers1[i];
        }
    }
    Console.WriteLine("Maximum is: " + maximumNum);
}

FindMax();
Console.WriteLine();
// Question No. 8
void FindMin()
{
    int minimumNum = 0;
    for (int i = 0; i < numbers1.Length; i++)
    {
        if (numbers1[i] < minimumNum)
        {
            minimumNum = numbers1[i];
        }
    }
    Console.WriteLine("Minimum is: " + minimumNum);
}

FindMin();
Console.WriteLine();
// Question No. 9
void ComputeAverage()
{
    int count = 0;
    for (int i = 0; i<numbers1.Length; i++)
    {
        count = count + numbers1[i];
    }
    int average = count / numbers1.Length;
    Console.WriteLine("The Average of sum of Array is: " + average);
}

ComputeAverage();
Console.WriteLine();
// Question No. 10
void CountOccurrences(int[] numberArray, int userInputQ10)
{
    Console.Write("Enter Number You Want to check Occurence: ");
    userInputQ10 = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < numbers1.Length; i++)
    {
        if(numbers1[i] == userInputQ10)
        {
            count++;
        }
    }
    Console.WriteLine("Number Repeat " + count + " time.");
}

CountOccurrences(numbers1, 10);
Console.WriteLine();





/* ---------------------------------Built-in METHODS---------------------------------*/





List<double> numbers = new List<double> { 15, -9, 0, 45, 87, 98, 23, 56 };
// Question No. 11
double median = FindMedian(numbers);
Console.WriteLine($"The median is: {median}");

double FindMedian(List<double> numbers)
{
    numbers.Sort();

    int count = numbers.Count;
    if (count == 0)
    {
        Console.WriteLine("Cannot find median of an empty list.");
    }

    if (count % 2 == 0)
    {
        double mid1 = numbers[(count / 2) - 1];
        double mid2 = numbers[count / 2];
        return (mid1 + mid2) / 2.0;
    }
    else
    {
        return numbers[count / 2];
    }
}

Console.WriteLine();
// Question No. 12
double standardDeviation = ComputeStandardDeviation(numbers);
Console.WriteLine($"The standard deviation is: {standardDeviation}");

double ComputeStandardDeviation(List<double> numbers)
{
    if (numbers.Count == 0)
    {
        Console.WriteLine("Cannot compute standard deviation of an empty list.");
    }

    double mean = numbers.Average();

    double variance = numbers.Select(n => Math.Pow(n - mean, 2)).Average();

    double standardDeviation = Math.Sqrt(variance);

    return standardDeviation;
}

Console.WriteLine();
// Question No. 13
List<double> uniqueValues = FindUniqueValues(numbers);

Console.WriteLine("Unique values:");
foreach (double value in uniqueValues)
{
    Console.WriteLine(value);
}

List<double> FindUniqueValues(List<double> data)
{
    List<double> uniqueValues = new List<double>();

    foreach (double value in data)
    {
        if (!uniqueValues.Contains(value))
        {
            uniqueValues.Add(value);
        }
    }

    return uniqueValues;
}

Console.WriteLine();
// Question No. 14
double mode = FindMode(numbers);

Console.WriteLine("Mode: " + mode);

double FindMode(List<double> data)
{
    double mode = data[0];
    int maxCount = 0;

    for (int i = 0; i < data.Count; i++)
    {
        double value = data[i];
        int count = 0;

        for (int j = 0; j < data.Count; j++)
        {
            if (data[j] == value)
            {
                count++;
            }
        }

        if (count > maxCount)
        {
            maxCount = count;
            mode = value;
        }
    }

    return mode;
}


Console.WriteLine();
// Question No. 15
List<int> list1 = new List<int> { 53, 63, 8, 10 };
List<int> list2 = new List<int> { 17, 12, 16, 6 };

List<int> sortedList = Sort(list1, list2);

Console.WriteLine("Sorted List:");
foreach (int number in sortedList)
{
    Console.Write(number + " ");
}

List<int> Sort(List<int> list1, List<int> list2)
{
    List<int> combinedList = new List<int>(list1);
    combinedList.AddRange(list2);

    combinedList.Sort();

    return combinedList;
}

Console.WriteLine();
// Question No. 16
List<int> sortedMergedList = Merge(list1, list2);

Console.WriteLine("Sorted Merged List:");
foreach (int number in sortedMergedList)
{
    Console.Write(number + " ");
}

List<int> Merge(List<int> list1, List<int> list2)
{
    List<int> mergedList = new List<int>(list1);

    mergedList.AddRange(list2);

    mergedList.Sort();

    return mergedList;
}

Console.WriteLine();
