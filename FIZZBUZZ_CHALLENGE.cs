// FIZZBUZZ CHALLENGE

/*Write a public method that accepts a number
---when the number is divisible by 3 return the word fizz

---when the number is divisible by 5 return the word buzz

---when the number is divisible by both, return the word fizzbuzz*/
if (i % 3 == 0 && i % 5 == 0)
{
Console.WriteLine($"{i} fizzbuzz");
} else if (i % 3 == 0)
{
    Console.WriteLine($"{i} fizz");
} else if (i % 5 == 0)
{
    Console.WriteLine($"{i} buzz");
}else
{
    Console.WriteLine(i);
}

