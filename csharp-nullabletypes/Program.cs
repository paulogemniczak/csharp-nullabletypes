DateTime? date = null;

Console.WriteLine($"GetValueOrDefault - {date.GetValueOrDefault()}");
Console.WriteLine($"HasValue - {date.HasValue}");
//Console.WriteLine($"Value - {date.Value}"); // Unhandled exception. System.InvalidOperationException: Nullable object must have a value.

DateTime? date2 = new DateTime(2020, 1, 1);
// DateTime date3 = date2; // Error
DateTime date3 = date2.GetValueOrDefault();
Console.WriteLine(date3);

DateTime? date4 = date3;
Console.WriteLine(date4.GetValueOrDefault());

DateTime? date5 = date ?? DateTime.Today;
Console.WriteLine(date5);
